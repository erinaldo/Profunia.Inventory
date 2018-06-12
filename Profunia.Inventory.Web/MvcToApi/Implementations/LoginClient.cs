using Profunia.Inventory.Web.Models;
using Profunia.Inventory.Web.MvcToApi.Interfaces;
using Profunia.Inventory.Web.WebInfrasture;
//using Profunia.Inventory.Web.WebInfrasture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
//using Profunia.Inventory.Web.WebInfrasture;
namespace Profunia.Inventory.Web.MvcToApi.Implementations
{
    public class LoginClient : ClientBase, ILoginClient
    {
        private const string RegisterUri = "api/register";
        private const string TokenUri = "http://localhost:61455/oauth/token";

        public LoginClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<TokenResponse> Login(string email, string password)
        {
            var response = await ApiClient.PostFormEncodedContent(TokenUri, "grant_type".AsPair("password"),
                "username".AsPair(email), "password".AsPair(password));
            var tokenResponse = await CreateJsonResponse<TokenResponse>(response);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await DecodeContent<dynamic>(response);
                tokenResponse.ErrorState = new ErrorStateResponse
                {
                    ModelState = new Dictionary<string, string[]>
                    {
                        {errorContent["error"], new string[] {errorContent["error_description"]}}
                    }
                };
                return tokenResponse;
            }

            var tokenData = await DecodeContent<dynamic>(response);
            tokenResponse.Data = tokenData["access_token"];
            return tokenResponse;
        }

        //public async Task<RegisterResponse> Register(RegisterViewModel viewModel)
        //{
        //    var apiModel = new RegisterApiModel
        //    {
        //        ConfirmPassword = viewModel.ConfirmPassword,
        //        Email = viewModel.Email,
        //        Password = viewModel.Password
        //    };
        //    var response = await ApiClient.PostJsonEncodedContent(RegisterUri, apiModel);
        //    var registerResponse = await CreateJsonResponse<RegisterResponse>(response);
        //    return registerResponse;
        //}
    }
}
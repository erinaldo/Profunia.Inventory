using Profunia.Inventory.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Profunia.Inventory.Web.MvcToApi.Implementations;
using Profunia.Inventory.Web.MvcToApi.Interfaces;
using Profunia.Inventory.Web.WebInfrasture.Interfaces;
using Profunia.Inventory.Web.WebInfrasture;

namespace Profunia.Inventory.Web.Controllers
{
    public class AccountMvcController : Controller
    {
        private readonly ILoginClient loginClient;
        private readonly ITokenContainer tokenContainer;

        /// <summary>
        /// Default parameterless constructor. 
        /// Delete this if you are using a DI container.
        /// </summary>
        public AccountMvcController()
        {
            tokenContainer = new TokenContainer();
            var apiClient = new ApiClient(HttpClientInstance.Instance, tokenContainer);
            loginClient = new LoginClient(apiClient);
        }

        /// <summary>
        /// Default constructor with dependency.
        /// Delete this if you aren't planning on using a DI container.
        /// </summary>
        /// <param name="loginClient">The login client.</param>
        /// <param name="tokenContainer">The token container.</param>
        public AccountMvcController(ILoginClient loginClient, ITokenContainer tokenContainer)
        {
            this.loginClient = loginClient;
            this.tokenContainer = tokenContainer;
        }

        public ActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var loginSuccess = await PerformLoginActions(model.UserName, model.Password);
            if (loginSuccess)
            {
                return RedirectToAction("CreateProduct", "Product");
            }

            ModelState.Clear();
            ModelState.AddModelError("", "The username or password is incorrect");
            return View(model);
        }
        private async Task<bool> PerformLoginActions(string email, string password)
        {
            var response = await loginClient.Login(email, password);

            if (response.StatusIsSuccessful)
            {
                tokenContainer.ApiToken = response.Data;
            }

            return response.StatusIsSuccessful;
        }
    }
}
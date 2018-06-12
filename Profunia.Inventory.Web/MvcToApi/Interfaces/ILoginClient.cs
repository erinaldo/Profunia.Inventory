using Profunia.Inventory.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profunia.Inventory.Web.MvcToApi.Interfaces
{
    public interface ILoginClient
    {
        Task<TokenResponse> Login(string email, string password);
    }
}


using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Profunia.Inventory.Entities.Query;
using Profunia.Inventory.Web.WebInfrasture;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
namespace Profunia.Inventory.Web.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<Profunia.Inventory.Web.WebInfrasture.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Profunia.Inventory.Web.WebInfrasture.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {Id="TEST001",
                UserName = "SuperPowerUser",
                Email = "taiseer.joudeh@gmail.com",
                EmailConfirmed = true,
                FirstName = "Pravat",
                LastName = "SAhoo",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "MySuperP@ss!");

            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Id="SuperAdmin" ,Name = "Super Admin" });
                roleManager.Create(new IdentityRole { Id="Admin",Name = "Admin" });
                roleManager.Create(new IdentityRole { Id="User",Name = "User" });
            }

            var adminUser = manager.FindByName("SuperPowerUser");

            manager.AddToRoles(adminUser.Id, new string[] { "User", "Admin", "Super Admin" });
        }
    }
}

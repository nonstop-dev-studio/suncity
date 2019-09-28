using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using suncity.web.Models;

namespace suncity.web.Helpers
{
    public static class UserAndRoleDataInitializer
    {
        public static void SeedData(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<User> userManager)
        {
            if (userManager.FindByEmailAsync("johndoe@localhost").Result == null)
            {
                User user = new User();
                user.UserName = "johndoe@localhost";
                user.Email = "johndoe@localhost";
                user.FirstName = "John";
                user.LastName = "Doe";

                IdentityResult result = userManager.CreateAsync(user, "P@ssw0rd1!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();
                }
            }


            if (userManager.FindByEmailAsync("alex@localhost").Result == null)
            {
                User user = new User();
                user.UserName = "alex@localhost";
                user.Email = "alex@localhost";
                user.FirstName = "Alex";
                user.LastName = "Calingasan";

                IdentityResult result = userManager.CreateAsync(user, "P@ssw0rd1!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}

using Authorisation.Model;
using Microsoft.AspNetCore.Identity;

namespace Authorisation.Helpers
{
    public static class UserAndRoleSeeder
    {
        public static void SeedData(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<AppUser> userManager)
        {
            if (userManager.FindByNameAsync("Medewerker1").Result == null)
            {
                AppUser user = new AppUser();
                user.Email = "bla@bla.nl";
                user.UserName = "userBla";

                IdentityResult result = userManager.CreateAsync(user, "Welkom123!").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Medewerker").Wait();
                }

            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Medewerker").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Medewerker";
                IdentityResult result = roleManager.CreateAsync(role).Result;
            }


        }
    }
}

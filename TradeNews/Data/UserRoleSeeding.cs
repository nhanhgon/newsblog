using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TradeNews.Models;

namespace TradeNews.Data
{
    public class UserRoleSeeding
    {
        public static async Task Initialize(TradeNewsDbContext context,
                            UserManager<User> userManager,
                            RoleManager<Role> roleManager)
        {
            // make sure database is created
            context.Database.EnsureCreated();

            //String adminId = "";
            //String memberId = "";

            var role1 = "Admin";
            var desc1 = "This is administrator!";

            var role2 = "Member";
            var desc2 = "This is member!";

            var password = "P@ssw0rd123";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new Role(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new Role(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("Admin") == null)
            {
                var user = new User
                {
                    UserName = "admin",
                    Email = "admin@tradenews.com",
                    FullName = "Admin",
                    Address = "Hanoi",
                    Gender = Gender.Male,
                    CreatedAt = DateTime.Now
                    //Phone = "0123456789"
                    //DateOfBirth = 
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
            }

            if (await userManager.FindByNameAsync("Member") == null)
            {
                var user = new User
                {
                    UserName = "member@email.com",
                    Email = "member@email.com",
                    FullName = "John",
                    Address = "Hanoi",
                    Gender = Gender.Male,
                    CreatedAt = DateTime.Now
                    //Phone = "0123456278"
                    //DateOfBirth = 
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}

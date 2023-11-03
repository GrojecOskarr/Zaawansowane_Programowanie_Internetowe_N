using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WebStore.DAL;
using WebStore.Model;

using System;

namespace WebStore.Tests

{
    public static class Extensions
    {
        // Create sample data
        public static async void SeedData(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider
            .GetRequiredService<RoleManager<IdentityRole<int>>>();
            // other seed data ...
            //Suppliers
            var supplier1 = new Supplier()
            {
                Id = 1,
                FirstName = "Adam",
                LastName = "Bednarski",
                UserName = "supp1@eg.eg",
                Email = "supp1@eg.eg",
                RegistrationDate = new DateTime(2010, 1, 1),
            };
            await userManager.CreateAsync(supplier1, "User1234");
            //Customers
            var customer1 = new Customer()
            {
                Id = 2,
                FirstName = "Adam",
                LastName = "Bebebebebe",
                UserName = "cust1@eg.eg",
                Email = "cust1@eg.eg",
                RegistrationDate = new DateTime(2010, 1, 1),
            };
            await userManager.CreateAsync(customer1, "User1234");
            
            
            //Categories
            var category1 = new Category()
            {
                Id = 1,
                Name = "Computers",
                Tag = "#computer"
            };
            await dbContext.AddAsync(category1);
            //Products
            var p1 = new Product()
            {
                Id = 1,
                CategoryId = category1.Id,
                SupplierId = supplier1.Id,
                Description = "Bardzo praktyczny monitor 32 cale",
                ImageBytes = new byte[] { 0xff, 0xff, 0xff, 0x80 },
                Name = "Monitor Dell 32",
                Price = 1000,
                Weight = 20,
            };
            await dbContext.AddAsync(p1);
            var p2 = new Product()
            {
                Id = 2,
                CategoryId = category1.Id,
                SupplierId = supplier1.Id,
                Description = "Precyzyjna mysz do pracy",
                ImageBytes = new byte[] { 0xff, 0xff, 0xff, 0x70 },
                Name = "Mysz Logitech",
                Price = 500,
                Weight = 0.5f,
            };
            await dbContext.AddAsync(p2);
            var o1 = new Order(){
                Id = 1,
                CustomerId = customer1.Id,
                DeliveryDate = new DateTime(2008, 4, 1, 7, 0, 0),
                OrderDate = new DateTime(2008, 3, 1, 7, 0, 0),
                TrackingNumber = 123456789,
            };
            await dbContext.AddAsync(o1);
            // save changes
            await dbContext.SaveChangesAsync();
        }
    }
}
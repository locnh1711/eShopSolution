using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
               );
            modelBuilder.Entity<Language>().HasData(
               new Language() { Id = "en", Name = "English", IsDefault = true },
               new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = false });
                

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                    );

            modelBuilder.Entity<Product>().HasData(
                  new Product()
                  {
                      Id = 1,
                      DateCreated = DateTime.Now,
                      OriginalPrice = 100000,
                      Price = 200000,
                      Stock = 0,
                      ViewCount = 0,
                 });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Viet Tien Men Shirt",
                     LanguageId = "en",
                     SeoAlias = "viet-tien-men-shirt",
                     SeoDescription = "Viet Tien Men Shirt",
                     SeoTitle = "Viet Tien Men Shirt",
                     Details = "Viet Tien Men Shirt",
                     Description = "Viet Tien Men Shirt"
                     
                 },
                 new ProductTranslation()
                 {
                        Id = 2,
                        ProductId = 1,
                        Name = "Áo sơ mi nam trắng Việt Tiến",
                        LanguageId = "vi",
                        SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                        SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                        SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                        Details = "Áo sơ mi nam trắng Việt Tiến",
                        Description = "Áo sơ mi nam trắng Việt Tiến"
                 });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
            // any guid
            var roleId = new Guid("8E571449-6259-48F3-BEEA-4BB63EC6B744");
            var adminId = new Guid("AFD0989B-6C53-46AE-8094-3137E396E88D");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "locnhgcs17219@fpt.edu.vn",
                NormalizedEmail = "locnhgcs17219@fpt.edu.vn",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Hieuloc123456"),
                SecurityStamp = string.Empty,
                FirstName = "Loc",
                LastName = "Nguyen",
                Dob = new DateTime(1999, 11, 17)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}

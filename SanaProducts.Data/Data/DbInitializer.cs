using SanaProducts.Domain.Entities;
using SanaProducts.Domain.Enums;
using SanaProducts.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Data.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SanaProductsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
            {
                new Category{Name="Shoes", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi"},
                new Category{Name="Clothes", Description=""},
                new Category{Name="Electronic Devices", Description=""},
                new Category{Name="Home", Description=""},
                new Category{Name="Construction", Description=""},
                new Category{Name="Cars", Description=""},
                new Category{Name="Toys", Description=""},
                new Category{Name="Sports", Description=""},
                new Category{Name="Kids", Description=""},
                new Category{Name="Video Games", Description=""},
                new Category{Name="Decoration", Description=""},
                new Category{Name="Interior Design", Description=""},
                new Category{Name="Food and Drinks", Description=""},
                new Category{Name="Liqueurs", Description=""}
            };

            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }

            context.SaveChanges();

            var products = new Product[]
            {
                new Product{Name="Reebok Men's Club MEMT Sneaker", TradeMark="Reebok", Image="https://bit.ly/31UV5dJ"},
                new Product{Name="Hurley Women’s Jacket", TradeMark="Hurley Women’s Jacket", Image="https://bit.ly/3pWYmRB"},
                new Product{Name="Barbie Dreamhouse", TradeMark="Barbie", Image="https://bit.ly/3s9ejap"},
                new Product{Name="Renault LOGAN", TradeMark="Renault", Image="https://bit.ly/3s1DgnQ"},
                new Product{Name="LED Desk Lamp", TradeMark="YOTUTUN", Image="https://bit.ly/33saKlg"},
                new Product{Name="Ron Santafe Nido Cóndores", TradeMark="Ron Santafe", Image="https://bit.ly/3mo8hPx"},
                new Product{Name="Microsoft XBOX 360 Slim", TradeMark="Microsoft", Image="https://bit.ly/33g8UDN"},
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();

            var productCategories = new ProductCategory[]
            {
                new ProductCategory{ProductId=1, CategoryId=1 },
                new ProductCategory{ProductId=2, CategoryId=2 },
                new ProductCategory{ProductId=3, CategoryId=7 },
                new ProductCategory{ProductId=4, CategoryId=6 },
                new ProductCategory{ProductId=5, CategoryId=11 },
                new ProductCategory{ProductId=5, CategoryId=12 },
                new ProductCategory{ProductId=6, CategoryId=13 },
                new ProductCategory{ProductId=6, CategoryId=14 },
                new ProductCategory{ProductId=7, CategoryId=3 },
                new ProductCategory{ProductId=7, CategoryId=7 },
                new ProductCategory{ProductId=7, CategoryId=10 }
            };
            foreach (ProductCategory pc in productCategories)
            {
                context.ProductCategories.Add(pc);
            }

            context.SaveChanges();

            var productDetails = new ProductDetail[]
           {
                new ProductDetail{ProductId=1, ProducedBy="Reebok", TechnicalDataSheet="", Model="", Description="", Score=5, Gender=Gender.Unisex},
                new ProductDetail{ProductId=2, ProducedBy="Hurley", TechnicalDataSheet="", Model="", Description="", Score=5, Gender=Gender.Masculine},
                new ProductDetail{ProductId=3, ProducedBy="Barbie", TechnicalDataSheet="", Model="", Description="", Score=4, Gender=Gender.Female},
                new ProductDetail{ProductId=4, ProducedBy="Renault", TechnicalDataSheet="", Model="", Description="", Score=3, Gender=Gender.Others},
                new ProductDetail{ProductId=5, ProducedBy="YOTUTUN", TechnicalDataSheet="", Model="", Description="", Score=4, Gender=Gender.Others }
           };
            foreach (Product pd in products)
            {
                context.Products.Add(pd);
            }

            context.SaveChanges();
        }
    }
}

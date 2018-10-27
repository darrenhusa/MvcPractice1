using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MvcPractice1.Models;

namespace MvcPractice1.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Suppliers.Any())
            {
                context.Suppliers.AddRange(
                    new Supplier
                    {
                        Code = "ER",
                        Name = "Ergonomics Ltd.",
                        Telephone = "517-555-3853"
                    },
                    new Supplier
                    {
                        Code = "HI",
                        Name = "Human Interface",
                        Telephone = "317-555-4747"
                    },
                    new Supplier
                    {
                        Code = "MT",
                        Name = "Mouse Tracks",
                        Telephone = "616-555-9228"
                    });
            }

            if (!context.Items.Any())
            {
                context.Items.AddRange(
                    new Item
                    { ItemId = 1663,
                      Description = "Antistatic Wipes",
                      UnitsOnHand = 20,
                      Cost = 0.15M,
                      SellingPrice = 0.25M,
                    },
                    new Item
                    { ItemId = 1683,
                      Description = "CD Wallet",
                      UnitsOnHand = 12,
                      Cost = 3.45M,
                      SellingPrice = 4.00M
                    },
                    new Item
                    { ItemId = 2563,
                      Description = "Desktop Holder",
                      UnitsOnHand = 4,
                      Cost = 3.85M,
                      SellingPrice = 4.75M
                    },
                    new Item
                    { ItemId = 2593,
                      Description = "Disks",
                      UnitsOnHand = 175,
                      Cost = 0.25M,
                      SellingPrice = 0.75M
                    },
                    new Item
                    { ItemId = 3923,
                      Description = "Disk Cases",
                      UnitsOnHand = 12,
                      Cost = 2.20M,
                      SellingPrice = 2.75M
                    },
                    new Item
                    { ItemId = 3953,
                      Description = "Mouse Holder",
                      UnitsOnHand = 10,
                      Cost = 0.80M,
                      SellingPrice = 1.00M
                    },
                    new Item
                    { ItemId = 4343,
                      Description = "Mouse Pad",
                      UnitsOnHand = 25,
                      Cost = 2.25M,
                      SellingPrice = 3.00M
                    },
                    new Item
                    { ItemId = 5810,
                      Description = "PC Tool Kit",
                      UnitsOnHand = 9,
                      Cost = 7.80M,
                      SellingPrice = 9.00M
                    },
                    new Item
                    { ItemId = 5930,
                      Description = "Wrist Rest",
                      UnitsOnHand = 3,
                      Cost = 2.90M,
                      SellingPrice = 3.25M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
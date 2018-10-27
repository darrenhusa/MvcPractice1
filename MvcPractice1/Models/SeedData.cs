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
            if (!context.Items.Any())
            {
                context.Items.AddRange(
                    new Item
                    { ItemId = 1663, Description = "Antistatic Wipes" },
                    new Item
                    { ItemId = 1683, Description = "CD Wallet" },
                    new Item
                    { ItemId = 2563, Description = "Desktop Holder" },
                    new Item
                    { ItemId = 2593, Description = "Disks" },
                    new Item
                    { ItemId = 3923, Description = "Disk Cases" },
                    new Item
                    { ItemId = 3953, Description = "Mouse Holder" },
                    new Item
                    { ItemId = 4343, Description = "Mouse Pad" },
                    new Item
                    { ItemId = 5810, Description = "PC Tool Kit" },
                    new Item
                    { ItemId = 5930, Description = "Wrist Rest" }
                );
                context.SaveChanges();
            }
        }
    }
}
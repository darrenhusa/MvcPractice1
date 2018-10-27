using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPractice1.Models
{
    public class FakeItemRepository : IItemRepository
    {
        public IQueryable<Item> Items => new List<Item> { 
            new Item { ItemId = 1663, Description = "Antistatic Wipes" },
            new Item { ItemId = 1683, Description = "CD Wallet" },
            new Item { ItemId = 2563, Description = "Desktop Holder"},
            new Item { ItemId = 2593, Description = "Disks"},
            new Item { ItemId = 3923, Description = "Disk Cases"},
            new Item { ItemId = 3953, Description = "Mouse Holder"},
            new Item { ItemId = 4343, Description = "Mouse Pad"},
            new Item { ItemId = 5810, Description = "PC Tool Kit"},
            new Item { ItemId = 5930, Description = "Wrist Rest"},
        }.AsQueryable<Item>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcPractice1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcPractice1.Controllers
{
    public class ItemController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index() => View(ItemRepository.repo.Items);

            //Item myitem = new Item();
            //myitem.ItemId = 1663;
            //myitem.Description = "Antistatic Wipes";

            //Item[] items = 
            //{ new Item { ItemId = 1663, Description = "Antistatic Wipes"},
            //  new Item { ItemId = 1683, Description = "CD Wallet"},
            //  new Item { ItemId = 2563, Description = "Desktop Holder"},
            //  new Item { ItemId = 2593, Description = "Disks"},
            //  new Item { ItemId = 3923, Description = "Disk Cases"},
            //  new Item { ItemId = 3953, Description = "Mouse Holder"},
            //  new Item { ItemId = 4343, Description = "Mouse Pad"},
            //  new Item { ItemId = 5810, Description = "PC Tool Kit"},
            //  new Item { ItemId = 5930, Description = "Wrist Rest"},
            //};
            //return View(items);
        //}

        public IActionResult New()
        {
            return View();
        }

    }
}

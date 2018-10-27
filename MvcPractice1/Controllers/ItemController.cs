using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcPractice1.Models;

namespace MvcPractice1.Controllers
{
    public class ItemController : Controller
    {
        private IItemRepository repository;

        public ItemController(IItemRepository repo)
        {
            repository = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {   
            return View(repository.Items);
        }

        public IActionResult New()
        {
            return View();
        }

    }
}

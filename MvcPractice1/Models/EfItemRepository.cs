using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcPractice1.Models
{
    public class EfItemRepository : IItemRepository
    {
        private ApplicationDbContext context;

        public EfItemRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Item> Items => context.Items;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPractice1.Models;

namespace MvcPractice1.Models
{
    public interface IItemRepository
    {
        IQueryable<Item> Items { get; }
    }
}

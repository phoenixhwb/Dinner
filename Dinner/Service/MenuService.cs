using System;
using System.Collections.Generic;
using System.Text;
using Dinner.Model;

namespace Dinner.Service
{
    class MenuService : IMenuService
    {
        public IEnumerable<Dish> GetMenu()
        {
            return new List<Dish>();
        }
    }
}

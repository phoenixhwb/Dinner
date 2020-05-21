using Dinner.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Service
{
    interface IMenuService
    {
        public IEnumerable<Dish> GetMenu();
    }
}

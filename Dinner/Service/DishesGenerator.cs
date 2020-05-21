using Dinner.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Service
{
    class DishesGenerator
    {
        static IEnumerable<Dish> s_dishes;
        public DishesGenerator(IMenuService menuService)
        {
            s_dishes = menuService.GetMenu();
        }

        private DailyDishes GenerateDayDishes()
        {

        }

    }
}

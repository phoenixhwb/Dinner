using Dinner.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Service
{
    class FakeMenuService : IMenuService
    {
        public IEnumerable<Dish> GetMenu() =>
            new List<Dish>
            {
                new Dish{ Name = "Main1", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Main2", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Main3", Class = DishClass.Main, Heavy = 2},
                new Dish{ Name = "Main4", Class = DishClass.Main, Heavy = 2},
                new Dish{ Name = "Main5", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Main6", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Main7", Class = DishClass.Main, Heavy = 2},
                new Dish{ Name = "Main8", Class = DishClass.Main, Heavy = 2},
                new Dish{ Name = "Main9", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Main10", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup1", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup2", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup3", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup4", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup5", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup6", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup7", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup8", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Soup9", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege1", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege2", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege3", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege4", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege5", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege6", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege7", Class = DishClass.Main, Heavy = 1},
                new Dish{ Name = "Vege8", Class = DishClass.Main, Heavy = 1},
            };
    }
}

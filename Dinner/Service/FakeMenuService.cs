using Dinner.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Service
{
    class FakeMenuService : IMenuService
    {
        public Menu GetMenu() =>
            new Menu
            {
                Soup = new List<Dish>
                {
                    new Soup{ Name = "Soup1", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup2", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup3", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup4", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup5", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup6", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup7", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup8", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "Soup9", Class = DishClass.Soup, Heavy = 1},

                },
                Main = new List<Dish>
                {
                    new Main{ Name = "Main1", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "Main2", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "Main3", Class = DishClass.Main, Heavy = 2},
                    new Main{ Name = "Main4", Class = DishClass.Main, Heavy = 2},
                    new Main{ Name = "Main5", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "Main6", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "Main7", Class = DishClass.Main, Heavy = 2},
                    new Main{ Name = "Main8", Class = DishClass.Main, Heavy = 2},
                    new Main{ Name = "Main9", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "Main10", Class = DishClass.Main, Heavy = 1},
                },
                Vege = new List<Dish>
                {
                    new Vege{ Name = "Vege1", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "Vege2", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "Vege3", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "Vege4", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "Vege5", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "Vege6", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "Vege7", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "Vege8", Class = DishClass.Vege, Heavy = 1},
                }
            };
    }
}

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
                    new Soup{ Name = "汤1", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤2", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤3", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤4", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤5", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤6", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤7", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤8", Class = DishClass.Soup, Heavy = 1},
                    new Soup{ Name = "汤9", Class = DishClass.Soup, Heavy = 1},

                },
                Main = new List<Dish>
                {
                    new Main{ Name = "主菜1", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "主菜2", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "主菜3", Class = DishClass.Main, Heavy = 2},
                    new Main{ Name = "主菜4", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "主菜5", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "主菜6", Class = DishClass.Main, Heavy = 1},
                    new Main{ Name = "主菜7", Class = DishClass.Main, Heavy = 2},
                    new Main{ Name = "主菜8", Class = DishClass.Main, Heavy = 2},
                    new Main{ Name = "主菜9", Class = DishClass.Main, Heavy = 1},
                },
                Vege = new List<Dish>
                {
                    new Vege{ Name = "蔬菜1", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "蔬菜2", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "蔬菜3", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "蔬菜4", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "蔬菜5", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "蔬菜6", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "蔬菜7", Class = DishClass.Vege, Heavy = 1},
                    new Vege{ Name = "蔬菜8", Class = DishClass.Vege, Heavy = 1},
                }
            };
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Model
{
    class Dish
    {
        public string Name { get; set; }
        public DishClass Class { get; set; }
        public int Heavy { get; set; }
        public bool IsChecked { get; set; }
        public Dish()
        {
            IsChecked = false;
        }

    }

    class Soup : Dish { }
    class Main : Dish { }
    class Vege : Dish { }
}

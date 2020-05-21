using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Model
{
    class DailyDishes
    {
        public Day Day { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
    }
}

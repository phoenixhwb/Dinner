using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dinner.Model
{
    class Menu
    {
        public List<Dish> Soup { get; set; }
        public List<Dish> Main { get; set; }
        public List<Dish> Vege { get; set; }
        public bool IsMainAllChecked { get => Main.All(d => d.IsChecked); }
        public bool IsAll2PointDish { get => Main.Where(d => !d.IsChecked).All(d => d.Heavy == 2); }
        public void MainReset()
        {
            foreach (var d in Main) d.IsChecked = false;
        }
        public void Reset()
        {
            foreach (var d in Soup) d.IsChecked = false;
            foreach (var d in Main) d.IsChecked = false;
            foreach (var d in Vege) d.IsChecked = false;
        }
    }
}

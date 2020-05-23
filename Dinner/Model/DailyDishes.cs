using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Model 
{
    class DailyDishes : ReactiveObject
    {
        public Day Day { get; set; }

        private IEnumerable<Dish> _dishes;
        public IEnumerable<Dish> Dishes { get => _dishes; set => this.RaiseAndSetIfChanged(ref _dishes, value); }
    }
}

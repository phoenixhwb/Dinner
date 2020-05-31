using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Model
{
    class WeekDishes : ReactiveObject
    {
        public int Index { get; set; }

        private List<DailyDishes> _days;
        public List<DailyDishes> Days { get => _days; set => this.RaiseAndSetIfChanged(ref _days, value); }
    }
}

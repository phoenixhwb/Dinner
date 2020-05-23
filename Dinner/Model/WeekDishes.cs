using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Model
{
    class WeekDishes : ReactiveObject
    {
        public int Index { get; set; }

        private IEnumerable<DailyDishes> _days;
        public IEnumerable<DailyDishes> Days { get => _days; set => this.RaiseAndSetIfChanged(ref _days, value); }
    }
}

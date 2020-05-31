using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dinner.Model;
using Dinner.Service;
using ReactiveUI;
using System.Reactive;

namespace Dinner.ViewModel
{
    class MainWindowViewModel : ReactiveObject
    {
        private DishesGenerator dishesGenerator;
        public MainWindowViewModel()
        {
            dishesGenerator = new DishesGenerator(new FakeMenuService());
            GenerateCommand = ReactiveCommand.Create(() =>
            {
                Week = dishesGenerator.GenerateWeekDishes();
            });
        }


        private WeekDishes _week;
        public WeekDishes Week { get => _week; set => this.RaiseAndSetIfChanged(ref _week, value); }

        public ReactiveCommand<Unit, Unit> GenerateCommand { get; set; }
    }
}

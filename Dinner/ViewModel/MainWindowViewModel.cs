using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Dinner.Model;
using Dinner.Service;
using ReactiveUI;

namespace Dinner.ViewModel
{
    class MainWindowViewModel : ReactiveObject
    {
        private DishesGenerator dishesGenerator;
        public MainWindowViewModel()
        {
            dishesGenerator = new DishesGenerator(new MenuService());
            Week = dishesGenerator.GenerateWeekDishes();
            foreach (var day in Week.Days)
            {
                Console.WriteLine("Day {0} :", day.Day);
                foreach (var dish in day.Dishes)
                {
                    Console.WriteLine("    Name:{0}  Class:{1}  Heavy:{2}", dish.Name, dish.Class, dish.Heavy);
                }
            }

        }


        private WeekDishes _week;
        public WeekDishes Week { get => _week; set => this.RaiseAndSetIfChanged(ref _week, value); }
            

    }
}

using Dinner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace Dinner.Service
{
    class DishesGenerator
    {
        static Menu s_menu;
        public DishesGenerator(IMenuService menuService)
        {
            s_menu = menuService.GetMenu();
        }

        public WeekDishes GenerateWeekDishes()
        {
            s_menu.Reset();
            var weekDays = new List<Day>
            {
                Day.星期一,
                Day.星期二,
                Day.星期三,
                Day.星期四,
                Day.星期五
            };
            var daysDishes =
                weekDays
                .Select(GenerateDayDishes)
                .ToList();
            var result =
                new WeekDishes
                {
                    Index = 1,
                    Days = daysDishes
                };
            return result;
        }

        private DailyDishes GenerateDayDishes(Day day)
        {
            var dishes = new List<Dish>();
            dishes.Add(GenerateSoup());
            dishes.Add(GenerateVege());
            dishes.AddRange(GenerateMains());

            return new DailyDishes
            {
                Day = day,
                Dishes = dishes
            };
        }

        private Dish GenerateSoup()
        {
            Dish result;
            var dishNumber = s_menu.Soup.Count();
            do
            {
                var index = RandomNumberService.Generate(dishNumber);
                result = s_menu.Soup.ElementAt(index);
            }
            while (result.IsChecked == true);
            result.IsChecked = true;
            return result;
        }

        private Dish GenerateVege()
        {
            Dish result;
            var dishNumber = s_menu.Vege.Count();
            do
            {
                var index = RandomNumberService.Generate(dishNumber);
                result = s_menu.Vege.ElementAt(index);
            }
            while (result.IsChecked == true);
            result.IsChecked = true;
            return result;
        }

        private IEnumerable<Dish> GenerateMains()
        {
            var result = new List<Dish>();
            var dishNumber = s_menu.Main.Count();
            while (result.Select(d => d.Heavy).Sum() != 3 )
            {
                if (s_menu.IsMainAllChecked || s_menu.IsAll2PointDish)
                    s_menu.MainReset();
                var index = RandomNumberService.Generate(dishNumber);
                var dish = s_menu.Main.ElementAt(index);
                var heavy = result.Sum(d => d.Heavy) + dish.Heavy;
                if(dish.IsChecked == false && heavy <= 3)
                {
                    result.Add(dish);
                    dish.IsChecked = true;
                }
            };
            return result;
        }
    }
}

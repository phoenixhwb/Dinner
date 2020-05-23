using System;
using System.Collections.Generic;
using System.Text;
using Dinner.Model;

namespace Dinner.Service
{
    class MenuService : IMenuService
    {
        public Menu GetMenu()
        {
            return new Menu();
        }
    }
}

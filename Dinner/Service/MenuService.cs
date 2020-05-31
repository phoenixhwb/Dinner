using System;
using System.Collections.Generic;
using System.Text;
using Dinner.Model;
using Microsoft.VisualBasic;

namespace Dinner.Service
{
    class MenuService : IMenuService
    {
        
        private const string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source =C:\\08.xls;Extended Properties=Excel 8.0";
        public MenuService()
        {

        }
        public Menu GetMenu()
        {
            return new Menu();
        }
    }
}

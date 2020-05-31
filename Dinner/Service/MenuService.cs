using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Text;
using Dinner.Model;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dinner.Service
{
    class MenuService : IMenuService
    {
        const string path = @"..\netcoreapp3.1\Data\Menu.xlsx";
        const string connstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1';";
        public Menu CurrentMenu { get; set; }
        public MenuService()
        {
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                conn.Open();
                CurrentMenu = new Menu
                {
                    Main = ToDomain(ReadMenu(conn, DishClass.Main)),
                    Soup = ToDomain(ReadMenu(conn, DishClass.Soup)),
                    Vege = ToDomain(ReadMenu(conn, DishClass.Vege)),
                };
            }
        }
        public Menu GetMenu()
        {
            return CurrentMenu;
        }

        private DataTable ReadMenu(OleDbConnection conn, DishClass dishClass)
        {
            DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
            string sheet = sheetsName.Rows[0][2].ToString();
            string sql = string.Format("SELECT * FROM [{0}]", sheet);

            OleDbDataAdapter ada = new OleDbDataAdapter(sql, connstring);
            DataSet set = new DataSet();
            ada.Fill(set);
            return set.Tables[0];
        }
        private IEnumerable<Dish> ToDomain(DataTable ds)
        {
            var a = ds.AsEnumerable();
            return
                a
                .Skip(1)
                .Select(x => ToDomain(x));
        }
        private Dish ToDomain(DataRow row)
        {
            return new Dish
            {
                Name = row.ItemArray[0].ToString(),
                Class = ToDomain(row.ItemArray[1].ToString()),
                Heavy = int.Parse(row.ItemArray[2].ToString())
            };
        }
        private DishClass ToDomain(string ds)
        {
            switch (ds)
            {
                case "Main": return DishClass.Main;
                case "Soup": return DishClass.Soup;
                case "Vege": return DishClass.Vege;
            }
            return DishClass.Main;
        }
    }
}

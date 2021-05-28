using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieticNutritionApp.Classes
{
    public class WeeklyMenu
    {
        public string getWeek(string Week)
        {
            return "You have add a new menu to week " + Week;
        }
    }
    public class MeatType
    {
        public string Chicken()
        {
            return ("chicken meat");
        }

        public string Pork()
        {
            return ("pork meat");
        }

        public string Beef()
        {
            return ("beef meat");
        }
    }
 
    public class DailyMenu
    {

        public string getDay(string Day)
        {
            return (", " + Day);
        }
    }
    public class MenuFacade
    {
        public static MenuFacade INSTANCE = new MenuFacade();
        private WeeklyMenu weeklymenu;
        private MeatType meattype;
        private DailyMenu dailymenu;

        private MenuFacade()
        {
            weeklymenu = new WeeklyMenu();
            meattype = new MeatType();
            dailymenu = new DailyMenu();
        }

        public static MenuFacade getInstance()
        {
            return INSTANCE;
        }
        public string getweek()
        {
            return "You have add a new menu to week " + weeklymenu;
        }
            public string getChicken()
        {
            return "Meat type chicken.";
        }
        public string getPork()
        {
            return "Meat type pork.";
        }
        public string getBeef()
        {
            return "Meat type beef.";
        }
    }
}

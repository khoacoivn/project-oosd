using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieticNutritionApp.Classes
{
    public class MenuFactory
    {
        private MenuFactory()
        {
        }
        public static CookType getCookType(Cooktypes CookType)
        {
            switch (CookType)
            {
                case Cooktypes.Grilled:
                    return new Grilled(new CheckingCookType());
                case Cooktypes.Fry:
                    return new Fry(new CheckingCookType());
                case Cooktypes.Boiled:
                    return new Boiled(new CheckingCookType());
                default:
                    return null;
            }
        }
    }
    public enum Cooktypes
    {
        Grilled, Fry, Boiled
    }
}

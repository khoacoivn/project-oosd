using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface TypeCook
{
    string OpenCookType();
}
namespace DieticNutritionApp.Classes
{
    public class CheckingCookType : TypeCook
    {
        public string OpenCookType()
        {
            return "Checking";
        }
    }
    public class SavingCookType : TypeCook
    {
        public string OpenCookType()
        {
            return "Saving";

        }
    }
    public abstract class CookType
    {
        protected TypeCook cooktype;
        public CookType(TypeCook cooktype)
        {
            this.cooktype = cooktype;
        }
        public abstract string OpenCookType();
    }
    public class Grilled : CookType
    {
 
        public Grilled(TypeCook cooktype) : base(cooktype)
        {
            this.cooktype = cooktype;
        }

        public override string OpenCookType()
        {

            cooktype.OpenCookType();
            return "Cook by grilled.";

        }
    }
    public class Fry : CookType
    {
        public Fry(TypeCook cooktype) : base(cooktype)
        {
            this.cooktype = cooktype;
        }
        public override string OpenCookType()
        {
            //print open a normal account is a 
            cooktype.OpenCookType();
            return "Cook by fry.";
        }
    }

    public class Boiled : CookType
    {
        protected Type type;
        public Boiled(TypeCook cooktype) : base(cooktype)
        {
            this.cooktype = cooktype;
        }
        public override string OpenCookType()
        {
            //print open a normal account is a 
            cooktype.OpenCookType();
            return "Cook by boiled.";
        }
    }
}

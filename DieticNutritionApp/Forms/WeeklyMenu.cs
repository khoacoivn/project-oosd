using DieticNutritionApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieticNutritionApp.Forms
{
    public partial class WeeklyMenu : Form
    {
        public WeeklyMenu()
        {
            InitializeComponent();
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (Foodcbb.SelectedItem.ToString() == "Chicken")
                MessageBox.Show(MenuFacade.getInstance().getChicken());
            else if (Foodcbb.SelectedItem.ToString() == "Pork")
                MessageBox.Show(MenuFacade.getInstance().getPork());
            else if (Foodcbb.SelectedItem.ToString() == "Beef")
                MessageBox.Show(MenuFacade.getInstance().getBeef());
            if (Cookcbb.SelectedItem.ToString() == "Grilled")
            {
                CookType Grilled = MenuFactory.getCookType(Cooktypes.Grilled);
                MessageBox.Show(Grilled.OpenCookType());
            }
            else if (Cookcbb.SelectedItem.ToString() == "Fry")
            {
                CookType Fry = MenuFactory.getCookType(Cooktypes.Fry);
                MessageBox.Show(Fry.OpenCookType());
            }
            else
            {
                CookType Boiled = MenuFactory.getCookType(Cooktypes.Boiled);
                MessageBox.Show(Boiled.OpenCookType());
            }
        }

       
    }
}


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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dsb = new MainForm();
            dsb.Show();
        }

        private void Registeredbtn_Click(object sender, EventArgs e)
        {
            SignUpForm secondForm = new SignUpForm();
            secondForm.ShowDialog();
        }
    }
}

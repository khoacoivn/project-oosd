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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

    

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            Signup account = new Signup.SignupBuilder(this.Nametbx.Text)
                                 .withUsername(this.UserNametbx.Text)
                                .withPassword(this.Passwordtbx.Text)
                                .withAddress(this.Addresstbx.Text)
                                .withPhone(this.Phonetbx.Text).build();
            MessageBox.Show(account.ToString());
        }
    }
}

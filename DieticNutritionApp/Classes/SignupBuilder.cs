using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieticNutritionApp.Classes
{
    public class Signup
    {
        private string Username;
        private string Password;
        private string NameOfUser;
        private string Address;
        private string Phone;
        public Signup(string Username, string Password, string NameOfUser, string Address, string Phone)
        {
            this.Username = Username;
            this.Password = Password;           
            this.NameOfUser = NameOfUser;
            this.Address = Address;
            this.Phone = Phone;
        }

        public Signup()
        {
        }

        public class SignupBuilder
        {
            private string Username;
            private string Password;
            private string NameOfUser;
            private string Address;
            private string Phone;
            public SignupBuilder(string NameOfUser)
            {
                this.NameOfUser = NameOfUser;
            }
            public SignupBuilder withUsername(string Username)
            {
                this.Username = Username;
                return this;
            }
            public SignupBuilder withPassword(string Password)
            {
                this.Password = Password;
                return this;
            }
            public SignupBuilder withAddress(string Address)
            {
                this.Address = Address;
                return this;
            }
            public SignupBuilder withPhone(string Phone)
            {
                this.Phone = Phone;
                return this;
            }
            public Signup build()
            {
                validateUserObject();
                Signup account = new Signup(this.Username, this.Password, this.NameOfUser, this.Address, this.Phone);
                return account;
            }
            private void validateUserObject()
            {

            }
        }
        public override string ToString()
        {
            return "New account has been registered.\n" +"Your account info:" + "\n" + "Username: " + this.Username + "\n" + "Password: " + this.Password + "\n" + "NameOfUser: " + this.NameOfUser + "\n" + "Address: " + this.Address + "\n" + "Phone: " + this.Phone + "\n" ;
        }
    }
}



namespace DieticNutritionApp.Forms
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.UserNametbx = new System.Windows.Forms.TextBox();
            this.Passwordtbx = new System.Windows.Forms.TextBox();
            this.Nametbx = new System.Windows.Forms.TextBox();
            this.Addresstbx = new System.Windows.Forms.TextBox();
            this.Phonetbx = new System.Windows.Forms.TextBox();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up Form";
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Location = new System.Drawing.Point(41, 57);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(57, 13);
            this.UserNamelbl.TabIndex = 0;
            this.UserNamelbl.Text = "UserName";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(41, 84);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.Passwordlbl.TabIndex = 0;
            this.Passwordlbl.Text = "Password";
            
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(41, 109);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(35, 13);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name";
           
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Location = new System.Drawing.Point(41, 136);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(45, 13);
            this.Addresslbl.TabIndex = 0;
            this.Addresslbl.Text = "Address";
           
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Location = new System.Drawing.Point(41, 162);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(38, 13);
            this.Phonelbl.TabIndex = 0;
            this.Phonelbl.Text = "Phone";
           
            // 
            // UserNametbx
            // 
            this.UserNametbx.Location = new System.Drawing.Point(129, 50);
            this.UserNametbx.Name = "UserNametbx";
            this.UserNametbx.Size = new System.Drawing.Size(100, 20);
            this.UserNametbx.TabIndex = 1;
            // 
            // Passwordtbx
            // 
            this.Passwordtbx.Location = new System.Drawing.Point(129, 77);
            this.Passwordtbx.Name = "Passwordtbx";
            this.Passwordtbx.Size = new System.Drawing.Size(100, 20);
            this.Passwordtbx.TabIndex = 1;
            // 
            // Nametbx
            // 
            this.Nametbx.Location = new System.Drawing.Point(129, 102);
            this.Nametbx.Name = "Nametbx";
            this.Nametbx.Size = new System.Drawing.Size(100, 20);
            this.Nametbx.TabIndex = 1;
            // 
            // Addresstbx
            // 
            this.Addresstbx.Location = new System.Drawing.Point(129, 128);
            this.Addresstbx.Name = "Addresstbx";
            this.Addresstbx.Size = new System.Drawing.Size(100, 20);
            this.Addresstbx.TabIndex = 1;
            // 
            // Phonetbx
            // 
            this.Phonetbx.Location = new System.Drawing.Point(129, 155);
            this.Phonetbx.Name = "Phonetbx";
            this.Phonetbx.Size = new System.Drawing.Size(100, 20);
            this.Phonetbx.TabIndex = 1;
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.Location = new System.Drawing.Point(147, 192);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(82, 23);
            this.SignUpbtn.TabIndex = 2;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = true;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 227);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.Phonetbx);
            this.Controls.Add(this.Addresstbx);
            this.Controls.Add(this.Nametbx);
            this.Controls.Add(this.Passwordtbx);
            this.Controls.Add(this.UserNametbx);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Phonelbl);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.TextBox UserNametbx;
        private System.Windows.Forms.TextBox Passwordtbx;
        private System.Windows.Forms.TextBox Nametbx;
        private System.Windows.Forms.TextBox Addresstbx;
        private System.Windows.Forms.TextBox Phonetbx;
        private System.Windows.Forms.Button SignUpbtn;
    }
}
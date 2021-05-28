
namespace DieticNutritionApp.Forms
{
    partial class LogInForm
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
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.Registeredbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Location = new System.Drawing.Point(13, 22);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(60, 13);
            this.UserNamelbl.TabIndex = 0;
            this.UserNamelbl.Text = "User Name";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(12, 51);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.Passwordlbl.TabIndex = 0;
            this.Passwordlbl.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // LogInbtn
            // 
            this.LogInbtn.Location = new System.Drawing.Point(12, 81);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(75, 23);
            this.LogInbtn.TabIndex = 2;
            this.LogInbtn.Text = "Log In";
            this.LogInbtn.UseVisualStyleBackColor = true;
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // Registeredbtn
            // 
            this.Registeredbtn.Location = new System.Drawing.Point(127, 81);
            this.Registeredbtn.Name = "Registeredbtn";
            this.Registeredbtn.Size = new System.Drawing.Size(75, 23);
            this.Registeredbtn.TabIndex = 3;
            this.Registeredbtn.Text = "Registered";
            this.Registeredbtn.UseVisualStyleBackColor = true;
            this.Registeredbtn.Click += new System.EventHandler(this.Registeredbtn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 126);
            this.Controls.Add(this.Registeredbtn);
            this.Controls.Add(this.LogInbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.UserNamelbl);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LogInbtn;
        private System.Windows.Forms.Button Registeredbtn;
    }
}
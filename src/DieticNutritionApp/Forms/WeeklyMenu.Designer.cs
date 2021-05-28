
namespace DieticNutritionApp.Forms
{
    partial class WeeklyMenu
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
            this.Weeklbl = new System.Windows.Forms.Label();
            this.Daylbl = new System.Windows.Forms.Label();
            this.Foodlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Weektxb = new System.Windows.Forms.TextBox();
            this.Daytxb = new System.Windows.Forms.TextBox();
            this.Foodcbb = new System.Windows.Forms.ComboBox();
            this.Cookcbb = new System.Windows.Forms.ComboBox();
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Weeklbl
            // 
            this.Weeklbl.AutoSize = true;
            this.Weeklbl.Location = new System.Drawing.Point(38, 32);
            this.Weeklbl.Name = "Weeklbl";
            this.Weeklbl.Size = new System.Drawing.Size(64, 13);
            this.Weeklbl.TabIndex = 0;
            this.Weeklbl.Text = "Enter Week";
            // 
            // Daylbl
            // 
            this.Daylbl.AutoSize = true;
            this.Daylbl.Location = new System.Drawing.Point(38, 60);
            this.Daylbl.Name = "Daylbl";
            this.Daylbl.Size = new System.Drawing.Size(54, 13);
            this.Daylbl.TabIndex = 1;
            this.Daylbl.Text = "Enter Day";
            // 
            // Foodlbl
            // 
            this.Foodlbl.AutoSize = true;
            this.Foodlbl.Location = new System.Drawing.Point(38, 87);
            this.Foodlbl.Name = "Foodlbl";
            this.Foodlbl.Size = new System.Drawing.Size(70, 13);
            this.Foodlbl.TabIndex = 0;
            this.Foodlbl.Text = "Choose Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choose Cook Type";
            // 
            // Weektxb
            // 
            this.Weektxb.Location = new System.Drawing.Point(183, 25);
            this.Weektxb.Name = "Weektxb";
            this.Weektxb.Size = new System.Drawing.Size(100, 20);
            this.Weektxb.TabIndex = 2;
            // 
            // Daytxb
            // 
            this.Daytxb.Location = new System.Drawing.Point(183, 53);
            this.Daytxb.Name = "Daytxb";
            this.Daytxb.Size = new System.Drawing.Size(100, 20);
            this.Daytxb.TabIndex = 2;
            // 
            // Foodcbb
            // 
            this.Foodcbb.FormattingEnabled = true;
            this.Foodcbb.Items.AddRange(new object[] {
            "Chicken",
            "Pork",
            "Beef"});
            this.Foodcbb.Location = new System.Drawing.Point(183, 79);
            this.Foodcbb.Name = "Foodcbb";
            this.Foodcbb.Size = new System.Drawing.Size(100, 21);
            this.Foodcbb.TabIndex = 3;
            // 
            // Cookcbb
            // 
            this.Cookcbb.FormattingEnabled = true;
            this.Cookcbb.Items.AddRange(new object[] {
            "Grilled",
            "Fry",
            "Boiled"});
            this.Cookcbb.Location = new System.Drawing.Point(183, 105);
            this.Cookcbb.Name = "Cookcbb";
            this.Cookcbb.Size = new System.Drawing.Size(100, 21);
            this.Cookcbb.TabIndex = 3;
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Location = new System.Drawing.Point(208, 135);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.Confirmbtn.TabIndex = 4;
            this.Confirmbtn.Text = "Confirm";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // WeeklyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 170);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.Cookcbb);
            this.Controls.Add(this.Foodcbb);
            this.Controls.Add(this.Daytxb);
            this.Controls.Add(this.Weektxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Foodlbl);
            this.Controls.Add(this.Daylbl);
            this.Controls.Add(this.Weeklbl);
            this.Name = "WeeklyMenu";
            this.Text = "WeeklyMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Weeklbl;
        private System.Windows.Forms.Label Daylbl;
        private System.Windows.Forms.Label Foodlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Weektxb;
        private System.Windows.Forms.TextBox Daytxb;
        private System.Windows.Forms.ComboBox Foodcbb;
        private System.Windows.Forms.ComboBox Cookcbb;
        private System.Windows.Forms.Button Confirmbtn;
    }
}
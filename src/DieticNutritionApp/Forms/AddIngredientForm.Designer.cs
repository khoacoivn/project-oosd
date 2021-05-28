namespace DieticNutritionApp.Forms
{
    partial class AddIngredientForm
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
            this.components = new System.ComponentModel.Container();
            this.tbName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbProteins = new System.Windows.Forms.TextBox();
            this.tbFats = new System.Windows.Forms.TextBox();
            this.tbVitamins = new System.Windows.Forms.TextBox();
            this.tbCarbs = new System.Windows.Forms.TextBox();
            this.cbIngType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMinerals = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 7);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(92, 20);
            this.tbName.TabIndex = 0;
        
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbProteins
            // 
            this.tbProteins.Location = new System.Drawing.Point(100, 30);
            this.tbProteins.Margin = new System.Windows.Forms.Padding(2);
            this.tbProteins.Name = "tbProteins";
            this.tbProteins.Size = new System.Drawing.Size(92, 20);
            this.tbProteins.TabIndex = 2;
            this.tbProteins.TextChanged += new System.EventHandler(this.tbProteins_TextChanged);
            // 
            // tbFats
            // 
            this.tbFats.Location = new System.Drawing.Point(100, 52);
            this.tbFats.Margin = new System.Windows.Forms.Padding(2);
            this.tbFats.Name = "tbFats";
            this.tbFats.Size = new System.Drawing.Size(92, 20);
            this.tbFats.TabIndex = 3;
            this.tbFats.TextChanged += new System.EventHandler(this.tbFats_TextChanged);
            // 
            // tbVitamins
            // 
            this.tbVitamins.Location = new System.Drawing.Point(100, 98);
            this.tbVitamins.Margin = new System.Windows.Forms.Padding(2);
            this.tbVitamins.Name = "tbVitamins";
            this.tbVitamins.Size = new System.Drawing.Size(92, 20);
            this.tbVitamins.TabIndex = 4;
            this.tbVitamins.TextChanged += new System.EventHandler(this.tbVitamins_TextChanged);
            // 
            // tbCarbs
            // 
            this.tbCarbs.Location = new System.Drawing.Point(100, 75);
            this.tbCarbs.Margin = new System.Windows.Forms.Padding(2);
            this.tbCarbs.Name = "tbCarbs";
            this.tbCarbs.Size = new System.Drawing.Size(92, 20);
            this.tbCarbs.TabIndex = 5;
            this.tbCarbs.TextChanged += new System.EventHandler(this.tbCarbs_TextChanged);
            // 
            // cbIngType
            // 
            this.cbIngType.FormattingEnabled = true;
            this.cbIngType.Location = new System.Drawing.Point(76, 160);
            this.cbIngType.Margin = new System.Windows.Forms.Padding(2);
            this.cbIngType.Name = "cbIngType";
            this.cbIngType.Size = new System.Drawing.Size(92, 21);
            this.cbIngType.TabIndex = 6;
            this.cbIngType.SelectedIndexChanged += new System.EventHandler(this.cbIngType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proteins";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fats";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Carbs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vitamins";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Minerals";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbMinerals
            // 
            this.tbMinerals.Location = new System.Drawing.Point(100, 123);
            this.tbMinerals.Margin = new System.Windows.Forms.Padding(2);
            this.tbMinerals.Name = "tbMinerals";
            this.tbMinerals.Size = new System.Drawing.Size(92, 20);
            this.tbMinerals.TabIndex = 13;
            this.tbMinerals.TextChanged += new System.EventHandler(this.tbMinerals_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ingredient type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(106, 184);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 19);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.tbProteins);
            this.guna2GradientPanel1.Controls.Add(this.tbName);
            this.guna2GradientPanel1.Controls.Add(this.btnOk);
            this.guna2GradientPanel1.Controls.Add(this.tbFats);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.tbVitamins);
            this.guna2GradientPanel1.Controls.Add(this.tbMinerals);
            this.guna2GradientPanel1.Controls.Add(this.tbCarbs);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.cbIngType);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(12, 37);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(282, 210);
            this.guna2GradientPanel1.TabIndex = 16;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // AddIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 262);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIngredientForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Ingredient";
            this.Load += new System.EventHandler(this.AddIngredientForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbProteins;
        private System.Windows.Forms.TextBox tbFats;
        private System.Windows.Forms.TextBox tbVitamins;
        private System.Windows.Forms.TextBox tbCarbs;
        private System.Windows.Forms.ComboBox cbIngType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMinerals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}
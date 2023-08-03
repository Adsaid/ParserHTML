namespace ParserHTML
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBrand = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkRes = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_minPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_maxPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkDiag = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_minPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoEllipsis = true;
            resources.ApplyResources(this.SearchBtn, "SearchBtn");
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // checkBrand
            // 
            resources.ApplyResources(this.checkBrand, "checkBrand");
            this.checkBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.checkBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBrand.FormattingEnabled = true;
            this.checkBrand.Items.AddRange(new object[] {
            resources.GetString("checkBrand.Items"),
            resources.GetString("checkBrand.Items1"),
            resources.GetString("checkBrand.Items2"),
            resources.GetString("checkBrand.Items3"),
            resources.GetString("checkBrand.Items4")});
            this.checkBrand.Name = "checkBrand";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // checkRes
            // 
            resources.ApplyResources(this.checkRes, "checkRes");
            this.checkRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.checkRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkRes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkRes.FormattingEnabled = true;
            this.checkRes.Items.AddRange(new object[] {
            resources.GetString("checkRes.Items"),
            resources.GetString("checkRes.Items1"),
            resources.GetString("checkRes.Items2"),
            resources.GetString("checkRes.Items3")});
            this.checkRes.Name = "checkRes";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // num_minPrice
            // 
            resources.ApplyResources(this.num_minPrice, "num_minPrice");
            this.num_minPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.num_minPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_minPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num_minPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_minPrice.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_minPrice.Name = "num_minPrice";
            this.num_minPrice.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // num_maxPrice
            // 
            resources.ApplyResources(this.num_maxPrice, "num_maxPrice");
            this.num_maxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.num_maxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_maxPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num_maxPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_maxPrice.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_maxPrice.Name = "num_maxPrice";
            this.num_maxPrice.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            // 
            // checkDiag
            // 
            resources.ApplyResources(this.checkDiag, "checkDiag");
            this.checkDiag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.checkDiag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkDiag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkDiag.FormattingEnabled = true;
            this.checkDiag.Items.AddRange(new object[] {
            resources.GetString("checkDiag.Items"),
            resources.GetString("checkDiag.Items1"),
            resources.GetString("checkDiag.Items2"),
            resources.GetString("checkDiag.Items3"),
            resources.GetString("checkDiag.Items4"),
            resources.GetString("checkDiag.Items5"),
            resources.GetString("checkDiag.Items6"),
            resources.GetString("checkDiag.Items7")});
            this.checkDiag.Name = "checkDiag";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.checkDiag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_maxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_minPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBrand);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            ((System.ComponentModel.ISupportInitialize)(this.num_minPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_minPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_maxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkDiag;
    }
}


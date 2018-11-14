namespace StockManagementSystem
{
    partial class Home
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchAndViewItemsSummaryButton = new System.Windows.Forms.Button();
            this.ViewSalesBetweenTwoDatesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.StockInButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemSetupButton = new System.Windows.Forms.Button();
            this.CategorySetupButton = new System.Windows.Forms.Button();
            this.CompanySetupButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(92, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Stock Management System";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchAndViewItemsSummaryButton);
            this.groupBox3.Controls.Add(this.ViewSalesBetweenTwoDatesButton);
            this.groupBox3.Location = new System.Drawing.Point(384, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 121);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Report";
            // 
            // SearchAndViewItemsSummaryButton
            // 
            this.SearchAndViewItemsSummaryButton.Location = new System.Drawing.Point(44, 27);
            this.SearchAndViewItemsSummaryButton.Name = "SearchAndViewItemsSummaryButton";
            this.SearchAndViewItemsSummaryButton.Size = new System.Drawing.Size(203, 23);
            this.SearchAndViewItemsSummaryButton.TabIndex = 0;
            this.SearchAndViewItemsSummaryButton.Text = "Search And View Items Summary";
            this.SearchAndViewItemsSummaryButton.UseVisualStyleBackColor = true;
            this.SearchAndViewItemsSummaryButton.Click += new System.EventHandler(this.SearchAndViewItemsSummaryButton_Click);
            // 
            // ViewSalesBetweenTwoDatesButton
            // 
            this.ViewSalesBetweenTwoDatesButton.Location = new System.Drawing.Point(44, 75);
            this.ViewSalesBetweenTwoDatesButton.Name = "ViewSalesBetweenTwoDatesButton";
            this.ViewSalesBetweenTwoDatesButton.Size = new System.Drawing.Size(203, 23);
            this.ViewSalesBetweenTwoDatesButton.TabIndex = 0;
            this.ViewSalesBetweenTwoDatesButton.Text = "View Sales Between Two Dates";
            this.ViewSalesBetweenTwoDatesButton.UseVisualStyleBackColor = true;
            this.ViewSalesBetweenTwoDatesButton.Click += new System.EventHandler(this.ViewSalesBetweenTwoDatesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StockOutButton);
            this.groupBox2.Controls.Add(this.StockInButton);
            this.groupBox2.Location = new System.Drawing.Point(384, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Entry";
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(154, 27);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(110, 23);
            this.StockOutButton.TabIndex = 0;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // StockInButton
            // 
            this.StockInButton.Location = new System.Drawing.Point(23, 27);
            this.StockInButton.Name = "StockInButton";
            this.StockInButton.Size = new System.Drawing.Size(110, 23);
            this.StockInButton.TabIndex = 0;
            this.StockInButton.Text = "Stock In";
            this.StockInButton.UseVisualStyleBackColor = true;
            this.StockInButton.Click += new System.EventHandler(this.StockInButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemSetupButton);
            this.groupBox1.Controls.Add(this.CategorySetupButton);
            this.groupBox1.Controls.Add(this.CompanySetupButton);
            this.groupBox1.Location = new System.Drawing.Point(160, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 210);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Input";
            // 
            // ItemSetupButton
            // 
            this.ItemSetupButton.Location = new System.Drawing.Point(29, 153);
            this.ItemSetupButton.Name = "ItemSetupButton";
            this.ItemSetupButton.Size = new System.Drawing.Size(112, 23);
            this.ItemSetupButton.TabIndex = 0;
            this.ItemSetupButton.Text = "Item Setup";
            this.ItemSetupButton.UseVisualStyleBackColor = true;
            this.ItemSetupButton.Click += new System.EventHandler(this.ItemSetupButton_Click);
            // 
            // CategorySetupButton
            // 
            this.CategorySetupButton.Location = new System.Drawing.Point(29, 27);
            this.CategorySetupButton.Name = "CategorySetupButton";
            this.CategorySetupButton.Size = new System.Drawing.Size(110, 23);
            this.CategorySetupButton.TabIndex = 0;
            this.CategorySetupButton.Text = "Category Setup";
            this.CategorySetupButton.UseVisualStyleBackColor = true;
            this.CategorySetupButton.Click += new System.EventHandler(this.CategorySetupButton_Click);
            // 
            // CompanySetupButton
            // 
            this.CompanySetupButton.Location = new System.Drawing.Point(29, 89);
            this.CompanySetupButton.Name = "CompanySetupButton";
            this.CompanySetupButton.Size = new System.Drawing.Size(110, 23);
            this.CompanySetupButton.TabIndex = 0;
            this.CompanySetupButton.Text = "Company Setup";
            this.CompanySetupButton.UseVisualStyleBackColor = true;
            this.CompanySetupButton.Click += new System.EventHandler(this.CompanySetupButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(795, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Admin panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SearchAndViewItemsSummaryButton;
        private System.Windows.Forms.Button ViewSalesBetweenTwoDatesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button StockInButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ItemSetupButton;
        private System.Windows.Forms.Button CategorySetupButton;
        private System.Windows.Forms.Button CompanySetupButton;
    }
}
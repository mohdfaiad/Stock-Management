namespace StockManagementSystem
{
    partial class UserInformation
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
            this.userInformationGridView = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userInformationGridView
            // 
            this.userInformationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userInformationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInformationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno});
            this.userInformationGridView.Enabled = false;
            this.userInformationGridView.Location = new System.Drawing.Point(12, 70);
            this.userInformationGridView.Name = "userInformationGridView";
            this.userInformationGridView.Size = new System.Drawing.Size(607, 263);
            this.userInformationGridView.TabIndex = 0;
            this.userInformationGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.userInformationGridView_RowPostPaint);
            // 
            // Sno
            // 
            this.Sno.HeaderText = "Sno";
            this.Sno.Name = "Sno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Updated System By User";
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userInformationGridView);
            this.Name = "UserInformation";
            this.Text = "UserInformation";
            ((System.ComponentModel.ISupportInitialize)(this.userInformationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userInformationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.Label label3;
    }
}
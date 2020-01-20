namespace Instant
{
    partial class DateTimeForm2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHolidayTomarow = new System.Windows.Forms.Label();
            this.lblTodayMonasebat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTodayMonasebat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHolidayTomarow, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1602, 847);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHolidayTomarow
            // 
            this.lblHolidayTomarow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHolidayTomarow.AutoSize = true;
            this.lblHolidayTomarow.Location = new System.Drawing.Point(3, 0);
            this.lblHolidayTomarow.Name = "lblHolidayTomarow";
            this.lblHolidayTomarow.Size = new System.Drawing.Size(1596, 423);
            this.lblHolidayTomarow.TabIndex = 0;
            this.lblHolidayTomarow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHolidayTomarow.Click += new System.EventHandler(this.lblHolidayTomarow_Click);
            // 
            // lblTodayMonasebat
            // 
            this.lblTodayMonasebat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayMonasebat.AutoSize = true;
            this.lblTodayMonasebat.Location = new System.Drawing.Point(3, 423);
            this.lblTodayMonasebat.Name = "lblTodayMonasebat";
            this.lblTodayMonasebat.Size = new System.Drawing.Size(1596, 424);
            this.lblTodayMonasebat.TabIndex = 2;
            this.lblTodayMonasebat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayMonasebat.Click += new System.EventHandler(this.lblHolidayTomarow_Click);
            // 
            // DateTimeForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 847);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateTimeForm2";
            this.Load += new System.EventHandler(this.DateTimeForm2_Load);
            this.Click += new System.EventHandler(this.DateTimeForm2_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHolidayTomarow;
        private System.Windows.Forms.Label lblTodayMonasebat;
    }
}
namespace WeightlessIT2
{
    partial class Lunchlog
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
            this.headerLunch = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.overviewLunchBox = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLunch
            // 
            this.headerLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headerLunch.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.headerLunch, 2);
            this.headerLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.22F);
            this.headerLunch.Location = new System.Drawing.Point(304, 0);
            this.headerLunch.Name = "headerLunch";
            this.headerLunch.Size = new System.Drawing.Size(187, 226);
            this.headerLunch.TabIndex = 0;
            this.headerLunch.Text = "Add lunch";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerLunch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.overviewLunchBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 453);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // overviewLunchBox
            // 
            this.overviewLunchBox.HideSelection = false;
            this.overviewLunchBox.Location = new System.Drawing.Point(3, 229);
            this.overviewLunchBox.Name = "overviewLunchBox";
            this.overviewLunchBox.Size = new System.Drawing.Size(392, 207);
            this.overviewLunchBox.TabIndex = 1;
            this.overviewLunchBox.UseCompatibleStateImageBehavior = false;
            // 
            // Lunchlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Lunchlog";
            this.Text = "Lunchlog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLunch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView overviewLunchBox;
    }
}
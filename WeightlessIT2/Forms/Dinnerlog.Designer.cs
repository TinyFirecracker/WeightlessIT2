namespace WeightlessIT2
{
    partial class Dinnerlog
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
            this.headerDinner = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.overviewDinnerBox = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerDinner
            // 
            this.headerDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headerDinner.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.headerDinner, 2);
            this.headerDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.22F);
            this.headerDinner.Location = new System.Drawing.Point(240, 0);
            this.headerDinner.Name = "headerDinner";
            this.headerDinner.Size = new System.Drawing.Size(202, 193);
            this.headerDinner.TabIndex = 0;
            this.headerDinner.Text = "Add dinner";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerDinner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.overviewDinnerBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 386);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // overviewDinnerBox
            // 
            this.overviewDinnerBox.HideSelection = false;
            this.overviewDinnerBox.Location = new System.Drawing.Point(3, 196);
            this.overviewDinnerBox.Name = "overviewDinnerBox";
            this.overviewDinnerBox.Size = new System.Drawing.Size(335, 187);
            this.overviewDinnerBox.TabIndex = 1;
            this.overviewDinnerBox.UseCompatibleStateImageBehavior = false;
            // 
            // Dinnerlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dinnerlog";
            this.Text = "Dinnerlog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerDinner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView overviewDinnerBox;
    }
}
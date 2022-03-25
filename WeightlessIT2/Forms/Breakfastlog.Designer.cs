namespace WeightlessIT2
{
    partial class Breakfastlog
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
            this.headerBreakfast = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.overviewMealBox = new System.Windows.Forms.ListView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBreakfast
            // 
            this.headerBreakfast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headerBreakfast.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.headerBreakfast, 2);
            this.headerBreakfast.Cursor = System.Windows.Forms.Cursors.Default;
            this.headerBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.22F);
            this.headerBreakfast.Location = new System.Drawing.Point(266, 0);
            this.headerBreakfast.Name = "headerBreakfast";
            this.headerBreakfast.Size = new System.Drawing.Size(253, 213);
            this.headerBreakfast.TabIndex = 0;
            this.headerBreakfast.Text = "Add breakfast";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.26752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.73248F));
            this.tableLayoutPanel1.Controls.Add(this.headerBreakfast, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.overviewMealBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // overviewMealBox
            // 
            this.overviewMealBox.HideSelection = false;
            this.overviewMealBox.Location = new System.Drawing.Point(3, 216);
            this.overviewMealBox.Name = "overviewMealBox";
            this.overviewMealBox.Size = new System.Drawing.Size(263, 191);
            this.overviewMealBox.TabIndex = 1;
            this.overviewMealBox.UseCompatibleStateImageBehavior = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(272, 216);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(510, 191);
            this.checkedListBox1.TabIndex = 2;
            // 
            // Breakfastlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Breakfastlog";
            this.Text = "Breakfastlog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerBreakfast;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView overviewMealBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
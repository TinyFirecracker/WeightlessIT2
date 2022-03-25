namespace WeightlessIT2
{
    partial class Snacklog
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
            this.headerSnack = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.overviewSnackBox = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerSnack
            // 
            this.headerSnack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headerSnack.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.headerSnack, 2);
            this.headerSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.22F);
            this.headerSnack.Location = new System.Drawing.Point(290, 0);
            this.headerSnack.Name = "headerSnack";
            this.headerSnack.Size = new System.Drawing.Size(214, 223);
            this.headerSnack.TabIndex = 0;
            this.headerSnack.Text = "Add snacks";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerSnack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.overviewSnackBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 446);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // overviewSnackBox
            // 
            this.overviewSnackBox.HideSelection = false;
            this.overviewSnackBox.Location = new System.Drawing.Point(3, 226);
            this.overviewSnackBox.Name = "overviewSnackBox";
            this.overviewSnackBox.Size = new System.Drawing.Size(391, 217);
            this.overviewSnackBox.TabIndex = 1;
            this.overviewSnackBox.UseCompatibleStateImageBehavior = false;
            // 
            // Snacklog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Snacklog";
            this.Text = "Snacklog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerSnack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView overviewSnackBox;
    }
}
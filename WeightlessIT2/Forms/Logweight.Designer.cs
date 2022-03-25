namespace WeightlessIT2
{
    partial class Logweight
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.submitWeight = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.weightTrendsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.22F);
            this.label1.Location = new System.Drawing.Point(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log weight";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.SetColumnSpan(this.numericUpDown1, 2);
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(312, 127);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(178, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // submitWeight
            // 
            this.submitWeight.Location = new System.Drawing.Point(404, 196);
            this.submitWeight.Name = "submitWeight";
            this.submitWeight.Size = new System.Drawing.Size(75, 23);
            this.submitWeight.TabIndex = 2;
            this.submitWeight.Text = "submit";
            this.submitWeight.UseVisualStyleBackColor = true;
            this.submitWeight.Click += new System.EventHandler(this.submitWeight_Click);
            // 
            // backButton2
            // 
            this.backButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backButton2.Location = new System.Drawing.Point(3, 426);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(75, 23);
            this.backButton2.TabIndex = 3;
            this.backButton2.Text = "<--";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // weightTrendsButton
            // 
            this.weightTrendsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.weightTrendsButton.Location = new System.Drawing.Point(724, 426);
            this.weightTrendsButton.Name = "weightTrendsButton";
            this.weightTrendsButton.Size = new System.Drawing.Size(75, 23);
            this.weightTrendsButton.TabIndex = 4;
            this.weightTrendsButton.Text = "history";
            this.weightTrendsButton.UseVisualStyleBackColor = true;
            this.weightTrendsButton.Click += new System.EventHandler(this.weightTrendsButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.weightTrendsButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.backButton2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.submitWeight, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.96396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.03604F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 454);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Logweight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Logweight";
            this.Text = "Logweight";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button submitWeight;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button weightTrendsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
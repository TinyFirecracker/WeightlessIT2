namespace WeightlessIT2
{
    partial class WeightTrends
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
            this.overviewWeightBox = new System.Windows.Forms.ListView();
            this.backButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // overviewWeightBox
            // 
            this.overviewWeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.overviewWeightBox, 2);
            this.overviewWeightBox.HideSelection = false;
            this.overviewWeightBox.Location = new System.Drawing.Point(3, 3);
            this.overviewWeightBox.Name = "overviewWeightBox";
            this.overviewWeightBox.Size = new System.Drawing.Size(787, 399);
            this.overviewWeightBox.TabIndex = 0;
            this.overviewWeightBox.UseCompatibleStateImageBehavior = false;
            // 
            // backButton2
            // 
            this.backButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton2.Location = new System.Drawing.Point(3, 412);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(74, 23);
            this.backButton2.TabIndex = 1;
            this.backButton2.Text = "<--";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.overviewWeightBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backButton2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.46342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.536586F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 443);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // WeightTrends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WeightTrends";
            this.Text = "WeightTrends";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView overviewWeightBox;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
namespace GreenvilleRevenueGUI
{
    partial class GreenvilleRevenueGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.outputThisYearRevenue = new System.Windows.Forms.Label();
            this.thisYearTextBox = new System.Windows.Forms.TextBox();
            this.lastYearTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputMoreContestants = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Greenville Idol contestants this year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Greenville Idol contestants last year";
            // 
            // outputThisYearRevenue
            // 
            this.outputThisYearRevenue.AutoSize = true;
            this.outputThisYearRevenue.Location = new System.Drawing.Point(71, 192);
            this.outputThisYearRevenue.Name = "outputThisYearRevenue";
            this.outputThisYearRevenue.Size = new System.Drawing.Size(35, 13);
            this.outputThisYearRevenue.TabIndex = 2;
            this.outputThisYearRevenue.Text = "label3";
            this.outputThisYearRevenue.Visible = false;
            // 
            // thisYearTextBox
            // 
            this.thisYearTextBox.Location = new System.Drawing.Point(206, 41);
            this.thisYearTextBox.Name = "thisYearTextBox";
            this.thisYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.thisYearTextBox.TabIndex = 3;
            // 
            // lastYearTextBox
            // 
            this.lastYearTextBox.Location = new System.Drawing.Point(206, 79);
            this.lastYearTextBox.Name = "lastYearTextBox";
            this.lastYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastYearTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(151, 136);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputMoreContestants
            // 
            this.outputMoreContestants.AutoSize = true;
            this.outputMoreContestants.Location = new System.Drawing.Point(74, 221);
            this.outputMoreContestants.Name = "outputMoreContestants";
            this.outputMoreContestants.Size = new System.Drawing.Size(35, 13);
            this.outputMoreContestants.TabIndex = 6;
            this.outputMoreContestants.Text = "label3";
            this.outputMoreContestants.Visible = false;
            // 
            // GreenvilleRevenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.outputMoreContestants);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lastYearTextBox);
            this.Controls.Add(this.thisYearTextBox);
            this.Controls.Add(this.outputThisYearRevenue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GreenvilleRevenueGUI";
            this.Text = "Greenville Revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputThisYearRevenue;
        private System.Windows.Forms.TextBox thisYearTextBox;
        private System.Windows.Forms.TextBox lastYearTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputMoreContestants;
    }
}


namespace Pay_and_Bonus
{
    partial class Form1
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
            this.grossPayPromptLabel = new System.Windows.Forms.Label();
            this.bonusPromptLabel = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grossPayPromptLabel
            // 
            this.grossPayPromptLabel.AutoSize = true;
            this.grossPayPromptLabel.Location = new System.Drawing.Point(43, 13);
            this.grossPayPromptLabel.Name = "grossPayPromptLabel";
            this.grossPayPromptLabel.Size = new System.Drawing.Size(81, 12);
            this.grossPayPromptLabel.TabIndex = 0;
            this.grossPayPromptLabel.Text = "Total Gross Pay:";
            // 
            // bonusPromptLabel
            // 
            this.bonusPromptLabel.AutoSize = true;
            this.bonusPromptLabel.Location = new System.Drawing.Point(49, 37);
            this.bonusPromptLabel.Name = "bonusPromptLabel";
            this.bonusPromptLabel.Size = new System.Drawing.Size(79, 12);
            this.bonusPromptLabel.TabIndex = 1;
            this.bonusPromptLabel.Text = "Bonus Amount:";
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(135, 9);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(100, 22);
            this.grossPayTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(135, 33);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(100, 22);
            this.bonusTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(9, 75);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(122, 12);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Retirement Contribution:";
            // 
            // contributionLabel
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Location = new System.Drawing.Point(135, 70);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(100, 21);
            this.contributionLabel.TabIndex = 5;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(47, 102);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 36);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Contribution";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(128, 102);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 152);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.bonusPromptLabel);
            this.Controls.Add(this.grossPayPromptLabel);
            this.Name = "Form1";
            this.Text = "Pay and Bonus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grossPayPromptLabel;
        private System.Windows.Forms.Label bonusPromptLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}


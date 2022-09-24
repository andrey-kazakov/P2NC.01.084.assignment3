namespace assignment3_AndreiKazakov
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
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightInputBox = new System.Windows.Forms.TextBox();
            this.HeightInputBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(21, 13);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(97, 13);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Weight (kilograms):";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(14, 40);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(104, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height (centimeters):";
            // 
            // WeightInputBox
            // 
            this.WeightInputBox.Location = new System.Drawing.Point(124, 13);
            this.WeightInputBox.MaxLength = 3;
            this.WeightInputBox.Name = "WeightInputBox";
            this.WeightInputBox.Size = new System.Drawing.Size(100, 20);
            this.WeightInputBox.TabIndex = 2;
            // 
            // HeightInputBox
            // 
            this.HeightInputBox.Location = new System.Drawing.Point(124, 40);
            this.HeightInputBox.MaxLength = 3;
            this.HeightInputBox.Name = "HeightInputBox";
            this.HeightInputBox.Size = new System.Drawing.Size(100, 20);
            this.HeightInputBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(231, 40);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // OutputBox
            // 
            this.OutputBox.Enabled = false;
            this.OutputBox.Location = new System.Drawing.Point(17, 68);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(289, 39);
            this.OutputBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 122);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.HeightInputBox);
            this.Controls.Add(this.WeightInputBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Name = "Form1";
            this.Text = "Assignment 3 Andrei Kazakov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeightInputBox;
        private System.Windows.Forms.TextBox HeightInputBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


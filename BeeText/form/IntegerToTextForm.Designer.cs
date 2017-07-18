namespace BeeText.form
{
    partial class IntegerToTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntegerToTextForm));
            this.enterTextLabel = new System.Windows.Forms.Label();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.binaryTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterTextLabel
            // 
            this.enterTextLabel.AutoSize = true;
            this.enterTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterTextLabel.Location = new System.Drawing.Point(12, 9);
            this.enterTextLabel.Name = "enterTextLabel";
            this.enterTextLabel.Size = new System.Drawing.Size(110, 20);
            this.enterTextLabel.TabIndex = 4;
            this.enterTextLabel.Text = "Enter Integer:";
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(0, 32);
            this.entryTextBox.Multiline = true;
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(571, 289);
            this.entryTextBox.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.convertButton.Location = new System.Drawing.Point(577, 153);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(141, 51);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(0, 351);
            this.binaryTextBox.Multiline = true;
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.Size = new System.Drawing.Size(718, 296);
            this.binaryTextBox.TabIndex = 7;
            // 
            // binaryTextLabel
            // 
            this.binaryTextLabel.AutoSize = true;
            this.binaryTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.binaryTextLabel.Location = new System.Drawing.Point(12, 328);
            this.binaryTextLabel.Name = "binaryTextLabel";
            this.binaryTextLabel.Size = new System.Drawing.Size(46, 20);
            this.binaryTextLabel.TabIndex = 8;
            this.binaryTextLabel.Text = "Text:";
            // 
            // IntegerToTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 647);
            this.Controls.Add(this.binaryTextLabel);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.enterTextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntegerToTextForm";
            this.Text = "Integer To Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterTextLabel;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.Label binaryTextLabel;
    }
}
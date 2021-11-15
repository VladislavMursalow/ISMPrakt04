
namespace ISMPrakt04
{
    partial class ForFormWithOneParam
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
            this.LabelForN = new System.Windows.Forms.Label();
            this.UpDownForN = new System.Windows.Forms.NumericUpDown();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownForN)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelForN
            // 
            this.LabelForN.AutoSize = true;
            this.LabelForN.Location = new System.Drawing.Point(66, 15);
            this.LabelForN.Name = "LabelForN";
            this.LabelForN.Size = new System.Drawing.Size(20, 20);
            this.LabelForN.TabIndex = 0;
            this.LabelForN.Text = "N";
            // 
            // UpDownForN
            // 
            this.UpDownForN.Location = new System.Drawing.Point(92, 13);
            this.UpDownForN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownForN.Name = "UpDownForN";
            this.UpDownForN.Size = new System.Drawing.Size(150, 27);
            this.UpDownForN.TabIndex = 1;
            this.UpDownForN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Brown;
            this.ResultButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultButton.Location = new System.Drawing.Point(266, 13);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(117, 43);
            this.ResultButton.TabIndex = 2;
            this.ResultButton.Text = "Результат";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(92, 46);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(150, 27);
            this.ResultTextBox.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(13, 49);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(75, 20);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Результат";
            // 
            // ForFormWithOneParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(480, 159);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.UpDownForN);
            this.Controls.Add(this.LabelForN);
            this.Name = "ForFormWithOneParam";
            this.Text = "ForFormWithOneParam";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownForN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelForN;
        private System.Windows.Forms.NumericUpDown UpDownForN;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultLabel;
    }
}
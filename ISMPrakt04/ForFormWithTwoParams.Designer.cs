
namespace ISMPrakt04
{
    partial class ForFormWithTwoParams
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
            this.Alabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.NNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Location = new System.Drawing.Point(12, 21);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(19, 20);
            this.Alabel.TabIndex = 0;
            this.Alabel.Text = "A";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Location = new System.Drawing.Point(12, 58);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(18, 20);
            this.Blabel.TabIndex = 1;
            this.Blabel.Text = "B";
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Cyan;
            this.ResultButton.Location = new System.Drawing.Point(208, 21);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(113, 61);
            this.ResultButton.TabIndex = 2;
            this.ResultButton.Text = "Розрахувати";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ATextBox
            // 
            this.ATextBox.BackColor = System.Drawing.Color.Cyan;
            this.ATextBox.Location = new System.Drawing.Point(37, 18);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(156, 27);
            this.ATextBox.TabIndex = 3;
            this.ATextBox.Text = "1";
            // 
            // BTextBox
            // 
            this.BTextBox.BackColor = System.Drawing.Color.Aqua;
            this.BTextBox.Location = new System.Drawing.Point(37, 55);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(156, 27);
            this.BTextBox.TabIndex = 4;
            this.BTextBox.Text = "2";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.ResultTextBox.Location = new System.Drawing.Point(23, 135);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(284, 48);
            this.ResultTextBox.TabIndex = 5;
            // 
            // NNumericUpDown
            // 
            this.NNumericUpDown.Location = new System.Drawing.Point(37, 88);
            this.NNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NNumericUpDown.Name = "NNumericUpDown";
            this.NNumericUpDown.Size = new System.Drawing.Size(156, 27);
            this.NNumericUpDown.TabIndex = 6;
            this.NNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "N";
            // 
            // ForFormWithTwoParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(398, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NNumericUpDown);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Alabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ForFormWithTwoParams";
            this.Text = "ForForm";
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.NumericUpDown NNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}
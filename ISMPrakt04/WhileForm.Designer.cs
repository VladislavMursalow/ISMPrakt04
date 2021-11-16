
namespace ISMPrakt04
{
    partial class WhileForm
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
            this.NNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NNumericUpDown
            // 
            this.NNumericUpDown.Location = new System.Drawing.Point(48, 12);
            this.NNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NNumericUpDown.Name = "NNumericUpDown";
            this.NNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.NNumericUpDown.TabIndex = 0;
            this.NNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "N =";
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ResultButton.Location = new System.Drawing.Point(216, 12);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(94, 29);
            this.ResultButton.TabIndex = 2;
            this.ResultButton.Text = "Розрахувати";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OutputTextBox.Location = new System.Drawing.Point(12, 60);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(377, 144);
            this.OutputTextBox.TabIndex = 3;
            // 
            // WhileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(531, 233);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NNumericUpDown);
            this.Name = "WhileForm";
            this.Text = "WhileForm";
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

namespace ISMPrakt04
{
    partial class While3TaskForm
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
            this.PnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PnumericUpDown
            // 
            this.PnumericUpDown.DecimalPlaces = 3;
            this.PnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PnumericUpDown.Location = new System.Drawing.Point(74, 12);
            this.PnumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PnumericUpDown.Name = "PnumericUpDown";
            this.PnumericUpDown.Size = new System.Drawing.Size(95, 27);
            this.PnumericUpDown.TabIndex = 0;
            this.PnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "P = ";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.OutputTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputTextBox.Location = new System.Drawing.Point(33, 45);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(202, 139);
            this.OutputTextBox.TabIndex = 3;
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResultButton.Location = new System.Drawing.Point(267, 27);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(111, 41);
            this.ResultButton.TabIndex = 4;
            this.ResultButton.Text = "Розрахувати";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // While3TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(452, 211);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnumericUpDown);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "While3TaskForm";
            this.Text = "While3TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.PnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ResultButton;
    }
}
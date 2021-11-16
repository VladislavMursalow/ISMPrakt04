
namespace ISMPrakt04
{
    partial class DoWhileForm
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.BackColor = System.Drawing.SystemColors.Highlight;
            this.TextInput.Location = new System.Drawing.Point(12, 12);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(373, 183);
            this.TextInput.TabIndex = 0;
            this.TextInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(423, 28);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(50, 20);
            this.LabelOutput.TabIndex = 1;
            this.LabelOutput.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.Location = new System.Drawing.Point(409, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запустити цикл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoWhileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(534, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.TextInput);
            this.Name = "DoWhileForm";
            this.Text = "DoWhileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Button button1;
    }
}
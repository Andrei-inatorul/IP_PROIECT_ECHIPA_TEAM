
namespace Interface
{
    partial class FormSell
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
            buttonSell = new Button();
            labelQuantity = new Label();
            labelBarcode = new Label();
            textBoxBarcode = new TextBox();
            numericUpDownQuantity = new NumericUpDown();
            groupBoxSell = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            groupBoxSell.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSell
            // 
            buttonSell.Location = new Point(592, 428);
            buttonSell.Margin = new Padding(3, 4, 3, 4);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(75, 29);
            buttonSell.TabIndex = 16;
            buttonSell.Text = "Vinde";
            buttonSell.UseVisualStyleBackColor = true;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuantity.Location = new Point(140, 198);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(86, 22);
            labelQuantity.TabIndex = 15;
            labelQuantity.Text = "Cantitate:";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBarcode.Location = new Point(114, 124);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(113, 22);
            labelBarcode.TabIndex = 14;
            labelBarcode.Text = "Cod de bare:";
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(242, 124);
            textBoxBarcode.Margin = new Padding(3, 4, 3, 4);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(249, 27);
            textBoxBarcode.TabIndex = 12;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(242, 199);
            numericUpDownQuantity.Margin = new Padding(3, 2, 3, 2);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(249, 27);
            numericUpDownQuantity.TabIndex = 17;
            // 
            // groupBoxSell
            // 
            groupBoxSell.Controls.Add(labelBarcode);
            groupBoxSell.Controls.Add(numericUpDownQuantity);
            groupBoxSell.Controls.Add(textBoxBarcode);
            groupBoxSell.Controls.Add(labelQuantity);
            groupBoxSell.Location = new Point(30, 44);
            groupBoxSell.Margin = new Padding(3, 2, 3, 2);
            groupBoxSell.Name = "groupBoxSell";
            groupBoxSell.Padding = new Padding(3, 2, 3, 2);
            groupBoxSell.Size = new Size(636, 358);
            groupBoxSell.TabIndex = 18;
            groupBoxSell.TabStop = false;
            groupBoxSell.Text = "VINDE PIESĂ";
            // 
            // FormSell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(712, 470);
            Controls.Add(groupBoxSell);
            Controls.Add(buttonSell);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSell";
            Text = "Vinde piesă:";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            groupBoxSell.ResumeLayout(false);
            groupBoxSell.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.GroupBox groupBoxSell;
    }
}
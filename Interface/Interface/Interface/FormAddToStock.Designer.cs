
namespace Interface
{
    partial class FormAddToStock
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
            buttonAddToStock = new Button();
            groupBoxUpdateStock = new GroupBox();
            numericUpDownQuantity = new NumericUpDown();
            labelQuantity = new Label();
            labelBarcode = new Label();
            textBoxBarcode = new TextBox();
            groupBoxUpdateStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // buttonAddToStock
            // 
            buttonAddToStock.Location = new Point(595, 388);
            buttonAddToStock.Name = "buttonAddToStock";
            buttonAddToStock.Size = new Size(69, 23);
            buttonAddToStock.TabIndex = 11;
            buttonAddToStock.Text = "Adaugă";
            buttonAddToStock.UseVisualStyleBackColor = true;
            buttonAddToStock.Click += buttonAddToStock_Click;
            // 
            // groupBoxUpdateStock
            // 
            groupBoxUpdateStock.Controls.Add(numericUpDownQuantity);
            groupBoxUpdateStock.Controls.Add(labelQuantity);
            groupBoxUpdateStock.Controls.Add(labelBarcode);
            groupBoxUpdateStock.Controls.Add(textBoxBarcode);
            groupBoxUpdateStock.Location = new Point(32, 28);
            groupBoxUpdateStock.Margin = new Padding(3, 2, 3, 2);
            groupBoxUpdateStock.Name = "groupBoxUpdateStock";
            groupBoxUpdateStock.Padding = new Padding(3, 2, 3, 2);
            groupBoxUpdateStock.Size = new Size(633, 336);
            groupBoxUpdateStock.TabIndex = 13;
            groupBoxUpdateStock.TabStop = false;
            groupBoxUpdateStock.Text = "ADAUGĂ LA STOC-UL DE PIESE";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(251, 186);
            numericUpDownQuantity.Margin = new Padding(3, 2, 3, 2);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(218, 23);
            numericUpDownQuantity.TabIndex = 16;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuantity.Location = new Point(164, 184);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(66, 19);
            labelQuantity.TabIndex = 15;
            labelQuantity.Text = "Cantitate:";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBarcode.Location = new Point(141, 129);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(89, 19);
            labelBarcode.TabIndex = 14;
            labelBarcode.Text = "Cod de bare:";
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(251, 129);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(218, 23);
            textBoxBarcode.TabIndex = 13;
            // 
            // FormAddToStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(groupBoxUpdateStock);
            Controls.Add(buttonAddToStock);
            Name = "FormAddToStock";
            Text = "Adaugă în stoc:";
            groupBoxUpdateStock.ResumeLayout(false);
            groupBoxUpdateStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonAddToStock;
        private System.Windows.Forms.GroupBox groupBoxUpdateStock;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
    }
}
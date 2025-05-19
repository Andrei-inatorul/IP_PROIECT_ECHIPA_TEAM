
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
            buttonAddToStock.Location = new Point(680, 517);
            buttonAddToStock.Margin = new Padding(3, 4, 3, 4);
            buttonAddToStock.Name = "buttonAddToStock";
            buttonAddToStock.Size = new Size(79, 31);
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
            groupBoxUpdateStock.Location = new Point(37, 37);
            groupBoxUpdateStock.Name = "groupBoxUpdateStock";
            groupBoxUpdateStock.Size = new Size(723, 448);
            groupBoxUpdateStock.TabIndex = 13;
            groupBoxUpdateStock.TabStop = false;
            groupBoxUpdateStock.Text = "ADAUGĂ LA STOC-UL DE PIESE";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(287, 248);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(249, 27);
            numericUpDownQuantity.TabIndex = 16;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuantity.Location = new Point(187, 245);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(86, 22);
            labelQuantity.TabIndex = 15;
            labelQuantity.Text = "Cantitate:";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBarcode.Location = new Point(161, 172);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(113, 22);
            labelBarcode.TabIndex = 14;
            labelBarcode.Text = "Cod de bare:";
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(287, 172);
            textBoxBarcode.Margin = new Padding(3, 4, 3, 4);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(249, 27);
            textBoxBarcode.TabIndex = 13;
            // 
            // FormAddToStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(800, 563);
            Controls.Add(groupBoxUpdateStock);
            Controls.Add(buttonAddToStock);
            Margin = new Padding(3, 4, 3, 4);
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
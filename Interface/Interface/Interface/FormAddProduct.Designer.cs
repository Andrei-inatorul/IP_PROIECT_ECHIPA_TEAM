
namespace Interface
{
    partial class FormAddProduct
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
            buttonAddProduct = new Button();
            groupBoxAddProduct = new GroupBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownStock = new NumericUpDown();
            textBoxBarcode = new TextBox();
            labelInitialStock = new Label();
            labelPrice = new Label();
            labelBarcode = new Label();
            comboBoxCategory = new ComboBox();
            labelBrand = new Label();
            labelNewPart = new Label();
            comboBoxProduct = new ComboBox();
            groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(649, 510);
            buttonAddProduct.Margin = new Padding(3, 2, 3, 2);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(78, 41);
            buttonAddProduct.TabIndex = 7;
            buttonAddProduct.Text = "Adaugă!";
            buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddProduct
            // 
            groupBoxAddProduct.Controls.Add(numericUpDownPrice);
            groupBoxAddProduct.Controls.Add(numericUpDownStock);
            groupBoxAddProduct.Controls.Add(textBoxBarcode);
            groupBoxAddProduct.Controls.Add(labelInitialStock);
            groupBoxAddProduct.Controls.Add(labelPrice);
            groupBoxAddProduct.Controls.Add(labelBarcode);
            groupBoxAddProduct.Controls.Add(comboBoxCategory);
            groupBoxAddProduct.Controls.Add(labelBrand);
            groupBoxAddProduct.Controls.Add(labelNewPart);
            groupBoxAddProduct.Controls.Add(comboBoxProduct);
            groupBoxAddProduct.Font = new Font("Mongolian Baiti", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxAddProduct.Location = new Point(44, 28);
            groupBoxAddProduct.Margin = new Padding(3, 2, 3, 2);
            groupBoxAddProduct.Name = "groupBoxAddProduct";
            groupBoxAddProduct.Padding = new Padding(3, 2, 3, 2);
            groupBoxAddProduct.Size = new Size(668, 478);
            groupBoxAddProduct.TabIndex = 18;
            groupBoxAddProduct.TabStop = false;
            groupBoxAddProduct.Text = "PIESĂ NOUĂ";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(287, 286);
            numericUpDownPrice.Margin = new Padding(3, 2, 3, 2);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(250, 23);
            numericUpDownPrice.TabIndex = 39;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(287, 352);
            numericUpDownStock.Margin = new Padding(3, 2, 3, 2);
            numericUpDownStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(250, 23);
            numericUpDownStock.TabIndex = 38;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(287, 82);
            textBoxBarcode.Margin = new Padding(3, 2, 3, 2);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(250, 23);
            textBoxBarcode.TabIndex = 37;
            // 
            // labelInitialStock
            // 
            labelInitialStock.AutoSize = true;
            labelInitialStock.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInitialStock.Location = new Point(142, 352);
            labelInitialStock.Name = "labelInitialStock";
            labelInitialStock.Size = new Size(109, 22);
            labelInitialStock.TabIndex = 36;
            labelInitialStock.Text = "Stoc Inițial :";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(173, 286);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(54, 22);
            labelPrice.TabIndex = 35;
            labelPrice.Text = "Preț :";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBarcode.Location = new Point(142, 82);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(123, 22);
            labelBarcode.TabIndex = 34;
            labelBarcode.Text = "Cod de bare : ";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(287, 146);
            comboBoxCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(250, 22);
            comboBoxCategory.TabIndex = 33;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBrand.Location = new Point(164, 142);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(72, 22);
            labelBrand.TabIndex = 32;
            labelBrand.Text = "Marcă :";
            // 
            // labelNewPart
            // 
            labelNewPart.AutoSize = true;
            labelNewPart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewPart.Location = new Point(171, 214);
            labelNewPart.Name = "labelNewPart";
            labelNewPart.Size = new Size(64, 22);
            labelNewPart.TabIndex = 31;
            labelNewPart.Text = "Piesă :";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(287, 212);
            comboBoxProduct.Margin = new Padding(3, 2, 3, 2);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(250, 22);
            comboBoxProduct.TabIndex = 30;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(800, 562);
            Controls.Add(groupBoxAddProduct);
            Controls.Add(buttonAddProduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddProduct";
            Text = "Adaugă piesă nouă  :";
            groupBoxAddProduct.ResumeLayout(false);
            groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelInitialStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelNewPart;
        private System.Windows.Forms.ComboBox comboBoxProduct;
    }
}
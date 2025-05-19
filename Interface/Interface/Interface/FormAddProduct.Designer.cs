
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
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelInitialStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelNewPart = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(649, 408);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(78, 33);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "Adaugă!";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            //this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.numericUpDownPrice);
            this.groupBoxAddProduct.Controls.Add(this.numericUpDownStock);
            this.groupBoxAddProduct.Controls.Add(this.textBoxBarcode);
            this.groupBoxAddProduct.Controls.Add(this.labelInitialStock);
            this.groupBoxAddProduct.Controls.Add(this.labelPrice);
            this.groupBoxAddProduct.Controls.Add(this.labelBarcode);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddProduct.Controls.Add(this.labelBrand);
            this.groupBoxAddProduct.Controls.Add(this.labelNewPart);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxProduct);
            this.groupBoxAddProduct.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddProduct.Location = new System.Drawing.Point(44, 22);
            this.groupBoxAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddProduct.Size = new System.Drawing.Size(668, 382);
            this.groupBoxAddProduct.TabIndex = 18;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "PIESĂ NOUĂ";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(287, 229);
            this.numericUpDownPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(250, 23);
            this.numericUpDownPrice.TabIndex = 39;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(287, 282);
            this.numericUpDownStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(250, 23);
            this.numericUpDownStock.TabIndex = 38;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(287, 66);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(250, 23);
            this.textBoxBarcode.TabIndex = 37;
            // 
            // labelInitialStock
            // 
            this.labelInitialStock.AutoSize = true;
            this.labelInitialStock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitialStock.Location = new System.Drawing.Point(142, 282);
            this.labelInitialStock.Name = "labelInitialStock";
            this.labelInitialStock.Size = new System.Drawing.Size(109, 22);
            this.labelInitialStock.TabIndex = 36;
            this.labelInitialStock.Text = "Stoc Inițial :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(173, 229);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 22);
            this.labelPrice.TabIndex = 35;
            this.labelPrice.Text = "Preț :";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(142, 66);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(123, 22);
            this.labelBarcode.TabIndex = 34;
            this.labelBarcode.Text = "Cod de bare : ";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(287, 117);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(250, 22);
            this.comboBoxCategory.TabIndex = 33;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(164, 114);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(72, 22);
            this.labelBrand.TabIndex = 32;
            this.labelBrand.Text = "Marcă :";
            // 
            // labelNewPart
            // 
            this.labelNewPart.AutoSize = true;
            this.labelNewPart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPart.Location = new System.Drawing.Point(171, 171);
            this.labelNewPart.Name = "labelNewPart";
            this.labelNewPart.Size = new System.Drawing.Size(64, 22);
            this.labelNewPart.TabIndex = 31;
            this.labelNewPart.Text = "Piesă :";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(287, 170);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(250, 22);
            this.comboBoxProduct.TabIndex = 30;
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddProduct";
            this.Text = "Adaugă piesă nouă  :";
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            this.ResumeLayout(false);

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
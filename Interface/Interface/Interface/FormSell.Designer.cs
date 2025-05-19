
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
            this.buttonSell = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSell = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBoxSell.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(592, 342);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(75, 23);
            this.buttonSell.TabIndex = 16;
            this.buttonSell.Text = "Vinde";
            this.buttonSell.UseVisualStyleBackColor = true;
            //this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(140, 158);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(86, 22);
            this.labelQuantity.TabIndex = 15;
            this.labelQuantity.Text = "Cantitate:";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(114, 99);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(113, 22);
            this.labelBarcode.TabIndex = 14;
            this.labelBarcode.Text = "Cod de bare:";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(242, 99);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(249, 22);
            this.textBoxBarcode.TabIndex = 12;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(242, 159);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(249, 22);
            this.numericUpDownQuantity.TabIndex = 17;
            // 
            // groupBoxSell
            // 
            this.groupBoxSell.Controls.Add(this.labelBarcode);
            this.groupBoxSell.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxSell.Controls.Add(this.textBoxBarcode);
            this.groupBoxSell.Controls.Add(this.labelQuantity);
            this.groupBoxSell.Location = new System.Drawing.Point(30, 35);
            this.groupBoxSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSell.Name = "groupBoxSell";
            this.groupBoxSell.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSell.Size = new System.Drawing.Size(636, 286);
            this.groupBoxSell.TabIndex = 18;
            this.groupBoxSell.TabStop = false;
            this.groupBoxSell.Text = "VINDE PIESĂ";
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 376);
            this.Controls.Add(this.groupBoxSell);
            this.Controls.Add(this.buttonSell);
            this.Name = "FormSell";
            this.Text = "Vinde piesă:";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBoxSell.ResumeLayout(false);
            this.groupBoxSell.PerformLayout();
            this.ResumeLayout(false);

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
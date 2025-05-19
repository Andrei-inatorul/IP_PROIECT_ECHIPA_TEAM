
namespace Interface
{
    partial class FormUpdatePrice
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
            this.groupBoxUpdatePrice = new System.Windows.Forms.GroupBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.numericUpDownNewPrice = new System.Windows.Forms.NumericUpDown();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.buttonUpdatePrice = new System.Windows.Forms.Button();
            this.groupBoxUpdatePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUpdatePrice
            // 
            this.groupBoxUpdatePrice.Controls.Add(this.labelBarcode);
            this.groupBoxUpdatePrice.Controls.Add(this.labelNewPrice);
            this.groupBoxUpdatePrice.Controls.Add(this.numericUpDownNewPrice);
            this.groupBoxUpdatePrice.Controls.Add(this.textBoxBarcode);
            this.groupBoxUpdatePrice.Location = new System.Drawing.Point(57, 10);
            this.groupBoxUpdatePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUpdatePrice.Name = "groupBoxUpdatePrice";
            this.groupBoxUpdatePrice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUpdatePrice.Size = new System.Drawing.Size(612, 293);
            this.groupBoxUpdatePrice.TabIndex = 4;
            this.groupBoxUpdatePrice.TabStop = false;
            this.groupBoxUpdatePrice.Text = "ACTUALIZEZĂ PREȚUL PIESEI";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(107, 104);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(118, 22);
            this.labelBarcode.TabIndex = 7;
            this.labelBarcode.Text = "Cod de bare :";
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPrice.Location = new System.Drawing.Point(122, 167);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(87, 22);
            this.labelNewPrice.TabIndex = 6;
            this.labelNewPrice.Text = "Preț nou :";
            // 
            // numericUpDownNewPrice
            // 
            this.numericUpDownNewPrice.DecimalPlaces = 2;
            this.numericUpDownNewPrice.Location = new System.Drawing.Point(251, 169);
            this.numericUpDownNewPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownNewPrice.Name = "numericUpDownNewPrice";
            this.numericUpDownNewPrice.Size = new System.Drawing.Size(254, 22);
            this.numericUpDownNewPrice.TabIndex = 5;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(251, 103);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(255, 22);
            this.textBoxBarcode.TabIndex = 4;
            // 
            // buttonUpdatePrice
            // 
            this.buttonUpdatePrice.Location = new System.Drawing.Point(562, 319);
            this.buttonUpdatePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdatePrice.Name = "buttonUpdatePrice";
            this.buttonUpdatePrice.Size = new System.Drawing.Size(106, 31);
            this.buttonUpdatePrice.TabIndex = 5;
            this.buttonUpdatePrice.Text = "Actualizează";
            this.buttonUpdatePrice.UseVisualStyleBackColor = true;
            //this.buttonUpdatePrice.Click += new System.EventHandler(this.buttonUpdatePrice_Click);
            // 
            // FormUpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.buttonUpdatePrice);
            this.Controls.Add(this.groupBoxUpdatePrice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUpdatePrice";
            this.Text = "Actualizează prețul";
            this.groupBoxUpdatePrice.ResumeLayout(false);
            this.groupBoxUpdatePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUpdatePrice;
        private System.Windows.Forms.Button buttonUpdatePrice;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownNewPrice;
        private System.Windows.Forms.TextBox textBoxBarcode;
    }
}
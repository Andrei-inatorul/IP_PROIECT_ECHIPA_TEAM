
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
            groupBoxUpdatePrice = new GroupBox();
            labelBarcode = new Label();
            labelNewPrice = new Label();
            numericUpDownNewPrice = new NumericUpDown();
            textBoxBarcode = new TextBox();
            buttonUpdatePrice = new Button();
            groupBoxUpdatePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUpdatePrice
            // 
            groupBoxUpdatePrice.Controls.Add(labelBarcode);
            groupBoxUpdatePrice.Controls.Add(labelNewPrice);
            groupBoxUpdatePrice.Controls.Add(numericUpDownNewPrice);
            groupBoxUpdatePrice.Controls.Add(textBoxBarcode);
            groupBoxUpdatePrice.Location = new Point(57, 12);
            groupBoxUpdatePrice.Margin = new Padding(3, 2, 3, 2);
            groupBoxUpdatePrice.Name = "groupBoxUpdatePrice";
            groupBoxUpdatePrice.Padding = new Padding(3, 2, 3, 2);
            groupBoxUpdatePrice.Size = new Size(612, 366);
            groupBoxUpdatePrice.TabIndex = 4;
            groupBoxUpdatePrice.TabStop = false;
            groupBoxUpdatePrice.Text = "ACTUALIZEZĂ PREȚUL PIESEI";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBarcode.Location = new Point(107, 130);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(118, 22);
            labelBarcode.TabIndex = 7;
            labelBarcode.Text = "Cod de bare :";
            // 
            // labelNewPrice
            // 
            labelNewPrice.AutoSize = true;
            labelNewPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewPrice.Location = new Point(122, 209);
            labelNewPrice.Name = "labelNewPrice";
            labelNewPrice.Size = new Size(87, 22);
            labelNewPrice.TabIndex = 6;
            labelNewPrice.Text = "Preț nou :";
            // 
            // numericUpDownNewPrice
            // 
            numericUpDownNewPrice.DecimalPlaces = 2;
            numericUpDownNewPrice.Location = new Point(251, 211);
            numericUpDownNewPrice.Margin = new Padding(3, 2, 3, 2);
            numericUpDownNewPrice.Name = "numericUpDownNewPrice";
            numericUpDownNewPrice.Size = new Size(254, 27);
            numericUpDownNewPrice.TabIndex = 5;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(251, 129);
            textBoxBarcode.Margin = new Padding(3, 2, 3, 2);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(255, 27);
            textBoxBarcode.TabIndex = 4;
            // 
            // buttonUpdatePrice
            // 
            buttonUpdatePrice.Location = new Point(562, 399);
            buttonUpdatePrice.Margin = new Padding(3, 2, 3, 2);
            buttonUpdatePrice.Name = "buttonUpdatePrice";
            buttonUpdatePrice.Size = new Size(106, 39);
            buttonUpdatePrice.TabIndex = 5;
            buttonUpdatePrice.Text = "Actualizează";
            buttonUpdatePrice.UseVisualStyleBackColor = true;
            // 
            // FormUpdatePrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(711, 450);
            Controls.Add(buttonUpdatePrice);
            Controls.Add(groupBoxUpdatePrice);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUpdatePrice";
            Text = "Actualizează prețul";
            groupBoxUpdatePrice.ResumeLayout(false);
            groupBoxUpdatePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewPrice).EndInit();
            ResumeLayout(false);

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
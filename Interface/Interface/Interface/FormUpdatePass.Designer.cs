
namespace Interface
{
    partial class FormUpdatePass
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
            textBoxUser = new TextBox();
            textBoxOldPass = new TextBox();
            textBoxNewPass = new TextBox();
            labelUsername = new Label();
            labelOldPass = new Label();
            labelNewPass = new Label();
            buttonUpdate = new Button();
            groupBoxUpdatePass = new GroupBox();
            groupBoxUpdatePass.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(207, 122);
            textBoxUser.Margin = new Padding(3, 4, 3, 4);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(255, 27);
            textBoxUser.TabIndex = 0;
            // 
            // textBoxOldPass
            // 
            textBoxOldPass.Location = new Point(207, 172);
            textBoxOldPass.Margin = new Padding(3, 4, 3, 4);
            textBoxOldPass.Name = "textBoxOldPass";
            textBoxOldPass.Size = new Size(255, 27);
            textBoxOldPass.TabIndex = 1;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(207, 228);
            textBoxNewPass.Margin = new Padding(3, 4, 3, 4);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(255, 27);
            textBoxNewPass.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(60, 121);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(138, 22);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Nume utilizator:";
            // 
            // labelOldPass
            // 
            labelOldPass.AutoSize = true;
            labelOldPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOldPass.Location = new Point(64, 172);
            labelOldPass.Name = "labelOldPass";
            labelOldPass.Size = new Size(119, 22);
            labelOldPass.TabIndex = 4;
            labelOldPass.Text = "Parola veche:";
            // 
            // labelNewPass
            // 
            labelNewPass.AutoSize = true;
            labelNewPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewPass.Location = new Point(73, 226);
            labelNewPass.Name = "labelNewPass";
            labelNewPass.Size = new Size(110, 22);
            labelNewPass.TabIndex = 5;
            labelNewPass.Text = "Parola nouă:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(476, 444);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(101, 36);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Actualizează!";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBoxUpdatePass
            // 
            groupBoxUpdatePass.Controls.Add(labelUsername);
            groupBoxUpdatePass.Controls.Add(textBoxUser);
            groupBoxUpdatePass.Controls.Add(labelNewPass);
            groupBoxUpdatePass.Controls.Add(textBoxOldPass);
            groupBoxUpdatePass.Controls.Add(labelOldPass);
            groupBoxUpdatePass.Controls.Add(textBoxNewPass);
            groupBoxUpdatePass.Location = new Point(29, 35);
            groupBoxUpdatePass.Margin = new Padding(3, 2, 3, 2);
            groupBoxUpdatePass.Name = "groupBoxUpdatePass";
            groupBoxUpdatePass.Padding = new Padding(3, 2, 3, 2);
            groupBoxUpdatePass.Size = new Size(548, 382);
            groupBoxUpdatePass.TabIndex = 7;
            groupBoxUpdatePass.TabStop = false;
            groupBoxUpdatePass.Text = "ACTUALIZEAZĂ PAROLA";
            // 
            // FormUpdatePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(620, 499);
            Controls.Add(groupBoxUpdatePass);
            Controls.Add(buttonUpdate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUpdatePass";
            Text = "Actualizează parola:";
            groupBoxUpdatePass.ResumeLayout(false);
            groupBoxUpdatePass.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxUpdatePass;
    }
}
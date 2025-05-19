
namespace Interface
{
    partial class FormAddUser
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
            buttonAddNewUser = new Button();
            groupBoxAddUser = new GroupBox();
            labelNewUserOccupation = new Label();
            labelNewUserPass = new Label();
            labelNewUserName = new Label();
            textBoxNewUserOccupation = new TextBox();
            textBoxNewUserPassword = new TextBox();
            textBoxNewUserName = new TextBox();
            groupBoxAddUser.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddNewUser
            // 
            buttonAddNewUser.Location = new Point(660, 414);
            buttonAddNewUser.Margin = new Padding(3, 2, 3, 2);
            buttonAddNewUser.Name = "buttonAddNewUser";
            buttonAddNewUser.Size = new Size(106, 38);
            buttonAddNewUser.TabIndex = 6;
            buttonAddNewUser.Text = "Adaugă";
            buttonAddNewUser.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddUser
            // 
            groupBoxAddUser.Controls.Add(labelNewUserOccupation);
            groupBoxAddUser.Controls.Add(labelNewUserPass);
            groupBoxAddUser.Controls.Add(labelNewUserName);
            groupBoxAddUser.Controls.Add(textBoxNewUserOccupation);
            groupBoxAddUser.Controls.Add(textBoxNewUserPassword);
            groupBoxAddUser.Controls.Add(textBoxNewUserName);
            groupBoxAddUser.Location = new Point(48, 32);
            groupBoxAddUser.Margin = new Padding(3, 2, 3, 2);
            groupBoxAddUser.Name = "groupBoxAddUser";
            groupBoxAddUser.Padding = new Padding(3, 2, 3, 2);
            groupBoxAddUser.Size = new Size(718, 372);
            groupBoxAddUser.TabIndex = 7;
            groupBoxAddUser.TabStop = false;
            groupBoxAddUser.Text = "ADAUGĂ UTILIZATOR NOU";
            // 
            // labelNewUserOccupation
            // 
            labelNewUserOccupation.AutoSize = true;
            labelNewUserOccupation.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewUserOccupation.Location = new Point(155, 232);
            labelNewUserOccupation.Name = "labelNewUserOccupation";
            labelNewUserOccupation.Size = new Size(122, 22);
            labelNewUserOccupation.TabIndex = 11;
            labelNewUserOccupation.Text = "Codul rolului:";
            // 
            // labelNewUserPass
            // 
            labelNewUserPass.AutoSize = true;
            labelNewUserPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewUserPass.Location = new Point(179, 172);
            labelNewUserPass.Name = "labelNewUserPass";
            labelNewUserPass.Size = new Size(68, 22);
            labelNewUserPass.TabIndex = 10;
            labelNewUserPass.Text = "Parolă:";
            // 
            // labelNewUserName
            // 
            labelNewUserName.AutoSize = true;
            labelNewUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewUserName.Location = new Point(136, 114);
            labelNewUserName.Name = "labelNewUserName";
            labelNewUserName.Size = new Size(162, 22);
            labelNewUserName.TabIndex = 9;
            labelNewUserName.Text = "Nume de utilizator:";
            // 
            // textBoxNewUserOccupation
            // 
            textBoxNewUserOccupation.Location = new Point(320, 232);
            textBoxNewUserOccupation.Margin = new Padding(3, 2, 3, 2);
            textBoxNewUserOccupation.Name = "textBoxNewUserOccupation";
            textBoxNewUserOccupation.Size = new Size(246, 27);
            textBoxNewUserOccupation.TabIndex = 8;
            // 
            // textBoxNewUserPassword
            // 
            textBoxNewUserPassword.Location = new Point(320, 172);
            textBoxNewUserPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxNewUserPassword.Name = "textBoxNewUserPassword";
            textBoxNewUserPassword.Size = new Size(246, 27);
            textBoxNewUserPassword.TabIndex = 7;
            // 
            // textBoxNewUserName
            // 
            textBoxNewUserName.Location = new Point(320, 112);
            textBoxNewUserName.Margin = new Padding(3, 2, 3, 2);
            textBoxNewUserName.Name = "textBoxNewUserName";
            textBoxNewUserName.Size = new Size(246, 27);
            textBoxNewUserName.TabIndex = 6;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(800, 465);
            Controls.Add(groupBoxAddUser);
            Controls.Add(buttonAddNewUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddUser";
            Text = "Adaugă utilizator nou:";
            groupBoxAddUser.ResumeLayout(false);
            groupBoxAddUser.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Label labelNewUserOccupation;
        private System.Windows.Forms.Label labelNewUserPass;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.TextBox textBoxNewUserOccupation;
        private System.Windows.Forms.TextBox textBoxNewUserPassword;
        private System.Windows.Forms.TextBox textBoxNewUserName;
    }
}
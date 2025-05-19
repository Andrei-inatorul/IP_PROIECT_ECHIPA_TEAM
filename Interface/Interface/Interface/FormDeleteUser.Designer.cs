
namespace Interface
{
    partial class FormDeleteUser
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
            buttonDelete = new Button();
            groupBoxDeleteUser = new GroupBox();
            labelNewUserName = new Label();
            textBoxDeletedUsername = new TextBox();
            groupBoxDeleteUser.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(542, 322);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 32);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Șterge";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeleteUser
            // 
            groupBoxDeleteUser.Controls.Add(labelNewUserName);
            groupBoxDeleteUser.Controls.Add(textBoxDeletedUsername);
            groupBoxDeleteUser.Location = new Point(31, 32);
            groupBoxDeleteUser.Margin = new Padding(3, 2, 3, 2);
            groupBoxDeleteUser.Name = "groupBoxDeleteUser";
            groupBoxDeleteUser.Padding = new Padding(3, 2, 3, 2);
            groupBoxDeleteUser.Size = new Size(582, 268);
            groupBoxDeleteUser.TabIndex = 6;
            groupBoxDeleteUser.TabStop = false;
            groupBoxDeleteUser.Text = "ȘTERGE UTILIZATOR";
            // 
            // labelNewUserName
            // 
            labelNewUserName.AutoSize = true;
            labelNewUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewUserName.Location = new Point(58, 121);
            labelNewUserName.Name = "labelNewUserName";
            labelNewUserName.Size = new Size(162, 22);
            labelNewUserName.TabIndex = 6;
            labelNewUserName.Text = "Nume de utilizator:";
            // 
            // textBoxDeletedUsername
            // 
            textBoxDeletedUsername.Location = new Point(226, 121);
            textBoxDeletedUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxDeletedUsername.Name = "textBoxDeletedUsername";
            textBoxDeletedUsername.Size = new Size(234, 27);
            textBoxDeletedUsername.TabIndex = 5;
            // 
            // FormDeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(650, 368);
            Controls.Add(groupBoxDeleteUser);
            Controls.Add(buttonDelete);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDeleteUser";
            Text = "Șterge utilizator:";
            groupBoxDeleteUser.ResumeLayout(false);
            groupBoxDeleteUser.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxDeleteUser;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.TextBox textBoxDeletedUsername;
    }
}
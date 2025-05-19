
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxDeleteUser = new System.Windows.Forms.GroupBox();
            this.labelNewUserName = new System.Windows.Forms.Label();
            this.textBoxDeletedUsername = new System.Windows.Forms.TextBox();
            this.groupBoxDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(542, 258);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 26);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Șterge";
            this.buttonDelete.UseVisualStyleBackColor = true;
            //this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxDeleteUser
            // 
            this.groupBoxDeleteUser.Controls.Add(this.labelNewUserName);
            this.groupBoxDeleteUser.Controls.Add(this.textBoxDeletedUsername);
            this.groupBoxDeleteUser.Location = new System.Drawing.Point(31, 26);
            this.groupBoxDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDeleteUser.Name = "groupBoxDeleteUser";
            this.groupBoxDeleteUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDeleteUser.Size = new System.Drawing.Size(582, 214);
            this.groupBoxDeleteUser.TabIndex = 6;
            this.groupBoxDeleteUser.TabStop = false;
            this.groupBoxDeleteUser.Text = "ȘTERGE UTILIZATOR";
            // 
            // labelNewUserName
            // 
            this.labelNewUserName.AutoSize = true;
            this.labelNewUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUserName.Location = new System.Drawing.Point(58, 97);
            this.labelNewUserName.Name = "labelNewUserName";
            this.labelNewUserName.Size = new System.Drawing.Size(162, 22);
            this.labelNewUserName.TabIndex = 6;
            this.labelNewUserName.Text = "Nume de utilizator:";
            // 
            // textBoxDeletedUsername
            // 
            this.textBoxDeletedUsername.Location = new System.Drawing.Point(226, 97);
            this.textBoxDeletedUsername.Name = "textBoxDeletedUsername";
            this.textBoxDeletedUsername.Size = new System.Drawing.Size(234, 22);
            this.textBoxDeletedUsername.TabIndex = 5;
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 294);
            this.Controls.Add(this.groupBoxDeleteUser);
            this.Controls.Add(this.buttonDelete);
            this.Name = "FormDeleteUser";
            this.Text = "Șterge utilizator:";
            this.groupBoxDeleteUser.ResumeLayout(false);
            this.groupBoxDeleteUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxDeleteUser;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.TextBox textBoxDeletedUsername;
    }
}
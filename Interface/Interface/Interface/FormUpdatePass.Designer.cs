
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxUpdatePass = new System.Windows.Forms.GroupBox();
            this.groupBoxUpdatePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(207, 98);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(255, 22);
            this.textBoxUser.TabIndex = 0;
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(207, 138);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(255, 22);
            this.textBoxOldPass.TabIndex = 1;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(207, 182);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(255, 22);
            this.textBoxNewPass.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(60, 97);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(138, 22);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Nume utilizator:";
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPass.Location = new System.Drawing.Point(64, 138);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(119, 22);
            this.labelOldPass.TabIndex = 4;
            this.labelOldPass.Text = "Parola veche:";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.Location = new System.Drawing.Point(73, 181);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(110, 22);
            this.labelNewPass.TabIndex = 5;
            this.labelNewPass.Text = "Parola nouă:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(476, 355);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(101, 29);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Actualizează!";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            //this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBoxUpdatePass
            // 
            this.groupBoxUpdatePass.Controls.Add(this.labelUsername);
            this.groupBoxUpdatePass.Controls.Add(this.textBoxUser);
            this.groupBoxUpdatePass.Controls.Add(this.labelNewPass);
            this.groupBoxUpdatePass.Controls.Add(this.textBoxOldPass);
            this.groupBoxUpdatePass.Controls.Add(this.labelOldPass);
            this.groupBoxUpdatePass.Controls.Add(this.textBoxNewPass);
            this.groupBoxUpdatePass.Location = new System.Drawing.Point(29, 28);
            this.groupBoxUpdatePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUpdatePass.Name = "groupBoxUpdatePass";
            this.groupBoxUpdatePass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUpdatePass.Size = new System.Drawing.Size(548, 306);
            this.groupBoxUpdatePass.TabIndex = 7;
            this.groupBoxUpdatePass.TabStop = false;
            this.groupBoxUpdatePass.Text = "ACTUALIZEAZĂ PAROLA";
            // 
            // FormUpdatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 399);
            this.Controls.Add(this.groupBoxUpdatePass);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "FormUpdatePass";
            this.Text = "Actualizează parola:";
            this.groupBoxUpdatePass.ResumeLayout(false);
            this.groupBoxUpdatePass.PerformLayout();
            this.ResumeLayout(false);

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
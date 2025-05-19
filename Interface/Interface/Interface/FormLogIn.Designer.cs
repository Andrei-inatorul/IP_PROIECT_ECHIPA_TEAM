namespace Interface
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 144);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Autentificare";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 194);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Nume de utilizator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 260);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Parola";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(377, 191);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(239, 23);
            textBoxUser.TabIndex = 3;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(377, 257);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(239, 23);
            textBoxPass.TabIndex = 4;
            // 
            // login
            // 
            login.Location = new Point(330, 310);
            login.Name = "login";
            login.Size = new Size(75, 23);
            login.TabIndex = 5;
            login.Text = "logare";
            login.UseVisualStyleBackColor = true;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 404);
            Controls.Add(login);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogIn";
            Text = "Autentificare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private Button login;
    }
}

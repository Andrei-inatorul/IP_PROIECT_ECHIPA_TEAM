using System;
using System.Windows.Forms;
using AutoPartsManagementDLL;

namespace Interface
{
    public partial class FormLogIn : TemplateActionForm
    {
        private ProxyActionManager _util;

        public FormLogIn()
        {
            InitializeComponent();
            _util = ProxyActionManager.GetInstance();

            this.AcceptButton = login;
            textBoxPass.PasswordChar = '*';

            ConnectButton(login); 
        }

        protected override bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(textBoxUser.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPass.Text);
        }

        protected override void ExecuteAction()
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            if (_util.Login(username, password))
            {
                Form pagina2 = new FormMenu();
                pagina2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizator sau parolă incorectă!", "Eroare");
                textBoxUser.Clear();
                textBoxPass.Clear();
            }
        }

        private void FormLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

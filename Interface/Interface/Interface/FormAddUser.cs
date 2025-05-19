using System;
using System.Windows.Forms;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using AutoPartsManagementDLL;
using System.IO;

namespace Interface
{
    public partial class FormAddUser : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormAddUser()
        {
            InitializeComponent();
            ConnectButton(buttonAddNewUser);
        }

        protected override bool ValidateInput()
        {
            string username = textBoxNewUserName.Text;
            string password = textBoxNewUserPassword.Text;
            string roleText = textBoxNewUserOccupation.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username și/sau parola nu pot să fie nedefinite.");
                return false;
            }

            int role;
            if (!int.TryParse(roleText, out role) || (role != 0 && role != 1))
            {
                MessageBox.Show("Ocupația trebuie să fie 0 (Stock Manager) sau 1 (Sales Clerk).");
                return false;
            }

            return true;
        }

        protected override void ExecuteAction()
        {
            string username = textBoxNewUserName.Text;
            string password = textBoxNewUserPassword.Text;
            int role = Convert.ToInt32(textBoxNewUserOccupation.Text);

            _util.AddUser(username, password, role);
            MessageBox.Show("Utilizator adaugat cu succes, cu username: '" + username + "'");
            this.Close();
        }
    }
}

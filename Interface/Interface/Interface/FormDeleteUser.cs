using System;
using System.Windows.Forms;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using AutoPartsManagementDLL;

namespace Interface
{
    public partial class FormDeleteUser : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormDeleteUser()
        {
            InitializeComponent();
            ConnectButton(buttonDelete); 
        }

        protected override bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxDeletedUsername.Text))
            {
                MessageBox.Show("Username is required.");
                return false;
            }
            return true;
        }

        protected override void ExecuteAction()
        {
            string username = textBoxDeletedUsername.Text;
            _util.DeleteUser(username);
            MessageBox.Show("Successfully deleted user '" + username + "'");
            this.Close();
        }
    }
}

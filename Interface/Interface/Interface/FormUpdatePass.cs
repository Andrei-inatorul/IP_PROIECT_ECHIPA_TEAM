using System;
using System.Windows.Forms;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using AutoPartsManagementDLL;
using System.IO;

namespace Interface
{
    public partial class FormUpdatePass : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormUpdatePass()
        {
            InitializeComponent();
            ConnectButton(buttonUpdate); 
        }

        protected override bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxOldPass.Text) ||
                string.IsNullOrWhiteSpace(textBoxNewPass.Text))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii.");
                return false;
            }

            return true;
        }

        protected override void ExecuteAction()
        {
            string username = textBoxUser.Text;
            string oldPass = textBoxOldPass.Text;
            string newPass = textBoxNewPass.Text;

            _util.UpdateUserPassword(username, oldPass, newPass);
            MessageBox.Show("Parola a fost actualizată cu succes!");
            this.Close();
        }
    }
}

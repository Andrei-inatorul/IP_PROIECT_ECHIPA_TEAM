using System;
using System.Windows.Forms;

namespace Interface
{
    public class TemplateActionForm : Form
    {
        protected Button buttonConfirm;

        // No constructor code to create a button!
        protected void ConnectButton(Button confirmButton)
        {
            buttonConfirm = confirmButton;
            buttonConfirm.Click += OnConfirmClick;
        }

        private void OnConfirmClick(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Date invalide.");
                return;
            }

            try
            {
                ExecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        protected virtual bool ValidateInput() { return true; }
        protected virtual void ExecuteAction() { }
    }
}

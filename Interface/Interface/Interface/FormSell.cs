using System;
using System.Windows.Forms;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using AutoPartsManagementDLL;

namespace Interface
{
    public partial class FormSell : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormSell()
        {
            InitializeComponent();
            ConnectButton(buttonSell); 
        }

        protected override bool ValidateInput()
        {
            int id;
            if (!int.TryParse(textBoxBarcode.Text, out id))
            {
                MessageBox.Show("Cod de bare invalid.");
                return false;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Cantitatea trebuie sa fie mai mare decât 1.");
                return false;
            }

            return true;
        }

        protected override void ExecuteAction()
        {
            int partId = Convert.ToInt32(textBoxBarcode.Text);
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            _util.SellPart(partId, quantity);
            MessageBox.Show("Parte vândută cu succes.");
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using AutoPartsManagementDLL;

namespace Interface
{
    public partial class FormAddToStock : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormAddToStock()
        {
            InitializeComponent();
            ConnectButton(buttonAddToStock); 
        }

        protected override bool ValidateInput()
        {
            int id;
            if (!int.TryParse(textBoxBarcode.Text, out id))
            {
                MessageBox.Show("ID invalid format.");
                return false;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie mai mare decât 1.");
                return false;
            }

            return true;
        }

        protected override void ExecuteAction()
        {
            int partId = Convert.ToInt32(textBoxBarcode.Text);
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            _util.AddToStock(partId, quantity);
            MessageBox.Show("Stoc actualizat cu succes.");
            this.Close();
        }

        private void buttonAddToStock_Click(object sender, EventArgs e)
        {

        }
    }
}

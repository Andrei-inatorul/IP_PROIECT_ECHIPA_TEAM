using System;
using System.Windows.Forms;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using AutoPartsManagementDLL;
using System.IO;

namespace Interface
{
    public partial class FormUpdatePrice : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormUpdatePrice()
        {
            InitializeComponent();
            ConnectButton(buttonUpdatePrice); // asigură-te că în Designer are acest nume
        }

        protected override bool ValidateInput()
        {
            int partId;
            if (!int.TryParse(textBoxBarcode.Text, out partId))
            {
                MessageBox.Show("Codul piesei trebuie să fie un număr valid.");
                return false;
            }

            if (numericUpDownNewPrice.Value <= 0)
            {
                MessageBox.Show("Prețul trebuie să fie mai mare decât 0.");
                return false;
            }

            return true;
        }

        protected override void ExecuteAction()
        {
            int partId = Convert.ToInt32(textBoxBarcode.Text);
            double price = Convert.ToDouble(numericUpDownNewPrice.Value);

            _util.UpdatePartPrice(partId, price);
            MessageBox.Show("Preț actualizat cu succes.");
            this.Close();
        }
    }
}

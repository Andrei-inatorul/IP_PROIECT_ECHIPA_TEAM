using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Items.DataBaseObjects;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using AutoPartsManagementDLL;

namespace Interface
{
    public partial class FormAddProduct : TemplateActionForm
    {
        private ValidAutoParts _validParts = ValidAutoParts.GetInstance();
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormAddProduct()
        {
            InitializeComponent();

            foreach (string brand in _validParts.Parts.Keys)
            {
                comboBoxCategory.Items.Add(brand);
            }

            ConnectButton(buttonAddProduct);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = comboBoxCategory.SelectedItem.ToString();
            List<string> models = _validParts.Parts[brand];

            comboBoxProduct.Items.Clear();
            foreach (string model in models)
            {
                comboBoxProduct.Items.Add(model);
            }
        }

        protected override bool ValidateInput()
        {
            if (!comboBoxCategory.Items.Contains(comboBoxCategory.Text))
            {
                MessageBox.Show("Te rugăm să selectezi un brand valid.");
                return false;
            }

            if (!comboBoxProduct.Items.Contains(comboBoxProduct.Text))
            {
                MessageBox.Show("Te rugăm să selectezi o piesă validă.");
                return false;
            }

            int barcode;
            if (!int.TryParse(textBoxBarcode.Text, out barcode))
            {
                MessageBox.Show("Codul de bare trebuie să fie un număr valid.");
                return false;
            }

            if (numericUpDownPrice.Value <= 0 || numericUpDownStock.Value < 0)
            {
                MessageBox.Show("Valori invalide pentru preț sau stoc.");
                return false;
            }

            return true;
        }

        protected override void ExecuteAction()
        {
            int barcode = Convert.ToInt32(textBoxBarcode.Text);
            string name = comboBoxProduct.Text;
            string brand = comboBoxCategory.Text;
            double price = Convert.ToDouble(numericUpDownPrice.Value);
            int stock = Convert.ToInt32(numericUpDownStock.Value);

            AutoPart part = new AutoPart(barcode, name, brand, price, stock);
            _util.AddNewPart(part);

            MessageBox.Show("Piesa a fost adăugată cu succes.");
            this.Close();
        }
    }
}

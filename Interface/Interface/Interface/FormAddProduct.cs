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

            // Setăm dropdown-ul de branduri
            foreach (string brand in _validParts.Parts.Keys)
            {
                comboBoxCategory.Items.Add(brand);
            }

            // Conectăm butonul la logica TemplateActionForm
            ConnectButton(buttonAddProduct); // asigură-te că există în Designer
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
                MessageBox.Show("Please select a valid brand.");
                return false;
            }

            if (!comboBoxProduct.Items.Contains(comboBoxProduct.Text))
            {
                MessageBox.Show("Please select a valid part name.");
                return false;
            }

            int barcode;
            if (!int.TryParse(textBoxBarcode.Text, out barcode))
            {
                MessageBox.Show("Barcode must be a valid number.");
                return false;
            }

            if (numericUpDownPrice.Value <= 0 || numericUpDownStock.Value < 0)
            {
                MessageBox.Show("Invalid values for price or stock.");
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

            MessageBox.Show("Part successfully added.");
            this.Close();
        }
    }
}

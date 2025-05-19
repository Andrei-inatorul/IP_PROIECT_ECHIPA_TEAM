using System;
using System.Windows.Forms;
using AutoPartsManagementDLL;
using Items.DataBaseObjects;
using System.Collections.Generic;
using System.Globalization;

namespace Interface
{
    public partial class FormMenu : Form
    {
        private ProxyActionManager _util;

        public FormMenu()
        {
            InitializeComponent();
            _util = ProxyActionManager.GetInstance();

            InitializeDataGrid();
            labelAuthenticatedUser.Text = "Bine ai venit, " + _util.CurrentUser.Username.ToUpper(CultureInfo.CurrentCulture);

            InitializeButtons();
        }




        private void InitializeButtons()
        {
            Permissions permissions = new Permissions();
            List<int> rights = permissions.RightsList(_util.CurrentUser.Rights);

            buttonAddUser.Enabled = rights.Contains(Constants.ModifyUsersDBRight);
            buttonDeleteUser.Enabled = rights.Contains(Constants.ModifyUsersDBRight);
            buttonPassUpdate.Enabled = rights.Contains(Constants.ModifyUsersDBRight);
            buttonUsersList.Enabled = rights.Contains(Constants.ViewUsersRight);

            buttonAddNewPart.Enabled = rights.Contains(Constants.ModifyPartsDBRight);
            buttonAddStock.Enabled = rights.Contains(Constants.ModifyPartsDBRight);
            buttonUpdateProductPrice.Enabled = rights.Contains(Constants.ModifyPartsDBRight);

            buttonSellPart.Enabled = rights.Contains(Constants.SellRight);
            buttonPartList.Enabled = rights.Contains(Constants.ViewPartsRight);
        }

        // Restul codului rămâne exact cum l-ai scris
        private void logOut_Click(object sender, EventArgs e)
        {
            Form pagina = new FormLogIn();
            this.Hide();
            pagina.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form pagina3 = new FormAddUser();
            pagina3.Show();
        }

        private void buttonPassUpdate_Click(object sender, EventArgs e)
        {
            Form pagina5 = new FormUpdatePass();
            pagina5.Show();
        }

        private void buttonUsersList_Click(object sender, EventArgs e)
        {
            DisplayUsers();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            Form pagina4 = new FormDeleteUser();
            pagina4.Show();
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            Form pagina6 = new FormAddProduct();
            pagina6.Show();
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            Form pagina7 = new FormAddToStock();
            pagina7.Show();
        }

        private void buttonSellProduct_Click(object sender, EventArgs e)
        {
            Form pagina8 = new FormSell();
            pagina8.Show();
        }

        private void buttonProductList_Click(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void buttonUpdateProductPrice_Click(object sender, EventArgs e)
        {
            Form pagina9 = new FormUpdatePrice();
            pagina9.Show();
        }

        private void InitializeDataGrid()
        {
            dataGridViewDBInfo.AllowUserToAddRows = false;
            dataGridViewDBInfo.Columns.Clear();
            dataGridViewDBInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (_util.IsAdmin())
            {
                dataGridViewDBInfo.Columns.Add("ID", "ID");
                dataGridViewDBInfo.Columns.Add("Username", "Username");
                dataGridViewDBInfo.Columns.Add("Rights", "Rights");
            }
            else
            {
                dataGridViewDBInfo.Columns.Add("Barcode", "Part ID");
                dataGridViewDBInfo.Columns.Add("Name", "Part Name");
                dataGridViewDBInfo.Columns.Add("Category", "Brand");
                dataGridViewDBInfo.Columns.Add("Price", "Price");
                dataGridViewDBInfo.Columns.Add("Stock", "Stock");
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "Poza";
                imgColumn.HeaderText = "Imagine";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgColumn.Width = 100;

                dataGridViewDBInfo.Columns.Add(imgColumn);
            }
        }

        private void DisplayProducts()
        {
            List<AutoPart> parts = _util.GetParts();
            dataGridViewDBInfo.Rows.Clear();
            Image img = Image.FromFile(Path.Combine(Application.StartupPath, "images", "default.jpg"));
            foreach (AutoPart p in parts)
            {
                dataGridViewDBInfo.Rows.Add(p.Id.ToString(), p.Name, p.Brand, p.Price.ToString(), p.Stock.ToString(),img);
            }
        }

        private void DisplayUsers()
        {
            List<User> users = _util.GetUsers();
            dataGridViewDBInfo.Rows.Clear();

            foreach (User u in users)
            {
                dataGridViewDBInfo.Rows.Add(u.Id.ToString(), u.Username, u.Rights.ToString());
            }
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpAutoParts.chm");
        }
    }
}

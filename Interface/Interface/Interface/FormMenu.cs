using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using AutoPartsManagementDLL;
using Items.DataBaseObjects;

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
                dataGridViewDBInfo.Columns.Add("Barcode", "ID Piesă");
                dataGridViewDBInfo.Columns.Add("Name", "Nume");
                dataGridViewDBInfo.Columns.Add("Category", "Marcă");
                dataGridViewDBInfo.Columns.Add("Price", "Preț");
                dataGridViewDBInfo.Columns.Add("Stock", "Stoc");

                var imgColumn = new DataGridViewImageColumn
                {
                    Name = "Poza",
                    HeaderText = "Imagine",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 100
                };
                dataGridViewDBInfo.Columns.Add(imgColumn);
            }
        }

        private void DisplayProducts()
        {
            List<AutoPart> parts = _util.GetParts();
            dataGridViewDBInfo.Rows.Clear();

            string imagesDir = Path.Combine(Application.StartupPath, "images");
            string fallback = Path.Combine(imagesDir, "default.jpg");

            foreach (AutoPart p in parts)
            {
                string imagePath = Path.Combine(imagesDir, $"{p.Id}.jpg");
                Image img;

                try
                {
                    img = File.Exists(imagePath) ? Image.FromFile(imagePath) : Image.FromFile(fallback);
                }
                catch
                {
                    img = null; // just in case both fail
                }

                dataGridViewDBInfo.Rows.Add(p.Id, p.Name, p.Brand, p.Price, p.Stock, img);
            }
        }

        private void DisplayUsers()
        {
            List<User> users = _util.GetUsers();
            dataGridViewDBInfo.Rows.Clear();

            foreach (User u in users)
            {
                dataGridViewDBInfo.Rows.Add(u.Id, u.Username, u.Rights);
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form login = new FormLogIn();
            this.Hide();
            login.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            new FormAddUser().Show();
        }

        private void buttonPassUpdate_Click(object sender, EventArgs e)
        {
            new FormUpdatePass().Show();
        }

        private void buttonUsersList_Click(object sender, EventArgs e)
        {
            DisplayUsers();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            new FormDeleteUser().Show();
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            new FormAddProduct().Show();
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            new FormAddToStock().Show();
        }

        private void buttonSellProduct_Click(object sender, EventArgs e)
        {
            new FormSell().Show();
        }

        private void buttonProductList_Click(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void buttonUpdateProductPrice_Click(object sender, EventArgs e)
        {
            new FormUpdatePrice().Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpAutoParts.chm");
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

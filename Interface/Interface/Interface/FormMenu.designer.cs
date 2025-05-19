
namespace Interface
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewDBInfo = new DataGridView();
            groupBoxRootAccess = new GroupBox();
            buttonDeleteUser = new Button();
            buttonPassUpdate = new Button();
            buttonAddUser = new Button();
            buttonUsersList = new Button();
            groupBoxEmployeeAccess = new GroupBox();
            buttonUpdateProductPrice = new Button();
            buttonAddNewPart = new Button();
            buttonSellPart = new Button();
            buttonPartList = new Button();
            buttonAddStock = new Button();
            groupBoxLogin = new GroupBox();
            buttonHelp = new Button();
            labelAuthenticatedUser = new Label();
            buttonLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDBInfo).BeginInit();
            groupBoxRootAccess.SuspendLayout();
            groupBoxEmployeeAccess.SuspendLayout();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDBInfo
            // 
            dataGridViewDBInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDBInfo.GridColor = SystemColors.ButtonFace;
            dataGridViewDBInfo.Location = new Point(16, 199);
            dataGridViewDBInfo.Margin = new Padding(3, 5, 3, 5);
            dataGridViewDBInfo.Name = "dataGridViewDBInfo";
            dataGridViewDBInfo.RowHeadersWidth = 51;
            dataGridViewDBInfo.RowTemplate.Height = 24;
            dataGridViewDBInfo.Size = new Size(1015, 445);
            dataGridViewDBInfo.TabIndex = 14;
            // 
            // groupBoxRootAccess
            // 
            groupBoxRootAccess.Controls.Add(buttonDeleteUser);
            groupBoxRootAccess.Controls.Add(buttonPassUpdate);
            groupBoxRootAccess.Controls.Add(buttonAddUser);
            groupBoxRootAccess.Controls.Add(buttonUsersList);
            groupBoxRootAccess.Location = new Point(311, 17);
            groupBoxRootAccess.Name = "groupBoxRootAccess";
            groupBoxRootAccess.Size = new Size(301, 161);
            groupBoxRootAccess.TabIndex = 16;
            groupBoxRootAccess.TabStop = false;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.BackColor = Color.FromArgb(153, 170, 181);
            buttonDeleteUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteUser.Location = new Point(171, 87);
            buttonDeleteUser.Margin = new Padding(3, 5, 3, 5);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(123, 68);
            buttonDeleteUser.TabIndex = 16;
            buttonDeleteUser.Text = "Șterge utilizator";
            buttonDeleteUser.UseVisualStyleBackColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonPassUpdate
            // 
            buttonPassUpdate.BackColor = Color.FromArgb(153, 170, 181);
            buttonPassUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPassUpdate.Location = new Point(24, 87);
            buttonPassUpdate.Margin = new Padding(3, 5, 3, 5);
            buttonPassUpdate.Name = "buttonPassUpdate";
            buttonPassUpdate.Size = new Size(123, 68);
            buttonPassUpdate.TabIndex = 14;
            buttonPassUpdate.Text = "Actualizeză parola";
            buttonPassUpdate.UseVisualStyleBackColor = false;
            buttonPassUpdate.Click += buttonPassUpdate_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.FromArgb(153, 170, 181);
            buttonAddUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddUser.Location = new Point(24, 9);
            buttonAddUser.Margin = new Padding(3, 5, 3, 5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(123, 68);
            buttonAddUser.TabIndex = 13;
            buttonAddUser.Text = "Adaugă utilizator";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonUsersList
            // 
            buttonUsersList.BackColor = Color.FromArgb(153, 170, 181);
            buttonUsersList.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUsersList.Location = new Point(171, 9);
            buttonUsersList.Margin = new Padding(3, 5, 3, 5);
            buttonUsersList.Name = "buttonUsersList";
            buttonUsersList.Size = new Size(123, 68);
            buttonUsersList.TabIndex = 15;
            buttonUsersList.Text = "Listă utilizatori";
            buttonUsersList.UseVisualStyleBackColor = false;
            buttonUsersList.Click += buttonUsersList_Click;
            // 
            // groupBoxEmployeeAccess
            // 
            groupBoxEmployeeAccess.Controls.Add(buttonUpdateProductPrice);
            groupBoxEmployeeAccess.Controls.Add(buttonAddNewPart);
            groupBoxEmployeeAccess.Controls.Add(buttonSellPart);
            groupBoxEmployeeAccess.Controls.Add(buttonPartList);
            groupBoxEmployeeAccess.Controls.Add(buttonAddStock);
            groupBoxEmployeeAccess.Location = new Point(618, 17);
            groupBoxEmployeeAccess.Name = "groupBoxEmployeeAccess";
            groupBoxEmployeeAccess.Size = new Size(413, 161);
            groupBoxEmployeeAccess.TabIndex = 17;
            groupBoxEmployeeAccess.TabStop = false;
            // 
            // buttonUpdateProductPrice
            // 
            buttonUpdateProductPrice.BackColor = Color.FromArgb(153, 170, 181);
            buttonUpdateProductPrice.FlatStyle = FlatStyle.Flat;
            buttonUpdateProductPrice.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdateProductPrice.Location = new Point(269, 9);
            buttonUpdateProductPrice.Margin = new Padding(3, 5, 3, 5);
            buttonUpdateProductPrice.Name = "buttonUpdateProductPrice";
            buttonUpdateProductPrice.Size = new Size(121, 68);
            buttonUpdateProductPrice.TabIndex = 25;
            buttonUpdateProductPrice.Text = "Actualizează prețul";
            buttonUpdateProductPrice.UseVisualStyleBackColor = false;
            buttonUpdateProductPrice.Click += buttonUpdateProductPrice_Click;
            // 
            // buttonAddNewPart
            // 
            buttonAddNewPart.BackColor = Color.FromArgb(153, 170, 181);
            buttonAddNewPart.FlatStyle = FlatStyle.Flat;
            buttonAddNewPart.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddNewPart.Location = new Point(29, 9);
            buttonAddNewPart.Margin = new Padding(3, 5, 3, 5);
            buttonAddNewPart.Name = "buttonAddNewPart";
            buttonAddNewPart.Size = new Size(115, 68);
            buttonAddNewPart.TabIndex = 24;
            buttonAddNewPart.Text = "Adaugă piesă nouă";
            buttonAddNewPart.UseVisualStyleBackColor = false;
            buttonAddNewPart.Click += buttonAddNewProduct_Click;
            // 
            // buttonSellPart
            // 
            buttonSellPart.BackColor = Color.FromArgb(153, 170, 181);
            buttonSellPart.FlatStyle = FlatStyle.Flat;
            buttonSellPart.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSellPart.Location = new Point(95, 87);
            buttonSellPart.Margin = new Padding(3, 5, 3, 5);
            buttonSellPart.Name = "buttonSellPart";
            buttonSellPart.Size = new Size(115, 68);
            buttonSellPart.TabIndex = 23;
            buttonSellPart.Text = "Vinde piesă";
            buttonSellPart.UseVisualStyleBackColor = false;
            buttonSellPart.Click += buttonSellProduct_Click;
            // 
            // buttonPartList
            // 
            buttonPartList.BackColor = Color.FromArgb(153, 170, 181);
            buttonPartList.FlatStyle = FlatStyle.Flat;
            buttonPartList.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPartList.Location = new Point(216, 87);
            buttonPartList.Margin = new Padding(3, 5, 3, 5);
            buttonPartList.Name = "buttonPartList";
            buttonPartList.Size = new Size(115, 68);
            buttonPartList.TabIndex = 22;
            buttonPartList.Text = "Listă piese";
            buttonPartList.UseVisualStyleBackColor = false;
            buttonPartList.Click += buttonProductList_Click;
            // 
            // buttonAddStock
            // 
            buttonAddStock.BackColor = Color.FromArgb(153, 170, 181);
            buttonAddStock.FlatStyle = FlatStyle.Flat;
            buttonAddStock.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddStock.Location = new Point(149, 9);
            buttonAddStock.Margin = new Padding(3, 5, 3, 5);
            buttonAddStock.Name = "buttonAddStock";
            buttonAddStock.Size = new Size(115, 68);
            buttonAddStock.TabIndex = 21;
            buttonAddStock.Text = "Adaugă la stoc";
            buttonAddStock.UseVisualStyleBackColor = false;
            buttonAddStock.Click += buttonAddStock_Click;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(buttonHelp);
            groupBoxLogin.Controls.Add(labelAuthenticatedUser);
            groupBoxLogin.Controls.Add(buttonLogOut);
            groupBoxLogin.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxLogin.Location = new Point(5, 17);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(301, 112);
            groupBoxLogin.TabIndex = 18;
            groupBoxLogin.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(153, 170, 181);
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHelp.ForeColor = Color.Black;
            buttonHelp.Location = new Point(166, 62);
            buttonHelp.Margin = new Padding(3, 5, 3, 5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(129, 39);
            buttonHelp.TabIndex = 16;
            buttonHelp.Text = "Ajutor";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // labelAuthenticatedUser
            // 
            labelAuthenticatedUser.AutoSize = true;
            labelAuthenticatedUser.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold | FontStyle.Italic);
            labelAuthenticatedUser.Location = new Point(43, 5);
            labelAuthenticatedUser.Name = "labelAuthenticatedUser";
            labelAuthenticatedUser.Size = new Size(0, 26);
            labelAuthenticatedUser.TabIndex = 15;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(183, 21, 64);
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.ForeColor = Color.Black;
            buttonLogOut.Location = new Point(11, 63);
            buttonLogOut.Margin = new Padding(3, 5, 3, 5);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(129, 41);
            buttonLogOut.TabIndex = 14;
            buttonLogOut.Text = "Ieși din cont";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += logOut_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(1043, 660);
            Controls.Add(groupBoxLogin);
            Controls.Add(groupBoxEmployeeAccess);
            Controls.Add(groupBoxRootAccess);
            Controls.Add(dataGridViewDBInfo);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormMenu";
            Text = "Meniu:";
            FormClosing += FormMenu_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDBInfo).EndInit();
            groupBoxRootAccess.ResumeLayout(false);
            groupBoxEmployeeAccess.ResumeLayout(false);
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDBInfo;
        private System.Windows.Forms.GroupBox groupBoxRootAccess;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUsersList;
        private System.Windows.Forms.Button buttonPassUpdate;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.GroupBox groupBoxEmployeeAccess;
        private System.Windows.Forms.Button buttonUpdateProductPrice;
        private System.Windows.Forms.Button buttonAddNewPart;
        private System.Windows.Forms.Button buttonSellPart;
        private System.Windows.Forms.Button buttonPartList;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelAuthenticatedUser;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
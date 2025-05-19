
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
            dataGridViewDBInfo.Location = new Point(14, 149);
            dataGridViewDBInfo.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDBInfo.Name = "dataGridViewDBInfo";
            dataGridViewDBInfo.RowHeadersWidth = 51;
            dataGridViewDBInfo.RowTemplate.Height = 24;
            dataGridViewDBInfo.Size = new Size(888, 334);
            dataGridViewDBInfo.TabIndex = 14;
            // 
            // groupBoxRootAccess
            // 
            groupBoxRootAccess.Controls.Add(buttonDeleteUser);
            groupBoxRootAccess.Controls.Add(buttonPassUpdate);
            groupBoxRootAccess.Controls.Add(buttonAddUser);
            groupBoxRootAccess.Controls.Add(buttonUsersList);
            groupBoxRootAccess.Location = new Point(272, 13);
            groupBoxRootAccess.Margin = new Padding(3, 2, 3, 2);
            groupBoxRootAccess.Name = "groupBoxRootAccess";
            groupBoxRootAccess.Padding = new Padding(3, 2, 3, 2);
            groupBoxRootAccess.Size = new Size(263, 121);
            groupBoxRootAccess.TabIndex = 16;
            groupBoxRootAccess.TabStop = false;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteUser.Location = new Point(150, 65);
            buttonDeleteUser.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(108, 51);
            buttonDeleteUser.TabIndex = 16;
            buttonDeleteUser.Text = "Șterge utilizator";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonPassUpdate
            // 
            buttonPassUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPassUpdate.Location = new Point(21, 65);
            buttonPassUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonPassUpdate.Name = "buttonPassUpdate";
            buttonPassUpdate.Size = new Size(108, 51);
            buttonPassUpdate.TabIndex = 14;
            buttonPassUpdate.Text = "Actualizeză parola";
            buttonPassUpdate.UseVisualStyleBackColor = true;
            buttonPassUpdate.Click += buttonPassUpdate_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddUser.Location = new Point(21, 7);
            buttonAddUser.Margin = new Padding(3, 4, 3, 4);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(108, 51);
            buttonAddUser.TabIndex = 13;
            buttonAddUser.Text = "Adaugă utilizator";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonUsersList
            // 
            buttonUsersList.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUsersList.Location = new Point(150, 7);
            buttonUsersList.Margin = new Padding(3, 4, 3, 4);
            buttonUsersList.Name = "buttonUsersList";
            buttonUsersList.Size = new Size(108, 51);
            buttonUsersList.TabIndex = 15;
            buttonUsersList.Text = "Listă utilizatori";
            buttonUsersList.UseVisualStyleBackColor = true;
            buttonUsersList.Click += buttonUsersList_Click;
            // 
            // groupBoxEmployeeAccess
            // 
            groupBoxEmployeeAccess.Controls.Add(buttonUpdateProductPrice);
            groupBoxEmployeeAccess.Controls.Add(buttonAddNewPart);
            groupBoxEmployeeAccess.Controls.Add(buttonSellPart);
            groupBoxEmployeeAccess.Controls.Add(buttonPartList);
            groupBoxEmployeeAccess.Controls.Add(buttonAddStock);
            groupBoxEmployeeAccess.Location = new Point(541, 13);
            groupBoxEmployeeAccess.Margin = new Padding(3, 2, 3, 2);
            groupBoxEmployeeAccess.Name = "groupBoxEmployeeAccess";
            groupBoxEmployeeAccess.Padding = new Padding(3, 2, 3, 2);
            groupBoxEmployeeAccess.Size = new Size(361, 121);
            groupBoxEmployeeAccess.TabIndex = 17;
            groupBoxEmployeeAccess.TabStop = false;
            // 
            // buttonUpdateProductPrice
            // 
            buttonUpdateProductPrice.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdateProductPrice.Location = new Point(235, 7);
            buttonUpdateProductPrice.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateProductPrice.Name = "buttonUpdateProductPrice";
            buttonUpdateProductPrice.Size = new Size(101, 51);
            buttonUpdateProductPrice.TabIndex = 25;
            buttonUpdateProductPrice.Text = "Actualizează prețul";
            buttonUpdateProductPrice.UseVisualStyleBackColor = true;
            buttonUpdateProductPrice.Click += buttonUpdateProductPrice_Click;
            // 
            // buttonAddNewPart
            // 
            buttonAddNewPart.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddNewPart.Location = new Point(25, 7);
            buttonAddNewPart.Margin = new Padding(3, 4, 3, 4);
            buttonAddNewPart.Name = "buttonAddNewPart";
            buttonAddNewPart.Size = new Size(101, 51);
            buttonAddNewPart.TabIndex = 24;
            buttonAddNewPart.Text = "Adaugă piesă nouă";
            buttonAddNewPart.UseVisualStyleBackColor = true;
            buttonAddNewPart.Click += buttonAddNewProduct_Click;
            // 
            // buttonSellPart
            // 
            buttonSellPart.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSellPart.Location = new Point(83, 65);
            buttonSellPart.Margin = new Padding(3, 4, 3, 4);
            buttonSellPart.Name = "buttonSellPart";
            buttonSellPart.Size = new Size(101, 51);
            buttonSellPart.TabIndex = 23;
            buttonSellPart.Text = "Vinde piesă";
            buttonSellPart.UseVisualStyleBackColor = true;
            buttonSellPart.Click += buttonSellProduct_Click;
            // 
            // buttonPartList
            // 
            buttonPartList.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPartList.Location = new Point(188, 64);
            buttonPartList.Margin = new Padding(3, 4, 3, 4);
            buttonPartList.Name = "buttonPartList";
            buttonPartList.Size = new Size(101, 51);
            buttonPartList.TabIndex = 22;
            buttonPartList.Text = "Listă piese";
            buttonPartList.UseVisualStyleBackColor = true;
            buttonPartList.Click += buttonProductList_Click;
            // 
            // buttonAddStock
            // 
            buttonAddStock.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddStock.Location = new Point(130, 7);
            buttonAddStock.Margin = new Padding(3, 4, 3, 4);
            buttonAddStock.Name = "buttonAddStock";
            buttonAddStock.Size = new Size(101, 51);
            buttonAddStock.TabIndex = 21;
            buttonAddStock.Text = "Adaugă la stoc";
            buttonAddStock.UseVisualStyleBackColor = true;
            buttonAddStock.Click += buttonAddStock_Click;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(buttonHelp);
            groupBoxLogin.Controls.Add(labelAuthenticatedUser);
            groupBoxLogin.Controls.Add(buttonLogOut);
            groupBoxLogin.Location = new Point(4, 13);
            groupBoxLogin.Margin = new Padding(3, 2, 3, 2);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Padding = new Padding(3, 2, 3, 2);
            groupBoxLogin.Size = new Size(263, 121);
            groupBoxLogin.TabIndex = 18;
            groupBoxLogin.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHelp.Location = new Point(28, 82);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(113, 29);
            buttonHelp.TabIndex = 16;
            buttonHelp.Text = "Ajutor";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // labelAuthenticatedUser
            // 
            labelAuthenticatedUser.AutoSize = true;
            labelAuthenticatedUser.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold | FontStyle.Italic);
            labelAuthenticatedUser.Location = new Point(38, 4);
            labelAuthenticatedUser.Name = "labelAuthenticatedUser";
            labelAuthenticatedUser.Size = new Size(0, 21);
            labelAuthenticatedUser.TabIndex = 15;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.Location = new Point(28, 44);
            buttonLogOut.Margin = new Padding(3, 4, 3, 4);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(113, 31);
            buttonLogOut.TabIndex = 14;
            buttonLogOut.Text = "Ieși din cont";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += logOut_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(913, 495);
            Controls.Add(groupBoxLogin);
            Controls.Add(groupBoxEmployeeAccess);
            Controls.Add(groupBoxRootAccess);
            Controls.Add(dataGridViewDBInfo);
            Margin = new Padding(3, 4, 3, 4);
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
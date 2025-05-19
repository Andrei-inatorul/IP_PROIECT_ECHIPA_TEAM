
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
            this.dataGridViewDBInfo = new System.Windows.Forms.DataGridView();
            this.groupBoxRootAccess = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUsersList = new System.Windows.Forms.Button();
            this.buttonPassUpdate = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.groupBoxEmployeeAccess = new System.Windows.Forms.GroupBox();
            this.buttonUpdateProductPrice = new System.Windows.Forms.Button();
            this.buttonAddNewPart = new System.Windows.Forms.Button();
            this.buttonSellPart = new System.Windows.Forms.Button();
            this.buttonPartList = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelAuthenticatedUser = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBInfo)).BeginInit();
            this.groupBoxRootAccess.SuspendLayout();
            this.groupBoxEmployeeAccess.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDBInfo
            // 
            this.dataGridViewDBInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDBInfo.Location = new System.Drawing.Point(16, 159);
            this.dataGridViewDBInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDBInfo.Name = "dataGridViewDBInfo";
            this.dataGridViewDBInfo.RowHeadersWidth = 51;
            this.dataGridViewDBInfo.RowTemplate.Height = 24;
            this.dataGridViewDBInfo.Size = new System.Drawing.Size(1015, 356);
            this.dataGridViewDBInfo.TabIndex = 14;
            // 
            // groupBoxRootAccess
            // 
            this.groupBoxRootAccess.Controls.Add(this.buttonDeleteUser);
            this.groupBoxRootAccess.Controls.Add(this.buttonPassUpdate);
            this.groupBoxRootAccess.Controls.Add(this.buttonAddUser);
            this.groupBoxRootAccess.Controls.Add(this.buttonUsersList);
            this.groupBoxRootAccess.Location = new System.Drawing.Point(311, 14);
            this.groupBoxRootAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRootAccess.Name = "groupBoxRootAccess";
            this.groupBoxRootAccess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRootAccess.Size = new System.Drawing.Size(301, 129);
            this.groupBoxRootAccess.TabIndex = 16;
            this.groupBoxRootAccess.TabStop = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(171, 69);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(124, 54);
            this.buttonDeleteUser.TabIndex = 16;
            this.buttonDeleteUser.Text = "Șterge utilizator";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUsersList
            // 
            this.buttonUsersList.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersList.Location = new System.Drawing.Point(171, 7);
            this.buttonUsersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUsersList.Name = "buttonUsersList";
            this.buttonUsersList.Size = new System.Drawing.Size(124, 54);
            this.buttonUsersList.TabIndex = 15;
            this.buttonUsersList.Text = "Listă utilizatori";
            this.buttonUsersList.UseVisualStyleBackColor = true;
            this.buttonUsersList.Click += new System.EventHandler(this.buttonUsersList_Click);
            // 
            // buttonPassUpdate
            // 
            this.buttonPassUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPassUpdate.Location = new System.Drawing.Point(24, 69);
            this.buttonPassUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPassUpdate.Name = "buttonPassUpdate";
            this.buttonPassUpdate.Size = new System.Drawing.Size(124, 54);
            this.buttonPassUpdate.TabIndex = 14;
            this.buttonPassUpdate.Text = "Actualizeză parola";
            this.buttonPassUpdate.UseVisualStyleBackColor = true;
            this.buttonPassUpdate.Click += new System.EventHandler(this.buttonPassUpdate_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.Location = new System.Drawing.Point(24, 7);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(124, 54);
            this.buttonAddUser.TabIndex = 13;
            this.buttonAddUser.Text = "Adaugă utilizator";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // groupBoxEmployeeAccess
            // 
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonUpdateProductPrice);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonAddNewPart);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonSellPart);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonPartList);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonAddStock);
            this.groupBoxEmployeeAccess.Location = new System.Drawing.Point(618, 14);
            this.groupBoxEmployeeAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEmployeeAccess.Name = "groupBoxEmployeeAccess";
            this.groupBoxEmployeeAccess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEmployeeAccess.Size = new System.Drawing.Size(413, 129);
            this.groupBoxEmployeeAccess.TabIndex = 17;
            this.groupBoxEmployeeAccess.TabStop = false;
            // 
            // buttonUpdateProductPrice
            // 
            this.buttonUpdateProductPrice.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateProductPrice.Location = new System.Drawing.Point(269, 7);
            this.buttonUpdateProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateProductPrice.Name = "buttonUpdateProductPrice";
            this.buttonUpdateProductPrice.Size = new System.Drawing.Size(115, 54);
            this.buttonUpdateProductPrice.TabIndex = 25;
            this.buttonUpdateProductPrice.Text = "Actualizează prețul";
            this.buttonUpdateProductPrice.UseVisualStyleBackColor = true;
            this.buttonUpdateProductPrice.Click += new System.EventHandler(this.buttonUpdateProductPrice_Click);
            // 
            // buttonAddNewPart
            // 
            this.buttonAddNewPart.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPart.Location = new System.Drawing.Point(29, 7);
            this.buttonAddNewPart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddNewPart.Name = "buttonAddNewPart";
            this.buttonAddNewPart.Size = new System.Drawing.Size(115, 54);
            this.buttonAddNewPart.TabIndex = 24;
            this.buttonAddNewPart.Text = "Adaugă piesă nouă";
            this.buttonAddNewPart.UseVisualStyleBackColor = true;
            this.buttonAddNewPart.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // buttonSellPart
            // 
            this.buttonSellPart.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellPart.Location = new System.Drawing.Point(95, 69);
            this.buttonSellPart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSellPart.Name = "buttonSellPart";
            this.buttonSellPart.Size = new System.Drawing.Size(115, 54);
            this.buttonSellPart.TabIndex = 23;
            this.buttonSellPart.Text = "Vinde piesă";
            this.buttonSellPart.UseVisualStyleBackColor = true;
            this.buttonSellPart.Click += new System.EventHandler(this.buttonSellProduct_Click);
            // 
            // buttonPartList
            // 
            this.buttonPartList.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPartList.Location = new System.Drawing.Point(215, 68);
            this.buttonPartList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPartList.Name = "buttonPartList";
            this.buttonPartList.Size = new System.Drawing.Size(115, 54);
            this.buttonPartList.TabIndex = 22;
            this.buttonPartList.Text = "Listă piese";
            this.buttonPartList.UseVisualStyleBackColor = true;
            this.buttonPartList.Click += new System.EventHandler(this.buttonProductList_Click);
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStock.Location = new System.Drawing.Point(149, 7);
            this.buttonAddStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(115, 54);
            this.buttonAddStock.TabIndex = 21;
            this.buttonAddStock.Text = "Adaugă la stoc";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonHelp);
            this.groupBoxLogin.Controls.Add(this.labelAuthenticatedUser);
            this.groupBoxLogin.Controls.Add(this.buttonLogOut);
            this.groupBoxLogin.Location = new System.Drawing.Point(4, 14);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogin.Size = new System.Drawing.Size(301, 129);
            this.groupBoxLogin.TabIndex = 18;
            this.groupBoxLogin.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(32, 87);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(129, 31);
            this.buttonHelp.TabIndex = 16;
            this.buttonHelp.Text = "Ajutor";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelAuthenticatedUser
            // 
            this.labelAuthenticatedUser.AutoSize = true;
            this.labelAuthenticatedUser.Font = new System.Drawing.Font("Sitka Subheading", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelAuthenticatedUser.Location = new System.Drawing.Point(44, 4);
            this.labelAuthenticatedUser.Name = "labelAuthenticatedUser";
            this.labelAuthenticatedUser.Size = new System.Drawing.Size(0, 26);
            this.labelAuthenticatedUser.TabIndex = 15;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(32, 47);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(129, 33);
            this.buttonLogOut.TabIndex = 14;
            this.buttonLogOut.Text = "Ieși din cont";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1043, 528);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxEmployeeAccess);
            this.Controls.Add(this.groupBoxRootAccess);
            this.Controls.Add(this.dataGridViewDBInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.Text = "Meniu:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBInfo)).EndInit();
            this.groupBoxRootAccess.ResumeLayout(false);
            this.groupBoxEmployeeAccess.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

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
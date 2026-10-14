namespace libraryStock_graphics
{
    partial class Form1
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonStockCount = new System.Windows.Forms.Button();
            this.buttonStockValue = new System.Windows.Forms.Button();
            this.buttonTotalStockStatus = new System.Windows.Forms.Button();
            this.buttonSellBook = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelLoginStatus = new System.Windows.Forms.Label();
            this.groupBoxProgram = new System.Windows.Forms.GroupBox();
            this.listViewStockValue = new System.Windows.Forms.ListView();
            this.columnHeaderTheme2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFlair = new System.Windows.Forms.Label();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.columnHeaderTheme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxRegister = new System.Windows.Forms.ComboBox();
            this.buttonRegisterSell = new System.Windows.Forms.Button();
            this.labelSoldComic = new System.Windows.Forms.Label();
            this.labelStockNumber = new System.Windows.Forms.Label();
            this.labelStockStatusText = new System.Windows.Forms.Label();
            this.groupBoxStockStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxProgram.SuspendLayout();
            this.groupBoxStockStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(13, 13);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxUsername
            // 
            this.textboxUsername.Location = new System.Drawing.Point(16, 41);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(119, 20);
            this.textboxUsername.TabIndex = 1;
            this.textboxUsername.TextChanged += new System.EventHandler(this.textboxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(16, 68);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(119, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 114);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(119, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonStockCount
            // 
            this.buttonStockCount.Location = new System.Drawing.Point(75, 156);
            this.buttonStockCount.Name = "buttonStockCount";
            this.buttonStockCount.Size = new System.Drawing.Size(133, 34);
            this.buttonStockCount.TabIndex = 4;
            this.buttonStockCount.Text = "Stock Count";
            this.buttonStockCount.UseVisualStyleBackColor = true;
            this.buttonStockCount.Click += new System.EventHandler(this.buttonStockCount_Click);
            // 
            // buttonStockValue
            // 
            this.buttonStockValue.Location = new System.Drawing.Point(214, 157);
            this.buttonStockValue.Name = "buttonStockValue";
            this.buttonStockValue.Size = new System.Drawing.Size(133, 34);
            this.buttonStockValue.TabIndex = 5;
            this.buttonStockValue.Text = "Stock Value";
            this.buttonStockValue.UseVisualStyleBackColor = true;
            this.buttonStockValue.Click += new System.EventHandler(this.buttonStockValue_Click);
            // 
            // buttonTotalStockStatus
            // 
            this.buttonTotalStockStatus.Location = new System.Drawing.Point(214, 193);
            this.buttonTotalStockStatus.Name = "buttonTotalStockStatus";
            this.buttonTotalStockStatus.Size = new System.Drawing.Size(133, 37);
            this.buttonTotalStockStatus.TabIndex = 6;
            this.buttonTotalStockStatus.Text = "Total Stock Status";
            this.buttonTotalStockStatus.UseVisualStyleBackColor = true;
            this.buttonTotalStockStatus.Click += new System.EventHandler(this.buttonTotalStockStatus_Click);
            // 
            // buttonSellBook
            // 
            this.buttonSellBook.Location = new System.Drawing.Point(75, 196);
            this.buttonSellBook.Name = "buttonSellBook";
            this.buttonSellBook.Size = new System.Drawing.Size(133, 34);
            this.buttonSellBook.TabIndex = 7;
            this.buttonSellBook.Text = "Register a book as sold";
            this.buttonSellBook.UseVisualStyleBackColor = true;
            this.buttonSellBook.Click += new System.EventHandler(this.buttonSellBook_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(348, 402);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelLoginStatus
            // 
            this.labelLoginStatus.AutoSize = true;
            this.labelLoginStatus.Location = new System.Drawing.Point(26, 164);
            this.labelLoginStatus.Name = "labelLoginStatus";
            this.labelLoginStatus.Size = new System.Drawing.Size(57, 13);
            this.labelLoginStatus.TabIndex = 10;
            this.labelLoginStatus.Text = "Logged in!";
            this.labelLoginStatus.Visible = false;
            // 
            // groupBoxProgram
            // 
            this.groupBoxProgram.Controls.Add(this.groupBoxStockStatus);
            this.groupBoxProgram.Controls.Add(this.labelSoldComic);
            this.groupBoxProgram.Controls.Add(this.buttonRegisterSell);
            this.groupBoxProgram.Controls.Add(this.comboBoxRegister);
            this.groupBoxProgram.Controls.Add(this.listViewStockValue);
            this.groupBoxProgram.Controls.Add(this.labelFlair);
            this.groupBoxProgram.Controls.Add(this.listViewStock);
            this.groupBoxProgram.Controls.Add(this.buttonSellBook);
            this.groupBoxProgram.Controls.Add(this.buttonTotalStockStatus);
            this.groupBoxProgram.Controls.Add(this.buttonStockValue);
            this.groupBoxProgram.Controls.Add(this.buttonStockCount);
            this.groupBoxProgram.Location = new System.Drawing.Point(170, 41);
            this.groupBoxProgram.Name = "groupBoxProgram";
            this.groupBoxProgram.Size = new System.Drawing.Size(627, 361);
            this.groupBoxProgram.TabIndex = 11;
            this.groupBoxProgram.TabStop = false;
            this.groupBoxProgram.Visible = false;
            // 
            // listViewStockValue
            // 
            this.listViewStockValue.AutoArrange = false;
            this.listViewStockValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTheme2,
            this.columnHeaderValue2});
            this.listViewStockValue.FullRowSelect = true;
            this.listViewStockValue.GridLines = true;
            this.listViewStockValue.HideSelection = false;
            this.listViewStockValue.Location = new System.Drawing.Point(233, 42);
            this.listViewStockValue.Name = "listViewStockValue";
            this.listViewStockValue.Size = new System.Drawing.Size(114, 113);
            this.listViewStockValue.TabIndex = 12;
            this.listViewStockValue.UseCompatibleStateImageBehavior = false;
            this.listViewStockValue.View = System.Windows.Forms.View.Details;
            this.listViewStockValue.Visible = false;
            // 
            // columnHeaderTheme2
            // 
            this.columnHeaderTheme2.Text = "Theme";
            // 
            // columnHeaderValue2
            // 
            this.columnHeaderValue2.Text = "Value";
            this.columnHeaderValue2.Width = 50;
            // 
            // labelFlair
            // 
            this.labelFlair.AutoSize = true;
            this.labelFlair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFlair.Location = new System.Drawing.Point(532, 167);
            this.labelFlair.Name = "labelFlair";
            this.labelFlair.Size = new System.Drawing.Size(28, 24);
            this.labelFlair.TabIndex = 11;
            this.labelFlair.Text = ":D";
            // 
            // listViewStock
            // 
            this.listViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTheme,
            this.columnHeaderPrice,
            this.columnHeaderStock});
            this.listViewStock.FullRowSelect = true;
            this.listViewStock.GridLines = true;
            this.listViewStock.HideSelection = false;
            this.listViewStock.Location = new System.Drawing.Point(46, 47);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(162, 109);
            this.listViewStock.TabIndex = 10;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            this.listViewStock.View = System.Windows.Forms.View.Details;
            this.listViewStock.Visible = false;
            this.listViewStock.SelectedIndexChanged += new System.EventHandler(this.listViewStock_SelectedIndexChanged);
            // 
            // columnHeaderTheme
            // 
            this.columnHeaderTheme.Text = "Theme";
            this.columnHeaderTheme.Width = 59;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 45;
            // 
            // columnHeaderStock
            // 
            this.columnHeaderStock.Text = "Stock";
            this.columnHeaderStock.Width = 52;
            // 
            // comboBoxRegister
            // 
            this.comboBoxRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegister.FormattingEnabled = true;
            this.comboBoxRegister.Items.AddRange(new object[] {
            "Joker",
            "Batman",
            "Cat",
            "Riddler",
            "Penguin"});
            this.comboBoxRegister.Location = new System.Drawing.Point(75, 236);
            this.comboBoxRegister.Name = "comboBoxRegister";
            this.comboBoxRegister.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegister.TabIndex = 13;
            this.comboBoxRegister.Visible = false;
            // 
            // buttonRegisterSell
            // 
            this.buttonRegisterSell.Location = new System.Drawing.Point(100, 263);
            this.buttonRegisterSell.Name = "buttonRegisterSell";
            this.buttonRegisterSell.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterSell.TabIndex = 14;
            this.buttonRegisterSell.Text = "Sell";
            this.buttonRegisterSell.UseVisualStyleBackColor = true;
            this.buttonRegisterSell.Visible = false;
            this.buttonRegisterSell.Click += new System.EventHandler(this.buttonRegisterSell_Click);
            // 
            // labelSoldComic
            // 
            this.labelSoldComic.AutoSize = true;
            this.labelSoldComic.Location = new System.Drawing.Point(119, 289);
            this.labelSoldComic.Name = "labelSoldComic";
            this.labelSoldComic.Size = new System.Drawing.Size(31, 13);
            this.labelSoldComic.TabIndex = 15;
            this.labelSoldComic.Text = "Sold!";
            this.labelSoldComic.Visible = false;
            // 
            // labelStockNumber
            // 
            this.labelStockNumber.AutoSize = true;
            this.labelStockNumber.Location = new System.Drawing.Point(6, 24);
            this.labelStockNumber.Name = "labelStockNumber";
            this.labelStockNumber.Size = new System.Drawing.Size(68, 13);
            this.labelStockNumber.TabIndex = 17;
            this.labelStockNumber.Text = "Total Stock: ";
            this.labelStockNumber.Click += new System.EventHandler(this.labelStockNumber_Click);
            // 
            // labelStockStatusText
            // 
            this.labelStockStatusText.AutoSize = true;
            this.labelStockStatusText.Location = new System.Drawing.Point(102, 24);
            this.labelStockStatusText.Name = "labelStockStatusText";
            this.labelStockStatusText.Size = new System.Drawing.Size(71, 13);
            this.labelStockStatusText.TabIndex = 18;
            this.labelStockStatusText.Text = "Stock Status:";
            this.labelStockStatusText.Click += new System.EventHandler(this.labelStockStatusText_Click);
            // 
            // groupBoxStockStatus
            // 
            this.groupBoxStockStatus.Controls.Add(this.labelStockStatusText);
            this.groupBoxStockStatus.Controls.Add(this.labelStockNumber);
            this.groupBoxStockStatus.Location = new System.Drawing.Point(226, 236);
            this.groupBoxStockStatus.Name = "groupBoxStockStatus";
            this.groupBoxStockStatus.Size = new System.Drawing.Size(217, 48);
            this.groupBoxStockStatus.TabIndex = 19;
            this.groupBoxStockStatus.TabStop = false;
            this.groupBoxStockStatus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxProgram);
            this.Controls.Add(this.labelLoginStatus);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.labelLogin);
            this.Name = "Form1";
            this.Text = "Comics";
            this.groupBoxProgram.ResumeLayout(false);
            this.groupBoxProgram.PerformLayout();
            this.groupBoxStockStatus.ResumeLayout(false);
            this.groupBoxStockStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonStockCount;
        private System.Windows.Forms.Button buttonStockValue;
        private System.Windows.Forms.Button buttonTotalStockStatus;
        private System.Windows.Forms.Button buttonSellBook;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelLoginStatus;
        private System.Windows.Forms.GroupBox groupBoxProgram;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.Label labelFlair;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderStock;
        private System.Windows.Forms.ColumnHeader columnHeaderTheme;
        private System.Windows.Forms.ListView listViewStockValue;
        private System.Windows.Forms.ColumnHeader columnHeaderTheme2;
        private System.Windows.Forms.ColumnHeader columnHeaderValue2;
        private System.Windows.Forms.ComboBox comboBoxRegister;
        private System.Windows.Forms.Button buttonRegisterSell;
        private System.Windows.Forms.Label labelSoldComic;
        private System.Windows.Forms.GroupBox groupBoxStockStatus;
        private System.Windows.Forms.Label labelStockStatusText;
        private System.Windows.Forms.Label labelStockNumber;
    }
}


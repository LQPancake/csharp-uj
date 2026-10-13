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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.labelLoginStatus = new System.Windows.Forms.Label();
            this.groupBoxProgram = new System.Windows.Forms.GroupBox();
            this.groupBoxProgram.SuspendLayout();
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
            // 
            // buttonStockValue
            // 
            this.buttonStockValue.Location = new System.Drawing.Point(214, 157);
            this.buttonStockValue.Name = "buttonStockValue";
            this.buttonStockValue.Size = new System.Drawing.Size(133, 34);
            this.buttonStockValue.TabIndex = 5;
            this.buttonStockValue.Text = "Stock Value";
            this.buttonStockValue.UseVisualStyleBackColor = true;
            // 
            // buttonTotalStockStatus
            // 
            this.buttonTotalStockStatus.Location = new System.Drawing.Point(214, 193);
            this.buttonTotalStockStatus.Name = "buttonTotalStockStatus";
            this.buttonTotalStockStatus.Size = new System.Drawing.Size(133, 37);
            this.buttonTotalStockStatus.TabIndex = 6;
            this.buttonTotalStockStatus.Text = "Total Stock Status";
            this.buttonTotalStockStatus.UseVisualStyleBackColor = true;
            // 
            // buttonSellBook
            // 
            this.buttonSellBook.Location = new System.Drawing.Point(75, 196);
            this.buttonSellBook.Name = "buttonSellBook";
            this.buttonSellBook.Size = new System.Drawing.Size(133, 34);
            this.buttonSellBook.TabIndex = 7;
            this.buttonSellBook.Text = "Register a book as sold";
            this.buttonSellBook.UseVisualStyleBackColor = true;
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
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(381, 73);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(237, 147);
            this.listBoxData.TabIndex = 9;
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
            this.groupBoxProgram.Controls.Add(this.listBoxData);
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
            this.Text = "Form1";
            this.groupBoxProgram.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Label labelLoginStatus;
        private System.Windows.Forms.GroupBox groupBoxProgram;
    }
}


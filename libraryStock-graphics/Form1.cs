using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ComicLibrary;

namespace libraryStock_graphics
{
    public partial class Form1 : Form
    {
        // Windows API for textbox placeholder text
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public Form1()
        {
            InitializeComponent();

            SendMessage(textboxUsername.Handle,
                EM_SETCUEBANNER, (IntPtr)1, "Username");

            SendMessage(textBoxPassword.Handle,
                EM_SETCUEBANNER, (IntPtr)1, "Password");

            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textboxUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginSystem login = new LoginSystem();

            string username = textboxUsername.Text;
            string password = textBoxPassword.Text;

            if (login.Login(username, password))
            {
                labelLoginStatus.Text = "Login successful!";
                labelLoginStatus.Visible = true;
                groupBoxProgram.Visible = true;
            }
            else
            {
                labelLoginStatus.Text = "Invalid username or password!";
                labelLoginStatus.Visible = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
using ComicLibrary;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace libraryStock_graphics
{
    public partial class Form1 : Form
    {
        // Windows API for textbox placeholder text
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int msg,
            IntPtr wParam,
            string lParam
        );

        private const int EM_SETCUEBANNER = 0x1501;

        // Path to the CSV file
        private readonly string filepath =
            @"C:\munkak\Github\csharp uj\libraryStock-graphics\libraryStock-ClassLibrary\bin\Debug\Comics.csv";

        // Repository used by the selling functionality
        private ComicRepo repo;

        public Form1()
        {
            InitializeComponent();

            SendMessage(
                textboxUsername.Handle,
                EM_SETCUEBANNER,
                (IntPtr)1,
                "Username"
            );

            SendMessage(
                textBoxPassword.Handle,
                EM_SETCUEBANNER,
                (IntPtr)1,
                "Password"
            );

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

        // LOGIN
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

        // EXIT
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // DISPLAY COMIC STOCK
        private void buttonStockCount_Click(object sender, EventArgs e)
        {
            listViewStock.Visible = !listViewStock.Visible;

            if (!listViewStock.Visible)
                return;

            ComicRepo stockRepo = new ComicRepo(filepath);

            listViewStock.Items.Clear();

            List<ComicStock> comics = stockRepo.GetAllComics();

            foreach (ComicStock comic in comics)
            {
                ListViewItem item = new ListViewItem(comic.ThemeName);

                item.SubItems.Add(comic.Price.ToString());
                item.SubItems.Add(comic.Stock.ToString());

                listViewStock.Items.Add(item);
            }
        }

        private void listViewStock_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }

        // DISPLAY TOTAL STOCK VALUE
        private void buttonStockValue_Click(object sender, EventArgs e)
        {
            listViewStockValue.Visible = !listViewStockValue.Visible;

            if (!listViewStockValue.Visible)
                return;

            ComicRepo stockRepo = new ComicRepo(filepath);

            listViewStockValue.Items.Clear();

            List<ComicStock> comics = stockRepo.GetAllComics();

            foreach (ComicStock comic in comics)
            {
                ListViewItem item = new ListViewItem(comic.ThemeName);

                item.SubItems.Add(comic.TotalValue().ToString());

                listViewStockValue.Items.Add(item);
            }
        }

        // SHOW OR HIDE THE SELLING CONTROLS
        private void buttonSellBook_Click(object sender, EventArgs e)
        {
            comboBoxRegister.Visible = !comboBoxRegister.Visible;
            buttonRegisterSell.Visible = !buttonRegisterSell.Visible;

            labelSoldComic.Visible = false;

            if (comboBoxRegister.Visible)
            {
                LoadComicsIntoComboBox();
            }
        }

        // LOAD COMIC NAMES INTO THE COMBOBOX
        private void LoadComicsIntoComboBox()
        {
            try
            {
                repo = new ComicRepo(filepath);

                string selectedComic =
                    comboBoxRegister.SelectedItem?.ToString();

                comboBoxRegister.Items.Clear();

                foreach (ComicStock comic in repo.GetAllComics())
                {
                    comboBoxRegister.Items.Add(comic.ThemeName);
                }

                // Restore the selection if it still exists
                if (selectedComic != null &&
                    comboBoxRegister.Items.Contains(selectedComic))
                {
                    comboBoxRegister.SelectedItem = selectedComic;
                }
                else
                {
                    comboBoxRegister.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load comics:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // SELL ONE COPY OF THE SELECTED COMIC
        private void buttonRegisterSell_Click(object sender, EventArgs e)
        {
            if (comboBoxRegister.SelectedItem == null)
            {
                MessageBox.Show("Please select a comic first!");
                return;
            }

            string selectedComic =
                comboBoxRegister.SelectedItem.ToString();

            try
            {
                // Reload the latest data before selling
                repo = new ComicRepo(filepath);

                bool sold = repo.SellComic(selectedComic);

                if (sold)
                {
                    labelSoldComic.Text =
                        selectedComic + " sold successfully!";

                    labelSoldComic.Visible = true;

                    // Refresh the ComboBox and keep the selection
                    LoadComicsIntoComboBox();

                    comboBoxRegister.SelectedItem = selectedComic;

                    // Refresh stock displays if they are visible
                    RefreshStockDisplays();
                }
                else
                {
                    labelSoldComic.Text =
                        selectedComic + " is out of stock!";

                    labelSoldComic.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not sell the comic:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // REFRESH STOCK LISTS AFTER A SALE
        private void RefreshStockDisplays()
        {
            ComicRepo stockRepo = new ComicRepo(filepath);
            List<ComicStock> comics = stockRepo.GetAllComics();

            if (listViewStock.Visible)
            {
                listViewStock.Items.Clear();

                foreach (ComicStock comic in comics)
                {
                    ListViewItem item =
                        new ListViewItem(comic.ThemeName);

                    item.SubItems.Add(comic.Price.ToString());
                    item.SubItems.Add(comic.Stock.ToString());

                    listViewStock.Items.Add(item);
                }
            }

            if (listViewStockValue.Visible)
            {
                listViewStockValue.Items.Clear();

                foreach (ComicStock comic in comics)
                {
                    ListViewItem item =
                        new ListViewItem(comic.ThemeName);

                    item.SubItems.Add(comic.TotalValue().ToString());

                    listViewStockValue.Items.Add(item);
                }
            }
        }

        private void buttonTotalStockStatus_Click(object sender, EventArgs e)
        {
            groupBoxStockStatus.Visible = !groupBoxStockStatus.Visible;

            if (!groupBoxStockStatus.Visible)
                return;
            string filepath = @"C:\munkak\Github\csharp uj\libraryStock-graphics\libraryStock-ClassLibrary\bin\Debug\Comics.csv";
            ComicRepo repo = new ComicRepo(filepath);
            List<ComicStock> comics = repo.GetAllComics();
            int totalStock = 0;
            foreach (ComicStock comic in comics)
            {
                totalStock += comic.Stock;
            }
            string status;
            if (totalStock > 5000)
            {
                status = "Over";
            }
            else if (totalStock > 1500)
            {
                status = "Normal";
            }
            else if (totalStock >= 1000)
            {
                status = "Low";
            }
            else
            {
                status = "Very Low";
            }

            labelStockNumber.Text = "Total stock: " + totalStock;
            labelStockStatusText.Text = "Stock status: " + status;

        }

        private void labelStockNumber_Click(object sender, EventArgs e)
        {

        }

        private void labelStockStatusText_Click(object sender, EventArgs e)
        {

        }
    }
}
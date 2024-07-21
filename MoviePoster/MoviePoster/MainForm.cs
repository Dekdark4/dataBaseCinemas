using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MoviePoster
{
    /// <summary>
    /// Main form for this application
    /// </summary>
    public partial class MainForm : Form
    {   
        private SqlConnection sqlConnection = null;

        /// <summary>
        /// Constructor for the main form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to hide the current form and show another one
        /// </summary>
        /// <param name="form"></param>
        private void ShowForm(Form form)
        {
            this.Hide();
            form.Show();
        }

        /// <summary>
        /// Method to exit from the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseConnection.Instance.CloseConnection();

            if (DatabaseConnection.Instance.Connection.State == ConnectionState.Closed)
                MessageBox.Show("SQL CONNECTION is closed successfully!");

            Application.Exit();
        }

        /// <summary>
        /// It opens SEARCH form and closes a current one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            ShowForm(new SearchForm());
        }

        /// <summary>
        /// It opens CINEMAS form and closes a current one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCinemas_Click(object sender, EventArgs e)
        {
            ShowForm(new CinemasForm());
        }

        /// <summary>
        /// It opens MOVIES form and closes a current one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowMovies_Click(object sender, EventArgs e)
        {
            ShowForm(new MoviesForm());
        }

        /// <summary>
        /// It opens CARTOONS form and closes a current one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCartoons_Click(object sender, EventArgs e)
        {
            ShowForm(new CartoonsForm());
        }

        /// <summary>
        /// It opens PRIVATE SESSIONS form and closes a current one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowSessions_Click(object sender, EventArgs e)
        {
            ShowForm(new SessionsForm());
        }

        /// <summary>
        /// Method that appears during the application loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = DatabaseConnection.Instance.Connection;

            if (sqlConnection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Подключение не установлено, возникла ошибка.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePoster
{
    public partial class MoviesForm : Form
    {

        private SqlConnection sqlConnection = null;

        public MoviesForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            {
                return;
            }

            base.WndProc(ref m);
        }

        private void MoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void ConnectDatabase()
        {
            sqlConnection = DatabaseConnection.Instance.Connection;

            if (sqlConnection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Подключение не установлено, возникла ошибка.");
            }
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
            LoadMoviesData();
        }

        private void LoadMoviesData()
        {
            try
            {
                string query = "SELECT * FROM Movies";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgMovies.DataSource = dataTable;

                dgMovies.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addMovie()
        {
            try
            {
                string movieTitle = tbMovieTitle.Text;
                string movieYear = tbMovieYear.Text;
                string movieCountry = tbMovieCountry.Text;
                string movieGenre = tbMovieGenre.Text;
                string movieDirector = tbMovieDirector.Text;
                string movieAge = tbMovieAge.Text;
                string movieLength = tbMovieLength.Text;


                string query = "INSERT INTO Movies (Title, YearOfProduction, Country, Genre, Director, AgeRestrictions, TimeLength) VALUES (@Title, @YearOfProduction, @Country, @Genre, @Director, @AgeRestrictions, @TimeLength)";

                using (SqlCommand command =  new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Title", tbMovieTitle.Text);
                    command.Parameters.AddWithValue("@YearOfProduction", tbMovieYear.Text);
                    command.Parameters.AddWithValue("@Country", tbMovieCountry.Text);
                    command.Parameters.AddWithValue("@Genre", tbMovieGenre.Text);
                    command.Parameters.AddWithValue("@Director", tbMovieDirector.Text);
                    command.Parameters.AddWithValue("@AgeRestrictions", tbMovieAge.Text);
                    command.Parameters.AddWithValue("@TimeLength", tbMovieLength.Text);

                    int result = command.ExecuteNonQuery();
                    
                    if (result > 0)
                    {
                        MessageBox.Show("Фильм успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMoviesData();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления фильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckMoviesValidation()
        {
            return ValidationHelper.CheckTextFields(this, tbMovieTitle, tbMovieYear, tbMovieCountry, tbMovieGenre, tbMovieDirector, tbMovieAge, tbMovieLength);
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            if (!CheckMoviesValidation())
                return;

            addMovie();
        }

        private void ClearTextFields()
        {
            tbMovieTitle.Clear();
            tbMovieYear.Clear();
            tbMovieCountry.Clear();
            tbMovieGenre.Clear();
            tbMovieDirector.Clear();
            tbMovieAge.Clear();
            tbMovieLength.Clear();
        }

        private void dgMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgMovies.Rows[e.RowIndex];

                tbMovieTitle.Text = row.Cells["Title"].Value.ToString();
                tbMovieYear.Text = row.Cells["YearOfProduction"].Value.ToString();
                tbMovieCountry.Text = row.Cells["Country"].Value.ToString();
                tbMovieGenre.Text = row.Cells["Genre"].Value.ToString();
                tbMovieDirector.Text = row.Cells["Director"].Value.ToString();
                tbMovieAge.Text = row.Cells["AgeRestrictions"].Value.ToString();
                tbMovieLength.Text = row.Cells["TimeLength"].Value.ToString();
            }
        }

        private void btnMovieRemove_Click(object sender, EventArgs e)
        {
            if (!CheckMoviesValidation())
                return;

            RemoveMovie();
        }

        private void RemoveMovie()
        {
            try
            {
                int selectedRowIndex = dgMovies.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgMovies.Rows[selectedRowIndex];
                int movieID = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string query = "DELETE FROM Movies WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", movieID);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Фильм успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMoviesData();
                        ClearTextFields();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления фильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMovieRefresh_Click(object sender, EventArgs e)
        {
            LoadMoviesData();
        }

        private void btnMovieEdit_Click(object sender, EventArgs e)
        {
            if (!CheckMoviesValidation())
                return;

            EditMovie();
        }

        private void EditMovie()
        {
            if (dgMovies.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgMovies.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgMovies.Rows[selectedRowIndex];
                int movieId = (int)selectedRow.Cells["Id"].Value;

                try
                {
                    string query = "UPDATE Movies SET Title = @Title, YearOfProduction = @YearOfProduction, Country = @Country, Genre = @Genre, Director = @Director, AgeRestrictions = @AgeRestrictions, TimeLength = @TimeLength WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id", movieId);
                        command.Parameters.AddWithValue("@Title", tbMovieTitle.Text);
                        command.Parameters.AddWithValue("@YearOfProduction", tbMovieYear.Text);
                        command.Parameters.AddWithValue("@Country", tbMovieCountry.Text);
                        command.Parameters.AddWithValue("@Genre", tbMovieGenre.Text);
                        command.Parameters.AddWithValue("@Director", tbMovieDirector.Text);
                        command.Parameters.AddWithValue("@AgeRestrictions", tbMovieAge.Text);
                        command.Parameters.AddWithValue("@TimeLength", tbMovieLength.Text);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Данные фильма успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMoviesData();
                            ClearTextFields();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления данных фильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обновления данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

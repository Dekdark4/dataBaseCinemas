using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePoster
{
    public partial class SessionsForm : Form
    {

        private SqlConnection sqlConnection = null;
        private int selectedSessionId = -1;

        public SessionsForm()
        {
            InitializeComponent();
        }

        private void PrivateSessionsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LoadSessionsData()
        {
            LoadCinemas();
            LoadMovies();
            LoadCartoons();
            LoadSessions();
        }

        private void PrivateSessionsForm_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
            LoadSessionsData();
            UpdateComboBoxVisibility();
        }

        private void LoadCinemas()
        {
            try
            {
                string query = "SELECT Id, CinemaName FROM Cinemas";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                cbCinemas.DataSource = dataTable;
                cbCinemas.DisplayMember = "CinemaName";
                cbCinemas.ValueMember = "Id";
                cbCinemas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных кинотеатров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMovies()
        {
            try
            {
                string query = "SELECT Id, Title FROM Movies";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                cbMovies.DataSource = dataTable;
                cbMovies.DisplayMember = "Title";
                cbMovies.ValueMember = "Id";
                cbMovies.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных фильмов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCartoons()
        {
            try
            {
                string query = "SELECT Id, Title FROM Cartoons";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                cbCartoons.DataSource = dataTable;
                cbCartoons.DisplayMember = "Title";
                cbCartoons.ValueMember = "Id";
                cbCartoons.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных мультфильмов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSessions()
        {
            try
            {
                string query = @"
                                        SELECT s.Id, c.CinemaName, 
                                            CASE 
                                                    WHEN m.Title IS NOT NULL THEN m.Title 
                                                    ELSE crt.Title 
                                            END AS Title, s.SessionDate 
                                        FROM Sessions s
                                        JOIN Cinemas c ON s.Id_Cinema = c.Id
                                        LEFT JOIN Movies m ON s.Id_Movie = m.Id
                                        LEFT JOIN Cartoons crt ON s.Id_Cartoon = crt.Id";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgSessions.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных сеансов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateComboBoxVisibility()
        {
            if (checkBoxCartoons.Checked)
            {
                cbCartoons.Visible = true;
                cbCartoons.Enabled = true;

                cbMovies.Visible = false;
                cbMovies.Enabled = false;
            }
            else
            {
                cbCartoons.Visible = false;
                cbCartoons.Enabled = false;

                cbMovies.Visible = true;
                cbMovies.Enabled = true;
            }
        }

        private void btnSessionAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.AreComboBoxesValid(this, "cbCinemas"))
                return;

            if (!ValidationHelper.AreComboBoxesValid(this, checkBoxCartoons.Checked ? "cbCartoons" : "cbMovies"))
                return;

            AddSessionToDatabase();
        }

        private void AddSessionToDatabase()
        {
            try
            {
                string query = "INSERT INTO Sessions (Id_Cinema, Id_Movie, Id_Cartoon, SessionDate) VALUES (@Id_Cinema, @Id_Movie, @Id_Cartoon, @SessionDate)";

                using (SqlCommand command =  new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Id_Cinema", cbCinemas.SelectedValue);
                    command.Parameters.AddWithValue("@Id_Movie", cbMovies.Visible ? cbMovies.SelectedValue : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Id_Cartoon", cbCartoons.Visible ? cbCartoons.SelectedValue : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SessionDate", dtDateTime.Value);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Сеанс успешно добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSessions();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении сеанса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxCartoons_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComboBoxVisibility();
        }

        private void btnSessionRemove_Click(object sender, EventArgs e)
        {
            if (dgSessions.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgSessions.SelectedRows[0];
                int sessionId = Convert.ToInt32(row.Cells["Id"].Value);

                try
                {
                    string query = "DELETE FROM Sessions WHERE Id = @SessionId";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@SessionId", sessionId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Сеанс успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSessions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении сеанса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите всю строку для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSessionRefresh_Click(object sender, EventArgs e)
        {
            LoadSessions();
        }

        private void btnSessionEdit_Click(object sender, EventArgs e)
        {
            if (selectedSessionId != -1)
            {
                try
                {
                    string query = checkBoxCartoons.Checked ?
                        "UPDATE Sessions SET Id_Cinema = @Id_Cinema, Id_Cartoon = @Id_Cartoon, SessionDate = @SessionDate WHERE Id = @Id" :
                        "UPDATE Sessions SET Id_Cinema = @Id_Cinema, Id_Movie = @Id_Movie, SessionDate = @SessionDate WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id_Cinema", cbCinemas.SelectedValue);
                        command.Parameters.AddWithValue("@Id_Movie", cbMovies.Visible ? (object)cbMovies.SelectedValue : DBNull.Value);
                        command.Parameters.AddWithValue("@Id_Cartoon", cbCartoons.Visible ? (object)cbCartoons.SelectedValue : DBNull.Value);
                        command.Parameters.AddWithValue("@SessionDate", dtDateTime.Value);
                        command.Parameters.AddWithValue("@Id", selectedSessionId);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Сеанс успешно обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSessions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении сеанса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

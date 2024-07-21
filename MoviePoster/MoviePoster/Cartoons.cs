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
    public partial class CartoonsForm : Form
    {

        private SqlConnection sqlConnection = null;

        public CartoonsForm()
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

        private void CartoonsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CartoonsForm_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
            LoadCartoonsData();
        }

        private void LoadCartoonsData()
        {
            try
            {
                string query = "SELECT * FROM Cartoons";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgCartoons.DataSource = dataTable;

                dgCartoons.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCartoonsValidation()
        {
            return ValidationHelper.CheckTextFields(this, tbCartoonTitle, tbCartoonYear, tbCartoonCountry, tbCartoonGenre, tbCartoonDirector, tbCartoonAge, tbCartoonLength);
        }

        private void btnCartoonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckCartoonsValidation())
                return;

            AddCartoon();
        }

        private void AddCartoon()
        {
            try
            {
                string cartoonTitle = tbCartoonTitle.Text;
                string cartoonYear = tbCartoonYear.Text;
                string cartoonCountry = tbCartoonCountry.Text;
                string cartoonGenre = tbCartoonGenre.Text;
                string cartoonDirector = tbCartoonDirector.Text;
                string cartoonAge = tbCartoonAge.Text;
                string cartoonLength = tbCartoonLength.Text;

                string query = "INSERT INTO Cartoons (Title, YearOfProduction, Country, Genre, Director, AgeRestrictions, TimeLength) VALUES (@Title, @YearOfProduction, @Country, @Genre, @Director, @AgeRestrictions, @TimeLength)";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Title", tbCartoonTitle.Text);
                    command.Parameters.AddWithValue("@YearOfProduction", tbCartoonYear.Text);
                    command.Parameters.AddWithValue("@Country", tbCartoonCountry.Text);
                    command.Parameters.AddWithValue("@Genre", tbCartoonGenre.Text);
                    command.Parameters.AddWithValue("@Director", tbCartoonDirector.Text);
                    command.Parameters.AddWithValue("@AgeRestrictions", tbCartoonAge.Text);
                    command.Parameters.AddWithValue("@TimeLength", tbCartoonLength.Text);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Мультфильм успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCartoonsData();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления мультфильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextFields()
        {
            tbCartoonTitle.Clear();
            tbCartoonYear.Clear();
            tbCartoonCountry.Clear();
            tbCartoonGenre.Clear();
            tbCartoonDirector.Clear();
            tbCartoonAge.Clear();
            tbCartoonLength.Clear();
        }

        private void dgCartoons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgCartoons.Rows[e.RowIndex];

                tbCartoonTitle.Text = row.Cells["Title"].Value.ToString();
                tbCartoonYear.Text = row.Cells["YearOfProduction"].Value.ToString();
                tbCartoonCountry.Text = row.Cells["Country"].Value.ToString();
                tbCartoonGenre.Text = row.Cells["Genre"].Value.ToString();
                tbCartoonDirector.Text = row.Cells["Director"].Value.ToString();
                tbCartoonAge.Text = row.Cells["AgeRestrictions"].Value.ToString();
                tbCartoonLength.Text = row.Cells["TimeLength"].Value.ToString();
            }
        }

        private void btnCartoonRemove_Click(object sender, EventArgs e)
        {
            if (!CheckCartoonsValidation())
                return;

            RemoveCartoon();
        }

        private void RemoveCartoon()
        {
            try
            {
                int selectedRowIndex = dgCartoons.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgCartoons.Rows[selectedRowIndex];
                int cartoonID = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string query = "DELETE FROM Cartoons WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", cartoonID);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Мультфильм успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCartoonsData();
                        ClearTextFields();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления мультфильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCartoonRefresh_Click(object sender, EventArgs e)
        {
            LoadCartoonsData();
        }

        private void btnCartoonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckCartoonsValidation())
                return;

            EditCartoon();
        }

        private void EditCartoon()
        {
            if (dgCartoons.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgCartoons.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgCartoons.Rows[selectedRowIndex];
                int cartoonId = (int)selectedRow.Cells["Id"].Value;

                try
                {
                    string query = "UPDATE Cartoons SET Title = @Title, YearOfProduction = @YearOfProduction, Country = @Country, Genre = @Genre, Director = @Director, AgeRestrictions = @AgeRestrictions, TimeLength = @TimeLength WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id", cartoonId);
                        command.Parameters.AddWithValue("@Title", tbCartoonTitle.Text);
                        command.Parameters.AddWithValue("@YearOfProduction", tbCartoonYear.Text);
                        command.Parameters.AddWithValue("@Country", tbCartoonCountry.Text);
                        command.Parameters.AddWithValue("@Genre", tbCartoonGenre.Text);
                        command.Parameters.AddWithValue("@Director", tbCartoonDirector.Text);
                        command.Parameters.AddWithValue("@AgeRestrictions", tbCartoonAge.Text);
                        command.Parameters.AddWithValue("@TimeLength", tbCartoonLength.Text);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Данные мультфильма успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCartoonsData();
                            ClearTextFields();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления данных мультфильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

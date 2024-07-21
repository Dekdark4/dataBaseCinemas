using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MoviePoster
{
    public partial class CinemasForm : Form
    {

        private SqlConnection sqlConnection = null;

        public CinemasForm()
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

        private void CinemasForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CinemasForm_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
            LoadCinemasData();
        }

        private void LoadCinemasData()
        {
            try
            {
                string query = "SELECT * FROM Cinemas";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgCinemas.DataSource = dataTable;

                dgCinemas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCinemasValidation()
        {
            return ValidationHelper.CheckTextFields(this, tbCinemaName, tbCinemaAddress);
        }

        private void btnCinemaAdd_Click(object sender, EventArgs e)
        {
            if (!CheckCinemasValidation())
                return;

            AddCinema();
        }

        private void AddCinema()
        {
            try
            {
                string cinemaName = tbCinemaName.Text;
                string cinemaAddress = tbCinemaAddress.Text;
                string cinemaEmail = tbCinemaEmail.Text;
                string cinemaPhone = tbCinemaPhone.Text;

                string query = "INSERT INTO Cinemas (CinemaName, Address, Email, Phone) VALUES (@CinemaName, @Address, @Email, @Phone)";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@CinemaName", cinemaName);
                    command.Parameters.AddWithValue("@Address", cinemaAddress);
                    command.Parameters.AddWithValue("@Email", cinemaEmail);
                    command.Parameters.AddWithValue("@Phone", cinemaPhone);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Кинотеатр успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCinemasData();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления кинотеатра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCinemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgCinemas.Rows[e.RowIndex];

                tbCinemaName.Text = row.Cells["CinemaName"].Value.ToString();
                tbCinemaAddress.Text = row.Cells["Address"].Value.ToString();
                tbCinemaEmail.Text = row.Cells["Email"].Value.ToString();
                tbCinemaPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void btnCinemaRemove_Click(object sender, EventArgs e)
        {
            if (!CheckCinemasValidation())
                return;

            RemoveCinema();
        }

        private void RemoveCinema()
        {
            try
            {
                int selectedRowIndex = dgCinemas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgCinemas.Rows[selectedRowIndex];
                int cinemaID = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string query = "DELETE FROM Cinemas WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", cinemaID);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Кинотеатр успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCinemasData();
                        ClearTextFields();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления кинотеатра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextFields()
        {
            tbCinemaName.Clear();
            tbCinemaAddress.Clear();
            tbCinemaEmail.Clear();
            tbCinemaPhone.Clear();
        }

        private void btnCinemaRefresh_Click(object sender, EventArgs e)
        {
            LoadCinemasData();
        }

        private void btnCinemaEdit_Click(object sender, EventArgs e)
        {
            if (!CheckCinemasValidation())
                return;

            EditCinema();
        }

        private void EditCinema()
        {
            if (dgCinemas.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgCinemas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgCinemas.Rows[selectedRowIndex];
                int cinemaId = (int)selectedRow.Cells["Id"].Value;

                try
                {
                    string query = "UPDATE Cinemas SET CinemaName = @CinemaName, Address = @Address, Email = @Email, Phone = @Phone WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id", cinemaId);
                        command.Parameters.AddWithValue("@CinemaName", tbCinemaName.Text);
                        command.Parameters.AddWithValue("@Address", tbCinemaAddress.Text);
                        command.Parameters.AddWithValue("@Email", tbCinemaEmail.Text);
                        command.Parameters.AddWithValue("@Phone", tbCinemaPhone.Text);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Данные кинотеатра успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCinemasData();
                            ClearTextFields();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления данных кинотеатра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
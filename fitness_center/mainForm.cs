using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fitness_center
{
    public partial class mainForm : Form
    {
        private string connectionString = "server=localhost;user=root;password=root;database=mydb;";
        private MySqlConnection connection;

        public mainForm()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private string currentQuery;

        private void clients_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuery = "SELECT * FROM mydb.guest";
            LoadData(currentQuery);
        }

        private void tickets_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuery = "SELECT ticket_id AS 'id', ticket_name AS 'Тип', ticket_price AS 'Стоимость', ticket_condition AS 'Условия' FROM tickets";
            LoadData(currentQuery);
        }

        private void groups_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQuery = "SELECT gym_id AS 'id', gym_name AS 'Название', gym_date AS 'Дата', gym_start AS 'Начало', gym_end AS 'Конец' FROM gym";
            LoadData(currentQuery);
        }

        private void LoadData(string query)
        {
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                info_dataGridView.DataSource = dataTable;
                addButton.Visible = true;
                editButton.Visible = true;
                deleteButton.Visible = true;
                info_dataGridView.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void change_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorizationForm authorizationForm = new authorizationForm();
            this.Hide();
            authorizationForm.Show();
            authorizationForm.FormClosed += (s, args) => this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clients (client_name, client_number, ticket_start, ticket_end, tickets_ticket_id) VALUES (@name, @number, @start, @end, @ticketId)";
            ExecuteNonQuery(query, new { name = "Иван Иванов", number = "123456789", start = "2023-01-01", end = "2023-12-31", ticketId = 1 });
            RefreshData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (info_dataGridView.SelectedRows.Count > 0)
            {
                int clientId = (int)info_dataGridView.SelectedRows[0].Cells["client_id"].Value;
                string query = "UPDATE clients SET client_name = @name, client_number = @number WHERE client_id = @id";
                ExecuteNonQuery(query, new { name = "Обновленное имя", number = "987654321", id = clientId });
                RefreshData();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (info_dataGridView.SelectedRows.Count > 0)
            {
                int clientId = (int)info_dataGridView.SelectedRows[0].Cells["client_id"].Value;
                string query = "DELETE FROM clients WHERE client_id = @id";
                ExecuteNonQuery(query, new { id = clientId });
                RefreshData();
            }
        }

        private void ExecuteNonQuery(string query, object parameters)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    foreach (var param in (IDictionary<string, object>)parameters)
                    {
                        cmd.Parameters.AddWithValue($"@{param.Key}", param.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void RefreshData()
        {
            if (!string.IsNullOrEmpty(currentQuery))
            {
                LoadData(currentQuery);
            }
        }
    }
}

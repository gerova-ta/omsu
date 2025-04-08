using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fitness_center
{
    public partial class adminForm : Form
    {
        private string connectionString = "server=localhost;user=root;password=root;database=fitness;";

        public adminForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string login = login_AdminTextBox.Text;
            string password = password_AdminTextBox.Text; 

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля 'Логин' и 'Пароль' обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM users WHERE user_login = @login";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@login", login);
                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO users (user_role, user_login, user_password, is_blocked) VALUES (@role, @login, @password, 0)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@role", "Менеджер");
                    insertCmd.Parameters.AddWithValue("@login", login);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Менеджер успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении менеджера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            string login = login_AdminTextBox.Text;

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Поле 'Логин' обязательно для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string unlockQuery = "UPDATE users SET is_blocked = 0 WHERE user_login = @login AND user_role = 'Менеджер'";
                using (MySqlCommand unlockCmd = new MySqlCommand(unlockQuery, conn))
                {
                    unlockCmd.Parameters.AddWithValue("@login", login);

                    try
                    {
                        int rowsAffected = unlockCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Менеджер успешно разблокирован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Менеджер с указанным логином не найден или не заблокирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Ошибка при разблокировке менеджера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string login = login_AdminTextBox.Text;

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Поле 'Логин' обязательно для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM users WHERE user_login = @login AND user_role = 'Менеджер'";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@login", login);

                    try
                    {
                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Менеджер успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Менеджер с указанным логином не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Ошибка при удалении менеджера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

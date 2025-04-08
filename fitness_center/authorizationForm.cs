using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fitness_center
{
    public partial class authorizationForm : Form
    {
        private string connectionString = "server=localhost;user=root;password=root;database=fitness;";
        private int failedAttempts = 0;

        public authorizationForm()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string login = login_textBox.Text;
            string password = password_textBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля 'Логин' и 'Пароль' обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_id, user_role, user_login, user_password, is_blocked FROM users WHERE user_login = @login";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isBlocked = reader.GetBoolean("is_blocked");
                            if (isBlocked)
                            {
                                MessageBox.Show("Вы заблокированы. Обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string storedPassword = reader.GetString("user_password");
                            if (storedPassword == password)
                            {
                                string role = reader.GetString("user_role");
                                MessageBox.Show("Вы успешно авторизовались.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;

                                if (role == "Администратор")
                                {
                                    adminForm adminForm = new adminForm();
                                    this.Hide();
                                    adminForm.Show();
                                    adminForm.FormClosed += (s, args) => this.Close();
                                }
                                else if (role == "Менеджер")
                                {
                                    mainForm mainForm = new mainForm();
                                    this.Hide();
                                    mainForm.Show();
                                    mainForm.FormClosed += (s, args) => this.Close();
                                }
                            }
                            else
                            {
                                failedAttempts++;
                                if (failedAttempts >= 3)
                                {
                                    reader.Close(); 
                                    string blockQuery = "UPDATE users SET is_blocked = 1 WHERE user_login = @login";
                                    using (MySqlCommand blockCmd = new MySqlCommand(blockQuery, conn))
                                    {
                                        blockCmd.Parameters.AddWithValue("@login", login);
                                        blockCmd.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            failedAttempts++;
                            if (failedAttempts >= 3)
                            {
                                reader.Close();
                                string blockQuery = "UPDATE users SET is_blocked = 1 WHERE user_login = @login";
                                using (MySqlCommand blockCmd = new MySqlCommand(blockQuery, conn))
                                {
                                    blockCmd.Parameters.AddWithValue("@login", login);
                                    blockCmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Вы заблокированы. Обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
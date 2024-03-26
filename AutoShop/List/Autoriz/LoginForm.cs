using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AutoShop.List.Autoriz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=AutoShop;Integrated Security=True;";
            // Проверка, существует ли такой же username в базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM client WHERE name = @name";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", nameBox.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        /*
                        // Если существует запись с таким username, выведите сообщение об ошибке
                        error.Text = "Имя занято";
                        Username.ForeColor = Color.Red;
                        error.ForeColor = Color.Black;
                        */
                    }
                    else
                    {
                        // Если такого username нет, продолжайте с добавлением записи в базу данных
                        string query = "INSERT INTO client (name, password, email) VALUES (@name, @password, @email)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", nameBox.Text);
                            command.Parameters.AddWithValue("@email", emailBox.Text);
                            command.Parameters.AddWithValue("@password", passwordBox.Text);

                            command.ExecuteNonQuery();
                            /*
                            notification.Close();
                            Properties.Settings.Default.succes = "Регистрация успешна!";
                            Properties.Settings.Default.Save();
                            Succes succes = new Succes();
                            succes.Show();
                            */

                            List.Autoriz.LoginForm login = new List.Autoriz.LoginForm();
                            this.Close();
                            login.Show();
                            /*
                            error.Text = "Регистрация успешна!";
                            error.ForeColor = Color.Green;
                            Password.ForeColor = Color.Black;
                            Username.ForeColor = Color.Black;
                            */
                        }
                    }
                }
            }
        }
    }
}

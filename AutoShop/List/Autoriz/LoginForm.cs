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
                        // имя занято
                        MessageBox.Show("Имя занято");
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

                            // успешно
                            MessageBox.Show("Регистрация успешна");

                            /*
                            List.Autoriz.RegistrationForm registr = new List.Autoriz.RegistrationForm();
                            this.Hide();
                            registr.Show();
                               */
                        }
                    }
                }
                connection.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sverBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool isDragging = false;
        private Point offset;
        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = new Point(e.X, e.Y);
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;
                this.Location = newLocation;
            }
        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            List.Autoriz.RegistrationForm registr = new List.Autoriz.RegistrationForm();
            this.Hide();
            registr.Show();
        }
    }
}

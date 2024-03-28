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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AutoShop.List.Autoriz
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        void notify(string notifyText)
        {
            notifyIcon1.Icon = SystemIcons.Question; // car
            // notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "AutoShop";
            notifyIcon1.BalloonTipText = notifyText;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=AutoShop;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM client WHERE name = @name";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", nameBox.Text);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 1)
                    {
                        string passwordQuery = "SELECT password FROM client WHERE name = @name";
                        using (SqlCommand passwordCommand = new SqlCommand(passwordQuery, connection))
                        {
                            passwordCommand.Parameters.AddWithValue("@name", nameBox.Text);
                            string storedPassword = (string)passwordCommand.ExecuteScalar();

                            if (passwordBox.Text == storedPassword)
                            {
                                //успешный
                                notify("Успешный вход!");

                                FormMain main = new FormMain();
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                // неверный пароль
                                notify("Неверный пароль!");
                            }
                        }
                    }
                    else
                    {
                        // неверное имя
                        notify("Неверное имя!");
                    }
                }
            }
        }

        private void closeBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sverBtn1_Click(object sender, EventArgs e)
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

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            List.Autoriz.LoginForm login = new List.Autoriz.LoginForm();
            this.Hide();
            login.Show();
        }

        private void nameBox_MouseEnter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Username")
            {
                nameBox.Text = "";
            }
        }

        private void nameBox_MouseLeave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Username";
            }
        }

        private void passwordBox_MouseEnter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.Text = "";
            }
        }

        private void passwordBox_MouseLeave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Password";
            }
        }
    }
}

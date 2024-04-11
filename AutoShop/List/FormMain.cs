using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop.List
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            homeBtn_Click(sender, e);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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


        private void menuClose()
        {
            foreach (Control control in content.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                    break;
                }
            }
        }

        public void OpenForm<T>() where T : Form, new()
        {
            menuClose();
            T newForm = new T();
            newForm.TopLevel = false;
            newForm.Size = new Size(content.Width, content.Height);
            content.Controls.Add(newForm);
            newForm.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            OpenForm<List.Content.HomeForm>();
        }

        private void carsBtn_Click(object sender, EventArgs e)
        {
            OpenForm<List.Cars.CarListForm>();
        }

        private void acessBtn_Click(object sender, EventArgs e)
        {
            OpenForm<List.Content.AccessoriesForm>();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            OpenForm<List.Content.serviceForm>();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            OpenForm<List.Content.ordersForm>();
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            OpenForm<List.Content.ContactsForm>();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void scrit()
        {
            if (guna2Panel1.Width == 300)
            {
                guna2Panel1.Width = 112;
                homeBtn.BorderThickness = 1;
                carsBtn.BorderThickness = 1;
                acessBtn.BorderThickness = 1;
                serviceBtn.BorderThickness = 1;
                ordersBtn.BorderThickness = 1;
                contactBtn.BorderThickness = 1;
                userBtn.BorderThickness = 1;
                exitBtn.BorderThickness = 1;
            }
            else
            {
                guna2Panel1.Width = 300;
                homeBtn.BorderThickness = 0;
                carsBtn.BorderThickness = 0;
                acessBtn.BorderThickness = 0;
                serviceBtn.BorderThickness = 0;
                ordersBtn.BorderThickness = 0;
                contactBtn.BorderThickness = 0;
                userBtn.BorderThickness = 0;
                exitBtn.BorderThickness = 0;
            }
        }

        private void homePic_Click(object sender, EventArgs e)
        {
            scrit();
            OpenForm<List.Content.HomeForm>();
        }

        private void carsPic_Click(object sender, EventArgs e)
        {
            scrit();
            OpenForm<List.Cars.CarListForm>();
        }

        private void acessPic_Click(object sender, EventArgs e)
        {
            scrit();
            OpenForm<List.Content.AccessoriesForm>();
        }

        private void servicePic_Click(object sender, EventArgs e)
        {
            scrit();
            OpenForm<List.Content.serviceForm>();
        }

        private void ordersPic_Click(object sender, EventArgs e)
        {
            scrit();
            OpenForm<List.Content.ordersForm>();
        }

        private void contactPic_Click(object sender, EventArgs e)
        {
            scrit();
            OpenForm<List.Content.ContactsForm>();
        }

        private void userPic_Click(object sender, EventArgs e)
        {
            scrit();
        }
    }
}

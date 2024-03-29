using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}

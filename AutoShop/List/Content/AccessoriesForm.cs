using AutoShop.List.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop.List.Content
{
    public partial class AccessoriesForm : Form
    {
        public AccessoriesForm()
        {
            InitializeComponent();
        }

        private void AccessoriesForm_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++)
            {
                itemAccessories form = new itemAccessories();
                form.TopLevel = false;
                flowLayoutPanel1.Controls.Add(form);
                form.Show();
            }

        }

        private void guna2vTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}

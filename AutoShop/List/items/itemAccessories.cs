using AutoShop.DataSet1TableAdapters;
using AutoShop.List.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop.List.items
{
    public partial class itemAccessories : Form
    {
        public int itemId;

        public itemAccessories(string name, string price, string opis, byte[] picture, int id)
        {
            InitializeComponent();

            label1.Text = name;
            label3.Text = price;
            label2.Text = opis;
            using (MemoryStream ms = new MemoryStream(picture))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
            itemId = id;
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.itemAcceOr = itemId;
            Properties.Settings.Default.Save();
        }
    }
}

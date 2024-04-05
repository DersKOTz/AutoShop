using AutoShop.DataSet1TableAdapters;
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
        private int itemId;
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
            //MessageBox.Show(id.ToString());
            itemId = id;
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(itemId.ToString());
        }
    }
}

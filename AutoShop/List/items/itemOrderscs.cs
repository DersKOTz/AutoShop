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
    public partial class itemOrderscs : Form
    {
        private int itemId;
        public itemOrderscs(string name, string price, string opis, byte[] picture, int id)
        {
            InitializeComponent();

            label1.Text = name;
            label5.Text = price;
            label2.Text = opis;
            using (MemoryStream ms = new MemoryStream(picture))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
            //MessageBox.Show(id.ToString());
            itemId = id;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // -
            int minus = Convert.ToInt32(label4.Text);
            int result = 0;
            result = minus - 1;
            if (result != 0)
            {
                label4.Text = (result).ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // +
            int plus = Convert.ToInt32(label4.Text);
            int result = 0;
            result = plus + 1;
            label4.Text = (result).ToString();
        }
    }
}

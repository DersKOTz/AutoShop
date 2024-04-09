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

        private void itemAccessories_Load(object sender, EventArgs e)
        {
            korz();
        }

        private void korz()
        {
            string idAcceOr = Properties.Settings.Default.idAcceOr;
            string[] idArray = idAcceOr.Split(',');

            foreach (string idStr in idArray)
            {
                if (!string.IsNullOrEmpty(idStr)) // Проверяем, что строка не пустая
                {
                    if (int.TryParse(idStr, out int itemId1)) // Пробуем преобразовать строку в число
                    {
                        if (itemId == itemId1) // Сравниваем с целым числом
                        {
                            buyBtn.Text = "В корзине";
                        }
                    }
                }
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.itemAcceOr = itemId;
            Properties.Settings.Default.Save();
            if (buyBtn.Text == "Заказать")
            {
                korz();
            }
        }


    }
}

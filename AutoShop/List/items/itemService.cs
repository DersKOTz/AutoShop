using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop.List.items
{
    public partial class itemService : Form
    {
        public int itemId;
        public itemService(string name, string price, string opis, byte[] picture, int id)
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

        private void itemService_Load(object sender, EventArgs e)
        {
            korz();
        }

        private void korz()
        {
            string idServOr = Properties.Settings.Default.idServOr;
            string[] idArray = idServOr.Split(',');

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
            Properties.Settings.Default.itemServOr = itemId;
            Properties.Settings.Default.Save();
            if (buyBtn.Text == "Заказать")
            {
                korz();
            }
        }


    }
}

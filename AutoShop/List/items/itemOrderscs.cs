using AutoShop.List.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


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

        private void minusTov()
        {
            string idAcceOr = Properties.Settings.Default.idAcceOr;
            string[] idArray = idAcceOr.Split(',');
            bool found = false;

            for (int i = 0; i < idArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(idArray[i])) // Проверяем, что строка не пустая
                {
                    if (int.TryParse(idArray[i], out int itemId1)) // Пробуем преобразовать строку в число
                    {
                        if (itemId == itemId1) // Сравниваем с целым числом
                        {
                            found = true;
                            string[] newArray = new string[idArray.Length - 1];
                            int newIndex = 0;
                            for (int j = 0; j < idArray.Length; j++)
                            {
                                if (j != i)
                                {
                                    newArray[newIndex] = idArray[j];
                                    newIndex++;
                                }
                            }
                            Properties.Settings.Default.idAcceOr = string.Join(",", newArray);
                            Properties.Settings.Default.Save();
                            break;
                        }
                    }
                }
            }
        }



        ordersForm form = new ordersForm();

        public void col()
        {
            int plus = Convert.ToInt32(label4.Text);
            int result = 0;
            result = plus + 1;
            label4.Text = (result).ToString();
        }

        public void colm()
        {
            int minus = Convert.ToInt32(label4.Text);
            int result = 0;
            result = minus - 1;
            if (result != 0)
            {
                label4.Text = (result).ToString();
            }
            else if (result == 0)
            {
                minusTov();
                this.Hide();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // -
            colm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // +

            col();

        }
    }
}

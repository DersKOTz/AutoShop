using AutoShop.List.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;
using Microsoft.Office.Interop.Excel;


namespace AutoShop.List.items
{
    public partial class itemOrderscs : Form
    {
        public int itemId;
        private int money;
        public itemOrderscs(string name, string price, string opis, byte[] picture, int id, string brand, string dopCar)
        {
            InitializeComponent();

            label1.Text = $"{brand} {name}";
            label5.Text = price;
            label2.Text = opis + dopCar;
            itemId = id;
            money = int.Parse(label5.Text);




            using (MemoryStream ms = new MemoryStream(picture))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
        }


        private void itemOrderscs_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = "Ders";
        }

        private void MinusTov(string idList, string paramName)
        {
            string[] idArray = idList.Split(',');
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
                            Properties.Settings.Default[paramName] = string.Join(",", newArray);
                            Properties.Settings.Default.Save();
                            break;
                        }
                    }
                }
            }
        }

        private void MinusTovAcce()
        {
            MinusTov(Properties.Settings.Default.idAcceOr, "idAcceOr");
        }

        private void MinusTovServ()
        {
            MinusTov(Properties.Settings.Default.idServOr, "idServOr");
        }

        private void MinusTovCar()
        {
            MinusTov(Properties.Settings.Default.idCarOr, "idCarOr");
        }

        ordersForm form = new ordersForm();

        public void col()
        {
            int result = 0;
            result = Convert.ToInt32(label4.Text) + 1;
            label4.Text = (result).ToString();
            //

            int price = 0;
            price = int.Parse(label5.Text) + money;
            label5.Text = $"{(price).ToString()}";

            Properties.Settings.Default.colvoMoney += 1;
            Properties.Settings.Default.Save();
        }

        public void colm()
        {
            int minus = Convert.ToInt32(label4.Text);
            int result = 0;
            result = minus - 1;
            label5.Text = $"{(int.Parse(label5.Text) - money).ToString()}";

            if (result != 0)
            {
                label4.Text = (result).ToString();
            }
            else if (result == 0)
            {
                MinusTovServ();
                MinusTovAcce();
                MinusTovCar();
                this.Hide();
            }
            Properties.Settings.Default.colvoMoney += 1;
            Properties.Settings.Default.Save();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            colm(); // minus
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            col(); // plus
        }


    }
}

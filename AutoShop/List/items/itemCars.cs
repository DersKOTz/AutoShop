﻿using AutoShop.List.Cars;
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
    public partial class itemCars : Form
    {
        public int itemId;
        public itemCars(string name, string price, string brand, byte[] picture, int id, string maxSpeed, string do100Speed, string power)
        {
            InitializeComponent();

            label1.Text = name;
            label2.Text = brand;
            label3.Text = price;
            label6.Text = $"0-100 км/ч\r\n{do100Speed} сек";
            label7.Text = $"{maxSpeed} км/ч\r\nмакс";
            label8.Text = $"{power} ЛС";

            using (MemoryStream ms = new MemoryStream(picture))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
            itemId = id;
        }

        private void itemCars_Load(object sender, EventArgs e)
        {
            korz();
        }

        private void korz()
        {
            string idAcceOr = Properties.Settings.Default.idCarOr;
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
            Properties.Settings.Default.car = itemId;
            Properties.Settings.Default.Save();
        }
    }
}

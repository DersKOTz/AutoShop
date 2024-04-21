using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop.List.Cars
{
    public partial class CarForm : Form
    {
        public int itemId;
        public string color1;
        public string interier1;
        public string wheel1;

        public CarForm(string name, string price, string brand, byte[] picture, int id,
                       string maxSpeed, string do100Speed, string power, string color,
                       string wheel, string interior, string body, string engineFuel, string gearbox, string privod)
        {
            InitializeComponent();
            label1.Text = $"{brand} {name}";
            label2.Text = $"0-100 км/ч\r\n{do100Speed} сек";
            label3.Text = $"{maxSpeed} км/ч\r\nмакс";
            label4.Text = $"{power} ЛС";

            label12.Text = $"{price} ₽";
            label8.Text = $"{body}";
            label9.Text = $"{engineFuel}";
            label10.Text = $"{gearbox}";
            label11.Text = $"{privod}";
            color1 = color;
            colorBody();

            interier1 = interior;
            colorInterier();

            wheel1 = wheel;
            wheels();

            using (MemoryStream ms = new MemoryStream(picture))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
            itemId = id;
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            korz();
        }

        private void colorBody()
        {
            string[] colorSets = color1.Split(',');
            for (int i = 0; i < colorSets.Length; i++)
            {
                string[] rgbValues = colorSets[i].Trim().Split(';');
                if (rgbValues.Length == 3)
                {
                    int red = int.Parse(rgbValues[0]);
                    int green = int.Parse(rgbValues[1]);
                    int blue = int.Parse(rgbValues[2]);
                    Color color = Color.FromArgb(red, green, blue);
                    switch (i)
                    {
                        case 0:
                            guna2CircleButton1.FillColor = color;
                            guna2CircleButton1.Visible = true;
                            break;
                        case 1:
                            guna2CircleButton2.FillColor = color;
                            guna2CircleButton2.Visible = true;
                            break;
                        case 2:
                            guna2CircleButton3.FillColor = color;
                            guna2CircleButton3.Visible = true;
                            break;
                        case 3:
                            guna2CircleButton4.FillColor = color;
                            guna2CircleButton4.Visible = true;
                            break;
                        case 4:
                            guna2CircleButton5.FillColor = color;
                            guna2CircleButton5.Visible = true;
                            break;
                    }
                }
            }

        }

        private void colorInterier()
        {
            string[] colorSets = interier1.Split(',');
            for (int i = 0; i < colorSets.Length; i++)
            {
                string[] rgbValues = colorSets[i].Trim().Split(';');
                if (rgbValues.Length == 3)
                {
                    int red = int.Parse(rgbValues[0]);
                    int green = int.Parse(rgbValues[1]);
                    int blue = int.Parse(rgbValues[2]);
                    Color color = Color.FromArgb(red, green, blue);
                    switch (i)
                    {
                        case 0:
                            guna2CircleButton9.FillColor = color;
                            guna2CircleButton9.Visible = true;
                            break;
                        case 1:
                            guna2CircleButton10.FillColor = color;
                            guna2CircleButton10.Visible = true;
                            break;
                        case 2:
                            guna2CircleButton11.FillColor = color;
                            guna2CircleButton11.Visible = true;
                            break;
                        case 3:
                            guna2CircleButton12.FillColor = color;
                            guna2CircleButton12.Visible = true;
                            break;
                        case 4:
                            guna2CircleButton13.FillColor = color;
                            guna2CircleButton13.Visible = true;
                            break;
                    }
                }
            }
        }

        public void wheels()
        {
            string[] wheelSet = wheel1.Split(',');
            for (int i = 0; i < wheelSet.Length; i++)
            {
                if (wheelSet[i] == "Зима") // Compare individual element of wheelSet
                {
                    guna2CircleButton6.Visible = true;
                }
                else if (wheelSet[i] == " Лето") // Compare individual element of wheelSet
                {
                    guna2CircleButton7.Visible = true;
                }
                else if (wheelSet[i] == " Всесезон") // Compare individual element of wheelSet
                {
                    guna2CircleButton8.Visible = true;
                }
            }
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

                            if (label8.Text != "")
                            {
                                CarDatabase database = new CarDatabase("Data Source=MyDatabase.db;Version=3;");
                                database.SaveCar(itemId.ToString(), label1.Text, Properties.Settings.Default.colorCar.Name, Properties.Settings.Default.wheelCar, Properties.Settings.Default.colorInterierCar.Name);
                            }
                        }
                    }
                }
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (buyBtn.Text == "Заказать")
            {
                Properties.Settings.Default.itemCarOr = itemId;
                Properties.Settings.Default.car = itemId;
                Properties.Settings.Default.Save();
                korz();
            }

        }




        public void colorBtn(Guna.UI2.WinForms.Guna2CircleButton btn)
        {
            Color borderColor = Color.FromArgb(195, 195, 195);
            int borderThickness = 1;

            foreach (var button in new[] { guna2CircleButton1, guna2CircleButton2, guna2CircleButton3, guna2CircleButton4, guna2CircleButton5 })
            {
                button.BorderColor = borderColor;
                button.BorderThickness = borderThickness;
            }
            btn.BorderColor = Color.Black;
            btn.BorderThickness = 2;
        }

        // color
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorCar = guna2CircleButton1.FillColor;
            Properties.Settings.Default.Save();
            colorBtn(guna2CircleButton1);

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorCar = guna2CircleButton2.FillColor;
            Properties.Settings.Default.Save();
            colorBtn(guna2CircleButton2);
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorCar = guna2CircleButton3.FillColor;
            Properties.Settings.Default.Save();
            colorBtn(guna2CircleButton3);
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorCar = guna2CircleButton4.FillColor;
            Properties.Settings.Default.Save();
            colorBtn(guna2CircleButton4);
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorCar = guna2CircleButton5.FillColor;
            Properties.Settings.Default.Save();
            colorBtn(guna2CircleButton5);
        }

        public void wheelBtn(Guna.UI2.WinForms.Guna2CircleButton btn)
        {
            Color borderColor = Color.FromArgb(195, 195, 195);
            int borderThickness = 1;

            foreach (var button in new[] { guna2CircleButton6, guna2CircleButton7, guna2CircleButton8 })
            {
                button.BorderColor = borderColor;
                button.BorderThickness = borderThickness;
            }
            btn.BorderColor = Color.Black;
            btn.BorderThickness = 2;
        }

        // wheel
        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wheelCar = "Зима";
            Properties.Settings.Default.Save();
            wheelBtn(guna2CircleButton6);
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wheelCar = "Лето";
            Properties.Settings.Default.Save();
            wheelBtn(guna2CircleButton7);
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wheelCar = "Всесезон";
            Properties.Settings.Default.Save();
            wheelBtn(guna2CircleButton8);
        }

        public void colorInterierBtn(Guna.UI2.WinForms.Guna2CircleButton btn)
        {
            Color borderColor = Color.FromArgb(195, 195, 195);
            int borderThickness = 1;

            foreach (var button in new[] { guna2CircleButton9, guna2CircleButton10, guna2CircleButton11, guna2CircleButton12, guna2CircleButton13 })
            {
                button.BorderColor = borderColor;
                button.BorderThickness = borderThickness;
            }
            btn.BorderColor = Color.Black;
            btn.BorderThickness = 2;
        }
        // interier
        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorInterierCar = guna2CircleButton9.FillColor;
            Properties.Settings.Default.Save();
            colorInterierBtn(guna2CircleButton9);
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorInterierCar = guna2CircleButton10.FillColor;
            Properties.Settings.Default.Save();
            colorInterierBtn(guna2CircleButton10);
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorInterierCar = guna2CircleButton11.FillColor;
            Properties.Settings.Default.Save();
            colorInterierBtn(guna2CircleButton11);
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorInterierCar = guna2CircleButton12.FillColor;
            Properties.Settings.Default.Save();
            colorInterierBtn(guna2CircleButton12);
        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorInterierCar = guna2CircleButton13.FillColor;
            Properties.Settings.Default.Save();
            colorInterierBtn(guna2CircleButton13);
        }
    }

}


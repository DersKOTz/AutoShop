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
                switch (i)
                {
                    case 0:
                        guna2CircleButton6.Visible = true;
                        break;
                    case 1:
                        guna2CircleButton7.Visible = true;
                        break;
                    case 2:
                        guna2CircleButton8.Visible = true;
                        break;
                }
            }
        }
    }

}


using AutoShop.DataSet1TableAdapters;
using AutoShop.List.items;
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

namespace AutoShop.List.Content
{
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += Settings_PropertyChanged;
        }

        DataSet1 dataSet1 = new DataSet1();

        private void ordersForm_Load(object sender, EventArgs e)
        {
            acceso();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.VerticalScroll.Visible = false;

        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ordersColvo")
            {

            }
        }


        private void acceso()
        {
            string idAcceOr = Properties.Settings.Default.idAcceOr;
            string[] idArray = idAcceOr.Split(','); // Разделяем строку по запятым
            tovarsTableAdapter1.Fill(dataSet1.tovars);
            foreach (DataRow row in dataSet1.tovars.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string name = row["name"].ToString();
                string price = row["price"].ToString();
                string opis = row["opis"].ToString();
                byte[] picture = (byte[])row["picture"];

                foreach (string idStr in idArray)
                {
                    if (!string.IsNullOrEmpty(idStr)) // Проверяем, что строка не пустая
                    {
                        if (int.TryParse(idStr, out int itemId)) // Пробуем преобразовать строку в число
                        {
                            if (id == itemId) // Сравниваем с целым числом
                            {
                                itemOrderscs form = new itemOrderscs(name, price, opis, picture, itemId);
                                form.TopLevel = false;
                                flowLayoutPanel1.Controls.Add(form);
                                form.Show();
                                ksk();
                                break; // Выход из цикла, так как нужная запись уже найдена и загружена
                            }
                        }
                    }
                }
            }
        }

        public void ksk()
        {
            int sum = 0;

            // Предполагается, что у вас есть список форм itemOrderscs
            List<itemOrderscs> ordersFormsList = new List<itemOrderscs>();

            // Проход по всем формам и получение их значений label4.Text
            foreach (itemOrderscs form1 in ordersFormsList)
            {
                string sts = form1.label4.Text;
                // Получение значения из label4.Text и преобразование его в число
                if (int.TryParse(form1.label4.Text, out int value))
                {
                    // Добавление значения к общей сумме
                    sum += value;
                }
            }

            // Отображение суммы в label1.Text формы OrdersForm
            label2.Text = sum.ToString();
        }
        private void car()
        {

        }
    }
}



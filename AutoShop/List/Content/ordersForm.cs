using AutoShop.DataSet1TableAdapters;
using AutoShop.List.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet1 = new DataSet1();

            tovarsTableAdapter1.Fill(dataSet1.tovars);
            foreach (DataRow row in dataSet1.tovars.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string name = row["name"].ToString();
                string price = row["price"].ToString();
                string opis = row["opis"].ToString();
                byte[] picture = (byte[])row["picture"];

                if (id == 4) // замените нужный_id на фактический id, который вам нужен
                {
                    itemOrderscs form = new itemOrderscs(name, price, opis, picture, id);
                    form.TopLevel = false;
                    flowLayoutPanel1.Controls.Add(form);
                    form.Show();
                    break; // Выход из цикла, так как нужная запись уже найдена и загружена
                }
            }
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.VerticalScroll.Visible = false;
        }
    }
}

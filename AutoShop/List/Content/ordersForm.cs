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
            Properties.Settings.Default.Save();
        }

        DataSet1 dataSet1 = new DataSet1();

        private void ordersForm_Load(object sender, EventArgs e)
        {
            acceso();
            service();
            moneyAndColvo();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.VerticalScroll.Visible = false;

            Properties.Settings.Default.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "colvoMoney")
                {
                    Settings_PropertyChanged(sender, e);
                }
            };
        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "colvoMoney")
            {
                moneyAndColvo();
            }
        }

        private void FillData(string idList, string[] idArray, DataTable dataTable)
        {
            using (DataTableReader reader = new DataTableReader(dataTable))
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string name = reader["name"].ToString();
                    string price = reader["price"].ToString();
                    string opis = reader["opis"].ToString();
                    byte[] picture = (byte[])reader["picture"];

                    foreach (string idStr in idArray)
                    {
                        if (!string.IsNullOrEmpty(idStr) && int.TryParse(idStr, out int itemId) && id == itemId)
                        {
                            itemOrderscs form = new itemOrderscs(name, price, opis, picture, itemId);
                            form.TopLevel = false;
                            flowLayoutPanel1.Controls.Add(form);
                            form.Show();
                            break;
                        }
                    }
                }
            }
        }

        private void acceso()
        {
            string idAcceOr = Properties.Settings.Default.idAcceOr;
            string[] idArray = idAcceOr.Split(',');
            tovarsTableAdapter1.Fill(dataSet1.tovars);
            FillData(idAcceOr, idArray, dataSet1.tovars);
        }

        private void service()
        {
            string idAcceOr = Properties.Settings.Default.idServOr;
            string[] idArray = idAcceOr.Split(',');
            serviceTableAdapter1.Fill(dataSet1.service);
            FillData(idAcceOr, idArray, dataSet1.service);
        }


        public void moneyAndColvo()
        {
            int totalItems = 0;
            int totalMoney = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is itemOrderscs)
                {
                    itemOrderscs item = (itemOrderscs)control;
                    totalItems += int.Parse(item.label5.Text);
                    totalMoney += int.Parse(item.label4.Text);
                }
            }
            label2.Text = $"Товары: {totalMoney} шт. ";
            label3.Text = $"Итого: {totalItems.ToString()} Р. ";
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}



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
    public partial class serviceForm : Form
    {
        public serviceForm()
        {
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += Settings_PropertyChanged;
        }

        public List<int> itemIdList = new List<int>();

        private void serviceForm_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet1 = new DataSet1();
            serviceTableAdapter1.Fill(dataSet1.service);
            int countService = 0;
            countService = (int)dataSet1.service.Rows.Count;

            for (int i = 0; i < countService; i++)
            {
                itemService form = new itemService(
                    dataSet1.service.Rows[i]["name"].ToString(),
                    dataSet1.service.Rows[i]["price"].ToString(),
                    dataSet1.service.Rows[i]["opis"].ToString(),
                    (byte[])dataSet1.service.Rows[i]["picture"],
                    Convert.ToInt32(dataSet1.service.Rows[i]["id"])
                );
                form.TopLevel = false;
                flowLayoutPanel1.Controls.Add(form);
                form.Show();
            }
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.VerticalScroll.Visible = false;
        }

        public void addOrder()
        {
            int newItem = Properties.Settings.Default.itemServOr;
            if (!itemIdList.Contains(newItem))
            {
                itemIdList.Add(newItem);
                foreach (int itemId in itemIdList)
                {
                    // Проверяем, содержится ли itemId уже в idAcceOr
                    if (!Properties.Settings.Default.idServOr.Contains(itemId.ToString() + ","))
                    {
                        Properties.Settings.Default.idServOr += itemId.ToString() + ",";
                    }
                }
                Properties.Settings.Default.Save();
            }
            // Properties.Settings.Default.Reset();

        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "itemServOr")
            {
                addOrder();
            }
        }

    }
}

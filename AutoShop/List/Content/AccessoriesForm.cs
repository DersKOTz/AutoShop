using AutoShop.List.items;
using AutoShop.Properties;
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
    public partial class AccessoriesForm : Form
    {
        public AccessoriesForm()
        {
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += Settings_PropertyChanged;
        }

        public List<int> itemIdList = new List<int>();

        private void AccessoriesForm_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet1 = new DataSet1();
            tovarsTableAdapter1.Fill(dataSet1.tovars);
            int countTovars = 0;
            countTovars = (int)dataSet1.tovars.Rows.Count;

            for (int i = 0; i < countTovars; i++)
            {
                itemAccessories form = new itemAccessories(
                    dataSet1.tovars.Rows[i]["name"].ToString(),
                    dataSet1.tovars.Rows[i]["price"].ToString(),
                    dataSet1.tovars.Rows[i]["opis"].ToString(),
                    (byte[])dataSet1.tovars.Rows[i]["picture"],
                    Convert.ToInt32(dataSet1.tovars.Rows[i]["id"])
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
            int newItem = Properties.Settings.Default.itemAcceOr;
            if (!itemIdList.Contains(newItem))
            {
                itemIdList.Add(newItem);
                foreach (int itemId in itemIdList)
                {
                    if (!Properties.Settings.Default.idAcceOr.Contains(itemId.ToString() + ","))
                    {
                        Properties.Settings.Default.idAcceOr += itemId.ToString() + ",";
                    }
                }
                Properties.Settings.Default.Save();
            }
        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "itemAcceOr")
            {
                addOrder();
            }
        }
    }
}

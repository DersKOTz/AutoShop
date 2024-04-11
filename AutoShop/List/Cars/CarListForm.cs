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

namespace AutoShop.List.Cars
{
    public partial class CarListForm : Form
    {
        public CarListForm()
        {
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += Settings_PropertyChanged;
        }

        public List<int> itemIdList = new List<int>();
        private void CarListForm_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet1 = new DataSet1();
            carsTableAdapter1.Fill(dataSet1.cars);
            int countcars = 0;
            countcars = (int)dataSet1.cars.Rows.Count;

            for (int i = 0; i < countcars; i++)
            {
                itemCars form = new itemCars(
                    dataSet1.cars.Rows[i]["name"].ToString(),
                    dataSet1.cars.Rows[i]["price"].ToString(),
                    dataSet1.cars.Rows[i]["opis"].ToString(),
                    (byte[])dataSet1.cars.Rows[i]["picture"],
                    Convert.ToInt32(dataSet1.cars.Rows[i]["id"])
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
            int newItem = Properties.Settings.Default.itemCarOr;
            if (!itemIdList.Contains(newItem))
            {
                itemIdList.Add(newItem);
                foreach (int itemId in itemIdList)
                {
                    // Проверяем, содержится ли itemId уже в idAcceOr
                    if (!Properties.Settings.Default.idCarOr.Contains(itemId.ToString() + ","))
                    {
                        Properties.Settings.Default.idCarOr += itemId.ToString() + ",";
                    }
                }
                Properties.Settings.Default.Save();
            }
            // Properties.Settings.Default.Reset();
        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "itemCarOr")
            {
                addOrder();
            }
        }
    }
}

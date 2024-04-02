using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace AutoShop.List.Content
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet1 = new DataSet1();
            contactTableAdapter1.Fill(dataSet1.contact);
            if (dataSet1.contact.Rows.Count > 0)
            {
                string city = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["city"].ToString();
                label1.Text = $"Центральный офис в {city}";

                string phone = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["phone"].ToString();
                label2.Text = $"Телефон горячей линии: {phone}";

                string address = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["address"].ToString();
                label3.Text = $"{address}";

                string hourWork = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["hourWork"].ToString();
                string dayWork = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["dayWork"].ToString();
                string dayExit = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["dayExit"].ToString();
                label4.Text = $"График работы: {hourWork}, {dayWork}, выходной {dayExit}";

                string nameOrg = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["nameOrg"].ToString();
                label6.Text = $"{nameOrg}";

                string innKpp = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["innKpp"].ToString();
                label7.Text = $"ИНН/КПП: {innKpp}";

                string ogrn = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["ogrn"].ToString();
                label8.Text = $"ОГРН: {ogrn}";

                string nameBank = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["nameBank"].ToString();
                label9.Text = $"Название банка: {nameBank}";

                string rc = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["rc"].ToString();
                label10.Text = $"Расчетный счет: {rc}";

                string kc = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["kc"].ToString();
                label11.Text = $"Кор. счет: {kc}";

                string bic = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["bic"].ToString();
                label12.Text = $"БИК банка: {bic}";
            }
        }

        private void emailingBtn_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://e.mail.ru/compose/?mailto=valavin.kostya@gmail.com"}") { CreateNoWindow = true });
        }
    }
}

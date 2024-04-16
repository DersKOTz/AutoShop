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
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Windows.Forms.VisualStyles;


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
            car();
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
                    string opis = null;
                    if (dataTable.Columns.Contains("opis"))
                    {
                        opis = reader["opis"].ToString();
                    }

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

        private void car()
        {
            string idAcceOr = Properties.Settings.Default.idCarOr;
            string[] idArray = idAcceOr.Split(',');
            carsTableAdapter1.Fill(dataSet1.cars);
            FillData(idAcceOr, idArray, dataSet1.cars);
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
            label3.Text = $"Итого: {totalItems} Р. ";
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            kvitan();
        }


        private void kvitan()
        {
            contactTableAdapter1.Fill(dataSet1.contact);

            string fileName = "AutoShopOrders.xlsx";
            var date = DateOnly.FromDateTime(DateTime.Now);
            string sheetName = $"{date}";
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;

            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                // Проверяем существует ли файл
                if (!File.Exists(filePath))
                {
                    // Если файл не существует, создаем новый
                    workbook = excelApp.Workbooks.Add();
                    workbook.SaveAs(filePath);
                }
                else
                {
                    workbook = excelApp.Workbooks.Open(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
            }

            if (workbook != null)
            {
                Excel.Worksheet worksheet = null;

                // Проверяем существует ли лист "студенты"
                bool studentsSheetExists = false;
                foreach (Excel.Worksheet sheet in workbook.Sheets)
                {
                    if (sheet.Name == sheetName)
                    {
                        worksheet = sheet;
                        studentsSheetExists = true;
                        break;
                    }
                }

                // Если лист "студенты" не существует, создаем его
                if (!studentsSheetExists)
                {
                    worksheet = workbook.Sheets.Add();
                    worksheet.Name = sheetName;
                    workbook.Save(); // Сохраняем изменения в файле
                }

                if (worksheet != null)
                {
                    try
                    {
                        // Название 
                        string nameOrg = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["nameOrg"].ToString();
                        string innKpp = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["innKpp"].ToString();
                        Excel.Range rangeNameOrg = worksheet.Range["B2:M2"];
                        rangeNameOrg.Merge();
                        rangeNameOrg.Value = $"Поставщик: {nameOrg}, ИНН/КПП {innKpp}";
                        rangeNameOrg.Font.Size = 14;
                        rangeNameOrg.Font.Bold = true;

                        // Адресс и телефон
                        string address = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["address"].ToString();
                        string city = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["city"].ToString();
                        string phone = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["phone"].ToString();
                        string hourWork = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["hourWork"].ToString();
                        string dayWork = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["dayWork"].ToString();
                        string dayExit = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["dayExit"].ToString();
                        Excel.Range rangeAdress = worksheet.Range["C3:K4"];
                        rangeAdress.Merge();
                        rangeAdress.Value = $"{city}, {address}, тел. {phone}. График работы {hourWork}, {dayWork}, выходной {dayExit}";
                        rangeAdress.Font.Size = 11;
                        rangeAdress.WrapText = true;

                        // тов чек
                        Excel.Range rangeCheck = worksheet.Range["B6:M6"];
                        rangeCheck.Merge();
                        rangeCheck.Value = $"Товарный чек № А-1 от {date}";
                        rangeCheck.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        rangeCheck.Font.Size = 14;
                        rangeCheck.Font.Bold = true;

                        // адресс получения
                        Excel.Range rangeAdr = worksheet.Range["B8:M8"];
                        rangeAdr.Merge();
                        rangeAdr.Value = $"Адрес получения заказа: ";
                        rangeAdr.Font.Size = 11;

                        // таблица шапка
                        worksheet.Cells[10, 2].Value = "№";
                        worksheet.Cells[10, 3].Value = "Код";
                        Excel.Range rangeTov = worksheet.Range["D10:I10"];
                        rangeTov.Merge();
                        rangeTov.Value = "Наименование товара";
                        worksheet.Cells[10, 10].Value = "Цена";
                        worksheet.Cells[10, 11].Value = "Кол-во";
                        worksheet.Cells[10, 12].Value = "Скидка";
                        worksheet.Cells[10, 13].Value = "Сумма";

                        // формат таблицы
                        Excel.Range rangeOth = worksheet.Range["B10:M10"];
                        rangeOth.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        rangeOth.Font.Bold = true;

                        // вставка данных
                        int row = 11;
                        int number = 1;
                        foreach (Control control in flowLayoutPanel1.Controls)
                        {
                            if (control is itemOrderscs)
                            {
                                itemOrderscs item = (itemOrderscs)control;

                                // номер
                                worksheet.Cells[row, 2].Value = number;

                                // id
                                worksheet.Cells[row, 3].Value = item.itemId;

                                // имя
                                Excel.Range rangeTovar = worksheet.Range[worksheet.Cells[row, 4], worksheet.Cells[row, 9]];
                                rangeTovar.Merge();
                                rangeTovar.Value = $"{item.label1.Text}. {item.label2.Text}.";

                                // цена
                                worksheet.Cells[row, 10].Value = int.Parse(item.label5.Text) / int.Parse(item.label4.Text);

                                // кол-во
                                worksheet.Cells[row, 11].Value = item.label4.Text;

                                // скидка
                                worksheet.Cells[row, 12].Value = "0%";

                                // сумма
                                worksheet.Cells[row, 13].Value = item.label5.Text;

                                row++;
                                number++;


                            }
                        }

                    }
                    catch
                    {
                        workbook.Save();
                        workbook.Close();
                        excelApp.Quit();

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    }

                }

                workbook.Save();
                workbook.Close();
                excelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }

        private void info()
        {
            if (dataSet1.contact.Rows.Count > 0)
            {

                string ogrn = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["ogrn"].ToString();
                //label8.Text = $"ОГРН: {ogrn}";

                string nameBank = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["nameBank"].ToString();
                //label9.Text = $"Название банка: {nameBank}";

                string rc = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["rc"].ToString();
                //label10.Text = $"Расчетный счет: {rc}";

                string kc = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["kc"].ToString();
                //label11.Text = $"Кор. счет: {kc}";

                string bic = dataSet1.contact.Rows[dataSet1.contact.Rows.Count - 1]["bic"].ToString();
                //label12.Text = $"БИК банка: {bic}";
            }
        }
    }
}



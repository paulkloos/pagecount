using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlTypes;
using System.Data.OleDb;

namespace pagecount
{
    public partial class Form3 : Form
    {
        private DataTable printers;
        private string currentchart;
        private Form1 reference;
        private string start = DateTime.Now.Date.ToString();
        private string stop = DateTime.Now.Date.ToString();

        public Form3(Form1 refer)
        {
            InitializeComponent();
            reference = refer;
            updated_dataview();
            filename_textbox.Text = reference.filepath;
        }

        private void updated_dataview()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + reference.Getdb();
            OleDbDataAdapter dataAdapter;
            try
            {
                dataAdapter = new OleDbDataAdapter("select * from printer", connection);

                OleDbCommandBuilder command = new OleDbCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                printers = new DataTable();
                printers.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(printers);

                printers_listbox.DataSource = printers;
                printers_listbox.DisplayMember = "location";
                currentchart = printers.Rows[0].ItemArray.GetValue(0).ToString();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void writeCSV(string file)
        {
            try
            {
                IList<string> currentchart_array = currentchart.Split(',').ToList<string>();
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + reference.Getdb();
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT print_report.[ID], print_report.[printer_id], print_report.[overall_pagecount], print_report.[color_pagecount], print_report.[mono_pagecount], print_report.[date_time] FROM print_report WHERE print_report.[printer_id] = " + currentchart_array[0] + " and print_report.[overall_pagecount] > 0 and format(print_report.date_time,'mm/yyyy') >= format(#" + start + "#,'mm/yyyy') and format(print_report.date_time,'mm/yyyy') <= format(#" + stop + "#,'mm/yyyy');", connection);
                DataTable table = new DataTable();
                DataTable table2 = new DataTable();
                adapter.Fill(table);

                foreach (DataColumn col in table.Columns)
                    table2.Columns.Add(col.ToString());

                foreach (string chart in currentchart_array)
                {
                    table.Clear();
                    adapter = new OleDbDataAdapter("SELECT print_report.[ID], print_report.[printer_id], print_report.[overall_pagecount], print_report.[color_pagecount], print_report.[mono_pagecount], print_report.[date_time] FROM print_report WHERE print_report.[printer_id] = " + chart + " and print_report.[overall_pagecount] > 0 and format(print_report.date_time,'mm/yyyy') >= format(#" + start + "#,'mm/yyyy') and format(print_report.date_time,'mm/yyyy') <= format(#" + stop + "#,'mm/yyyy');", connection);
                    
                    adapter.Fill(table);

                    if (daily_radiobutton.Checked)
                    {//daily
                        DateTime date = start_datetimepicker.Value;
                        DateTime date2 = end_datetimepicker.Value;
                        int count = 0;
                        int last = 0;


                        for (int year = date.Year; year < date2.Year + 1; year++)
                        {
                            for (int month = date.Month; month < date2.Month + 1; month++)
                            {
                                if (date.Month != date2.Month)
                                {
                                    int day;
                                    if (month == date.Month)
                                        day = date.Day;
                                    else
                                        day = 1;

                                    count = last;
                                    for (; day < DateTime.DaysInMonth(date.Year, month) + 1 && DateTime.Parse(month + "/" + day + "/" + year) != DateTime.Parse(date2.Month + "/" + date2.Day + "/" + date2.Year); day++)
                                    {
                                        while (count < table.Rows.Count)
                                        {
                                            if (DateTime.Parse(table.Rows[count][5].ToString().Split(' ')[0]) == DateTime.Parse(month + "/" + day + "/" + year))
                                            {
                                                table2.Rows.Add(table.Rows[count].ItemArray);
                                                last = count + 1;
                                                break;
                                            }
                                            else
                                                count++;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int day = date.Day; day < date2.Day + 1; day++)
                                    {
                                        while (count < table.Rows.Count)
                                        {
                                            if (DateTime.Parse(table.Rows[count][5].ToString().Split(' ')[0]) == DateTime.Parse(month + "/" + day + "/" + year))
                                            {
                                                table2.Rows.Add(table.Rows[count].ItemArray);
                                                break;
                                            }
                                            else
                                                count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (weekly_radiobutton.Checked)
                    {//weekly
                        DateTime date = start_datetimepicker.Value;
                        DateTime date2 = end_datetimepicker.Value;
                        int count = 0;
                        int last = 0;

                        for (int year = date.Year; year < date2.Year + 1; year++)
                        {
                            for (int month = date.Month; month < date2.Month + 1; month++)
                            {
                                if (date.Month != date2.Month)
                                {
                                    int day;
                                    if (month == date.Month)
                                        day = date.Day;
                                    else
                                        day = 1;

                                    count = last;
                                    for (; day < DateTime.DaysInMonth(date.Year, month) + 1 && DateTime.Parse(month + "/" + day + "/" + year) != DateTime.Parse(date2.Month + "/" + date2.Day + "/" + date2.Year); day++)
                                    {//start looking at day of week, that the date range starts
                                        if (DateTime.Parse(month + "/" + day + "/" + year).DayOfWeek == date.DayOfWeek)
                                        {
                                            while (count < table.Rows.Count)
                                            {
                                                if (DateTime.Parse(table.Rows[count][5].ToString().Split(' ')[0]) == DateTime.Parse(month + "/" + day + "/" + year))
                                                {
                                                    table2.Rows.Add(table.Rows[count].ItemArray);
                                                    last = count + 1;
                                                    break;
                                                }
                                                else
                                                    count++;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int day = date.Day; day < date2.Day + 1; day++)
                                    {
                                        if (DateTime.Parse(month + "/" + day + "/" + year).DayOfWeek == DayOfWeek.Sunday)
                                        {
                                            while (count < table.Rows.Count)
                                            {
                                                if (DateTime.Parse(table.Rows[count][5].ToString().Split(' ')[0]) == DateTime.Parse(month + "/" + day + "/" + year))
                                                {
                                                    table2.Rows.Add(table.Rows[count].ItemArray);
                                                    break;
                                                }
                                                else
                                                    count++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (monthly_radiobutton.Checked)
                    {//monthly
                        DateTime date = start_datetimepicker.Value;
                        DateTime date2 = end_datetimepicker.Value;
                        int count = 0;
                        int last = 0;
                        bool found_first;

                        for (int year = date.Year; year < date2.Year + 1; year++)
                        {
                            for (int month = date.Month; month < date2.Month + 1; month++)
                            {
                                if (date.Month != date2.Month)
                                {
                                    int day;
                                    if (month == date.Month)
                                        day = date.Day;
                                    else
                                        day = 1;

                                    count = last;
                                    found_first = false;
                                    for (; day < DateTime.DaysInMonth(year, month) + 1 && !found_first && DateTime.Parse(month + "/" + day + "/" + year) != DateTime.Parse(date2.Month + "/" + date2.Day + "/" + date2.Year); day++)
                                    {
                                        while (count < table.Rows.Count)
                                        {
                                            if (DateTime.Parse(table.Rows[count][5].ToString().Split(' ')[0]) == DateTime.Parse(month + "/" + day + "/" + year))
                                            {
                                                table2.Rows.Add(table.Rows[count].ItemArray);
                                                found_first = true;
                                                last = count + 1;
                                                break;
                                            }
                                            else
                                                count++;
                                        }
                                    }
                                }
                                else
                                {
                                    while (count < table.Rows.Count)
                                    {
                                        if (DateTime.Parse(table.Rows[count][5].ToString().Split(' ')[0]) == DateTime.Parse(month + "/" + date2.Day + "/" + year))
                                        {
                                            table2.Rows.Add(table.Rows[count].ItemArray);
                                            break;
                                        }
                                        else
                                            count++;
                                    }
                                }
                            }
                        }
                    }
                }
                int current_id=0;
                adapter.Dispose();
                connection.Close();
                StreamWriter output = new StreamWriter(file, false);
                table2.Columns.Add("overall_diff");
                table2.Columns.Add("color_diff");
                table2.Columns.Add("mono_diff");
                int row_count = 1;
                int cols = table2.Columns.Count;
                for (int c = 0; c < cols; c++)
                {//write csv headers
                    output.Write("\""+table2.Columns[c]+"\"");
                    if (c < cols - 1)
                        output.Write(",");
                }
                output.Write(output.NewLine);

                foreach (DataRow row in table2.Rows)
                {//write data
                    for (int c = 0; c < cols; c++)
                    {
                        if (c < cols - 3)
                        {//write data for all but the last 3 columns
                            if (!Convert.IsDBNull(row[c]))
                                output.Write(row[c].ToString());

                            if (c < cols - 1)
                                output.Write(",");
                        }
                        else
                        {
                            if (row_count > 1 && int.Parse(row[1].ToString()) == current_id)
                            {//write excel formula to compare days
                                if (c == cols - 3)
                                    output.Write("=C" + (row_count + 1) + " - C" + row_count + ",");
                                else if (c == cols - 2)
                                    output.Write("=D" + (row_count + 1) + " - D" + row_count + ",");
                                else if (c == cols - 1)
                                    output.Write("=E" + (row_count + 1) + " - E" + row_count);
                            }
                            else
                            {//if not enough rows, the difference is 0
                                output.Write("0");
                                if (c < cols - 1)
                                    output.Write(",");
                                else
                                    current_id = int.Parse(row[1].ToString());
                            }
                        }
                    }
                    row_count++;
                    output.Write(output.NewLine);
                }
                output.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void export_button_Click(object sender, EventArgs e)
        {
            writeCSV(reference.filepath);
            this.Close();
        }

        private void end_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            stop = end_datetimepicker.Value.Date.ToString();
            if (end_datetimepicker.Value.Date.CompareTo(DateTime.Parse(start)) < 0)
                start_datetimepicker.Value = end_datetimepicker.Value.AddDays(-1);
        }

        private void start_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            start = start_datetimepicker.Value.Date.ToString();
            if (start_datetimepicker.Value.Date.CompareTo(DateTime.Parse(stop)) > 0)
                end_datetimepicker.Value = start_datetimepicker.Value.AddDays(1);
        }

        private void printers_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int index = 0; index < printers_listbox.SelectedIndices.Count; index++)
            {
                if (index == 0)
                    currentchart = printers.Rows[printers_listbox.SelectedIndices[0]].ItemArray.GetValue(0).ToString();
                else
                    currentchart += "," + printers.Rows[printers_listbox.SelectedIndices[index]].ItemArray.GetValue(0).ToString();
            }
        }
    }
}

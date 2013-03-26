using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Web;



namespace pagecount
{
    public partial class Form2 : Form
    {
        private DataTable printers;
        private string currentchart = "0";
        private string start = DateTime.Now.Date.ToString();
        private string stop = DateTime.Now.Date.ToString();
        private string start_time = "00:00";
        private string stop_time = "23:00";
        private Form1 reference;
        public Form2(Form1 refer)
        {
            InitializeComponent();
            reference = refer;
            start_time_datetimepicker.Value = DateTime.Parse(start_time);
            stop_time_datetimepicker.Value = DateTime.Parse(stop_time);
            updated_dataview();
        }
        private void updated_dataview()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + reference.Getdb();
            OleDbDataAdapter dataAdapter;
            try
            {
                dataAdapter = new OleDbDataAdapter("select * from printer", connection);

                // Populate a new data table and bind it to the BindingSource.
                printers = new DataTable();
                printers.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(printers);
                printer_combobox.DataSource = printers;
                printer_combobox.DisplayMember = "location";
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
        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateChart();
        }
        public void UpdateChart()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + reference.Getdb();
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT print_report.[ID], print_report.[printer_id], print_report.[overall_pagecount], print_report.[color_pagecount], print_report.[mono_pagecount], print_report.[date_time], base_count.[printer_id], base_count.[overall_pagecount] AS baseo, base_count.[color_pagecount] AS basec, base_count.[mono_pagecount] AS basem, print_report.[overall_pagecount] - [baseo] AS totalo, print_report.[color_pagecount] - [basec] AS totalc, print_report.[mono_pagecount] - [basem] AS totalm FROM print_report INNER JOIN base_count ON format(DateAdd('h',1,base_count.[date_time]),'mm/dd/yyyy hh') = format(print_report.[date_time], 'mm/dd/yyyy hh') WHERE print_report.[printer_id] = " + currentchart + " and base_count.[printer_id] = " + currentchart + " and print_report.[overall_pagecount] > 0 and base_count.[overall_pagecount] > 0 and Format(TimeSerial(Hour(print_report.[date_time]),0,0),'Short Time') <= '" + stop_time + "' and INT(print_report.date_time) >= DateValue('" + start + "') and INT(print_report.date_time) <= DateValue('" + stop + "') and Format(TimeSerial(Hour(base_count.[date_time]),0,0),'Short Time') >= '" + start_time + "';", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                adapter.Dispose();
                if (live_tracking_checkbox.Checked)
                {
                    adapter = new OleDbDataAdapter("SELECT print_report.[ID], print_report.[printer_id], print_report.[overall_pagecount], print_report.[color_pagecount], print_report.[mono_pagecount], print_report.[date_time], base_count.[printer_id], base_count.[overall_pagecount] AS baseo, base_count.[color_pagecount] AS basec, base_count.[mono_pagecount] AS basem, print_report.[overall_pagecount] - [baseo] AS totalo, print_report.[color_pagecount] - [basec] AS totalc, print_report.[mono_pagecount] - [basem] AS totalm FROM print_report INNER JOIN base_count ON format(DateAdd('h',1,base_count.[date_time]),'mm/dd/yyyy hh') = format(print_report.[date_time], 'mm/dd/yyyy hh') WHERE print_report.[printer_id] = " + currentchart + " and base_count.[printer_id] = " + currentchart + " and print_report.[overall_pagecount] > 0 and Format(TimeSerial(Hour(print_report.[date_time]),0,0),'Short Time') = '" + DateTime.Now.AddHours(-1).ToString("HH:") + "00" + "' and print_report.date_time > DateValue('" + DateTime.Now + "') and Format(TimeSerial(Hour(base_count.[date_time]),0,0),'Short Time') = '" + start_time + "';", connection);
                    DataTable table2 = new DataTable();
                    adapter.Fill(table2);
                    table.Merge(table2);

                    adapter.Dispose();
                }
                connection.Close();

                printed_pages_chart.DataSource = table;
                printed_pages_chart.ChartAreas[0].AxisX.LabelStyle.Format = "M/d/yy htt";
                printed_pages_chart.Series.Clear();
                printed_pages_chart.Series.Add("Total");
                printed_pages_chart.Series["Total"].XValueMember = "date_time";
                printed_pages_chart.Series["Total"].YValueMembers = "totalo";
                printed_pages_chart.Series["Total"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                printed_pages_chart.Series["Total"].IsValueShownAsLabel = true;
                printed_pages_chart.Series.Add("Color");
                printed_pages_chart.Series["Color"].XValueMember = "date_time";
                printed_pages_chart.Series["Color"].YValueMembers = "totalc";
                printed_pages_chart.Series["Color"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                printed_pages_chart.Series["Color"].IsValueShownAsLabel = true;
                printed_pages_chart.Series.Add("Mono");
                printed_pages_chart.Series["Mono"].XValueMember = "date_time";
                printed_pages_chart.Series["Mono"].YValueMembers = "totalm";
                printed_pages_chart.Series["Mono"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                printed_pages_chart.Series["Mono"].IsValueShownAsLabel = true;
                
                foreach(System.Windows.Forms.DataVisualization.Charting.Series s in printed_pages_chart.Series)
                {
                    foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint dp in s.Points)
                    {
                        if (dp.YValues[0] == 0)
                        {
                            dp.IsValueShownAsLabel = false;
                        }
                    }

                }
                printed_pages_chart.DataBind();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void start_date_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            start = start_date_datetimepicker.Value.Date.ToString();
            if (start_date_datetimepicker.Value.Date.CompareTo(DateTime.Parse(stop)) > 0)
                stop_date_datetimepicker.Value = start_date_datetimepicker.Value.AddDays(1);
        }

        private void printer_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentchart = printers.Rows[printer_combobox.SelectedIndex].ItemArray.GetValue(0).ToString();
        }

        private void stop_date_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            stop = stop_date_datetimepicker.Value.Date.ToString();
            if (stop_date_datetimepicker.Value.Date.CompareTo(DateTime.Parse(start)) < 0)
                start_date_datetimepicker.Value = stop_date_datetimepicker.Value.AddDays(-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printed_pages_chart.Series.Clear();
        }

        private void start_time_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            start_time = start_time_datetimepicker.Value.ToString("HH:mm");
        }

        private void stop_time_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            stop_time = stop_time_datetimepicker.Value.ToString("HH:mm");
        }    
    }
}

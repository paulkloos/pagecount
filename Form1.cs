using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Data.SqlTypes;
using System.Security;
using System.Security.AccessControl;
using Microsoft.Win32;


namespace pagecount
{
    public partial class Form1 : Form
    {
        public static readonly String ALL = "iso.3.6.1.2.1.43.10.2.1.4.1.1";//found snmp variable for HP printers
        public static readonly String COLOR = "iso.3.6.1.4.1.11.2.3.9.4.2.1.4.1.2.7.0";//found snmp variable for HP printers
        public string filepath;
        private Form2 window = null;
        private Form3 window2 = null;
        private Form4 window3 = null;
        private int interval = 10000;
        private int grid_select_index;
        private DataTable printers;

        public Form1()
        {
            InitializeComponent();
            string []arg = Environment.GetCommandLineArgs();
            if(arg.Length > 1 && arg[1] == "start")
            {
                update_timer.Start();
                this.Text = "Pagecount - Started";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_settings();
            
        }

        private void printers_delete_button_Click(object sender, EventArgs e)
        {
            int index;
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+database_path_textbox.Text;
            OleDbCommand cmd;
            try
            {
                if (printer_list_gridview.RowCount > 0)
                {
                    index = int.Parse(printer_list_gridview.SelectedRows[0].Cells[0].Value.ToString());
                    string query = "delete from printer where ID = " + index;
                    connection.Open();
                    cmd = new OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            //catch (
            catch (Exception e4)
            {
                MessageBox.Show(e4.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                updated_dataview();
            }
            
        }

        private void add_printer_button_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+database_path_textbox.Text;
            OleDbCommand cmd;
            try
            {
                string ip = printer_ip_textbox.Text;
                string name = printer_name_textbox.Text;
                string type = printer_type_combobox.Text;
                string query;
                int id;
                if (type.Equals("Black & White") == true)
                    type = "total";
                else if (type.Equals("Color") == true)
                    type = "both";

                connection.Open();
                query = "insert into printer (ip,location,type) values('" + ip + "','" + name + "','" + type + "')";
                cmd = new OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                if (printer_replace_checkbox.Checked == true)
                {
                    OleDbDataAdapter dataAdapter;
                    DataTable printer_info;
                    //get recently inserted id
                    dataAdapter = new OleDbDataAdapter("SELECT ID FROM printer WHERE ip='" + ip + "' and location='" + name + "' and type='" + type + "' and disabled=false", connection);
                    OleDbCommandBuilder command = new OleDbCommandBuilder(dataAdapter);
                    DataTable temp = new DataTable();

                    temp.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(temp);
                    id = int.Parse(temp.Rows[0][0].ToString());

                    //get disabled date from previous printer
                    dataAdapter = new OleDbDataAdapter("select disabled_date from printer where ID = " + printers.Rows[printer_replacement_combobox.SelectedIndex].ItemArray.GetValue(0).ToString(), connection);
                    command = new OleDbCommandBuilder(dataAdapter);                    

                    printer_info = new DataTable();
                    printer_info.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(printer_info);
                    
                    query = "update printer set replacement = "+id+" where ID = " + printers.Rows[printer_replacement_combobox.SelectedIndex].ItemArray.GetValue(0).ToString();
                    cmd = new OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    //update print report entries that happened during the switch period
                    query = "update print_report set printer_id = " + id + " where printer_id = " + printers.Rows[printer_replacement_combobox.SelectedIndex].ItemArray.GetValue(0).ToString() + " and format(date_time,'yyyy/mm/dd hh') >= format('" + printer_info.Rows[0][0].ToString() + "', 'yyyy/mm/dd hh')";
                    cmd = new OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
            }
            catch (Exception e1)
            {
                label2.Text = e1.Message;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                updated_dataview();
            }
            printer_ip_textbox.Text = "";
            printer_name_textbox.Text = "";
            printer_replace_checkbox.Checked = false;
        }

        private void printers_refresh_button_Click(object sender, EventArgs e)
        {
            updated_dataview();
        }

        public void updated_dataview()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+database_path_textbox.Text;
            OleDbDataAdapter dataAdapter;
            try
            {
                if (hide_disabled_checkbox.Checked)
                    dataAdapter = new OleDbDataAdapter("select * from printer where disabled=false", connection);
                else
                    dataAdapter = new OleDbDataAdapter("select * from printer", connection);

                OleDbCommandBuilder command = new OleDbCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                
                //display 'Color' for 'both' type
                DataRow[] rows = table.Select("type = 'both'");
                foreach (DataRow row in rows)
                    row["type"] = "Color";

                //display 'Color' for 'both' type
                rows = table.Select("type = 'total'");
                foreach (DataRow row in rows)
                    row["type"] = "Black & White";
                
                printer_list_gridview.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                printer_list_gridview.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                dataAdapter.Dispose();

                dataAdapter = new OleDbDataAdapter("SELECT * FROM printer WHERE disabled = true", connection);

                command = new OleDbCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                printers = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(printers);
                if (table.Rows.Count > 0)
                {
                    printer_replacement_combobox.DataSource = printers;
                    printer_replacement_combobox.DisplayMember = "ID";
                }
                else
                {
                    printer_replacement_combobox.Items.Add("None");
                }

                dataAdapter.Dispose();
            }
            catch (ArgumentException AE)
            {
                //do nothing, the list is blank
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

        private void database_browse_button_Click(object sender, EventArgs e)
        {
            database_openfiledialog.ShowDialog();
        }

        private void database_openfiledialog_FileOk(object sender, CancelEventArgs e)
        {
            database_path_textbox.Text = database_openfiledialog.FileName;
            updated_dataview();
        }

        private void snmpget_browse_button_Click(object sender, EventArgs e)
        {
            snmpget_openfiledialog.ShowDialog();
        }

        private void snmpget_openfiledialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox4.Text = snmpget_openfiledialog.FileName;
        }

        private void save_settings_button_Click(object sender, EventArgs e)
        {
            save_settings();
            interval = int.Parse(interval_textbox.Text);
            if (interval_combobox.Text.Equals("Seconds"))
            {
                interval = interval * 1000;
            }
            else if (interval_combobox.Text.Equals("Hours"))
            {
                interval = interval * 1000 * 60 * 60;
            }
            else if (interval_combobox.Text.Equals("Days"))
            {
                interval = interval * 1000 * 60 * 60 * 24;
            }
            else
            {
                interval = interval * 1000000;
            }

            update_timer.Interval = interval;
        }

        private void save_settings()
        {
            if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pagecount"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pagecount");
            }
            XmlTextWriter textwriter = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pagecount\\settings.xml", null);
            textwriter.WriteStartDocument();
            textwriter.WriteStartElement("settings");
            textwriter.WriteStartElement("files");
            textwriter.WriteStartElement("database", "");
            textwriter.WriteString(database_path_textbox.Text);
            textwriter.WriteEndElement();
            textwriter.WriteStartElement("snmp", "");
            textwriter.WriteString(textBox4.Text);
            textwriter.WriteEndElement();
            textwriter.WriteEndElement();
            textwriter.WriteStartElement("time", "");
            textwriter.WriteStartElement("interval", "");
            textwriter.WriteString(interval_textbox.Text);
            textwriter.WriteEndElement();
            textwriter.WriteStartElement("type", "");
            textwriter.WriteString(interval_combobox.Text);
            textwriter.WriteEndElement();
            textwriter.WriteEndElement();
            textwriter.WriteStartElement("show_disabled", "");
            textwriter.WriteString(hide_disabled_checkbox.CheckState.ToString());
            textwriter.WriteEndElement();
            textwriter.WriteEndElement();
            textwriter.WriteEndDocument();
            textwriter.Close();
        }

        private void load_settings()
        {
            XmlTextReader xmlread = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pagecount\\settings.xml");
            XmlNodeType node;
            bool in_database = false, in_snmap = false, in_time = false, in_interval = false, in_type = false, in_show_disabled = false;
            try
            {
                while (xmlread.Read())
                {
                    node = xmlread.NodeType;
                    if (node == XmlNodeType.Element && xmlread.Name == "database")
                        in_database = true;

                    if (node == XmlNodeType.Element && xmlread.Name == "snmp")
                        in_snmap = true;

                    if (node == XmlNodeType.Element && xmlread.Name == "time")
                        in_time = true;

                    if (node == XmlNodeType.Element && xmlread.Name == "interval")
                        in_interval = true;

                    if (node == XmlNodeType.Element && xmlread.Name == "type")
                        in_type = true;

                    if (node == XmlNodeType.Element && xmlread.Name == "show_disabled")
                        in_show_disabled = true;

                    if (node == XmlNodeType.Text && in_show_disabled)
                    {
                        if (xmlread.Value == "Checked")
                            hide_disabled_checkbox.CheckState = CheckState.Checked;
                        else
                            hide_disabled_checkbox.CheckState = CheckState.Unchecked;

                        in_show_disabled = false;
                    }
                    if (node == XmlNodeType.Text && in_database)
                    {
                        database_path_textbox.Text = xmlread.Value;
                        in_database = false;
                    }
                    if (node == XmlNodeType.Text && in_snmap)
                    {
                        textBox4.Text = xmlread.Value;
                        in_snmap = false;
                    }
                    if (node == XmlNodeType.Text && in_time && in_interval)
                    {
                        interval_textbox.Text = xmlread.Value;
                        in_interval = false;
                    }
                    if (node == XmlNodeType.Text && in_time && in_type)
                    {
                        interval_combobox.Text = xmlread.Value;
                        if (interval_combobox.Text.Equals("Seconds"))
                        {
                            interval = int.Parse(interval_textbox.Text) * 1000;
                        }
                        else if (interval_combobox.Text.Equals("Hours"))
                        {
                            interval = int.Parse(interval_textbox.Text) * 1000 * 60 * 60;
                        }
                        else if (interval_combobox.Text.Equals("Days"))
                        {
                            interval = int.Parse(interval_textbox.Text) * 1000 * 60 * 60 * 24;
                        }
                        else
                        {
                            interval = interval * 1000000;
                        }
                        in_type = false;
                        in_time = false;
                    }
                }
                if (database_path_textbox.Text.Length > 0)
                    updated_dataview();

                update_timer.Interval = interval;
            }
            catch (Exception e5)
            {
                MessageBox.Show("Unable to open settings file: " + e5.Message);
            }
            finally
            {
                xmlread.Close();
            }
        }

        public void update_count()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+database_path_textbox.Text;
            OleDbCommand cmd, cmd2;
            OleDbDataReader reader;
            try
            {
                connection.Open();
                cmd = new OleDbCommand("SELECT * FROM printer WHERE disabled=false", connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int result1, result2, result3;
                    if (reader["type"].ToString().Equals("total"))
                    {
                        result1 = getPageCount(textBox4.Text, reader["ip"].ToString(), ALL);
                        result2 = 0;
                        result3 = 0;
                    }
                    else if (reader["type"].ToString().Equals("both"))
                    {
                        result1 = getPageCount(textBox4.Text, reader["ip"].ToString(), ALL);
                        result2 = getPageCount(textBox4.Text, reader["ip"].ToString(), COLOR);
                        result3 = result1 - result2;
                    }
                    else
                    {
                        result1 = 0;
                        result2 = 0;
                        result3 = 0;
                    }
                    SqlDateTime n = new SqlDateTime(DateTime.Now);
                    string query = "INSERT INTO print_report (printer_id,overall_pagecount,color_pagecount,mono_pagecount,date_time) VALUES(" + reader["ID"] + "," + result1 + "," + result2 + "," + result3 + ",'" + n + "')";

                    cmd2 = new OleDbCommand(query, connection);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception e1)
            {
                log_error(e1.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            if (window != null && window.Visible)
                window.UpdateChart();
        }
        public int getPageCount(string file, string ip, string type)
        {
            String text, vtext;
            int start, end, value;
            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = file;

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = "-v 1 -Lo -c public " + ip + " " + type;

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Start the process
            pProcess.Start();
            //Get program output
            text = pProcess.StandardOutput.ReadToEnd();
            //Wait for process to finish
            pProcess.WaitForExit();

            start = text.LastIndexOf(':') + 1;
            end = text.Length - start;

            vtext = text.Substring(start, end);
            vtext.Trim();

            try
            {
                value = int.Parse(vtext);
            }
            catch (Exception e2)
            {
                log_error(e2.Message + ": " + text);
                value = 0;
            }
            return value;
        }

        private void log_error(string message)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+database_path_textbox.Text;
            OleDbCommand cmd;
            connection.Open();
            SqlDateTime n = new SqlDateTime(DateTime.Now);
            System.Text.RegularExpressions.Regex.Replace(message,@"""|\\","");
            string query = "INSERT INTO errors (message,date_time) VALUES('"+message+"','"+n+"')";

            cmd = new OleDbCommand(query, connection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            connection.Dispose();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            update_count();
            update_timer.Start();
            this.Text = "Pagecount - Started";
        }

        private void update_timer_Tick(object sender, EventArgs e)
        {
            update_count();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            update_timer.Stop();
            this.Text = "Pagecount - Stopped";
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void show_toolscriptmenuitem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void exit_toolstripmenuitem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void open_chart_button_Click(object sender, EventArgs e)
        {
            window = new Form2(this);
            window.Show();
        }
        public string Getdb()
        {
            return database_path_textbox.Text;
        }

        private void export_button_Click(object sender, EventArgs e)
        {
            try
            {
                export_savefiledialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
            }
        }

        private void export_savefiledialog_FileOk(object sender, CancelEventArgs e)
        {
            filepath = export_savefiledialog.FileName;
            window2 = new Form3(this);
            window2.Show();
        }

        private void printers_disable_button_Click(object sender, EventArgs e)
        {
            if (printer_list_gridview.RowCount > 0 && printer_list_gridview.SelectedRows[0].Cells[0].Value != null)
            {
                grid_select_index = int.Parse(printer_list_gridview.SelectedRows[0].Cells[0].Value.ToString());
                window3 = new Form4(this);
                window3.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (printer_replace_checkbox.Checked == true)
                printer_replacement_combobox.Enabled = true;
            else
                printer_replacement_combobox.Enabled = false;
        }
        public int Get_GridSelectedIndex()
        {
            return grid_select_index;
        }
    }    
}

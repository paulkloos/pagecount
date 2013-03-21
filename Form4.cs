using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace pagecount
{
    public partial class Form4 : Form
    {
        private Form1 reference;
        public Form4(Form1 refer)
        {
            InitializeComponent();
            reference = refer;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            int index;
            string name;
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + reference.Getdb();
            OleDbCommand cmd;
            try
            {
                index = reference.Get_GridSelectedIndex();
                OleDbDataAdapter dataAdapter;
                //get printer name
                dataAdapter = new OleDbDataAdapter("SELECT location FROM printer WHERE ID=" + index, connection);
                OleDbCommandBuilder command = new OleDbCommandBuilder(dataAdapter);
                DataTable temp = new DataTable();

                temp.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(temp);
                name = temp.Rows[0][0].ToString();

                string temp_time;
                temp_time = date_disabled_datetimepicker.Value.Month.ToString() + "/" + date_disabled_datetimepicker.Value.Day.ToString() + "/" + date_disabled_datetimepicker.Value.Year.ToString() + " " + time_disabled_datetimepicker.Value.Hour.ToString()+":00:00";
                SqlDateTime n = new SqlDateTime(DateTime.Parse(temp_time));
                string query = "UPDATE printer SET location='"+name+"(disabled)', disabled=true,disabled_date='"+n+"' where ID = " + index;
                connection.Open();
                cmd = new OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e4)
            {
                MessageBox.Show(e4.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                reference.updated_dataview();
            }
            this.Close();
        }
    }
}

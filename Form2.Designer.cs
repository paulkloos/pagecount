namespace pagecount
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.printed_pages_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.update_button = new System.Windows.Forms.Button();
            this.printer_combobox = new System.Windows.Forms.ComboBox();
            this.start_date_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.stop_date_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.live_tracking_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stop_time_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start_time_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.printed_pages_chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printed_pages_chart
            // 
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Title = "Page Count";
            chartArea1.Name = "ChartArea1";
            this.printed_pages_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.printed_pages_chart.Legends.Add(legend1);
            this.printed_pages_chart.Location = new System.Drawing.Point(1, 1);
            this.printed_pages_chart.Name = "printed_pages_chart";
            this.printed_pages_chart.Size = new System.Drawing.Size(1037, 608);
            this.printed_pages_chart.TabIndex = 0;
            this.printed_pages_chart.Text = "Printed Pages";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(654, 7);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // printer_combobox
            // 
            this.printer_combobox.FormattingEnabled = true;
            this.printer_combobox.Location = new System.Drawing.Point(11, 28);
            this.printer_combobox.Name = "printer_combobox";
            this.printer_combobox.Size = new System.Drawing.Size(182, 21);
            this.printer_combobox.TabIndex = 2;
            this.printer_combobox.SelectedIndexChanged += new System.EventHandler(this.printer_combobox_SelectedIndexChanged);
            // 
            // start_date_datetimepicker
            // 
            this.start_date_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_date_datetimepicker.Location = new System.Drawing.Point(41, 19);
            this.start_date_datetimepicker.Name = "start_date_datetimepicker";
            this.start_date_datetimepicker.Size = new System.Drawing.Size(103, 20);
            this.start_date_datetimepicker.TabIndex = 3;
            this.start_date_datetimepicker.ValueChanged += new System.EventHandler(this.start_date_datetimepicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start";
            // 
            // stop_date_datetimepicker
            // 
            this.stop_date_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stop_date_datetimepicker.Location = new System.Drawing.Point(41, 45);
            this.stop_date_datetimepicker.Name = "stop_date_datetimepicker";
            this.stop_date_datetimepicker.Size = new System.Drawing.Size(103, 20);
            this.stop_date_datetimepicker.TabIndex = 5;
            this.stop_date_datetimepicker.ValueChanged += new System.EventHandler(this.stop_date_datetimepicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stop";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.live_tracking_checkbox);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.printer_combobox);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Location = new System.Drawing.Point(1, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 85);
            this.panel1.TabIndex = 7;
            // 
            // live_tracking_checkbox
            // 
            this.live_tracking_checkbox.AutoSize = true;
            this.live_tracking_checkbox.Location = new System.Drawing.Point(638, 61);
            this.live_tracking_checkbox.Name = "live_tracking_checkbox";
            this.live_tracking_checkbox.Size = new System.Drawing.Size(91, 17);
            this.live_tracking_checkbox.TabIndex = 10;
            this.live_tracking_checkbox.Text = "Live Tracking";
            this.live_tracking_checkbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stop_time_datetimepicker);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.start_time_datetimepicker);
            this.groupBox2.Location = new System.Drawing.Point(432, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 72);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // stop_time_datetimepicker
            // 
            this.stop_time_datetimepicker.CustomFormat = "HH:mm";
            this.stop_time_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stop_time_datetimepicker.Location = new System.Drawing.Point(41, 45);
            this.stop_time_datetimepicker.Name = "stop_time_datetimepicker";
            this.stop_time_datetimepicker.ShowUpDown = true;
            this.stop_time_datetimepicker.Size = new System.Drawing.Size(91, 20);
            this.stop_time_datetimepicker.TabIndex = 3;
            this.stop_time_datetimepicker.ValueChanged += new System.EventHandler(this.stop_time_datetimepicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start";
            // 
            // start_time_datetimepicker
            // 
            this.start_time_datetimepicker.CustomFormat = "HH:mm";
            this.start_time_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_time_datetimepicker.Location = new System.Drawing.Point(41, 19);
            this.start_time_datetimepicker.Name = "start_time_datetimepicker";
            this.start_time_datetimepicker.ShowUpDown = true;
            this.start_time_datetimepicker.Size = new System.Drawing.Size(91, 20);
            this.start_time_datetimepicker.TabIndex = 0;
            this.start_time_datetimepicker.ValueChanged += new System.EventHandler(this.start_time_datetimepicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Printer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stop_date_datetimepicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.start_date_datetimepicker);
            this.groupBox1.Location = new System.Drawing.Point(246, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 72);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printed_pages_chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Charts";
            ((System.ComponentModel.ISupportInitialize)(this.printed_pages_chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart printed_pages_chart;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ComboBox printer_combobox;
        private System.Windows.Forms.DateTimePicker start_date_datetimepicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker stop_date_datetimepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker stop_time_datetimepicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker start_time_datetimepicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox live_tracking_checkbox;
    }
}
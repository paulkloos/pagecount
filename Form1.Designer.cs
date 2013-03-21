namespace pagecount
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printer_list_gridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printer_ip_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printer_name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printer_type_combobox = new System.Windows.Forms.ComboBox();
            this.add_printer_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printer_replacement_combobox = new System.Windows.Forms.ComboBox();
            this.printer_replace_checkbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printers_delete_button = new System.Windows.Forms.Button();
            this.printers_refresh_button = new System.Windows.Forms.Button();
            this.database_path_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.database_browse_button = new System.Windows.Forms.Button();
            this.database_openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.snmpget_browse_button = new System.Windows.Forms.Button();
            this.snmpget_openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.save_settings_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.interval_textbox = new System.Windows.Forms.TextBox();
            this.interval_combobox = new System.Windows.Forms.ComboBox();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.hide_button = new System.Windows.Forms.Button();
            this.update_timer = new System.Windows.Forms.Timer(this.components);
            this.hidden_menu_contextmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show_toolstriptmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_toolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.icon_notifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.open_chart_button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.export_savefiledialog = new System.Windows.Forms.SaveFileDialog();
            this.printers_disable_button = new System.Windows.Forms.Button();
            this.hide_disabled_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.printer_list_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.hidden_menu_contextmenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // printer_list_gridview
            // 
            this.printer_list_gridview.AllowUserToAddRows = false;
            this.printer_list_gridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printer_list_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.printer_list_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.printer_list_gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.printer_list_gridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.printer_list_gridview.Location = new System.Drawing.Point(368, 52);
            this.printer_list_gridview.MultiSelect = false;
            this.printer_list_gridview.Name = "printer_list_gridview";
            this.printer_list_gridview.ReadOnly = true;
            this.printer_list_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.printer_list_gridview.Size = new System.Drawing.Size(433, 200);
            this.printer_list_gridview.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Printers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // printer_ip_textbox
            // 
            this.printer_ip_textbox.Location = new System.Drawing.Point(38, 17);
            this.printer_ip_textbox.Name = "printer_ip_textbox";
            this.printer_ip_textbox.Size = new System.Drawing.Size(151, 20);
            this.printer_ip_textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP";
            // 
            // printer_name_textbox
            // 
            this.printer_name_textbox.Location = new System.Drawing.Point(38, 56);
            this.printer_name_textbox.Name = "printer_name_textbox";
            this.printer_name_textbox.Size = new System.Drawing.Size(151, 20);
            this.printer_name_textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // printer_type_combobox
            // 
            this.printer_type_combobox.FormattingEnabled = true;
            this.printer_type_combobox.Items.AddRange(new object[] {
            "Black & White",
            "Color"});
            this.printer_type_combobox.Location = new System.Drawing.Point(214, 18);
            this.printer_type_combobox.Name = "printer_type_combobox";
            this.printer_type_combobox.Size = new System.Drawing.Size(124, 21);
            this.printer_type_combobox.TabIndex = 8;
            this.printer_type_combobox.Text = "Black & White";
            // 
            // add_printer_button
            // 
            this.add_printer_button.Location = new System.Drawing.Point(214, 56);
            this.add_printer_button.Name = "add_printer_button";
            this.add_printer_button.Size = new System.Drawing.Size(123, 20);
            this.add_printer_button.TabIndex = 9;
            this.add_printer_button.Text = "Add Printer";
            this.add_printer_button.UseVisualStyleBackColor = true;
            this.add_printer_button.Click += new System.EventHandler(this.add_printer_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.printer_replacement_combobox);
            this.groupBox1.Controls.Add(this.printer_replace_checkbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.add_printer_button);
            this.groupBox1.Controls.Add(this.printer_type_combobox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.printer_name_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.printer_ip_textbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 136);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New printer";
            // 
            // printer_replacement_combobox
            // 
            this.printer_replacement_combobox.Enabled = false;
            this.printer_replacement_combobox.FormattingEnabled = true;
            this.printer_replacement_combobox.Location = new System.Drawing.Point(67, 106);
            this.printer_replacement_combobox.Name = "printer_replacement_combobox";
            this.printer_replacement_combobox.Size = new System.Drawing.Size(267, 21);
            this.printer_replacement_combobox.TabIndex = 12;
            // 
            // printer_replace_checkbox
            // 
            this.printer_replace_checkbox.AutoSize = true;
            this.printer_replace_checkbox.Location = new System.Drawing.Point(38, 83);
            this.printer_replace_checkbox.Name = "printer_replace_checkbox";
            this.printer_replace_checkbox.Size = new System.Drawing.Size(137, 17);
            this.printer_replace_checkbox.TabIndex = 11;
            this.printer_replace_checkbox.Text = "Replace another printer";
            this.printer_replace_checkbox.UseVisualStyleBackColor = true;
            this.printer_replace_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Replacing";
            // 
            // printers_delete_button
            // 
            this.printers_delete_button.Location = new System.Drawing.Point(702, 258);
            this.printers_delete_button.Name = "printers_delete_button";
            this.printers_delete_button.Size = new System.Drawing.Size(99, 23);
            this.printers_delete_button.TabIndex = 11;
            this.printers_delete_button.Text = "Delete Selected";
            this.printers_delete_button.UseVisualStyleBackColor = true;
            this.printers_delete_button.Click += new System.EventHandler(this.printers_delete_button_Click);
            // 
            // printers_refresh_button
            // 
            this.printers_refresh_button.Location = new System.Drawing.Point(368, 258);
            this.printers_refresh_button.Name = "printers_refresh_button";
            this.printers_refresh_button.Size = new System.Drawing.Size(75, 23);
            this.printers_refresh_button.TabIndex = 12;
            this.printers_refresh_button.Text = "Refresh";
            this.printers_refresh_button.UseVisualStyleBackColor = true;
            this.printers_refresh_button.Click += new System.EventHandler(this.printers_refresh_button_Click);
            // 
            // database_path_textbox
            // 
            this.database_path_textbox.Location = new System.Drawing.Point(66, 6);
            this.database_path_textbox.Name = "database_path_textbox";
            this.database_path_textbox.ReadOnly = true;
            this.database_path_textbox.Size = new System.Drawing.Size(646, 20);
            this.database_path_textbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "database";
            // 
            // database_browse_button
            // 
            this.database_browse_button.Location = new System.Drawing.Point(66, 31);
            this.database_browse_button.Name = "database_browse_button";
            this.database_browse_button.Size = new System.Drawing.Size(75, 23);
            this.database_browse_button.TabIndex = 15;
            this.database_browse_button.Text = "Browse...";
            this.database_browse_button.UseVisualStyleBackColor = true;
            this.database_browse_button.Click += new System.EventHandler(this.database_browse_button_Click);
            // 
            // database_openfiledialog
            // 
            this.database_openfiledialog.DefaultExt = "accdb";
            this.database_openfiledialog.Filter = "Access Database (*.accdb)|*.accdb";
            this.database_openfiledialog.FileOk += new System.ComponentModel.CancelEventHandler(this.database_openfiledialog_FileOk);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(349, 20);
            this.textBox4.TabIndex = 16;
            // 
            // snmpget_browse_button
            // 
            this.snmpget_browse_button.Location = new System.Drawing.Point(12, 258);
            this.snmpget_browse_button.Name = "snmpget_browse_button";
            this.snmpget_browse_button.Size = new System.Drawing.Size(75, 23);
            this.snmpget_browse_button.TabIndex = 17;
            this.snmpget_browse_button.Text = "Browse...";
            this.snmpget_browse_button.UseVisualStyleBackColor = true;
            this.snmpget_browse_button.Click += new System.EventHandler(this.snmpget_browse_button_Click);
            // 
            // snmpget_openfiledialog
            // 
            this.snmpget_openfiledialog.DefaultExt = "exe";
            this.snmpget_openfiledialog.FileName = "snmpget.exe";
            this.snmpget_openfiledialog.Filter = "executable file (*.exe)|*.exe";
            this.snmpget_openfiledialog.FileOk += new System.ComponentModel.CancelEventHandler(this.snmpget_openfiledialog_FileOk);
            // 
            // save_settings_button
            // 
            this.save_settings_button.Location = new System.Drawing.Point(12, 343);
            this.save_settings_button.Name = "save_settings_button";
            this.save_settings_button.Size = new System.Drawing.Size(98, 23);
            this.save_settings_button.TabIndex = 18;
            this.save_settings_button.Text = "Save settings";
            this.save_settings_button.UseVisualStyleBackColor = true;
            this.save_settings_button.Click += new System.EventHandler(this.save_settings_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "snmpget";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Interval";
            // 
            // interval_textbox
            // 
            this.interval_textbox.Location = new System.Drawing.Point(85, 304);
            this.interval_textbox.Name = "interval_textbox";
            this.interval_textbox.Size = new System.Drawing.Size(100, 20);
            this.interval_textbox.TabIndex = 21;
            this.interval_textbox.Text = "1";
            // 
            // interval_combobox
            // 
            this.interval_combobox.FormattingEnabled = true;
            this.interval_combobox.Items.AddRange(new object[] {
            "Seconds",
            "Hours",
            "Days"});
            this.interval_combobox.Location = new System.Drawing.Point(200, 304);
            this.interval_combobox.Name = "interval_combobox";
            this.interval_combobox.Size = new System.Drawing.Size(121, 21);
            this.interval_combobox.TabIndex = 22;
            this.interval_combobox.Text = "Hours";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(431, 374);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 27;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(538, 374);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 28;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // hide_button
            // 
            this.hide_button.Location = new System.Drawing.Point(689, 374);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(96, 23);
            this.hide_button.TabIndex = 29;
            this.hide_button.Text = "Hide Window";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // update_timer
            // 
            this.update_timer.Tick += new System.EventHandler(this.update_timer_Tick);
            // 
            // hidden_menu_contextmenustrip
            // 
            this.hidden_menu_contextmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_toolstriptmenuitem,
            this.exit_toolstripmenuitem});
            this.hidden_menu_contextmenustrip.Name = "contextMenuStrip1";
            this.hidden_menu_contextmenustrip.Size = new System.Drawing.Size(153, 70);
            // 
            // show_toolstriptmenuitem
            // 
            this.show_toolstriptmenuitem.Name = "show_toolstriptmenuitem";
            this.show_toolstriptmenuitem.Size = new System.Drawing.Size(152, 22);
            this.show_toolstriptmenuitem.Text = "Show";
            this.show_toolstriptmenuitem.Click += new System.EventHandler(this.show_toolscriptmenuitem_Click);
            // 
            // exit_toolstripmenuitem
            // 
            this.exit_toolstripmenuitem.Name = "exit_toolstripmenuitem";
            this.exit_toolstripmenuitem.Size = new System.Drawing.Size(152, 22);
            this.exit_toolstripmenuitem.Text = "Exit";
            this.exit_toolstripmenuitem.Click += new System.EventHandler(this.exit_toolstripmenuitem_Click);
            // 
            // icon_notifyicon
            // 
            this.icon_notifyicon.ContextMenuStrip = this.hidden_menu_contextmenustrip;
            this.icon_notifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon_notifyicon.Icon")));
            this.icon_notifyicon.Text = "Page Count";
            this.icon_notifyicon.Visible = true;
            // 
            // open_chart_button
            // 
            this.open_chart_button.Location = new System.Drawing.Point(110, 374);
            this.open_chart_button.Name = "open_chart_button";
            this.open_chart_button.Size = new System.Drawing.Size(75, 23);
            this.open_chart_button.TabIndex = 30;
            this.open_chart_button.Text = "Chart";
            this.open_chart_button.UseVisualStyleBackColor = true;
            this.open_chart_button.Click += new System.EventHandler(this.open_chart_button_Click);
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(226, 374);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(75, 23);
            this.export_button.TabIndex = 31;
            this.export_button.Text = "Export";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // export_savefiledialog
            // 
            this.export_savefiledialog.DefaultExt = "*.csv";
            this.export_savefiledialog.Filter = "CSV (*.csv)|*.csv";
            this.export_savefiledialog.Title = "Create Export File";
            this.export_savefiledialog.FileOk += new System.ComponentModel.CancelEventHandler(this.export_savefiledialog_FileOk);
            // 
            // printers_disable_button
            // 
            this.printers_disable_button.Location = new System.Drawing.Point(538, 258);
            this.printers_disable_button.Name = "printers_disable_button";
            this.printers_disable_button.Size = new System.Drawing.Size(102, 23);
            this.printers_disable_button.TabIndex = 32;
            this.printers_disable_button.Text = "Disable Selected";
            this.printers_disable_button.UseVisualStyleBackColor = true;
            this.printers_disable_button.Click += new System.EventHandler(this.printers_disable_button_Click);
            // 
            // hide_disabled_checkbox
            // 
            this.hide_disabled_checkbox.AutoSize = true;
            this.hide_disabled_checkbox.Location = new System.Drawing.Point(373, 289);
            this.hide_disabled_checkbox.Name = "hide_disabled_checkbox";
            this.hide_disabled_checkbox.Size = new System.Drawing.Size(127, 17);
            this.hide_disabled_checkbox.TabIndex = 33;
            this.hide_disabled_checkbox.Text = "Hide disabled printers";
            this.hide_disabled_checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 415);
            this.Controls.Add(this.hide_disabled_checkbox);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.interval_combobox);
            this.Controls.Add(this.printers_disable_button);
            this.Controls.Add(this.interval_textbox);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.hide_button);
            this.Controls.Add(this.open_chart_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.snmpget_browse_button);
            this.Controls.Add(this.save_settings_button);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.database_browse_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.database_path_textbox);
            this.Controls.Add(this.printers_refresh_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printers_delete_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printer_list_gridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Page Count - Stopped";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printer_list_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.hidden_menu_contextmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView printer_list_gridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox printer_ip_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox printer_name_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox printer_type_combobox;
        private System.Windows.Forms.Button add_printer_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button printers_delete_button;
        private System.Windows.Forms.Button printers_refresh_button;
        private System.Windows.Forms.TextBox database_path_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button database_browse_button;
        private System.Windows.Forms.OpenFileDialog database_openfiledialog;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button snmpget_browse_button;
        private System.Windows.Forms.OpenFileDialog snmpget_openfiledialog;
        private System.Windows.Forms.Button save_settings_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox interval_textbox;
        private System.Windows.Forms.ComboBox interval_combobox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Timer update_timer;
        private System.Windows.Forms.ContextMenuStrip hidden_menu_contextmenustrip;
        private System.Windows.Forms.ToolStripMenuItem show_toolstriptmenuitem;
        private System.Windows.Forms.ToolStripMenuItem exit_toolstripmenuitem;
        private System.Windows.Forms.NotifyIcon icon_notifyicon;
        private System.Windows.Forms.Button open_chart_button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.SaveFileDialog export_savefiledialog;
        private System.Windows.Forms.ComboBox printer_replacement_combobox;
        private System.Windows.Forms.CheckBox printer_replace_checkbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button printers_disable_button;
        private System.Windows.Forms.CheckBox hide_disabled_checkbox;
    }
}


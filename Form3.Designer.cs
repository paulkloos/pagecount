namespace pagecount
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.start_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.end_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.daily_radiobutton = new System.Windows.Forms.RadioButton();
            this.weekly_radiobutton = new System.Windows.Forms.RadioButton();
            this.monthly_radiobutton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printers_listbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Printers";
            // 
            // start_datetimepicker
            // 
            this.start_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_datetimepicker.Location = new System.Drawing.Point(15, 243);
            this.start_datetimepicker.Name = "start_datetimepicker";
            this.start_datetimepicker.Size = new System.Drawing.Size(88, 20);
            this.start_datetimepicker.TabIndex = 2;
            this.start_datetimepicker.ValueChanged += new System.EventHandler(this.start_datetimepicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start";
            // 
            // end_datetimepicker
            // 
            this.end_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_datetimepicker.Location = new System.Drawing.Point(171, 243);
            this.end_datetimepicker.Name = "end_datetimepicker";
            this.end_datetimepicker.Size = new System.Drawing.Size(88, 20);
            this.end_datetimepicker.TabIndex = 4;
            this.end_datetimepicker.ValueChanged += new System.EventHandler(this.end_datetimepicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End";
            // 
            // daily_radiobutton
            // 
            this.daily_radiobutton.AutoSize = true;
            this.daily_radiobutton.Checked = true;
            this.daily_radiobutton.Location = new System.Drawing.Point(6, 19);
            this.daily_radiobutton.Name = "daily_radiobutton";
            this.daily_radiobutton.Size = new System.Drawing.Size(48, 17);
            this.daily_radiobutton.TabIndex = 6;
            this.daily_radiobutton.TabStop = true;
            this.daily_radiobutton.Text = "Daily";
            this.daily_radiobutton.UseVisualStyleBackColor = true;
            // 
            // weekly_radiobutton
            // 
            this.weekly_radiobutton.AutoSize = true;
            this.weekly_radiobutton.Location = new System.Drawing.Point(60, 19);
            this.weekly_radiobutton.Name = "weekly_radiobutton";
            this.weekly_radiobutton.Size = new System.Drawing.Size(61, 17);
            this.weekly_radiobutton.TabIndex = 7;
            this.weekly_radiobutton.Text = "Weekly";
            this.weekly_radiobutton.UseVisualStyleBackColor = true;
            // 
            // monthly_radiobutton
            // 
            this.monthly_radiobutton.AutoSize = true;
            this.monthly_radiobutton.Location = new System.Drawing.Point(128, 19);
            this.monthly_radiobutton.Name = "monthly_radiobutton";
            this.monthly_radiobutton.Size = new System.Drawing.Size(62, 17);
            this.monthly_radiobutton.TabIndex = 8;
            this.monthly_radiobutton.Text = "Monthly";
            this.monthly_radiobutton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthly_radiobutton);
            this.groupBox1.Controls.Add(this.weekly_radiobutton);
            this.groupBox1.Controls.Add(this.daily_radiobutton);
            this.groupBox1.Location = new System.Drawing.Point(15, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 49);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Type";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(347, 296);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 10;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(228, 296);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(75, 23);
            this.export_button.TabIndex = 11;
            this.export_button.Text = "Export";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // filename_textbox
            // 
            this.filename_textbox.Location = new System.Drawing.Point(15, 197);
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.ReadOnly = true;
            this.filename_textbox.Size = new System.Drawing.Size(407, 20);
            this.filename_textbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "File";
            // 
            // printers_listbox
            // 
            this.printers_listbox.FormattingEnabled = true;
            this.printers_listbox.Location = new System.Drawing.Point(12, 25);
            this.printers_listbox.Name = "printers_listbox";
            this.printers_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.printers_listbox.Size = new System.Drawing.Size(410, 147);
            this.printers_listbox.TabIndex = 14;
            this.printers_listbox.SelectedIndexChanged += new System.EventHandler(this.printers_listbox_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 331);
            this.Controls.Add(this.printers_listbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filename_textbox);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.end_datetimepicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_datetimepicker);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_datetimepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker end_datetimepicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton daily_radiobutton;
        private System.Windows.Forms.RadioButton weekly_radiobutton;
        private System.Windows.Forms.RadioButton monthly_radiobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.TextBox filename_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox printers_listbox;
    }
}
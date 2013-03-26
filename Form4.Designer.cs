namespace pagecount
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.date_disabled_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.time_disabled_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // date_disabled_datetimepicker
            // 
            this.date_disabled_datetimepicker.CustomFormat = "";
            this.date_disabled_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_disabled_datetimepicker.Location = new System.Drawing.Point(90, 12);
            this.date_disabled_datetimepicker.Name = "date_disabled_datetimepicker";
            this.date_disabled_datetimepicker.Size = new System.Drawing.Size(96, 20);
            this.date_disabled_datetimepicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date disabled";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(15, 85);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(111, 85);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time Disabled (0-23)";
            // 
            // time_disabled_datetimepicker
            // 
            this.time_disabled_datetimepicker.CustomFormat = "HH";
            this.time_disabled_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_disabled_datetimepicker.Location = new System.Drawing.Point(140, 45);
            this.time_disabled_datetimepicker.Name = "time_disabled_datetimepicker";
            this.time_disabled_datetimepicker.ShowUpDown = true;
            this.time_disabled_datetimepicker.Size = new System.Drawing.Size(46, 20);
            this.time_disabled_datetimepicker.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 120);
            this.Controls.Add(this.time_disabled_datetimepicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_disabled_datetimepicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Disable printer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_disabled_datetimepicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker time_disabled_datetimepicker;
    }
}
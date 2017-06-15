namespace VehicleRental
{
    partial class Main
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
            this.cbVehicles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPerDay = new System.Windows.Forms.Button();
            this.btnPerKM = new System.Windows.Forms.Button();
            this.txtJourney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddFuel = new System.Windows.Forms.Button();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnService = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVehicles
            // 
            this.cbVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehicles.FormattingEnabled = true;
            this.cbVehicles.Items.AddRange(new object[] {
            "Audi A6, 1 ABC 221",
            "Ford T812, 1 ABD 760",
            "Jaguar X200 1 ABG 432"});
            this.cbVehicles.Location = new System.Drawing.Point(393, 13);
            this.cbVehicles.Name = "cbVehicles";
            this.cbVehicles.Size = new System.Drawing.Size(179, 21);
            this.cbVehicles.TabIndex = 0;
            this.cbVehicles.SelectedIndexChanged += new System.EventHandler(this.cbVehicles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Vehicle:";
            // 
            // rtbReport
            // 
            this.rtbReport.Location = new System.Drawing.Point(312, 54);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.Size = new System.Drawing.Size(260, 191);
            this.rtbReport.TabIndex = 2;
            this.rtbReport.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(415, 251);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDays);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPerDay);
            this.groupBox1.Controls.Add(this.btnPerKM);
            this.groupBox1.Controls.Add(this.txtJourney);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journey";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(98, 45);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(156, 20);
            this.txtDays.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Days Rented:";
            // 
            // btnPerDay
            // 
            this.btnPerDay.Location = new System.Drawing.Point(179, 71);
            this.btnPerDay.Name = "btnPerDay";
            this.btnPerDay.Size = new System.Drawing.Size(75, 23);
            this.btnPerDay.TabIndex = 11;
            this.btnPerDay.Text = "Per Day";
            this.btnPerDay.UseVisualStyleBackColor = true;
            this.btnPerDay.Click += new System.EventHandler(this.btnPerDay_Click);
            // 
            // btnPerKM
            // 
            this.btnPerKM.Location = new System.Drawing.Point(98, 71);
            this.btnPerKM.Name = "btnPerKM";
            this.btnPerKM.Size = new System.Drawing.Size(75, 23);
            this.btnPerKM.TabIndex = 8;
            this.btnPerKM.Text = "Per KM";
            this.btnPerKM.UseVisualStyleBackColor = true;
            this.btnPerKM.Click += new System.EventHandler(this.btnPerKM_Click);
            // 
            // txtJourney
            // 
            this.txtJourney.Location = new System.Drawing.Point(98, 19);
            this.txtJourney.Name = "txtJourney";
            this.txtJourney.Size = new System.Drawing.Size(156, 20);
            this.txtJourney.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "KM Travelled:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddFuel);
            this.groupBox2.Controls.Add(this.txtFuel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel";
            // 
            // btnAddFuel
            // 
            this.btnAddFuel.Location = new System.Drawing.Point(179, 45);
            this.btnAddFuel.Name = "btnAddFuel";
            this.btnAddFuel.Size = new System.Drawing.Size(75, 23);
            this.btnAddFuel.TabIndex = 9;
            this.btnAddFuel.Text = "Add Fuel";
            this.btnAddFuel.UseVisualStyleBackColor = true;
            this.btnAddFuel.Click += new System.EventHandler(this.btnAddFuel_Click);
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(98, 19);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(156, 20);
            this.txtFuel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Litres Purchased:";
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(6, 16);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(245, 23);
            this.btnService.TabIndex = 8;
            this.btnService.Text = "One Click Vehicle Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnService);
            this.groupBox4.Location = new System.Drawing.Point(12, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 45);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Service";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 286);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVehicles);
            this.Name = "Main";
            this.Text = "Rental Vehicles";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPerKM;
        private System.Windows.Forms.TextBox txtJourney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddFuel;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnPerDay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDays;
    }
}


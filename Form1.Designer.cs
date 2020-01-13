namespace missionControl1
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.tb_raw = new System.Windows.Forms.TextBox();
            this.tb_lat_p = new System.Windows.Forms.TextBox();
            this.tb_lon_p = new System.Windows.Forms.TextBox();
            this.btn_data_save = new System.Windows.Forms.Button();
            this.com_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_lat_p = new System.Windows.Forms.Label();
            this.lbl_lon_p = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_acc_x_p = new System.Windows.Forms.TextBox();
            this.tb_mag_y_p = new System.Windows.Forms.TextBox();
            this.tb_mag_z_p = new System.Windows.Forms.TextBox();
            this.tb_mag_x_p = new System.Windows.Forms.TextBox();
            this.tb_gyro_z_p = new System.Windows.Forms.TextBox();
            this.tb_gyro_y_p = new System.Windows.Forms.TextBox();
            this.tb_gyro_x_p = new System.Windows.Forms.TextBox();
            this.tb_acc_z_p = new System.Windows.Forms.TextBox();
            this.tb_acc_y_p = new System.Windows.Forms.TextBox();
            this.imu_panel_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_pres_p = new System.Windows.Forms.TextBox();
            this.tb_temp_p = new System.Windows.Forms.TextBox();
            this.lbl_temp_p = new System.Windows.Forms.Label();
            this.lbl_pres_p = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pres_b = new System.Windows.Forms.TextBox();
            this.tb_temp_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_lon_b = new System.Windows.Forms.TextBox();
            this.tb_lat_b = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_acc_y_b = new System.Windows.Forms.TextBox();
            this.tb_gyro_y_b = new System.Windows.Forms.TextBox();
            this.tb_acc_z_b = new System.Windows.Forms.TextBox();
            this.tb_acc_x_b = new System.Windows.Forms.TextBox();
            this.tb_gyro_x_b = new System.Windows.Forms.TextBox();
            this.tb_mag_y_b = new System.Windows.Forms.TextBox();
            this.tb_mag_z_b = new System.Windows.Forms.TextBox();
            this.tb_gyro_z_b = new System.Windows.Forms.TextBox();
            this.tb_mag_x_b = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(780, 110);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(645, 659);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // tb_raw
            // 
            this.tb_raw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_raw.Location = new System.Drawing.Point(19, 70);
            this.tb_raw.Name = "tb_raw";
            this.tb_raw.ReadOnly = true;
            this.tb_raw.Size = new System.Drawing.Size(1406, 20);
            this.tb_raw.TabIndex = 2;
            // 
            // tb_lat_p
            // 
            this.tb_lat_p.Location = new System.Drawing.Point(13, 53);
            this.tb_lat_p.Name = "tb_lat_p";
            this.tb_lat_p.ReadOnly = true;
            this.tb_lat_p.Size = new System.Drawing.Size(87, 20);
            this.tb_lat_p.TabIndex = 3;
            // 
            // tb_lon_p
            // 
            this.tb_lon_p.Location = new System.Drawing.Point(106, 53);
            this.tb_lon_p.Name = "tb_lon_p";
            this.tb_lon_p.ReadOnly = true;
            this.tb_lon_p.Size = new System.Drawing.Size(87, 20);
            this.tb_lon_p.TabIndex = 4;
            // 
            // btn_data_save
            // 
            this.btn_data_save.Location = new System.Drawing.Point(20, 25);
            this.btn_data_save.Name = "btn_data_save";
            this.btn_data_save.Size = new System.Drawing.Size(197, 56);
            this.btn_data_save.TabIndex = 5;
            this.btn_data_save.Text = "Start Saving";
            this.btn_data_save.UseVisualStyleBackColor = true;
            this.btn_data_save.Click += new System.EventHandler(this.btn_data_save_Click);
            // 
            // com_port
            // 
            this.com_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_port.FormattingEnabled = true;
            this.com_port.Location = new System.Drawing.Point(19, 138);
            this.com_port.Name = "com_port";
            this.com_port.Size = new System.Drawing.Size(102, 21);
            this.com_port.TabIndex = 6;
            this.com_port.SelectedIndexChanged += new System.EventHandler(this.com_port_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Serial Port";
            // 
            // lbl_lat_p
            // 
            this.lbl_lat_p.AutoSize = true;
            this.lbl_lat_p.Location = new System.Drawing.Point(15, 37);
            this.lbl_lat_p.Name = "lbl_lat_p";
            this.lbl_lat_p.Size = new System.Drawing.Size(45, 13);
            this.lbl_lat_p.TabIndex = 8;
            this.lbl_lat_p.Text = "Latitude";
            // 
            // lbl_lon_p
            // 
            this.lbl_lon_p.AutoSize = true;
            this.lbl_lon_p.Location = new System.Drawing.Point(103, 37);
            this.lbl_lon_p.Name = "lbl_lon_p";
            this.lbl_lon_p.Size = new System.Drawing.Size(54, 13);
            this.lbl_lon_p.TabIndex = 9;
            this.lbl_lon_p.Text = "Longitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CSV Logger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Raw Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label6.Location = new System.Drawing.Point(571, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mission Control";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(113, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Booster Section";
            // 
            // tb_acc_x_p
            // 
            this.tb_acc_x_p.Location = new System.Drawing.Point(132, 40);
            this.tb_acc_x_p.Name = "tb_acc_x_p";
            this.tb_acc_x_p.ReadOnly = true;
            this.tb_acc_x_p.Size = new System.Drawing.Size(57, 20);
            this.tb_acc_x_p.TabIndex = 21;
            // 
            // tb_mag_y_p
            // 
            this.tb_mag_y_p.Location = new System.Drawing.Point(195, 116);
            this.tb_mag_y_p.Name = "tb_mag_y_p";
            this.tb_mag_y_p.ReadOnly = true;
            this.tb_mag_y_p.Size = new System.Drawing.Size(57, 20);
            this.tb_mag_y_p.TabIndex = 22;
            // 
            // tb_mag_z_p
            // 
            this.tb_mag_z_p.Location = new System.Drawing.Point(258, 116);
            this.tb_mag_z_p.Name = "tb_mag_z_p";
            this.tb_mag_z_p.ReadOnly = true;
            this.tb_mag_z_p.Size = new System.Drawing.Size(57, 20);
            this.tb_mag_z_p.TabIndex = 23;
            // 
            // tb_mag_x_p
            // 
            this.tb_mag_x_p.Location = new System.Drawing.Point(131, 116);
            this.tb_mag_x_p.Name = "tb_mag_x_p";
            this.tb_mag_x_p.ReadOnly = true;
            this.tb_mag_x_p.Size = new System.Drawing.Size(57, 20);
            this.tb_mag_x_p.TabIndex = 24;
            // 
            // tb_gyro_z_p
            // 
            this.tb_gyro_z_p.Location = new System.Drawing.Point(259, 78);
            this.tb_gyro_z_p.Name = "tb_gyro_z_p";
            this.tb_gyro_z_p.ReadOnly = true;
            this.tb_gyro_z_p.Size = new System.Drawing.Size(57, 20);
            this.tb_gyro_z_p.TabIndex = 25;
            // 
            // tb_gyro_y_p
            // 
            this.tb_gyro_y_p.Location = new System.Drawing.Point(195, 78);
            this.tb_gyro_y_p.Name = "tb_gyro_y_p";
            this.tb_gyro_y_p.ReadOnly = true;
            this.tb_gyro_y_p.Size = new System.Drawing.Size(57, 20);
            this.tb_gyro_y_p.TabIndex = 26;
            // 
            // tb_gyro_x_p
            // 
            this.tb_gyro_x_p.Location = new System.Drawing.Point(132, 78);
            this.tb_gyro_x_p.Name = "tb_gyro_x_p";
            this.tb_gyro_x_p.ReadOnly = true;
            this.tb_gyro_x_p.Size = new System.Drawing.Size(57, 20);
            this.tb_gyro_x_p.TabIndex = 27;
            // 
            // tb_acc_z_p
            // 
            this.tb_acc_z_p.Location = new System.Drawing.Point(258, 40);
            this.tb_acc_z_p.Name = "tb_acc_z_p";
            this.tb_acc_z_p.ReadOnly = true;
            this.tb_acc_z_p.Size = new System.Drawing.Size(57, 20);
            this.tb_acc_z_p.TabIndex = 28;
            // 
            // tb_acc_y_p
            // 
            this.tb_acc_y_p.Location = new System.Drawing.Point(195, 40);
            this.tb_acc_y_p.Name = "tb_acc_y_p";
            this.tb_acc_y_p.ReadOnly = true;
            this.tb_acc_y_p.Size = new System.Drawing.Size(57, 20);
            this.tb_acc_y_p.TabIndex = 29;
            // 
            // imu_panel_lbl
            // 
            this.imu_panel_lbl.AutoSize = true;
            this.imu_panel_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.imu_panel_lbl.Location = new System.Drawing.Point(4, 4);
            this.imu_panel_lbl.Name = "imu_panel_lbl";
            this.imu_panel_lbl.Size = new System.Drawing.Size(78, 20);
            this.imu_panel_lbl.TabIndex = 30;
            this.imu_panel_lbl.Text = "IMU Data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.imu_panel_lbl);
            this.panel1.Controls.Add(this.tb_acc_y_p);
            this.panel1.Controls.Add(this.tb_gyro_y_p);
            this.panel1.Controls.Add(this.tb_acc_z_p);
            this.panel1.Controls.Add(this.tb_acc_x_p);
            this.panel1.Controls.Add(this.tb_gyro_x_p);
            this.panel1.Controls.Add(this.tb_mag_y_p);
            this.panel1.Controls.Add(this.tb_mag_z_p);
            this.panel1.Controls.Add(this.tb_gyro_z_p);
            this.panel1.Controls.Add(this.tb_mag_x_p);
            this.panel1.Location = new System.Drawing.Point(15, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 155);
            this.panel1.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Acceleration (ft/s^2)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Rotation Rate (dps)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Magnetic Field (gauss)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "x-axis";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(195, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "y-axis";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(256, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "z-axis";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tb_lon_p);
            this.panel2.Controls.Add(this.tb_lat_p);
            this.panel2.Controls.Add(this.lbl_lat_p);
            this.panel2.Controls.Add(this.lbl_lon_p);
            this.panel2.Location = new System.Drawing.Point(80, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 83);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_data_save);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(242, 654);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 99);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(18, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 409);
            this.panel4.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label17.Location = new System.Drawing.Point(147, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 33;
            this.label17.Text = "PEANUT";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(65, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "Location";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.tb_pres_p);
            this.panel5.Controls.Add(this.tb_temp_p);
            this.panel5.Controls.Add(this.lbl_temp_p);
            this.panel5.Controls.Add(this.lbl_pres_p);
            this.panel5.Location = new System.Drawing.Point(80, 148);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 87);
            this.panel5.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(65, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Temp/Alt";
            // 
            // tb_pres_p
            // 
            this.tb_pres_p.Location = new System.Drawing.Point(106, 53);
            this.tb_pres_p.Name = "tb_pres_p";
            this.tb_pres_p.ReadOnly = true;
            this.tb_pres_p.Size = new System.Drawing.Size(87, 20);
            this.tb_pres_p.TabIndex = 4;
            // 
            // tb_temp_p
            // 
            this.tb_temp_p.Location = new System.Drawing.Point(13, 53);
            this.tb_temp_p.Name = "tb_temp_p";
            this.tb_temp_p.ReadOnly = true;
            this.tb_temp_p.Size = new System.Drawing.Size(87, 20);
            this.tb_temp_p.TabIndex = 3;
            // 
            // lbl_temp_p
            // 
            this.lbl_temp_p.AutoSize = true;
            this.lbl_temp_p.Location = new System.Drawing.Point(15, 37);
            this.lbl_temp_p.Name = "lbl_temp_p";
            this.lbl_temp_p.Size = new System.Drawing.Size(83, 13);
            this.lbl_temp_p.TabIndex = 8;
            this.lbl_temp_p.Text = "Temperature (C)";
            // 
            // lbl_pres_p
            // 
            this.lbl_pres_p.AutoSize = true;
            this.lbl_pres_p.Location = new System.Drawing.Point(107, 37);
            this.lbl_pres_p.Name = "lbl_pres_p";
            this.lbl_pres_p.Size = new System.Drawing.Size(70, 13);
            this.lbl_pres_p.TabIndex = 9;
            this.lbl_pres_p.Text = "Pressure (Pa)";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Location = new System.Drawing.Point(390, 222);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 409);
            this.panel6.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.tb_pres_b);
            this.panel7.Controls.Add(this.tb_temp_b);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(80, 148);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 87);
            this.panel7.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(65, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Temp/Alt";
            // 
            // tb_pres_b
            // 
            this.tb_pres_b.Location = new System.Drawing.Point(106, 53);
            this.tb_pres_b.Name = "tb_pres_b";
            this.tb_pres_b.ReadOnly = true;
            this.tb_pres_b.Size = new System.Drawing.Size(87, 20);
            this.tb_pres_b.TabIndex = 4;
            // 
            // tb_temp_b
            // 
            this.tb_temp_b.Location = new System.Drawing.Point(13, 53);
            this.tb_temp_b.Name = "tb_temp_b";
            this.tb_temp_b.ReadOnly = true;
            this.tb_temp_b.Size = new System.Drawing.Size(87, 20);
            this.tb_temp_b.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Temperature (C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pressure (Pa)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(147, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "BUTTER";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.tb_lon_b);
            this.panel8.Controls.Add(this.tb_lat_b);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Location = new System.Drawing.Point(80, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(204, 83);
            this.panel8.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(65, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Location";
            // 
            // tb_lon_b
            // 
            this.tb_lon_b.Location = new System.Drawing.Point(106, 53);
            this.tb_lon_b.Name = "tb_lon_b";
            this.tb_lon_b.ReadOnly = true;
            this.tb_lon_b.Size = new System.Drawing.Size(87, 20);
            this.tb_lon_b.TabIndex = 4;
            // 
            // tb_lat_b
            // 
            this.tb_lat_b.Location = new System.Drawing.Point(13, 53);
            this.tb_lat_b.Name = "tb_lat_b";
            this.tb_lat_b.ReadOnly = true;
            this.tb_lat_b.Size = new System.Drawing.Size(87, 20);
            this.tb_lat_b.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Latitude";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(103, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Longitude";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label22);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.label24);
            this.panel9.Controls.Add(this.label25);
            this.panel9.Controls.Add(this.label26);
            this.panel9.Controls.Add(this.label27);
            this.panel9.Controls.Add(this.label28);
            this.panel9.Controls.Add(this.tb_acc_y_b);
            this.panel9.Controls.Add(this.tb_gyro_y_b);
            this.panel9.Controls.Add(this.tb_acc_z_b);
            this.panel9.Controls.Add(this.tb_acc_x_b);
            this.panel9.Controls.Add(this.tb_gyro_x_b);
            this.panel9.Controls.Add(this.tb_mag_y_b);
            this.panel9.Controls.Add(this.tb_mag_z_b);
            this.panel9.Controls.Add(this.tb_gyro_z_b);
            this.panel9.Controls.Add(this.tb_mag_x_b);
            this.panel9.Location = new System.Drawing.Point(15, 241);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 155);
            this.panel9.TabIndex = 31;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(256, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "z-axis";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(195, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 34;
            this.label23.Text = "y-axis";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(129, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 33;
            this.label24.Text = "x-axis";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 119);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "Magnetic Field (gauss)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 81);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "Rotation Rate (dps)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 13);
            this.label27.TabIndex = 31;
            this.label27.Text = "Acceleration (ft/s^2)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label28.Location = new System.Drawing.Point(4, 4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 20);
            this.label28.TabIndex = 30;
            this.label28.Text = "IMU Data";
            // 
            // tb_acc_y_b
            // 
            this.tb_acc_y_b.Location = new System.Drawing.Point(195, 40);
            this.tb_acc_y_b.Name = "tb_acc_y_b";
            this.tb_acc_y_b.ReadOnly = true;
            this.tb_acc_y_b.Size = new System.Drawing.Size(57, 20);
            this.tb_acc_y_b.TabIndex = 29;
            // 
            // tb_gyro_y_b
            // 
            this.tb_gyro_y_b.Location = new System.Drawing.Point(195, 78);
            this.tb_gyro_y_b.Name = "tb_gyro_y_b";
            this.tb_gyro_y_b.ReadOnly = true;
            this.tb_gyro_y_b.Size = new System.Drawing.Size(57, 20);
            this.tb_gyro_y_b.TabIndex = 26;
            // 
            // tb_acc_z_b
            // 
            this.tb_acc_z_b.Location = new System.Drawing.Point(258, 40);
            this.tb_acc_z_b.Name = "tb_acc_z_b";
            this.tb_acc_z_b.ReadOnly = true;
            this.tb_acc_z_b.Size = new System.Drawing.Size(57, 20);
            this.tb_acc_z_b.TabIndex = 28;
            // 
            // tb_acc_x_b
            // 
            this.tb_acc_x_b.Location = new System.Drawing.Point(132, 40);
            this.tb_acc_x_b.Name = "tb_acc_x_b";
            this.tb_acc_x_b.ReadOnly = true;
            this.tb_acc_x_b.Size = new System.Drawing.Size(57, 20);
            this.tb_acc_x_b.TabIndex = 21;
            // 
            // tb_gyro_x_b
            // 
            this.tb_gyro_x_b.Location = new System.Drawing.Point(132, 78);
            this.tb_gyro_x_b.Name = "tb_gyro_x_b";
            this.tb_gyro_x_b.ReadOnly = true;
            this.tb_gyro_x_b.Size = new System.Drawing.Size(57, 20);
            this.tb_gyro_x_b.TabIndex = 27;
            // 
            // tb_mag_y_b
            // 
            this.tb_mag_y_b.Location = new System.Drawing.Point(195, 116);
            this.tb_mag_y_b.Name = "tb_mag_y_b";
            this.tb_mag_y_b.ReadOnly = true;
            this.tb_mag_y_b.Size = new System.Drawing.Size(57, 20);
            this.tb_mag_y_b.TabIndex = 22;
            // 
            // tb_mag_z_b
            // 
            this.tb_mag_z_b.Location = new System.Drawing.Point(258, 116);
            this.tb_mag_z_b.Name = "tb_mag_z_b";
            this.tb_mag_z_b.ReadOnly = true;
            this.tb_mag_z_b.Size = new System.Drawing.Size(57, 20);
            this.tb_mag_z_b.TabIndex = 23;
            // 
            // tb_gyro_z_b
            // 
            this.tb_gyro_z_b.Location = new System.Drawing.Point(259, 78);
            this.tb_gyro_z_b.Name = "tb_gyro_z_b";
            this.tb_gyro_z_b.ReadOnly = true;
            this.tb_gyro_z_b.Size = new System.Drawing.Size(57, 20);
            this.tb_gyro_z_b.TabIndex = 25;
            // 
            // tb_mag_x_b
            // 
            this.tb_mag_x_b.Location = new System.Drawing.Point(131, 116);
            this.tb_mag_x_b.Name = "tb_mag_x_b";
            this.tb_mag_x_b.ReadOnly = true;
            this.tb_mag_x_b.Size = new System.Drawing.Size(57, 20);
            this.tb_mag_x_b.TabIndex = 24;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label29.Location = new System.Drawing.Point(113, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(140, 22);
            this.label29.TabIndex = 19;
            this.label29.Text = "Payload Section";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 793);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_port);
            this.Controls.Add(this.tb_raw);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox tb_raw;
        private System.Windows.Forms.TextBox tb_lat_p;
        private System.Windows.Forms.TextBox tb_lon_p;
        private System.Windows.Forms.Button btn_data_save;
        private System.Windows.Forms.ComboBox com_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lat_p;
        private System.Windows.Forms.Label lbl_lon_p;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_acc_x_p;
        private System.Windows.Forms.TextBox tb_mag_y_p;
        private System.Windows.Forms.TextBox tb_mag_z_p;
        private System.Windows.Forms.TextBox tb_mag_x_p;
        private System.Windows.Forms.TextBox tb_gyro_z_p;
        private System.Windows.Forms.TextBox tb_gyro_y_p;
        private System.Windows.Forms.TextBox tb_gyro_x_p;
        private System.Windows.Forms.TextBox tb_acc_z_p;
        private System.Windows.Forms.TextBox tb_acc_y_p;
        private System.Windows.Forms.Label imu_panel_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_pres_p;
        private System.Windows.Forms.TextBox tb_temp_p;
        private System.Windows.Forms.Label lbl_temp_p;
        private System.Windows.Forms.Label lbl_pres_p;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pres_b;
        private System.Windows.Forms.TextBox tb_temp_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_lon_b;
        private System.Windows.Forms.TextBox tb_lat_b;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_acc_y_b;
        private System.Windows.Forms.TextBox tb_gyro_y_b;
        private System.Windows.Forms.TextBox tb_acc_z_b;
        private System.Windows.Forms.TextBox tb_acc_x_b;
        private System.Windows.Forms.TextBox tb_gyro_x_b;
        private System.Windows.Forms.TextBox tb_mag_y_b;
        private System.Windows.Forms.TextBox tb_mag_z_b;
        private System.Windows.Forms.TextBox tb_gyro_z_b;
        private System.Windows.Forms.TextBox tb_mag_x_b;
        private System.Windows.Forms.Label label29;
    }
}


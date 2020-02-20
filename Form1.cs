using System;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Collections.Generic;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace missionControl1
{
    public partial class Form1 : Form
    {

        SerialPort Port1 = new SerialPort();
        SerialPort Port2 = new SerialPort();
        string[] parsed;
        int[] data_set_all = new int[6] { 1, 4, 7, 10, 11, 15 };
        int[] data_set_gps = new int[2] {4, 6};
        bool fix;
        bool save_flag = false;
        bool init_flag = true;
        int file = 0;
        string tag_1;
        string tag_2;
        string tag_3;
        string tag_1_mode;
        string tag_2_mode;
        string tag_3_mode;
        List<string> tags;
        string csv = "save_dat_";
        string csv_1 = "send_to_Google_";
        string manual_path;
        string[] ports;
        string[] data_settings = new string[2] { "All Data", "GPS Only" };
        GMapOverlay markers = new GMapOverlay("markers");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            com_port_1.Items.AddRange(ports);
            com_port_2.Items.AddRange(ports);
            tags = new List<string> { "PEANUT", "BUTTER", "JELLY" };
            cb_tag_1.Items.AddRange(tags.ToArray());
            cb_tag_2.Items.AddRange(tags.ToArray());
            cb_tag_3.Items.AddRange(tags.ToArray());
            Port1.BaudRate = 9600;
            Port1.Parity = Parity.None;
            Port1.StopBits = StopBits.One;
            Port1.DataBits = 8;
            Port1.Handshake = Handshake.None;
            Port1.RtsEnable = true;
            Port1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            
            Port2.BaudRate = 9600;
            Port2.Parity = Parity.None;
            Port2.StopBits = StopBits.One;
            Port2.DataBits = 8;
            Port2.Handshake = Handshake.None;
            Port2.RtsEnable = true;
            Port2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            cb_sens_mode_p.Items.AddRange(data_settings);
            cb_sens_mode_b.Items.AddRange(data_settings);
            cb_sens_mode_j.Items.AddRange(data_settings);

            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.MapProvider = GoogleMapProvider.Instance;
            map.CacheLocation = "mapcache";
            map.MinZoom = 5;
            map.MaxZoom = 18;
            map.Zoom = 16;
            map.Overlays.Add(markers);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            if (save_flag)
            {
                File.AppendAllText(manual_path, indata);
            }
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    tb_raw.Text = indata;
                });
            }
            catch (InvalidOperationException)
            {
                // This happens when closing the GUI
            }

            parsed = parse_string(indata);
            bool matching = false;
            foreach (string tag in tags)
            {
                if (parsed[0] == tag)
                {
                    matching = true;
                }
            }
            if (!matching)
            {
                if (parsed[0].Length > 0 && parsed[0].Length < 10)
                {
                    tags.Add(parsed[0]);
                }
                return;
            }
            int which_tag = 0;
            List<string> used_tags = new List<string> { tag_1, tag_2, tag_3 };
            List<string> used_modes = new List<string> { tag_1_mode, tag_2_mode, tag_3_mode };
            foreach(string tag in used_tags)
            {
                if (parsed[0] == tag && !string.IsNullOrEmpty(used_modes[which_tag]))
                {
                    switch (used_modes[which_tag])
                    {
                        case "All Data":
                            text_all_data(parsed);
                            sp.DiscardInBuffer();
                            return;

                        case "GPS Only":
                            text_gps_data(parsed);
                            sp.DiscardInBuffer();
                            return;
                    }

                }
                which_tag++;
            }
        }

        private string[] parse_string(string input_data)
        {
            string[] alldat = input_data.Split(',');
            return alldat;
        }

        private void text_gps_data(string[] dat_delim)
        {
            int equ;
            int mer;
            double lat = 0.0;
            double lon = 0.0;

            if (dat_delim.Length <= 8 || dat_delim.Length > 15) return; // Checking for data

            if (dat_delim[data_set_gps[0]] == "") fix = false; // if the latitude string is empty there is no fix
            else fix = true;

            if (dat_delim[data_set_gps[0] + 1] == "N") equ = 1;
            else equ = -1;

            if (dat_delim[data_set_gps[1] + 1] == "E") mer = 1;
            else mer = -1;
            if (fix)
            {
                lat = Convert.ToDouble(get_geo(dat_delim[data_set_gps[0]])) * equ;
                lon = Convert.ToDouble(get_geo(dat_delim[data_set_gps[1]])) * mer;
            }
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    markers.Clear();
                    if (dat_delim[0] == tag_1)
                    {
                        tb_lat_p.Text = lat.ToString();
                        tb_lon_p.Text = lon.ToString();
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_small);
                        markers.Markers.Add(marker);
                    }
                    else if (dat_delim[0] == tag_2)
                    {
                        tb_lat_b.Text = lat.ToString();
                        tb_lon_b.Text = lon.ToString();
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red_small);
                        markers.Markers.Add(marker);
                    }
                    else if (dat_delim[0] == tag_3)
                    {
                        tb_lat_j.Text = lat.ToString();
                        tb_lon_j.Text = lon.ToString();
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green_small);
                        markers.Markers.Add(marker);
                    }
                    PointLatLng pos = map.Position;

                    double lat_error = Math.Abs(lat - pos.Lat);
                    double lon_error = Math.Abs(lon - pos.Lng);

                    if (fix && (lat_error > 0.007 || lon_error > 0.007))
                    {
                        map.Position = new PointLatLng(lat, lon);
                    }
                });
            }
            catch (InvalidOperationException)
            {
                // This happens when closing the GUI
            }
        }

        private void text_all_data(string[] dat_delim)
        {
            int equ;
            int mer;
            double lat = 0.0;
            double lon = 0.0;

            if (dat_delim.Length <= 15 || dat_delim.Length > 25 ) return; // Checking for data
            
            if (dat_delim[data_set_all[5]] == "") fix = false; // if the latitude string is empty there is no fix
            else fix = true;

            if (dat_delim[data_set_all[5] + 1] == "N") equ = 1;
            else equ = -1;

            if (dat_delim[data_set_all[5] + 3] == "E") mer = 1;
            else mer = -1;
            if (fix)
            {
                lat = Convert.ToDouble(get_geo(dat_delim[data_set_all[5]])) * equ;
                lon = Convert.ToDouble(get_geo(dat_delim[data_set_all[5] + 2])) * mer;
            }
            // This will update all GUI elements whenever new data is received
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    markers.Clear();
                    if (dat_delim[0] == tag_1)
                    {
                        tb_lat_p.Text = lat.ToString();
                        tb_lon_p.Text = lon.ToString();
                        tb_acc_x_p.Text = dat_delim[data_set_all[0]];
                        tb_acc_y_p.Text = dat_delim[data_set_all[0] + 1];
                        tb_acc_z_p.Text = dat_delim[data_set_all[0] + 2];
                        tb_gyro_x_p.Text = dat_delim[data_set_all[1]];
                        tb_gyro_y_p.Text = dat_delim[data_set_all[1] + 1];
                        tb_gyro_z_p.Text = dat_delim[data_set_all[1] + 2];
                        tb_mag_x_p.Text = dat_delim[data_set_all[2]];
                        tb_mag_y_p.Text = dat_delim[data_set_all[2] + 1];
                        tb_mag_z_p.Text = dat_delim[data_set_all[2] + 2];
                        tb_temp_p.Text = dat_delim[data_set_all[3]];
                        tb_pres_p.Text = dat_delim[data_set_all[4]];
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_small);
                        markers.Markers.Add(marker);
                    }
                    else if (dat_delim[0] == tag_2)
                    {
                        tb_lat_b.Text = lat.ToString();
                        tb_lon_b.Text = lon.ToString();
                        tb_acc_x_b.Text = dat_delim[data_set_all[0]];
                        tb_acc_y_b.Text = dat_delim[data_set_all[0] + 1];
                        tb_acc_z_b.Text = dat_delim[data_set_all[0] + 2];
                        tb_gyro_x_b.Text = dat_delim[data_set_all[1]];
                        tb_gyro_y_b.Text = dat_delim[data_set_all[1] + 1];
                        tb_gyro_z_b.Text = dat_delim[data_set_all[1] + 2];
                        tb_mag_x_b.Text = dat_delim[data_set_all[2]];
                        tb_mag_y_b.Text = dat_delim[data_set_all[2] + 1];
                        tb_mag_z_b.Text = dat_delim[data_set_all[2] + 2];
                        tb_temp_b.Text = dat_delim[data_set_all[3]];
                        tb_pres_b.Text = dat_delim[data_set_all[4]];
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red_small);
                        markers.Markers.Add(marker);
                    }
                    else if(dat_delim[0] == tag_3)
                    {
                        tb_lat_j.Text = lat.ToString();
                        tb_lon_j.Text = lon.ToString();
                        tb_acc_x_j.Text = dat_delim[data_set_all[0]];
                        tb_acc_y_j.Text = dat_delim[data_set_all[0] + 1];
                        tb_acc_z_j.Text = dat_delim[data_set_all[0] + 2];
                        tb_gyro_x_j.Text = dat_delim[data_set_all[1]];
                        tb_gyro_y_j.Text = dat_delim[data_set_all[1] + 1];
                        tb_gyro_z_j.Text = dat_delim[data_set_all[1] + 2];
                        tb_mag_x_j.Text = dat_delim[data_set_all[2]];
                        tb_mag_y_j.Text = dat_delim[data_set_all[2] + 1];
                        tb_mag_z_j.Text = dat_delim[data_set_all[2] + 2];
                        tb_temp_j.Text = dat_delim[data_set_all[3]];
                        tb_pres_j.Text = dat_delim[data_set_all[4]];
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green_small);
                        markers.Markers.Add(marker);
                    }
                    PointLatLng pos = map.Position;

                    double lat_error = Math.Abs(lat - pos.Lat);
                    double lon_error = Math.Abs(lon - pos.Lng);

                    if (fix && (lat_error > 0.007 || lon_error > 0.007))
                    {
                        map.Position = new PointLatLng(lat, lon);
                    }
                });
            }
            catch (InvalidOperationException)
            {
                // This happens when closing the GUI
            }
        }

        private string get_geo(string coord)
        {
            float geo = float.Parse(coord, CultureInfo.InvariantCulture.NumberFormat);
            int dd = (int)geo / 100;
            float ss = geo - (float)dd * 100;
            geo = dd + ss / 60;
            return geo.ToString("0.00000");
        }

        private void btn_data_save_Click(object sender, EventArgs e)
        {
            if (init_flag)
            {
                string header = "manual_saver\n";
                while (File.Exists(csv + file.ToString() + ".csv"))
                {
                    file++;
                }
                manual_path = csv + file.ToString() + ".csv";
                File.WriteAllText(manual_path, header);
                init_flag = false;
            }
            if (!save_flag) btn_data_save.Text = "Stop Saving";
            else btn_data_save.Text = "Start Saving";

            save_flag = !save_flag;
        }

        private void com_port_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Port1.Close();
                Port1.PortName = com_port_1.Text;
                Port1.Open();
            }
            catch (System.UnauthorizedAccessException)
            {

            }
        }

        private void com_list_up_1_Click(object sender, EventArgs e)
        {
            com_port_1.Items.Clear();
            ports = SerialPort.GetPortNames();
            com_port_1.Items.AddRange(ports);
        }

        private void com_port_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                Port2.Close();
                Port2.PortName = com_port_2.Text;
                Port2.Open();
            }
            catch (System.UnauthorizedAccessException)
            {
                
            }
        }

        private void com_list_up_2_Click(object sender, EventArgs e)
        {
            com_port_2.Items.Clear();
            ports = SerialPort.GetPortNames();
            com_port_2.Items.AddRange(ports);
        }

        private void cb_tag_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag_1 = cb_tag_1.Text;
            tb_tag_1.Text = tag_1;
        }

        private void cb_tag_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag_2 = cb_tag_2.Text;
            tb_tag_2.Text = tag_2;
        }

        private void cb_tag_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag_3 = cb_tag_3.Text;
            tb_tag_3.Text = tag_3;
        }

        private void btn_tag1_Click(object sender, EventArgs e)
        {
            cb_tag_1.Items.Clear();
            cb_tag_1.Items.AddRange(tags.ToArray());
        }

        private void btn_tag_2_Click(object sender, EventArgs e)
        {
            cb_tag_2.Items.Clear();
            cb_tag_2.Items.AddRange(tags.ToArray());
        }

        private void btn_tag_3_Click(object sender, EventArgs e)
        {
            cb_tag_3.Items.Clear();
            cb_tag_3.Items.AddRange(tags.ToArray());
        }

        private void cb_sens_mode_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_sens_mode_p.Text == data_settings[0])
            {
                tag_1_mode = data_settings[0];
            }
            else if(cb_sens_mode_p.Text == data_settings[1])
            {
                tag_1_mode = data_settings[1];
            }
        }

        private void cb_sens_mode_b_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sens_mode_b.Text == data_settings[0])
            {
                tag_2_mode = data_settings[0];
            }
            else if (cb_sens_mode_b.Text == data_settings[1])
            {
                tag_2_mode = data_settings[1];
            }
        }

        private void cb_sens_mode_j_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sens_mode_j.Text == data_settings[0])
            {
                tag_3_mode = data_settings[0];
            }
            else if (cb_sens_mode_j.Text == data_settings[1])
            {
                tag_3_mode = data_settings[1];
            }
        }
    }
}

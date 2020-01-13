using System;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace missionControl1
{
    public partial class Form1 : Form
    {

        SerialPort mySerialPort = new SerialPort();
        string[] parsed;
        const int acc_index = 1;
        const int gyro_index = 4;
        const int mag_index = 7;
        const int temp_index = 10;
        const int pres_index = 11;
        const int lat_pos = 15;
        bool fix;
        bool save_flag = false;
        bool init_flag = true;
        int file = 0;
        string booster_section = "PEANUT";
        string payload_section = "BUTTER";
        string csv = "save_dat_";
        string manual_path;
        string[] ports;
        GMapOverlay markers = new GMapOverlay("markers");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            com_port.Items.AddRange(ports);
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;
            
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //map.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
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
            update_text(parsed);
            sp.DiscardInBuffer();
        }

        private string[] parse_string(string input_data)
        {
            string[] alldat = input_data.Split(',');
            return alldat;
        }

        private void update_text(string[] dat_delim)
        {
            int equ;
            int mer;
            double lat = 0.0;
            double lon = 0.0;

            if (dat_delim.Length <= 1 || dat_delim.Length > 25 ) return; // Checking for data

            if (!(dat_delim[0] == booster_section) && !(dat_delim[0] == payload_section)) return; // Check that the rigth data is being sent

            if (dat_delim[lat_pos] == "") fix = false; // if the latitude string is empty there is no fix
            else fix = true;

            if (dat_delim[lat_pos + 1] == "N") equ = 1;
            else equ = -1;

            if (dat_delim[lat_pos + 3] == "E") mer = 1;
            else mer = -1;
            if (fix)
            {
                lat = Convert.ToDouble(get_geo(dat_delim[lat_pos])) * equ;
                lon = Convert.ToDouble(get_geo(dat_delim[lat_pos + 2])) * mer;
            }
            // This will update all GUI elements whenever new data is received
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    markers.Clear();
                    if (dat_delim[0] == booster_section)
                    {
                        tb_lat_p.Text = lat.ToString();
                        tb_lon_p.Text = lon.ToString();
                        tb_acc_x_p.Text = dat_delim[acc_index];
                        tb_acc_y_p.Text = dat_delim[acc_index + 1];
                        tb_acc_z_p.Text = dat_delim[acc_index + 2];
                        tb_gyro_x_p.Text = dat_delim[gyro_index];
                        tb_gyro_y_p.Text = dat_delim[gyro_index + 1];
                        tb_gyro_z_p.Text = dat_delim[gyro_index + 2];
                        tb_mag_x_p.Text = dat_delim[mag_index];
                        tb_mag_y_p.Text = dat_delim[mag_index + 1];
                        tb_mag_z_p.Text = dat_delim[mag_index + 2];
                        tb_temp_p.Text = dat_delim[temp_index];
                        tb_pres_p.Text = dat_delim[pres_index];
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_small);
                        markers.Markers.Add(marker);
                    }
                    else if (dat_delim[0] == payload_section)
                    {
                        tb_lat_b.Text = lat.ToString();
                        tb_lon_b.Text = lon.ToString();
                        tb_acc_x_b.Text = dat_delim[acc_index];
                        tb_acc_y_b.Text = dat_delim[acc_index + 1];
                        tb_acc_z_b.Text = dat_delim[acc_index + 2];
                        tb_gyro_x_b.Text = dat_delim[gyro_index];
                        tb_gyro_y_b.Text = dat_delim[gyro_index + 1];
                        tb_gyro_z_b.Text = dat_delim[gyro_index + 2];
                        tb_mag_x_b.Text = dat_delim[mag_index];
                        tb_mag_y_b.Text = dat_delim[mag_index + 1];
                        tb_mag_z_b.Text = dat_delim[mag_index + 2];
                        tb_temp_b.Text = dat_delim[temp_index];
                        tb_pres_b.Text = dat_delim[pres_index];
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red_small);
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

        private void com_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySerialPort.Close();
            mySerialPort.PortName = com_port.Text;
            mySerialPort.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com_port.Items.Clear();
            ports = SerialPort.GetPortNames();
            com_port.Items.AddRange(ports);
        }
    }
}

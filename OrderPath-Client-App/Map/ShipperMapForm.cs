using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OrderPath_Client_App
{
    public partial class ShipperMapForm : Form
    {
        private double _lat;
        private double _lng;
        private string _name;

        public ShipperMapForm(double lat, double lng, string name)
        {
            InitializeComponent();
            _lat = lat;
            _lng = lng;
            _name = name;
        }

        private async void ShipperMapForm_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            string file = Path.Combine(Application.StartupPath, "leaflet_map.html");
            if (!File.Exists(file))
            {
                MessageBox.Show("File leaflet_map.html không tồn tại:\n" + file);
                return;
            }

            webView21.Source = new Uri(file);

            // Chờ WebView2 load xong
            webView21.NavigationCompleted += (s, ev) =>
            {
                var json = JsonConvert.SerializeObject(new
                {
                    lat = _lat,
                    lng = _lng,
                    name = _name
                });
                webView21.CoreWebView2.PostWebMessageAsJson(json);
            };
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OrderPath_Client_App
{
    public partial class TestMap : Form
    {
        public TestMap()
        {
            InitializeComponent();
            webView21.WebMessageReceived += WebView21_WebMessageReceived;
        }

        private async void TestMap_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            string file = Path.Combine(Application.StartupPath, "leaflet_map.html");
            if (!File.Exists(file))
            {
                MessageBox.Show("File leaflet_map.html không tồn tại:\n" + file);
                return;
            }

            webView21.Source = new Uri(file);
        }

        private void WebView21_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                dynamic data = JsonConvert.DeserializeObject(e.WebMessageAsJson);
                double lat = data.lat;
                double lng = data.lng;
            }
            catch { }
        }
    }
}

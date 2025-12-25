using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderPath_Client_App.Forms;
namespace OrderPath_Client_App
{
    public partial class FormMainUsers : Form
    {
        public FormMainUsers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DanhSachGioHang danhSachGioHang = new DanhSachGioHang();
            danhSachGioHang.Show();
        }
    }
}

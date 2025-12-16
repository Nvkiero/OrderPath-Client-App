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
    public partial class InforUsers : Form
    {
        public InforUsers()
        {
            InitializeComponent();
        }

        private void pB_AnhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private void bt_thayDoiThongTin_Click(object sender, EventArgs e)
        {
            FormUpdateInfor formUpdateInfor = new FormUpdateInfor();
            formUpdateInfor.Show();
        }
    }
}

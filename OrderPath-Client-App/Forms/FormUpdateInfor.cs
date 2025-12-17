using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OrderPath_Client_App.Forms
{
    public partial class FormUpdateInfor : Form
    {
        public FormUpdateInfor()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            //new ChangePasswordForm(Session.Token).ShowDialog(); // cần tạo class Session để lưu token
        }
    }
}

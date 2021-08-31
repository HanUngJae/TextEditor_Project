using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0522
{
    public partial class 메모장정보 : Form
    {
        public 메모장정보()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 메모장정보_Load(object sender, EventArgs e)
        { 

            this.lbl_Name.Text = SystemInformation.UserName;
            this.lbl_ComputerName.Text = SystemInformation.ComputerName;
            this.lbl_Version.Text = Application.ProductVersion.ToString();
        }
    }
}

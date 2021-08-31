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
    public partial class 도움말 : Form
    {
        public 도움말()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            도움말_파일 f = new 도움말_파일();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            도움말_입력 f = new 도움말_입력();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            도움말_서식 f = new 도움말_서식();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            도움말_편집 f = new 도움말_편집();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            도움말_보기 f = new 도움말_보기();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            메모장정보 f = new 메모장정보();
            f.Show();
        }
    }
}

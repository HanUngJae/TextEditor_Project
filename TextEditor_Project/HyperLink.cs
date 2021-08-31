using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor_Project
{
    public partial class HyperLink : Form
    {
        private string HyperLink_value1;
        private string HyperLink_value2;
        private int Return_value1;
        public string Passvalue1
        {
            get { return this.HyperLink_value1; }
            set { this.HyperLink_value1 = value; }
        }
        public string Passvalue2
        {
            get { return this.HyperLink_value2; }
            set { this.HyperLink_value2 = value; }
        }
        public int Return
        {
            get { return this.Return_value1; }
            set { this.Return_value1 = value; }
        }

        public HyperLink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passvalue1 = textBox1.Text;
            Passvalue2 = textBox2.Text;
            Return_value1 = 1;
            Return = Return_value1;
            this.Close();
        }
    }
}

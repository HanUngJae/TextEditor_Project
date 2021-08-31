using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor_Project;

namespace _0522  
{
    public partial class 찾기 : Form
    {
        private Form1 dnn = null;
        public 찾기()
        {
            InitializeComponent();
        }
        public 찾기(Form1 text_box)
        {
            dnn = text_box;
            InitializeComponent();
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            this.btn_Find.Enabled = true;
        }

        private bool FindText()
        {
            int nFind;
            int nLen;
            string strTempText;
            string strTempFind;

            if (chk_Case.Checked)
            {
                strTempText = dnn.richTextBox1.Text;
                strTempFind = txt_Find.Text;
            }
            else
            {
                strTempText = dnn.richTextBox1.Text.ToLower();
                strTempFind = txt_Find.Text.ToLower();
            }

            nLen = txt_Find.Text.Length;

            if (rdo_Up.Checked)
            {
                if ((dnn.richTextBox1.SelectionStart - dnn.richTextBox1.SelectionLength) < 0)
                    nFind = -1;
                else
                    nFind = strTempText.LastIndexOf(
                        strTempFind
                        , dnn.richTextBox1.SelectionStart
                          - dnn.richTextBox1.SelectionLength
                          );
            }
            else
            {
                nFind = strTempText.IndexOf(
                    strTempFind
                    , dnn.richTextBox1.SelectionStart
                      + dnn.richTextBox1.SelectionLength);

            }

            if (nFind == -1)
                return false;
            else
            {
                dnn.richTextBox1.SelectionStart = nFind;
                dnn.richTextBox1.SelectionLength = nLen;
                dnn.richTextBox1.Focus();
                return true;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (!FindText())
            {
                MessageBox.Show(
                    this.txt_Find.Text + "을(를) 찾을 수 없습니다."
                    , "메모장"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
            }
        }
    }
}

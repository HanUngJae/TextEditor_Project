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
    public partial class 바꾸기 : Form
    {
        public 바꾸기()
        {
            InitializeComponent();
        }
        private Form1 dnn = null;
        public 바꾸기(Form1 text_box)
        {
            dnn = text_box;
            InitializeComponent();
        }
        private void 바꾸기_Load(object sender, EventArgs e)
        {
            txt_Find.Focus();
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

        private void btn_Replace_Click(object sender, EventArgs e)// 바꾸기 //
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
            else
            {
                //텍스트 변경
                dnn.richTextBox1.SelectedText = this.txt_Replace.Text;
                dnn.richTextBox1.SelectionStart =
                    dnn.richTextBox1.SelectionStart - txt_Replace.Text.Length;

                dnn.richTextBox1.SelectionLength = txt_Replace.Text.Length;
            }
        }
        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            while (FindText())
            {
                dnn.richTextBox1.SelectedText = this.txt_Replace.Text;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool FindText()
        {
            int nFind;
            int nLen;
            string strTempText;
            string strTempFind;

            if (chk_Case.Checked)
            {
                strTempText = dnn.richTextBox1.Text; //찾을 대상
                strTempFind = txt_Find.Text; //찾을 단어
            }
            else
            {
                strTempText = dnn.richTextBox1.Text.ToLower(); //소문자
                strTempFind = txt_Find.Text.ToLower(); //소문자
            }

            nLen = txt_Find.Text.Length; //텍스트 길이

            //위로 / 아래로 검색
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
            else // 아래로
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
        private void Find_TextChanged(object sender, EventArgs e)
        {
            this.btn_Find.Enabled = true;
            this.btn_Replace.Enabled = true;
            this.btn_ReplaceAll.Enabled = true;
        }
    }
}

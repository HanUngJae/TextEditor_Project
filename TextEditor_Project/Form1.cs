using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium; // Web
using OpenQA.Selenium.Chrome; //Web
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormsApp1; // 계산기 --> 이형준
using _0522; // 이준일
using System.Collections;
using System.Reflection;

namespace TextEditor_Project
{
    public partial class Form1 : Form
    {

        #region 필드(클래스 변수)

        private String currentFile = string.Empty;

        public System.Diagnostics.Process p = new System.Diagnostics.Process();

        private int font_count = 0;

        private string[] array;

        // string[] FS_Array = new string[16];
        string[] FS_Array = new string[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };

        private string str = "굴림";

        private int tema = 0;

        ArrayList WebUrl1 = new ArrayList();
        ArrayList WebUrl2 = new ArrayList();

        List<LinkLabel> dict1 = new List<LinkLabel>();
        List<LinkLabel> dict2 = new List<LinkLabel>();
        List<LinkLabel.Link> dict3 = new List<LinkLabel.Link>();
        List<LinkLabel.Link> dict4 = new List<LinkLabel.Link>();

        private int HyperLink_Count = 1;
        private int HyperLink_true = 0;
        private int WebUrl_Number = 0;
        private int WebUrl2_Number = 0;
        public int HyperLink_Result = 0;
        //int hyperlink_count = 0;

        #region 링크라벨(link)과 링크라벨.링크(data)
        LinkLabel link1 = new LinkLabel();
        LinkLabel link2 = new LinkLabel();
        LinkLabel link3 = new LinkLabel();
        LinkLabel link4 = new LinkLabel();
        LinkLabel link5 = new LinkLabel();
        LinkLabel.Link data1 = new LinkLabel.Link();
        LinkLabel.Link data2 = new LinkLabel.Link();
        LinkLabel.Link data3 = new LinkLabel.Link();
        LinkLabel.Link data4 = new LinkLabel.Link();
        LinkLabel.Link data5 = new LinkLabel.Link();
        #endregion

        #endregion

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("settings.dat"))
            {
                FileStream stream = new FileStream("settings.dat", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                Font font = (Font)formatter.Deserialize(stream);
                stream.Close();

                richTextBox1.Font = font;

            }
            dict1.Add(link1);
            dict1.Add(link2);
            dict1.Add(link3);
            dict1.Add(link4);
            dict1.Add(link5);
            dict3.Add(data1);
            dict3.Add(data2);
            dict3.Add(data3);
            dict3.Add(data4);
            dict3.Add(data5);
            //richTextBox1.Font = new Font("궁서", 9, FontStyle.Regular); //Tahoma
        }
        // 폼 X 종료
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // 폼 X 종료
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show(
                    "파일의 내용이 변경되었습니다.\r\n\r\n" +
                    "변경된 내용을 저장하시겠습니까?", //표시문자열
                    "메모장", //제목                                 //아이콘
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);//버튼종류
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(currentFile))
                    {
                        SaveFileDialog dlg2 = new SaveFileDialog();
                        dlg2.FileName = "*.rtf";
                        dlg2.Filter =
                            //표시될문자열|필터링파일종류;필터링파일종류;...
                            "텍스트문서(*.rtf)|*.rtf|모든 파일(*.*)|*.*";
                        if (dlg2.ShowDialog() == DialogResult.OK)
                        {
                            currentFile = dlg2.FileName;
                        }
                        else
                        {
                            e.Cancel = true;//종료 작업 중지
                            return;
                        }
                    }
                    StreamWriter writer =
                            new StreamWriter(currentFile);
                    writer.Write(richTextBox1.Rtf);
                    richTextBox1.Modified = false;
                    writer.Close();
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;//종료 작업 중지
            }
        }
        // 메모장 메인
        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            p = System.Diagnostics.Process.Start("IExplore.exe", e.LinkText);
        }
        // 테스트 버튼
        private void WordWrap_Button_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;
                WordWrap_Label.Text = "False";
            }
            else if (richTextBox1.WordWrap == false)
            {
                richTextBox1.WordWrap = true;
                WordWrap_Label.Text = "True";
            }
        }
        // 폼 로드시 폰트 사이즈 및 폰트 이름 저장
        private void Form1_Load(object sender, EventArgs e) // 폼 로드시 폰트 사이즈 및 폰트 저장
        {
            comboBox2.Text = fontDialog1.Font.Size.ToString();

            FontFamily[] fonts = FontFamily.Families;
            array = new string[fonts.Length];
            int i = 0;
            if (font_count == 0)
            {
                foreach (FontFamily font in fonts)
                {
                    comboBox1.Items.Add(font.Name);
                    array[i] = font.Name;
                    i++;
                }
                font_count = 1;
                for (int j = 0; j < 16; j++)
                {
                    //FS_Array[j] = j.ToString();
                    comboBox2.Items.Add(FS_Array[j]);
                }
                this.richTextBox1.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
                richTextBox1.SelectionFont = new System.Drawing.Font("굴림", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                //richTextBox1.SelectionFont = fontDialog1.Font;
                //comboBox1.SelectedIndex = 239;
                //comboBox1.SelectedIndex
                //this.richTextBox1.SelectionFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular);
            }
        }


        #region ToolTip 모음

        #region 파일 툴팁

        // 새문서 툴팁
        private void NewFile_MouseHover(object sender, EventArgs e) // 새문서 툴팁
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.NewFile, "새문서");
        }
        // 저장 툴팁
        private void SaveFile_MouseHover(object sender, EventArgs e) // 저장 툴팁
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.SaveFile, "저장");
        }
        // 불러오기 툴팁
        private void button10_MouseHover(object sender, EventArgs e) // 불러오기 툴팁
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.button10, "불러오기");
        }
        // 다른이름으로 저장 툴팁
        private void NewSaveFile_MouseHover(object sender, EventArgs e) // 다른 이름으로 저장 툴팁
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.NewSaveFile, "다른 이름으로 저장");
        }
        // 인쇄 툴팁
        private void PrintFile_MouseHover(object sender, EventArgs e) // 인쇄 툴팁
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.PrintFile, "인쇄");
        }
        // 끝내기 툴팁
        private void ExitFile_MouseHover(object sender, EventArgs e)  // 끝내기 툴팁
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.ExitFile, "끝내기");
        }

        #endregion

        #region 입력 툴팁

        // 날짜/시간 툴팁
        private void DayTime_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.DayTime, "날짜/시간");
        }
        // 그림 불러오기 툴팁
        private void picture_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.picture, "그림 불러오기");
        }
        // 계산기 툴팁
        private void Calculator_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Calculator, "계산기");
        }
        // 그림판 툴팁
        private void PaintExe_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.PaintExe, "그림판");
        }
        // 웹 찾기 툴팁
        private void Search_TextBox_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Search_TextBox, "웹 찾기");
        }
        // 웹 찾기 버튼 툴팁
        private void Search_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Search_Button, "웹 찾기");
        }
        // 문자표 툴팁
        private void CharacterMap_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.CharacterMap, "문자표");
        }

        #endregion

        #region 서식 툴팁

        // 볼드체 툴팁
        private void Bold_Click_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Bold_Click, "굵게");
        }
        // 이테릭체 툴팁
        private void Italic_Click_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Italic_Click, "기울어짐");
        }
        // 취소선 툴팁
        private void Strikeout_Click_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Strikeout_Click, "취소선");
        }
        // 밑줄 툴팁
        private void Underline_Click_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Underline_Click, "밑줄");
        }
        //색상 팔레트 툴팁
        private void colorPicker1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.colorPicker1, "색상");
        }
        // 글자 크기 툴팁
        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.comboBox2, "글자 크기");
        }
        // 글자 폰트 툴팁
        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.comboBox1, "글자 폰트");
        }
        // 왼쪽 정렬 툴팁
        private void Left_Alignment_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Left_Alignment_Button, "왼쪽 정렬");
        }
        // 오른쪽 정렬 툴팁
        private void Right_Alignment_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Right_Alignment_Button, "오른쪽 정렬");
        }
        // 중앙 정렬 툴팁
        private void Center_Alignment_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Center_Alignment_Button, "중앙 정렬");
        }
        // 전체 지우기 툴팁
        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.button4, "전체 지우기");
        }

        #endregion

        #region 편집 툴팁

        // 찾기 툴팁
        private void Find_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Find_Button, "찾기");
        }
        // 바꾸기 툴팁
        private void Change_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Change_Button, "바꾸기");
        }
        // 복사 툴팁
        private void Copy_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Copy_Button, "복사");
        }
        // 붙여넣기 툴팁
        private void Paste_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Paste_Button, "붙여넣기");
        }
        // 잘라내기 툴팁
        private void Cutoff_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Cutoff_Button, "잘라내기");
        }
        // 되돌리기 툴팁
        private void Undo_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Undo_Button, "실행취소");
        }
        // 다시실행 툴팁
        private void Redo_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.Redo_Button, "다시실행");
        }
        // 모두선택 툴팁
        private void AllChoice_Button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.AllChoice_Button, "모두선택");
        }
        // 하이퍼링크 툴팁
        private void HyperLinkButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.HyperLinkButton, "하이퍼링크");
        }


        #endregion

        #endregion

        #region 파일 모음

        // 새 문서
        private void NewFile_Click(object sender, EventArgs e) // 새 문서
        {
            새문서NToolStripMenuItem.PerformClick();
        }
        // 저장
        private void SaveFile_Click(object sender, EventArgs e) // 저장
        {
            저장SToolStripMenuItem.PerformClick();
        }
        // 불러오기
        private void button10_Click(object sender, EventArgs e) // 불러오기
        {
            불러오기OToolStripMenuItem.PerformClick();
        }
        // 다른이름으로 저장
        private void NewSaveFile_Click(object sender, EventArgs e) // 다른이름으로 저장
        {
            다른이름으로저장AToolStripMenuItem.PerformClick();
        }
        // 인쇄
        private void PrintFile_Click(object sender, EventArgs e) // 인쇄
        {
            인쇄PToolStripMenuItem.PerformClick();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            string text = richTextBox1.Text;
            Font font = richTextBox1.Font;
            Brush brush = new SolidBrush(richTextBox1.ForeColor);

            e.Graphics.DrawString(text, font, brush, e.MarginBounds.Left, e.MarginBounds.Top);
        }
        // 끝내기
        private void ExitFile_Click(object sender, EventArgs e) // 끝내기
        {
            끝내기XToolStripMenuItem.PerformClick();
        }

        #endregion

        #region 입력 모음

        // 날짜/시간
        private void DayTime_Click(object sender, EventArgs e) // 날짜/시간
        {
            날짜시간TToolStripMenuItem.PerformClick();
        }
        // 문자표
        private void CharacterMap_Click(object sender, EventArgs e) // 문자표
        {
            문자표ToolStripMenuItem.PerformClick();
        }
        // 그림 불러오기
        private void picture_Click(object sender, EventArgs e) //그림 불러오기
        {
            그림IToolStripMenuItem.PerformClick();
        }
        // 그림판
        private void PaintExe_Click(object sender, EventArgs e) // 그림판
        {
            그림판DToolStripMenuItem.PerformClick();
        }
        // 계산기
        private void Calculator_Click(object sender, EventArgs e) // 계산기
        {
            계산기SToolStripMenuItem.PerformClick();
        }
        // 검색
        private void Search_Button_Click(object sender, EventArgs e) // 검색
        {
            if (Search_TextBox.Text.Length > 0)
            {
                //IWebDriver driver = new ChromeDriver();
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                var driver = new ChromeDriver(driverService, new ChromeOptions());
                driver.Url = "https://google.co.kr";
                //driver.Manage().Window.Maximize(); // 전체화면 설정
                driver.FindElement(By.Name("q")).SendKeys(Search_TextBox.Text);
                Thread.Sleep(100);
                driver.FindElement(By.Name("btnK")).Click();
            }
            else
            {
                MessageBox.Show("문자가 입력되지 않았습니다");
            }
        }

        #endregion

        #region 서식 모음

        // 왠쪽 정렬
        private void Left_Alignment_Button_Click(object sender, EventArgs e) // 왼쪽 정렬
        {
            // textBox1.TextAlign = HorizontalAlignment.Left;
            왼쪽정렬ToolStripMenuItem.PerformClick();
        }
        // 중앙 정렬
        private void Center_Alignment_Button_Click(object sender, EventArgs e) // 중앙 정렬
        {
            // textBox1.TextAlign = HorizontalAlignment.Center;
            가운데정렬ToolStripMenuItem.PerformClick();
            //textBox1.Lines = textBox1.Lines(0);
        }
        // 오른쪽 정렬
        private void Right_Alignment_Button_Click(object sender, EventArgs e) // 오른쪽 정렬
        {
            // textBox1.TextAlign = HorizontalAlignment.Right;
            오른쪽정렬ToolStripMenuItem.PerformClick();
        }
        // 전체 지우기
        private void button4_Click(object sender, EventArgs e) // 전체 지우기
        {
            // textBox1.Clear();
            richTextBox1.Clear();
        }
        // 글꼴 변경
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) // 글꼴 변경
        {
            str = comboBox1.SelectedItem.ToString();
            fontDialog1.Font = new Font(str, fontDialog1.Font.Size);
            richTextBox1.SelectionFont = fontDialog1.Font;
            #region 이전 코드
            /*FontFamily[] fonts_1 = FontFamily.Families;
            foreach (FontFamily font in fonts_1)
            {
                richTextBox1.Text += font.Name +"\n"; // 사용가능 글꼴 이름 출력
            }*/
            /*foreach (string font_name in array)
            {
                if (str == font_name)
                {
                    this.richTextBox1.LanguageOption = RichTextBoxLanguageOptions.UIFonts; // 영어도 글씨체 바뀜
                    //richTextBox1.Text += "True\n";
                    int number = Int32.Parse(FS);
                    richTextBox1.SelectionFont = new Font(str, number);
                    //richTextBox1.SelectionFont = new Font(str, 9);
                    //Font font = new Font(str, 9);
                    //richTextBox1.SelectionFont = font;
                    //richTextBox1.SelectionFont = new Font("Arial", 12);
                    //richTextBox1.Font = new Font("궁서", 12);
                    //richTextBox1.Font = new Font("Comic Sans MS", 14);

                }
                //richTextBox1.Text += comboBox1.Items.IndexOf("궁서");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        richTextBox1.Text += array[i];
                        richTextBox1.Text += "\n";
                    }
                    else
                    {
                        break;
                    }
                }
                richTextBox1.Text += "\n" + array.Length;
            }*/
            #endregion
        }
        // 폰트 크기
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // 폰트크기
        {
            float fl = float.Parse(comboBox2.SelectedItem.ToString());
            comboBox1.Text = str;
            fontDialog1.Font = new Font(str, fl);
            richTextBox1.SelectionFont = fontDialog1.Font;
        }
        // 폰트 다이얼로그
        private void Font_choice_Click(object sender, EventArgs e) // 폰트, 크기, 취소선등 전체 보기
        {
            전체서식ToolStripMenuItem.PerformClick();
        }
        // 볼드체
        private void Bold_Click_Click(object sender, EventArgs e)// 볼드체
        {
            굵게ToolStripMenuItem.PerformClick();
        }
        // 이테릭체
        private void Italic_Click_Click(object sender, EventArgs e) //이테릭체
        {
            기울기ToolStripMenuItem.PerformClick();
        }
        // 취소선
        private void Strikeout_Click_Click(object sender, EventArgs e) // 취소선
        {
            if (richTextBox1.SelectionFont != null)
            {
                int number = 1;

                number = richTextBox1.SelectionFont.Strikeout ? 1 : 2;
                number *= richTextBox1.SelectionFont.Bold ? 3 : 1;
                number *= richTextBox1.SelectionFont.Italic ? 5 : 1;
                number *= richTextBox1.SelectionFont.Underline ? 7 : 1;

                switch (number)

                {

                    case 1: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular); break;

                    case 2: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout); break;

                    case 3: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold); break;

                    case 5: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic); break;

                    case 7: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline); break;

                    case 6: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Bold); break;

                    case 10: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Italic); break;

                    case 14: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Underline); break;

                    case 15: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;

                    case 21: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;

                    case 35: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;

                    case 30: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Bold | FontStyle.Italic); break;

                    case 42: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Bold | FontStyle.Underline); break;

                    case 70: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Italic | FontStyle.Underline); break;

                    case 105: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;

                    case 210: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;
                }
            }
                
        }
        // 밑줄
        private void Underline_Click_Click(object sender, EventArgs e) // 밑줄
        {
            밑줄ToolStripMenuItem.PerformClick();
        }
        // 색상 다이얼로그
        private void Font_Color_Button_Click(object sender, EventArgs e) // 색상 다이얼로그
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }
        // 색상 팔레트
        private void colorPicker1_Click(object sender, BlackBeltCoder.ColorPickerEventArgs e) // 색상 팔레트
        {
            colorDialog1.Color = e.Value;
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        #endregion

        #region 편집 모음

        // 바꾸기
        private void Change_Button_Click(object sender, EventArgs e) //바꾸기
        {
            바꾸기ToolStripMenuItem.PerformClick();
        }
        // 찾기
        private void Find_Button_Click(object sender, EventArgs e) // 찾기
        {
            찾기ToolStripMenuItem.PerformClick();
        }
        // 하이퍼링크
        private void HyperLinkButton_Click(object sender, EventArgs e) // 하이퍼링크
        {
            HyperLink hl = new HyperLink();
            hl.ShowDialog();
            HyperLink_Result = hl.Return;

            if (HyperLink_Result == 1)
            {
                for (int k = 0; k < HyperLink_Count; k++)
                {
                    if (HyperLink_true == k)
                    {
                        dict2.Add(dict1[k]);
                        dict4.Add(dict3[k]);
                        dict2[k].Text = hl.Passvalue1;
                        dict2[k].LinkClicked += new LinkLabelLinkClickedEventHandler(this.Link_Search);
                        //dict2[k].LinkClicked += new LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
                        dict4[k].LinkData = hl.Passvalue2;
                        dict2[k].AutoSize = true;
                        dict2[k].Location = this.richTextBox1.GetPositionFromCharIndex(this.richTextBox1.TextLength);
                        this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
                        this.richTextBox1.Controls.Add(dict2[k]);
                        //richTextBox1.Text += "\n" + hl.Passvalue1.Length;
                        for (int j = 0; j < hl.Passvalue1.Length + 3; j++)
                        {
                            this.richTextBox1.Text += "  ";
                        }
                        //dict2.ToList<LinkLabel>().ForEach(p => richTextBox1.Text += "\n" + p.Text);
                        for (int j = 0; j < dict2.Count; j++)
                        {
                            if (WebUrl_Number == j)
                            {
                                WebUrl1.Add(dict2[k].Text);
                                //WebUrl1.Add(aaaa[0].Text);
                            }
                            //richTextBox1.Text += "\nWebUrl[" + j + "]" + WebUrl1[j];
                        }
                        for (int j = 0; j < dict4.Count; j++)
                        {
                            if (WebUrl2_Number == j)
                            {
                                WebUrl2.Add(dict4[k].LinkData.ToString());
                                //WebUrl2.Add(bbbb[0].LinkData.ToString());
                            }
                            //richTextBox1.Text += "\nWebUrl2[" + j + "]" + WebUrl2[j];
                        }
                    }
                }
                #region 무쓸모
                /*if(hyperlink_count == 1)
                {
                    richTextBox1.Text += "\n1. " + WebUrl1[1];
                }
                if (hyperlink_count == 2)
                {
                    richTextBox1.Text += "\n1. " + WebUrl1[1];
                    richTextBox1.Text += "\n2. " + WebUrl1[2];
                }
                if (hyperlink_count == 3)
                {
                    richTextBox1.Text += "\n1. " + WebUrl1[1];
                    richTextBox1.Text += "\n2. " + WebUrl1[2];
                    richTextBox1.Text += "\n3. " + WebUrl1[3];
                }
                richTextBox1.Text += "\n" +hyperlink_count + "번째 인덱스";
                hyperlink_count++;*/
                #endregion
                HyperLink_Count++;
                HyperLink_true++;
                WebUrl_Number++;
                WebUrl2_Number++;
                HyperLink_Result = 0;
            }
        }
        // 링크
        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start(e.LinkText);
        }
        // 링크2
        private void Link_Search(object sender, LinkLabelLinkClickedEventArgs e) // 링크2
        {
            LinkLabel result = (LinkLabel)sender;
            //richTextBox1.Text += "\n" + result.Text;
            for (int i = 0; i < WebUrl1.Count; i++)
            {
                if ((string)WebUrl1[i] == result.Text)
                {
                    string weblink = "" + WebUrl2[i];
                    System.Diagnostics.Process.Start(weblink);
                }
            }
        }
        // 복사
        private void Copy_Button_Click(object sender, EventArgs e) // 복사
        {
            복사ToolStripMenuItem.PerformClick();
        }
        // 붙여넣기
        private void Paste_Button_Click(object sender, EventArgs e) // 붙여넣기
        {
            붙여넣기ToolStripMenuItem.PerformClick();
        }
        // 잘라내기
        private void Cutoff_Button_Click(object sender, EventArgs e) // 잘라내기
        {
            잘라내기ToolStripMenuItem.PerformClick();
        }
        // 모두선택
        private void AllChoice_Button_Click(object sender, EventArgs e) // 모두선택
        {
            모두선택ToolStripMenuItem.PerformClick();
        }
        // 다시실행
        private void Redo_Button_Click(object sender, EventArgs e)
        {
            다시실행ToolStripMenuItem.PerformClick();                     
        }
        // 실행 취소
        private void Undo_Button_Click(object sender, EventArgs e) // 실행취소
        {
            실행취소ToolStripMenuItem.PerformClick();
            richTextBox1.Undo();
        }

        private void richTextBox1_ModifiedChanged(object sender, EventArgs e)
        {
            // 실행취소 = 이전에 수정된 내용이 있으면 버튼 활성
            if (richTextBox1.Modified == false)
            {
                Undo_Button.Enabled = false;
                Redo_Button.Enabled = false;
                실행취소ToolStripMenuItem.Enabled = false;
                다시실행ToolStripMenuItem.Enabled = false;
            }
            else
            {
                Undo_Button.Enabled = true;
                Redo_Button.Enabled = true;
                실행취소ToolStripMenuItem.Enabled = true;
                다시실행ToolStripMenuItem.Enabled = true;
            }

        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // 복사, 잘라내기 = 선택된 문자가 있으면 버튼 활성
            if (richTextBox1.SelectedRtf.Length == 0)
            {
                Copy_Button.Enabled = false;
                Cutoff_Button.Enabled = false;
                복사ToolStripMenuItem.Enabled = false;
                잘라내기ToolStripMenuItem.Enabled = false;
            }
            else
            {
                Copy_Button.Enabled = true;
                Cutoff_Button.Enabled = true;
                복사ToolStripMenuItem.Enabled = true;
                잘라내기ToolStripMenuItem.Enabled = true;
            }
            // 붙여넣기 = clipboard에 저장된 데이터가 있으면 버튼 활성
            if (Clipboard.ContainsText())
            {
                Paste_Button.Enabled = true;
                붙여넣기ToolStripMenuItem.Enabled = true;
            }
            else
            {
                Paste_Button.Enabled = false;
                붙여넣기ToolStripMenuItem.Enabled = false;
            }

        }

        #endregion

        #region 도움말 모음

        private void Help_Button1_Click(object sender, EventArgs e) //파일 도움말 버튼
        {
            도움말_파일 f = new 도움말_파일();
            f.Show();            
        }

        private void Help_Button2_Click(object sender, EventArgs e) //입력 도움말 버튼
        {
            도움말_입력 f = new 도움말_입력();
            f.Show();
        }

        private void Help_Button3_Click(object sender, EventArgs e) //서식 도움말 버튼
        {
            도움말_서식 f = new 도움말_서식();
            f.Show();
        }

        private void Help_Button4_Click(object sender, EventArgs e) //편집 도움말 버튼
        {
            도움말_편집 f = new 도움말_편집();
            f.Show();
        }

        private void Help_Button5_Click(object sender, EventArgs e) //보기 도움말 버튼
        {
            도움말_보기 f = new 도움말_보기();
            f.Show();
        }

        private void Help_Button6_Click(object sender, EventArgs e) //정보 도움말 버튼
        {
            메모장정보 f = new 메모장정보();
            f.Show();
        }

        #endregion

        #region 상태메세지 관련

        // 타이머
        private void timer1_Tick(object sender, EventArgs e) // 타이머
        {
            toolStripStatusLabel1.Text =
            String.Format("현재 시간 : {0}시 {1:0#}분 {2}초",
            DateTime.Now.Hour, DateTime.Now.Minute,
            DateTime.Now.Second.ToString().PadLeft(2, '0'));
        }
        // 상태메세지 글자수 & 붙여넣기 버튼 활성화
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = richTextBox1.Lines.Length;
            int y = richTextBox1.TextLength;

            toolStripStatusLabel2.Text = x + "줄";
            toolStripStatusLabel3.Text = y + "글자";

        }

        #endregion

        #region ToolStrip 관련


        

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)//파일
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox7.Visible = false;
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)//입력
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox7.Visible = false;
        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)//서식
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox7.Visible = false;
        }

        private void toolStripSplitButton5_ButtonClick(object sender, EventArgs e)//편집
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox7.Visible = false;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)//도움말
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox7.Visible = true;
        }

        private void 새문서NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show(
                    "파일의 내용이 변경되었습니다.\r\n" +
                    "변경된 내용을 저장하시겠습니까?", //표시문자열
                    "메모장", // 제목
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation);//버튼종류
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(currentFile))
                    {
                        //파일저장
                        SaveFileDialog dlg2 = new SaveFileDialog();
                        dlg2.FileName = "*.rtf"; // 파일 초기 이름
                        //표시될문자열|필터링파일종류;필터링파일종류;....
                        dlg2.Filter = "텍스트문서 (*.rtf)|*.rtf|모든 파일(*.*)|*.*";
                        if (dlg2.ShowDialog() == DialogResult.OK)
                        {
                            currentFile = dlg2.FileName;
                        }
                        else
                        {
                            return;
                        }
                    }
                    StreamWriter writer = new StreamWriter(currentFile);
                    writer.Write(richTextBox1.Rtf);
                    richTextBox1.Modified = false;
                    writer.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            richTextBox1.Clear();
            currentFile = string.Empty;
            toolStripStatusLabel2.Text = "0줄";
            toolStripStatusLabel3.Text = " 0글자";
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                //파일저장
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = "*.rtf";
                dlg.Filter = "rtf 문서 (*.rtf)|*.txt|모든 파일(*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    currentFile = dlg.FileName;
                }
                else
                {
                    return;
                }
            }
            StreamWriter writer = new StreamWriter(currentFile);
            writer.Write(richTextBox1.Rtf);
            richTextBox1.Modified = false;
            writer.Close();
        }

        private void 불러오기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show(
                    "파일의 내용이 변경되었습니다.\r\n" +
                    "변경된 내용을 저장하시겠습니까?",
                    "메모장",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation); //버튼종류
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(currentFile))
                    {
                        //파일저장
                        SaveFileDialog dlg2 = new SaveFileDialog();
                        dlg2.FileName = "*.rtf";
                        dlg2.Filter = "텍스트문서 (*.rtf)|*.rtf|모든 파일(*.*)|*.*";
                        if (dlg2.ShowDialog() == DialogResult.OK)
                        {
                            currentFile = dlg2.FileName;
                        }
                        else
                        {
                            return;
                        }

                    }
                    StreamWriter writer = new StreamWriter(currentFile);
                    writer.Write(richTextBox1.Rtf);
                    writer.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "*.rtf";
            dlg.Filter = "rtf 문서 (*.rtf)|*.rtf|모든 파일(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dlg.FileName);
                richTextBox1.Rtf = reader.ReadToEnd();
                richTextBox1.Modified = false;
                reader.Close();

                currentFile = dlg.FileName;
            }
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "*.rtf"; // 파일 초기 이름
            //표시될문자열|필터링파일종류;필터링파일종류;....
            dlg.Filter = "rtf 문서 (*.rtf)|*.rtf|모든 파일(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                currentFile = dlg.FileName;
            }
            else
            {
                return;
            }
            StreamWriter writer = new StreamWriter(currentFile);
            writer.Write(richTextBox1.Rtf);
            richTextBox1.Modified = false;
            writer.Close();
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show(
                    "파일의 내용이 변경되었습니다.\r\n" +
                    "변경된 내용을 저장하시겠습니까?", //표시문자열
                    "메모장", // 제목
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation);//버튼종류
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(currentFile))
                    {
                        //파일저장
                        SaveFileDialog dlg2 = new SaveFileDialog();
                        dlg2.FileName = "*.rtf"; // 파일 초기 이름
                        //표시될문자열|필터링파일종류;필터링파일종류;....
                        dlg2.Filter = "텍스트문서 (*.rtf)|*.rtf|모든 파일(*.*)|*.*";
                        if (dlg2.ShowDialog() == DialogResult.OK)
                        {
                            currentFile = dlg2.FileName;
                        }
                        else
                        {
                            return;
                        }
                    }
                    StreamWriter writer = new StreamWriter(currentFile);
                    writer.Write(richTextBox1.Rtf);
                    richTextBox1.Modified = false;
                    writer.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            richTextBox1.Clear();
            Close();

        }

        private void 그림IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = (Bitmap)Bitmap.FromFile(dialog.FileName);
                Clipboard.Clear();
                Clipboard.SetImage(bitmap);
                this.richTextBox1.Paste();
            }
            else
            {
                return;
            }
        }

        private void 그림판DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint");
        }

        private void 문자표ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("charmap");
        }

        private void 계산기SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator(this);
            calculator.Show();
        }

        private void 날짜시간TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String TODAY = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분");
            richTextBox1.Text += TODAY + "\n";
        }

        private void 굵게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionFont != null)
            {
                int number = 1;

                number = richTextBox1.SelectionFont.Bold ? 1 : 2;
                number *= richTextBox1.SelectionFont.Italic ? 3 : 1;
                number *= richTextBox1.SelectionFont.Strikeout ? 5 : 1;
                number *= richTextBox1.SelectionFont.Underline ? 7 : 1;

                switch (number)

                {

                    case 1: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular); break;

                    case 2: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold); break;

                    case 3: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic); break;

                    case 5: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout); break;

                    case 7: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline); break;

                    case 6: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;

                    case 10: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout); break;

                    case 14: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;

                    case 15: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout); break;

                    case 21: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;

                    case 35: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Underline); break;

                    case 30: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout); break;

                    case 42: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;

                    case 70: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline); break;

                    case 105: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;

                    case 210: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;
                }
            }

        }

        private void 기울기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionFont != null)
            {
                int number = 1;

                number = richTextBox1.SelectionFont.Italic ? 1 : 2;
                number *= richTextBox1.SelectionFont.Bold ? 3 : 1;
                number *= richTextBox1.SelectionFont.Strikeout ? 5 : 1;
                number *= richTextBox1.SelectionFont.Underline ? 7 : 1;

                switch (number)

                {

                    case 1: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular); break;

                    case 2: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic); break;

                    case 3: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold); break;

                    case 5: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout); break;

                    case 7: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline); break;

                    case 6: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold); break;

                    case 10: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout); break;

                    case 14: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;

                    case 15: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout); break;

                    case 21: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;

                    case 35: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Underline); break;

                    case 30: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Strikeout); break;

                    case 42: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline); break;

                    case 70: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;

                    case 105: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline); break;

                    case 210: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline); break;
                }
            }
            
        }

        private void 밑줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                int number = 1;

                number *= richTextBox1.SelectionFont.Underline ? 1 : 2;
                number *= richTextBox1.SelectionFont.Bold ? 3 : 1;
                number *= richTextBox1.SelectionFont.Italic ? 5 : 1;
                number *= richTextBox1.SelectionFont.Strikeout ? 7 : 1;

                switch (number)

                {

                    case 1: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular); break;

                    case 2: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline); break;

                    case 3: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold); break;

                    case 5: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic); break;

                    case 7: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout); break;

                    case 6: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Bold); break;

                    case 10: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic); break;

                    case 14: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Strikeout); break;

                    case 15: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;

                    case 21: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout); break;

                    case 35: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout); break;

                    case 30: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic); break;

                    case 42: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Bold | FontStyle.Strikeout); break;

                    case 70: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic | FontStyle.Strikeout); break;

                    case 105: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout); break;

                    case 210: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout); break;
                }
            }
            
        }

        private void 전체서식ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(); //폰드 설정창 열기
            richTextBox1.SelectionFont = fontDialog1.Font; //폰트 설정창 폰트 적용
        }

        private void 왼쪽정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void 가운데정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void 오른쪽정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void 찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("문자가 입력되지 않았습니다");
                return;
            }
            찾기 f = new 찾기(this);
            f.Show();
        }

        private void 바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            바꾸기 f = new 바꾸기(this);
            f.Show();
        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                this.richTextBox1.SelectedText =
                    Clipboard.GetDataObject().GetData(DataFormats.Text, true).ToString();
            }
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
            richTextBox1.SelectedText = String.Empty;
        }

        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 다시실행ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        #endregion

        #region 테마 관련

        private void 밝은테마ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema = 0;
            // menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            toolStrip1.ForeColor = System.Drawing.Color.Black;
            panel1.BackColor = System.Drawing.SystemColors.Control;
            groupBox1.ForeColor = System.Drawing.Color.Black;
            groupBox2.ForeColor = System.Drawing.Color.Black;
            groupBox3.ForeColor = System.Drawing.Color.Black;
            groupBox4.ForeColor = System.Drawing.Color.Black;
            groupBox7.ForeColor = System.Drawing.Color.Black;
            richTextBox1.BackColor = System.Drawing.Color.White;

            //상태표시줄
            statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            statusStrip1.ForeColor = System.Drawing.Color.Black;
        }

        private void 어두운테마ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema = 1;
            //menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            toolStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            toolStrip1.ForeColor = System.Drawing.Color.White;            
            panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox3.ForeColor = System.Drawing.Color.White;
            groupBox4.ForeColor = System.Drawing.Color.White;
            groupBox7.ForeColor = System.Drawing.Color.White;
            richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;

            //상태표시줄
            statusStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            statusStrip1.ForeColor = System.Drawing.Color.White;
        }

        #endregion

        /*준일씨가 해둔건 toopStrip에 옮겨놨어요. 그리고 panel1에 panel3 과 panel4를 넣었습니다. 
         * panel3에는 toolstrip1이 들어가 있고 panel4에는 groupBox1,2,3,4,7(도움말)이 들어 있어요.*/
    }
}

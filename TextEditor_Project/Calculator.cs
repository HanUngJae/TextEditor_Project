using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public enum Operators{Add,Sub,Multi,Div,Result}

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public bool isStartNum = true;
        public Operators Opt = Operators.Add;

        public Calculator(TextEditor_Project.Form1 form1)
        {
            InitializeComponent();
            //int number1;
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }
    
        public void SetNum(String number)
        {
            if (isNewNum)
            {
                if (isStartNum)
                {
                    NumberScreen.Text = number;
                }
                else
                {
                    NumberScreen.Text += number;
                }

                ResultScreen.Text = number;
                isNewNum = false;
                isStartNum = false;
            }
            else
            {
                if (ResultScreen.Text == "0")
                {
                    NumberScreen.Text = number;
                    ResultScreen.Text = number;
                }
                else
                {
                    NumberScreen.Text = NumberScreen.Text + number;
                    ResultScreen.Text = ResultScreen.Text + number;
                }

            }
        }

        private void Opt_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                int num = int.Parse(ResultScreen.Text);
                if (Opt == Operators.Add)
                    Result += num;
                else if (Opt == Operators.Sub)
                {
                    Result -= num;
                }
                else if (Opt == Operators.Multi)
                {
                    Result *= num;
                }
                else if (Opt == Operators.Div)
                {
                    Result /= num;
                }
                else if (Opt == Operators.Result)
                {
                    NumberScreen.Text = Result.ToString();
                }
                ResultScreen.Text = Result.ToString();
                isNewNum = true;
            }


            Button optButton = (Button)sender;
            if (optButton.Text == "+")
            {
                Opt = Operators.Add;
                NumberScreen.Text += "+";
            }           
            else if (optButton.Text == "-")
            {
                Opt = Operators.Sub;
                NumberScreen.Text += "-";
            }          
            else if (optButton.Text == "*")
            {
                Opt = Operators.Multi;
                NumberScreen.Text += "*";
            }           
            else if (optButton.Text == "/")
            {
                Opt = Operators.Div;
                NumberScreen.Text += "/";
            }     
            else if (optButton.Text == "=")
            {
                Result = 0;
                isNewNum = true;
                isStartNum = true;

                Opt = Operators.Add;

                NumberScreen.Text = "0";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            Result = 0;
            isNewNum = true;
            isStartNum = true;
            Opt = Operators.Add;

            NumberScreen.Text = "0";
            ResultScreen.Text = "0";
        }

        private void NumberScreen_Click(object sender, EventArgs e)
        {

        }
    }
}

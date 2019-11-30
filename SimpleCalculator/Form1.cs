using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        string condition;
        double firstnum;
        double secondnum;
        double result;
        string Num;
        string numarray;

        public Calculator()
        {
            InitializeComponent();
        }
        public void buttonEnable()
        {
            if (textBoxDisplay.Text == null || textBoxDisplay.Text == "")
            {
                buttonDel.Enabled = false;
            }
            else
            {
                buttonDel.Enabled = true;
            }
        }
        public void buttonClick(string args)
        {
            {
                if (textBoxDisplay.Text == null || textBoxDisplay.Text == "0")
                {
                    textBoxDisplay.Text = Num.ToString();
                }
                else
                {
                    textBoxDisplay.Text = textBoxDisplay.Text + Num.ToString();
                }
                buttonEnable();
            }
        }
        private void b_click(object sender, EventArgs e)
        {
            string b = (sender as Button).Text;
            Num = b;
            for (int x = 0; x < 10; x++)
            {
                numarray = x.ToString();
                if (numarray == Num)
                {
                    buttonClick(Num);
                    break;
                }
            }
            if (Num == "C")
            {
                textBoxDisplay.Text = null;
                buttonEnable();
            }
            if (Num == "CE")
            {
                textBoxDisplay.Text = null;
                history.Text = null;
                buttonEnable();
            }
            else if (Num == ".")
            {
                string display = textBoxDisplay.Text;
                if (display.IndexOf('.') == -1)
                {
                    buttonClick(Num);
                }
                else
                {
                    MessageBox.Show(string.Format("Please check your input. The existing number {0} already has a decimal.", display), "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Num == "+_")
            {
                string display = textBoxDisplay.Text;
                if(display.IndexOf('-')==-1)
                {
                    String Sign = "-";
                    textBoxDisplay.Text = Sign + textBoxDisplay.Text;
                }
                else
                {
                    String plus = textBoxDisplay.Text;
                    String n = plus.Replace("-", "");
                    textBoxDisplay.Text = n;
                }
            }
            else if (Num == "=")
            {
                secondnum = double.Parse(textBoxDisplay.Text);
                if (condition == "Add")
                {
                    history.Text = history.Text + textBoxDisplay.Text;
                    result = firstnum + secondnum;
                    textBoxDisplay.Text = result.ToString();
                }
                else if (condition == "Sub")
                {
                    history.Text = history.Text + textBoxDisplay.Text;
                    result = firstnum - secondnum;
                    textBoxDisplay.Text = result.ToString();
                }
                else if (condition == "Multiply")
                {
                    history.Text = history.Text + textBoxDisplay.Text;
                    result = firstnum * secondnum;
                    textBoxDisplay.Text = result.ToString();
                }
                else if (condition == "Divide")
                {
                    history.Text = history.Text + textBoxDisplay.Text;
                    result = firstnum / secondnum;
                    textBoxDisplay.Text = result.ToString();
                }
            }
            else if (Num == "+")
            {
                history.Text = textBoxDisplay.Text+ "+";
                firstnum = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "0";
                condition = "Add";
            }
            else if (Num == "-")
            {
                history.Text = textBoxDisplay.Text + "-";
                firstnum = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "0";
                condition = "Sub";
            }
            else if (Num == "X")
            {
                history.Text = textBoxDisplay.Text + "X";
                firstnum = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "0";
                condition = "Multiply";
            }
            else if (Num == "/")
            {
                history.Text = textBoxDisplay.Text + "/";
                firstnum = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "0";
                condition = "Divide";
            }
            else if (Num == "DEL")
            {
                string display = textBoxDisplay.Text;
                string newString = display.Remove(display.Length - 1, 1);
                textBoxDisplay.Text = newString;
                buttonEnable();
            }
        }
    }
}
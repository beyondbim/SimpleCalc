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
        private void button0_Click(object sender, EventArgs e)
        {
            Num = "0";
            buttonClick(Num);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Num = "1";
            buttonClick(Num);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Num = "2";
            buttonClick(Num);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Num = "3";
            buttonClick(Num);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Num = "4";
            buttonClick(Num);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Num = "5";
            buttonClick(Num);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Num = "6";
            buttonClick(Num);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Num = "7";
            buttonClick(Num);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Num = "8";
            buttonClick(Num);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Num = "9";
            buttonClick(Num);
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = null;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secondnum = double.Parse(textBoxDisplay.Text);
            if (condition == "Add")
            {
                result = firstnum + secondnum;
                textBoxDisplay.Text = result.ToString();
            }
            else if (condition == "Sub")
            {
                result = firstnum - secondnum;
                textBoxDisplay.Text = result.ToString();
            }
            else if (condition == "Multiply")
            {
                result = firstnum * secondnum;
                textBoxDisplay.Text = result.ToString();
            }
            else if (condition == "Divide")
            {
                result = firstnum / secondnum;
                textBoxDisplay.Text = result.ToString();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            condition = "Add";
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            condition = "Sub";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            condition = "Multiply";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            condition = "Divide";
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            string display = textBoxDisplay.Text;
            string newString = display.Remove(display.Length - 1, 1);
            textBoxDisplay.Text = newString;
            buttonEnable();
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = null;
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == null || textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "0.";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + ".";
            }
            buttonEnable();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
        }
    }
}
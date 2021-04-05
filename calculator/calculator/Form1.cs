using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        enum Mystatus {idle, plus, substract, multiply, divid};
        Mystatus status;
        decimal ans;
        string input;
        string input2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = "0";
            ans = 0;
            input = "";
            input = "";
            status = Mystatus.idle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "0";
            else {
                input2 += "0";
            }
            ShowText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "1";
            else
            {
                input2 += "1";
            }
            ShowText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "2";
            else
            {
                input2 += "2";
            }
            ShowText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "3";
            else
            {
                input2 += "3";
            }
            ShowText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "4";
            else
            {
                input2 += "4";
            }
            ShowText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "5";
            else
            {
                input2 += "5";
            }
            ShowText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "6";
            else
            {
                input2 += "6";
            }
            ShowText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "7";
            else
            {
                input2 += "7";
            }
            ShowText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "8";
            else
            {
                input2 += "8";
            }
            ShowText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += "9";
            else
            {
                input2 += "9";
            }
            ShowText();
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
                input += ".";
            else {
                input += ".";
            }
            ShowText();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Process();
            ShowText();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Process();
            status = Mystatus.plus;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Process();
            status = Mystatus.substract;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Process();
            status = Mystatus.multiply;
        }

        private void buttonDivid_Click(object sender, EventArgs e)
        {
            Process();
            status = Mystatus.divid;
        }

        
        private void buttonMod_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonReverse_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            ans = 0;
            input = "";
            input = "";
            status = Mystatus.idle;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {

        }

        private void buttonPi_Click(object sender, EventArgs e)
        {

        }

        private void buttonReciprocal_Click(object sender, EventArgs e)
        {

        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (status == Mystatus.idle)
            {
                input = input.Remove(input.Length - 1, input.Length - 1);
            }
            else
            {
                input2 = input2.Remove(input2.Length - 1, input2.Length - 1);
            }
            ShowText();
        }
        void Process() {
            if (status != Mystatus.idle) {
                decimal t1 = Decimal.Parse(input);
                decimal t2 = Decimal.Parse(input2);
                decimal t3 = 0;
                switch (status)
                {
                    case Mystatus.plus:
                        t3 = t1 + t2;
                        break;
                    case Mystatus.substract:
                        t3 = t1 - t2;
                        break;
                    case Mystatus.multiply:
                        t3 = t1 * t2;
                        break;
                    case Mystatus.divid:
                        t3 = t1 / t2;
                        break;
                }
                ans = t3;
                input = t3.ToString();
                input2 = "";
                status = Mystatus.idle;
                ShowText();

            }

        }
        void ShowText() {
            if (status == Mystatus.idle)
            {
                textBox.Text = input;
            }
            else {
                textBox.Text = input2;
            }
        }
    }
}

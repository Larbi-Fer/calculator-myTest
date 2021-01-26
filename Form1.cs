using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application2
{
    public partial class Form1 : Form
    {
        double n1 = 0, n2 = 0, r = 0;
        char op;
        string va = "";
        public Form1()
        {
            InitializeComponent();
            calc.Text = " 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                n1 = Convert.ToDouble(calc.Text);
                op = '+';
                lbl.Text += Convert.ToString(n1) + " + ";
            }
            else
            {
                n2 = Convert.ToDouble(calc.Text);
                switch (op)
                {
                    case '+':
                        n1 = n1 + n2;
                        op = '+';
                        break;
                    case '-':
                        n1 = n1 - n2;
                        op = '+';
                        break;
                    case '*':
                        n1 = n1 * n2;
                        op = '+';
                        break;
                    case '/':
                        n1 = n1 / n2;
                        op = '+';
                        break;
                }
                lbl.Text += Convert.ToString(n2) + " + ";
            }
            calc.Text = " 0";            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                n1 = Convert.ToDouble(calc.Text);
                op = '-';
                lbl.Text += Convert.ToString(n1) + " - ";
            }
            else
            {
                n2 = Convert.ToDouble(calc.Text);
                switch (op)
                {
                    case '+':
                        n1 = n1 + n2;
                        op = '-';
                        break;
                    case '-':
                        n1 = n1 - n2;
                        op = '-';
                        break;
                    case '*':
                        n1 = n1 * n2;
                        op = '-';
                        break;
                    case '/':
                        n1 = n1 / n2;
                        op = '-';
                        break;
                }
                lbl.Text += Convert.ToString(n2) + " - ";
            }
            calc.Text = " 0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                n1 = Convert.ToDouble(calc.Text);
                op = '*';
                lbl.Text += Convert.ToString(n1) + " × ";
            }
            else
            {
                n2 = Convert.ToDouble(calc.Text);
                switch (op)
                {
                    case '+':
                        n1 = n1 + n2;
                        op = '*';
                        break;
                    case '-':
                        n1 = n1 - n2;
                        op = '*';
                        break;
                    case '*':
                        n1 = n1 * n2;
                        op = '*';
                        break;
                    case '/':
                        n1 = n1 / n2;
                        op = '*';
                        break;
                }
                lbl.Text += Convert.ToString(n2) + " × ";
            }
            calc.Text = " 0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                n1 = Convert.ToDouble(calc.Text);
                op = '/';
                lbl.Text += Convert.ToString(n1) + " ÷ ";
            }
            else
            {
                n2 = Convert.ToDouble(calc.Text);
                switch (op)
                {
                    case '+':
                        n1 = n1 + n2;
                        op = '/';
                        break;
                    case '-':
                        n1 = n1 - n2;
                        op = '/';
                        break;
                    case '*':
                        n1 = n1 * n2;
                        op = '/';
                        break;
                    case '/':
                        n1 = n1 / n2;
                        op = '/';
                        break;
                }
                lbl.Text += Convert.ToString(n2) + " ÷ ";
            }
            calc.Text = " 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 1";
            }
            else
            {
                calc.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 2";
            }
            else
            {
                calc.Text += "2";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 3";
            }
            else
            {
                calc.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 4";
            }
            else
            {
                calc.Text += "4";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 5";
            }
            else
            {
                calc.Text += "5";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 6";
            }
            else
            {
                calc.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 7";
            }
            else
            {
                calc.Text += "7";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 8";
            }
            else
            {
                calc.Text += "8";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calc.Text == " 0")
            {
                calc.Text = " 9";
            }
            else
            {
                calc.Text += "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (calc.Text != " 0")
            {
                calc.Text += "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*string[] y = new string[calc.Text.Length];
            for(int x = 0; x < y.Length ;x++)
            { 
                if( y[x] == "0" || y[x]=="1"||y[x] == "2" || y[x]=="3"||y[x] == "4" || y[x]=="5"||y[x] == "6" || y[x]=="7"||y[x] == "8" || y[x]=="9")
                {
                    
                }
                else if( y[x] == "," )
                {
                    break;
                }
                /*else
                {
                    calc.Text += ",";
                    break;
                }
            };*/
            if (va == "")
            {
                va = ",";
                calc.Text += ",";
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //calc.Clear();
            calc.Text = " 0";
            lbl.Text = "";
            n1 = 0;
            n2 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(calc.Text);
            switch (op)
            {
            case '+':
                r = n1 + n2;
                lbl.Text = "";
                break;
            case '-':
                r = n1 - n2;
                lbl.Text = "";
                break;
            case '*':
                r = n1 * n2;
                lbl.Text = "";
                break;
            case '/':
                r = n1 / n2;
                lbl.Text = "";
                break;
            }
            if (r >= 0)
            {
                calc.Text = " " + Convert.ToString(r);
            }
            else
            {
                    calc.Text = Convert.ToString(r);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                double c = Convert.ToDouble(calc.Text);
                if (c > 0)
                {
                    calc.Text = "-" + c;
                }
                else
                {
                    //calc.Text = Convert.ToString(s);
                    //string[] y = new string[calc.Text.Length];
                    //calc.Clear();
                    //y[0] = " ";
                    //calc.Text.Remove(0);
                    double cal = Convert.ToDouble(calc.Text);
                    cal = cal * (-1);
                    calc.Text = " " + Convert.ToString(cal);
                }
            }
            catch
            {
            }
            
            

        }

        
        private void button20_Click(object sender, EventArgs e)
        {
            if (n1 != 0 && calc.Text == "0" )
            {
                calc.Text = " 0";
                n1 = 0;
                n2 = 0;
                lbl.Text = "";
            }
            else if (n1 != 0 && calc.Text != "0")
            {
                calc.Text = " 0";
                n2 = 0;
            }
            else
            {
                calc.Text = " 0";
                lbl.Text = "";
                n1 = 0;
                n2 = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string[] y = new string[calc.Text.Length];
            int w = calc.Text.Length;
            //y[w] = "";
            //calc.Text.Replace(y[w],"");
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressionCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EventHandler eh = new EventHandler(Numbers_Click);
            button_num_0.Click += eh;
            button_num_1.Click += eh;
            button_num_2.Click += eh;
            button_num_3.Click += eh;
            button_num_4.Click += eh;
            button_num_5.Click += eh;
            button_num_6.Click += eh;
            button_num_7.Click += eh;
            button_num_8.Click += eh;
            button_num_9.Click += eh;
            button_add.Click += eh;
            button_sub.Click += eh;
            button_mul.Click += eh;
            button_div.Click += eh;
            EventHandler eh1 = new EventHandler(Openbraket_Click);
            btn_openbrace.Click += eh1;
            btn_openbraket.Click += eh1;
            btn_openmidbraket.Click += eh1;
            EventHandler eh2 = new EventHandler(Closebraket_Click);
            btn_closebrace.Click += eh1;
            btn_closebraket.Click += eh1;
            btn_closemidbraket.Click += eh1;
            txtOutput.Text = "0";
            txtOutput.ForeColor = Color.Silver;
        }
        static bool IsOpStr(string op)
        {
            if (op != "+" && op != "-" && op != "*" && op != "/")
            {
                return false;
            }
            return true;
        }
        static bool IsNumber(char op)
        {
            if (op >= '0' && op <= '9')
            {
                return true;
            }
            return false;
        }


        private void Closebraket_Click(object sender, EventArgs e)
        {
            if (IsNumber(txtOutput.Text[txtOutput.Text.Length - 1]))
            {
                txtOutput.Text += ((Button)sender).Text;
            }
            else
            {
                MessageBox.Show("expression error");
            }

        }

        private void Openbraket_Click(object sender, EventArgs e)
        {
            if (txtOutput.ForeColor == Color.Silver)
            {
                txtOutput.ForeColor = Color.Black;
                txtOutput.Text = "";
                txtOutput.Text = "(";
                
            }
            else
            {
                if (IsOpStr(txtOutput.Text[txtOutput.Text.Length - 1].ToString()))
                {
                    txtOutput.Text += ((Button)sender).Text;
                }
                else
                {
                    MessageBox.Show("expression error");
                }
            }
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            if (txtOutput.ForeColor == Color.Silver)
            {
                txtOutput.ForeColor = Color.Black;
                txtOutput.Text = "";
            }
            txtOutput.Text += ((Button)sender).Text;
        }
        #region 输入表达式
        private void button_num_0_Click(object sender, EventArgs e)
        {

        }

        private void button_num_1_Click(object sender, EventArgs e)
        {

        }

        private void button_num_2_Click(object sender, EventArgs e)
        {

        }

        private void button_num_3_Click(object sender, EventArgs e)
        {

        }

        private void button_num_4_Click(object sender, EventArgs e)
        {

        }

        private void button_num_5_Click(object sender, EventArgs e)
        {

        }

        private void button_num_6_Click(object sender, EventArgs e)
        {

        }

        private void button_num_7_Click(object sender, EventArgs e)
        {

        }

        private void button_num_8_Click(object sender, EventArgs e)
        {

        }

        private void button_num_9_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void button_sub_Click(object sender, EventArgs e)
        {

        }

        private void button_mul_Click(object sender, EventArgs e)
        {

        }

        private void button_div_Click(object sender, EventArgs e)
        {

        }

        private void button_dot_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region 输入左括号
        private void btn_openbraket_Click(object sender, EventArgs e)
        {

        }

        private void btn_openmidbraket_Click(object sender, EventArgs e)
        {

        }

        private void btn_openbrace_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region 输入右括号
        private void btn_closebraket_Click(object sender, EventArgs e)
        {

        }

        private void btn_closemidbraket_Click(object sender, EventArgs e)
        {

        }

        private void btn_closebrace_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button_ce_Click(object sender, EventArgs e)
        {

        }

        private void button_enter_Click(object sender, EventArgs e)
        {

        }
    }
    class ExpressionCalc
    {

    }

}

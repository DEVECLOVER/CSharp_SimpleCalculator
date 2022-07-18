using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// 之后的改进 争取实现微软计算器类似的功能 可以计算一连串的式子  加减乘除 加括号等等
/// </summary>
namespace Calc
{
    public partial class CalcForm : Form
    {
        private double NumFormer = 0;//前一个操作数
        private double NumTemp = 0;//临时变量
        private double Result = 0;//结果
        private char cOperator;//操作符
        private bool DotClicked = false;//用于标记小数点是否被按下
        private double DecimalNum = 1;//按下小数点后，再按下数字的精度
        private bool Flag = true;//enter键是否按下的标志位 按下为true 默认上电为true
        private bool Flag_Char = false;//符号键是否按下的标志位  默认没有按下
        private bool Flag_Dot = false; //是否在有数字的情况下直接点击小数点
        private bool Flag_Inverse = false;
        public CalcForm() //构造函数
        {
            InitializeComponent(); //初始化界面
            txtOutput.Text = "0";  //输出初始化
            //数字0~9
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

            //运算符+、-、*、/
            EventHandler eh2 = new EventHandler(Operators_Click);
            button_add.Click += eh2;
            button_sub.Click += eh2;
            button_mul.Click += eh2;
            button_div.Click += eh2;
        }

        #region   数字按钮   统一函数在  Numbers_Click（） private
        private void CalcForm_Load(object sender, EventArgs e)
        {

        }
        //****数字按钮0-9
        private void button_num_0_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_1_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_2_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_3_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_4_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_5_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_6_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_7_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_8_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_9_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }
        #endregion

        #region  运算符操作  统一函数在 Operators_Click（） private
        //****操作符+、-、*、/
        private void button_add_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }
        #endregion  


        //****等于号=
        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(NumFormer.ToString() + "__" + NumTemp.ToString());
                switch (cOperator)
                {
                    case '+':
                        //计算并检测数据是否越界
                        checked { Result = NumFormer + NumTemp; }
                        break;
                    case '-':
                        checked { Result = NumFormer - NumTemp; }
                        break;
                    case '*':
                        checked { Result = NumFormer * NumTemp; };
                        break;
                    case '/':
                        checked { Result = NumFormer / NumTemp; };
                        break;
                }
            }
            catch
            {
                MessageBox.Show("运算结果溢出");//自动弹窗显示
            }
            Flag = true; //enter键按下
            Flag_Char = false; //符号键还没按下
            Flag_Dot = false;
            Flag_Inverse = false;
            DotClicked = false;
            txtOutput.Text = Result.ToString();
            //清空变量
            NumFormer = double.Parse(txtOutput.Text);
            NumTemp = 0;//临时变量
            cOperator = '\0';//操作符
            DecimalNum = 1;
        }

        //****清空键CE
        private void button_ce_Click(object sender, EventArgs e)
        {
            //清空变量
            NumFormer = 0;//前一个操作数
            NumTemp = 0;//临时变量
            Result = 0;//结果
            cOperator = '\0';//操作符
            DecimalNum = 1;
            //清空页面显示
            txtOutput.Text = "0";
            Flag = true;
            Flag_Char = false;
            Flag_Dot = false;
            Flag_Inverse = false;
            DotClicked = false;
        }

        //****小数点.
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!DotClicked)
            {
                if (Flag)
                {
                    txtOutput.Text = "0.";
                    NumTemp = 0;
                    DotClicked = true;
                    Flag_Dot = true;
                    Flag_Inverse = false;
                }
                else
                {
                    txtOutput.Text += ".";
                    DotClicked = true;
                    Flag_Dot = false;
                    Flag_Inverse = false;
                }

            }
        }

        //集中处理按钮点击事件
        //****数字按钮0-9
        private void Numbers_Click(object sender, EventArgs e)
        {
            string strClickNum = ((Button)sender).Text;
            try
            {
                if (DotClicked)
                {
                    //得出点击的小数数值
                    //decimalIndex++;
                    DecimalNum *= 0.1;
                    checked { NumTemp = NumTemp + long.Parse(strClickNum) * DecimalNum; }
                }
                else
                {
                    checked { NumTemp = NumTemp * 10 + long.Parse(strClickNum); }
                }
            }
            catch
            {
                //貌似double型并不会轻易溢出
                MessageBox.Show("数据溢出");
            }

            if (!Flag) //将这两个if语句交换顺序，结果是不一样的  就像穿袜子和穿鞋的顺序
            {
                txtOutput.Text += strClickNum;
            }
            if (Flag)
            {
                Flag = false;
                Flag_Char = false;
                if (Flag_Dot)
                {
                    txtOutput.Text += strClickNum;
                }
                else
                {
                    txtOutput.Text = strClickNum;
                }
            }
            Flag_Inverse = false;
//            DotClicked = false;  //小数点的标志位只能在等于号与清除号中置位
        }

        //集中处理按钮点击事件
        //****操作符+、-、*、/
        private void Operators_Click(object sender, EventArgs e)
        {
            string strClickOp = ((Button)sender).Text;
            cOperator = strClickOp[0];//strClickOp长度为1  如何将string转换为char
            if (Flag) //当enter键按下时，将计算结果作为第一个计算数
            {
                if (!Flag_Inverse)
                {
                    NumFormer = double.Parse(txtOutput.Text);
                }
            }
            else
            {
                if (!Flag_Char)//防止连续两次按下符号键 将0赋值给NumFormer 
                {
                    if (!Flag_Inverse)
                    {
                        NumFormer = double.Parse(txtOutput.Text);
                    }
                }
            }
            NumTemp = 0;   //按下符号键都会置零
            if (!Flag_Char)
            {
                Flag_Char = true;
                txtOutput.Text += cOperator.ToString();
            }
            if (Flag_Char)//改变运算符号
            {
                //MessageBox.Show(txtOutput.Text);
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1) + cOperator.ToString();
            }
            DotClicked = false;
            DecimalNum = 1;
            Flag = false;
            Flag_Dot = false;
            Flag_Inverse = false;
        }

        private void Btn_Inverse_Click(object sender, EventArgs e)
        {
            int lens = txtOutput.TextLength;
            if(lens > 0)
            {
                if(txtOutput.Text[lens-1] == '+' || txtOutput.Text[lens - 1] == '-' || txtOutput.Text[lens - 1] == '*' || txtOutput.Text[lens - 1] == '/')
                {
                    return;
                }
            }
            if (!Flag_Char)
            {
                if (txtOutput.Text[0] != '-')
                {
                    txtOutput.Text = "-" + txtOutput.Text;
                }
                else
                {
                    txtOutput.Text = txtOutput.Text.Substring(1);
                }
                NumFormer = double.Parse(txtOutput.Text);
                Flag_Inverse = true;
            }
            else
            {
                int index_operator = 0;
                for (int i = 0; i < lens; i++)
                {
                    if (txtOutput.Text[i] == '+' || txtOutput.Text[i] == '-' || txtOutput.Text[i] == '*' || txtOutput.Text[i] == '/')
                    {
                        index_operator = i+1;
                        break;
                    }
                }
                txtOutput.Text = txtOutput.Text.Substring(0,index_operator) + "(-" + txtOutput.Text.Substring(index_operator) + ")";
                NumTemp = 0 - NumTemp;
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            int lens = txtOutput.TextLength;
            string expression = txtOutput.Text;
            int index = Math.Max(Math.Max(expression.IndexOf("+"), expression.IndexOf("-")), Math.Max(expression.IndexOf("*"), expression.IndexOf("/")));
            if(lens == 1)
            {
                txtOutput.Text = "0";
                Flag = true;
                Flag_Char = false;
                Flag_Dot = false;
                Flag_Inverse = false;
                DotClicked = false;
                return;
            }
            txtOutput.Text = txtOutput.Text.Substring(0, lens - 1);
            if (index < 0)
            {
                NumFormer = double.Parse(txtOutput.Text);
                //MessageBox.Show(NumFormer.ToString());
                return;
            }
            NumFormer = double.Parse(txtOutput.Text.Substring(0,index));
            if (index+1 == lens)
            {
                Flag_Char = false;
                return;
            }
            NumTemp = double.Parse(txtOutput.Text.Substring(index+1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace LaserSolution
{
    public partial class Frm_NumPad :UIEditForm
    {
        public Frm_NumPad()
        {
            InitializeComponent();
            this.Text = "输入值范围:" + _MinValue.ToString() + " ~ " + _MaxValue.ToString();
        }
        private double _MinValue;
        public double MinValue
        {
            set { _MinValue = value;
                ulb_value_min.Text = value.ToString();
            }
        }
        private double _MaxValue;
        public double MaxValue
        {
            set { _MaxValue = value;
                lb_value_max.Text = value.ToString();
            }
        }
        public string Content = "";
        private double _typeinvalue;
        public double TypeInValue
        {
            get { return _typeinvalue; }
            set { _typeinvalue = value;
                textboxnew.Text = value.ToString("F3");
            }
        }
        public String sName
        {
            set { lb_name.Text = value; }
        }
        private void AddNew(char x_char)
        {
            if (x_char == '-')
            {
                if (Content == "")
                {
                    Content = "-";

                }
                else
                {
                    return;
                }
            }
            string temp= Content + x_char;
            double tmpvalue;
            bool bresult = double.TryParse(temp, out tmpvalue);
            if (bresult)
            {
                Content = Content + x_char;
                textboxnew.Text = Content;
                //if (tmpvalue > =0.0 || tmpvalue < _9)
                //{
                //   // ShowErrorTip("值过范围!");
                //}
                //else
                //{

                //    Content = Content + x_char;
                //    textboxnew.Text = Content;

                //}
            }
            else
            {
                ShowErrorTip("请正确输入值!");
            }

        }
        public bool bComplete = false;
        private void DeleteOne()
        {
            if (Content.Length > 0)
            {
                Content = Content.Substring(0, Content.Length - 1);
                textboxnew.Text = Content;
            }

        }
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            DeleteOne();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            bComplete = true;
            if (double.TryParse(textboxnew.Text, out _typeinvalue))
            {
                if (_typeinvalue > _MaxValue || _typeinvalue < _MinValue)
                {
                    ShowErrorTip("值过范围!");
                }
                else
                {
                    Close();
                }
              
            }
            else
            {
                UIMessageTip.ShowError("输入值错误,请重试!");
            }
            
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            AddNew('1');
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            AddNew('2');
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            AddNew('3');
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            AddNew('4');
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            AddNew('5');
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            AddNew('6');
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            AddNew('7');
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            AddNew('8');
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            AddNew('9');
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            AddNew('0');
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            bComplete = false;
            Close();
            
        }
        private void btn_Dot_Click(object sender, EventArgs e)
        {
            AddNew('.');
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (Content == "")
            {
                AddNew('-');
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Content = "";
            textboxnew.Text = "";
        }
    }
}

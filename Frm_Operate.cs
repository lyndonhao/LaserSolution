using System;

using System.Configuration;

using Sunny.UI;
using NLog;
using static LaserSolution.GlobalData;
using Tools;
using LaserSolution.Properties;
using Newtonsoft.Json;
using System.IO;

namespace LaserSolution
{
    public partial class Frm_Operate : UITitlePage
    {
        public Frm_Operate()
        {
            InitializeComponent();

            InitFunctionKeys();
            SetFunctionKeysLabel("快速运行", "激光开", "", "X", "Y", "Z","R");


            //timer start
            timer1.Start();


           
   
        }
      
        
        #region Function keys
        private void InitFunctionKeys()
        {
            sbtn_Pre.Visible = true;
            sbtn_F1.Visible = true;
            sbtn_F2.Visible = true;
            sbtn_F3.Visible = true;
            sbtn_F4.Visible = true;
            sbtn_F5.Visible = true;
            sbtn_F6.Visible = true;
            sbtn_F7.Visible = true;
        }
        private void SetFunctionKeysLabel(string x_F1,string x_F2,string x_F3,string x_F4,string x_F5,string x_F6,string x_F7)
        {
  
             sbtn_F1.Text = x_F1;
            sbtn_F2.Text = x_F2;
            sbtn_F3.Text = x_F3;
            sbtn_F4.Text = x_F4;
            sbtn_F5.Text = x_F5;
            sbtn_F6.Text = x_F6;
            sbtn_F7.Text = x_F7;

        }
        #endregion
        private static Logger log = NLog.LogManager.GetLogger("LaserLog");
        private void sbtn_F1_Click(object sender, EventArgs e)
        {
            log.Info("message ,other form  operate!!!!!!!!!!!!!!!");
            //复位激光错误
            
        }

        private void sbtn_F2_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_F3_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_F4_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_F5_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_F6_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_F7_Click(object sender, EventArgs e)
        {

        }
        private void GetAxisStatus()
        {

        }

        private void RefreshDisplayAxisStatus()
        {


            ///display axis Status
            ///
            


            lb_Xspeed.Text = GlobalData.Axis[(int)AxisesChannel.Axis_X].Status.FedbackSpeed.ToString("f3");
          //  lb_YSpeed.Text = GlobalData.Axis[(int)AxisesChannel.Axis_Y].Status.FedbackSpeed.ToString("f3");
          //  lb_ZSpeed.Text = GlobalData.Axis[(int)AxisesChannel.Axis_Z].Status.FedbackSpeed.ToString("f3");
            lb_ASpeed.Text = GlobalData.Axis[(int)AxisesChannel.Axis_A].Status.FedbackSpeed.ToString("f3");

            //CurrentPos.x = GlobalData.Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos-ZeroPhase.x;
            //CurrentPos.y = GlobalData.Axis[(int)AxisesChannel.Axis_Y].Status.CurrentPos-ZeroPhase.y;
            //CurrentPos.z = GlobalData.Axis[(int)AxisesChannel.Axis_Z].Status.CurrentPos-ZeroPhase.z;
            //CurrentPos.a = GlobalData.Axis[(int)AxisesChannel.Axis_A].Status.CurrentPos-ZeroPhase.a;
            //CurrentPos.c = GlobalData.Axis[(int)AxisesChannel.Axis_C].Status.CurrentPos-ZeroPhase.c;
            CurrentPos.x = GlobalData.Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos;
            CurrentPos.y = GlobalData.Axis[(int)AxisesChannel.Axis_Y].Status.CurrentPos ;
            CurrentPos.z = GlobalData.Axis[(int)AxisesChannel.Axis_Z].Status.CurrentPos ;
            CurrentPos.a = GlobalData.Axis[(int)AxisesChannel.Axis_A].Status.CurrentPos ;
            CurrentPos.c = GlobalData.Axis[(int)AxisesChannel.Axis_C].Status.CurrentPos ;
            lb_XPos.Text = CurrentPos.x.ToString("f3");
            //lb_Ypos.Text = CurrentPos.y.ToString("f3");
            //lb_Zpos.Text = CurrentPos.z.ToString("f3");
            lb_Apos.Text = CurrentPos.a.ToString("f3");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GlobalData.mc.Connected)
            {
                RefreshDisplayAxisStatus();
            }
            
            //GlobalData.Height=mc.GetVarValue("HEIGHT");
           // lb_Height.Text = GlobalData.Height.ToString("F1");
        }
        private void RefreshPointAtStatus()
        {

            
            
        
        }

        private void input_Radius_TextChanged(object sender, EventArgs e)
        {
            //RefreshRotParam();
        }

        private void input_Radius_Click(object sender, EventArgs e)
        {

            //Frm_NumPad frm_Num = new Frm_NumPad();
            //frm_Num.MaxValue = 400;
            //frm_Num.MinValue = 0;
            //frm_Num.ShowDialog();
            //if (frm_Num.bComplete)

            //{
            //    input_Radius.Text = frm_Num.TypeInValue.ToString();

            //}
            //frm_Num.Dispose();
           

        }
       
        private void input_rotateSpeed_Click(object sender, EventArgs e)
        {


        }
        private double GetLineSpeed(double _radius, double _rotSpeed)
        {        
            return 2 * _radius * Pi * _rotSpeed / 360;
        }
        



        private void enable_CCW_Click(object sender, EventArgs e)
        {
           
        }

        private void Switch_RotateEnable_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Switch_RotateEnable_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_RotaEnable_Click(object sender, EventArgs e)
        {
           
        }

        private void input_LaserPower_TextChanged(object sender, EventArgs e)
        {
          // mc.LaserPower(float.Parse(input_LaserPower.Text.Trim()));
        }

        private void sbtn_F1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mc.Do((int)enum_OutputLable.ResetLaser, true);
        }

        private void sbtn_F1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mc.Do((int)enum_OutputLable.ResetLaser,true);
        }
    }
}


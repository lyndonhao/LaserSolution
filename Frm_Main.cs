using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
using NLog;
using System.Collections.Generic;
using static LaserSolution.GlobalData;
using System.Configuration;
using System.IO;
using Tools;
using Newtonsoft.Json;
using System.Threading;
using LaserSolution.Properties;
using RemotContolTool;
using System.Collections;

namespace LaserSolution
{
    public partial class Frm_Main : UIHeaderMainFooterFrame
    {
      
       // string controllerip = "127.0.0.1";
        public Frm_Main()
        {
            InitializeComponent();
            //set app start path
            StepRun();

            #region 配置主页
            //AddPage(new Frm_Operate(), GlobalData.nPage_Operate);
            //AddPage(new Frm_Production(), GlobalData.nPage_Production);
            //AddPage(new Frm_Program(), GlobalData.nPage_Program);
            AddPage(new Frm_Processing(), GlobalData.nPage_Processing);
            //AddPage(new Frm_Diagnosis(), GlobalData.nPage_Diagnosis);
            //AddPage(new Frm_Setting(), GlobalData.nPage_Settings);
            //AddPage(new Frm_Help(), GlobalData.nPage_Help);
            //设置关联

            #endregion
            #region 初始化 head 系统状态显示数据 
           // initSystemImgStatusData();
            #endregion
           
            // RefreshChoseStatus(GlobalData.nPage_Operate);

            //Login motion controller

             
                timer1.Start();
        }

        /// <summary>
        /// define seleted and released button color
        /// </summary>
        Color l_Seleted = Color.FromArgb(249, 226, 137);
        Color l_Released = Color.FromArgb(247, 248, 249);
        private void RefreshChoseStatus(int SelectPageIndex)
        {
            //deal with chosen status of the button . change the  color of the button background
            Color l_Seleted = Color.FromArgb(249, 226, 137);
            Color l_Released = Color.FromArgb(247, 248, 249);
            //jump to page 
            //TreeNode tn = Aside.SelectedNode;
            //GlobalData.OldPageIndex = Aside.GetPageIndex(tn);
            //Aside.SelectPage(SelectPageIndex);

            ////x_SButton.FillColor = l_Seleted;
            //switch (SelectPageIndex)
            //{
            //    case GlobalData.nPage_Operate:
            //        btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
            //        btn_Operate.FillColor = l_Seleted; break;
            //    case GlobalData.nPage_Diagnosis:
            //        btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
            //        btn_Diagnosis.FillColor = l_Seleted; break;
            //    //case GlobalData.nPage_Login:
            //    //    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
            //    //    btn.FillColor = l_Seleted; break;
            //    case GlobalData.nPage_Processing:
            //        btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
            //        btn_Processing.FillColor = l_Seleted; break;
            //    case GlobalData.nPage_Production:
            //        btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
            //        btn_Production.FillColor = l_Seleted; break;
            //    case GlobalData.nPage_Program:
            //        btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
            //        btn_Program.FillColor = l_Seleted; break;
            //    case GlobalData.nPage_Settings:
            //        btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
            //        btn_Setting.FillColor = l_Seleted; break;


          //  }


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
        }
        #endregion

      

        int trytime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            //lb_date.Text = DateTime.Now.ToShortDateString();
            //lb_week.Text = DateTime.Now.ToString("dddd");
            //lb_TimeHour.Text  = DateTime.Now.ToLongTimeString();
         
            //refresh status display
            RefreshStatusDisplay();

            lb_LaserPower.Text = GlobalData.LaserPower1.ToString() + " 瓦";
           
            // TimeSpan timeTotle= new TimeSpan(0,0,(int)GlobalData.t)
            mc.GetProductTotleTime(GlobalData.StandardCladdingInstr);
           
            GlobalData.LineSpeedNow = Axis[AxisesChannel.Axis_X].Status.FedbackSpeed;
            lb_SpeedT.Text = GlobalData.LineSpeedNow.ToString() + " mm/s";
            CurrentMoveId = mc.GetRotID();
            double i_span = 0;
            if (CurrentMoveId > 0)
            {
                 i_span = CurrentMoveId * (360 / GlobalData.StandardCladdingInstr.RotParam.RotSpeed);
            }
            else
            {
                ;
            }
            double hour = (GlobalData.StandardCladdingInstr.tTotle - i_span) / 3600;
            double min =( (GlobalData.StandardCladdingInstr.tTotle - i_span) %3600)/60;

            TimeSpan timeleft = new TimeSpan((int)hour, (int)min,(int)((min-(int)min)*60));
            lb_SpeedRatio.Text = timeleft.ToString(@"hh\:mm\:ss");
        }
        

        private void imglogo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("程序关闭?", "提示信息", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Close();
            }
        }
        private void CheckSystemStatus()
        {
            GlobalData.SystemStatusCode = (int)GlobalData.OperateMode * 10 + (int)GlobalData.SystemStatus;
                //int i = -1;
            if (ico_AUTO.Visible)
            { GlobalData.OperateMode = OperateModeType.AUTO; }
            else
            {
                GlobalData.OperateMode = OperateModeType.MANUL;
            }
            if (ico_Estop.Visible)
            {
                GlobalData.SystemStatus = SystemStatusType.Estop;
            }
            else
            {
                if (ico_Error.Visible)
                {
                    GlobalData.SystemStatus = SystemStatusType.Error;
                }
                else
                {
                    // if (CycleRunning)
                    //     GlobalData.SystemStatus = SystemStatusType.Running;
                    //// if(cyc)
                }
            }

           
                //bool bok=int.TryParse(,out i);
        }
        int times = 0;
        #region 状态栏图标刷新
        private void RefreshStatusDisplay()
        {
            lb_programName.Text = CurrentSelectProgram;
            /// ico_comunicatOK&ico_ComunicatError   comnunication status,
            if (GlobalData.mc.Connected && mc.bAlive)
            {

                ico_comunicatOK.Visible = true;
                ico_ComunicatError.Visible = false;






            }
            else
            {
                times++;
                if (times > 10)
                {
                    times = 0;
                    try
                    {
                        if (mc.Connect(controllerip))
                        {
                            log.Info("重新连接控制器成功!");
                        }
                    }

                    catch (Exception ex)
                    {
                        log.Info("重新连接控制器失败!");
                    }
                }
                ico_comunicatOK.Visible = false;
                ico_ComunicatError.Visible = true;
            }
            ///ico_AUTO
            ico_AUTO.Visible = GlobalData.bInputValues[(int)enum_InputLable.AutoIn];
            ico_Manual.Visible = !ico_AUTO.Visible;
            ///1 for auto  ;0 for maual
            OperateModeCode = GlobalData.bInputValues[(int)enum_InputLable.AutoIn]?1:0;

            // ico_Error.Visible=
            ico_Error.Visible = (ico_Estop.Visible || ico_LaserError.Visible ||ico_MotorFault.Visible);
            if (ico_Error.Visible)
            {
                mc.LaserOFFIM();
                log.Info("设备存在故障,立即停机!");
            }
            //estop
            ico_Estop.Visible= !GlobalData.bInputValues[(int)enum_InputLable.Estop];

            //output laser beam
           // ico_LaserON.Visible = (GlobalData.LaserPWM.Freq > 0) && (GlobalData.LaserPWM.Duty > 0);
            ico_LaserON.Visible = mc.GetLaserStatus();
            //ico_NeedMaint.Visible = false;

            ico_LaserError.Visible = GlobalData.bInputValues[(int)enum_InputLable.LaserError];

            ico_PowderError.Visible = !ico_PowderRunning.Visible;
            ///axis fault
            ///
            int status = 0;
            for (int i = 0; i < Axis.Length; i++)
            {
                status += Axis[i].Status.StatusCode;
            }
            ///every axis no error
            ico_MotorFault.Visible = (status != 0 && status!=0x800);
            ///no estop and error then system is ok
            ico_SystemOK.Visible = !ico_Estop.Visible && !ico_Error.Visible;
            switch (StandardCladdingInstr.PartType)
            {
                case SpecialInstrType.ShapeOnCylinder:
                    ico_InstrType.Image= Resources.耐磨带;
                    break;
                case SpecialInstrType.SurfaceOnAxis:
                    ico_InstrType.Image = Resources.轴类;
                        break;
            }
            float l_status;
          
            mc.GetVarValue("CycleStatus", out l_status);
            CycleStatus = (int)l_status;
            CyclePause = (CycleStatus == 2);
            CycleRunning = (CycleStatus == 1);
            CycleStop = (CycleStatus == 4);
         
            ico_Pause.Visible = CyclePause;
            //' Doaction of cycle  0 null 1 start 2 pause 3 resume  4 stop/cancle 取消
            mc.SetVarValue("DoAction", (float)DoAction);
          //  ico_Pause.Visible=GlobalData.SystemStatus


        }
        private void initSystemImgStatusData()
        {
           
            ImgStatus imgbuttonstatus = new ImgStatus();
            /*
             *
             * private Sunny.UI.UIImageButton ico_SystemOK;
            private Sunny.UI.UIImageButton ico_Warnning;
            private Sunny.UI.UIImageButton ico_Error;
            private Sunny.UI.UIImageButton ico_Fault;
            private Sunny.UI.UIImageButton ico_comunicatOK;
            private Sunny.UI.UIImageButton ico_NeedMaint;
            private Sunny.UI.UIImageButton ico_ComunicatError;
            private Sunny.UI.UIImageButton ico_PowderRunning;
            private Sunny.UI.UIImageButton ico_PowderError;
            private Sunny.UI.UIImageButton ico_LaserError;
            private Sunny.UI.UIImageButton ico_GuideON;
            private Sunny.UI.UIImageButton ico_LaserON;
            private Sunny.UI.UIImageButton ico_AUTO;
            private Sunny.UI.UIImageButton ico_Manual;
            private Sunny.UI.UIImageButton ico_STOP;
            private Sunny.UI.UIImageButton ico_Pause;
            private Sunny.UI.UIImageButton ico_RUNNING;
            private Sunny.UI.UIImageButton ico_Estop;
            */
            //estop
            imgbuttonstatus.name = "ico_Estop";
            imgbuttonstatus.comment = "整机设备急停状态";
            imgbuttonstatus.value = false; //true as system is in estop. estop loop is  open
           GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_RUNNING
            imgbuttonstatus.name = "ico_RUNNING";
            imgbuttonstatus.comment = "程序运行中";
            imgbuttonstatus.value = false; //true as Programe is running
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_Pause
            imgbuttonstatus.name = "ico_Pause";
            imgbuttonstatus.comment = "程序暂停";
            imgbuttonstatus.value = false; //true as Programe is pause
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_STOP
            imgbuttonstatus.name = "ico_STOP";
            imgbuttonstatus.comment = "程序已停止";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_Manual
            imgbuttonstatus.name = "ico_Manual";
            imgbuttonstatus.comment = "手动模式";
            imgbuttonstatus.value = false; //true as 
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_AUTO
            imgbuttonstatus.name = "ico_AUTO";
            imgbuttonstatus.comment = "自动模式";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_LaserON
            imgbuttonstatus.name = "ico_LaserON";
            imgbuttonstatus.comment = "激光已出光";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_GuideON
            imgbuttonstatus.name = "ico_GuideON";
            imgbuttonstatus.comment = "红色指引光开";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_LaserError
            imgbuttonstatus.name = "ico_LaserError";
            imgbuttonstatus.comment = "激光错误";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_PowderError
            imgbuttonstatus.name = "ico_PowderError";
            imgbuttonstatus.comment = "送粉器异常";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_PowderRunning
            imgbuttonstatus.name = "ico_PowderRunning";
            imgbuttonstatus.comment = "送粉器运行中";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_ComunicatError
            imgbuttonstatus.name = "ico_ComunicatError";
            imgbuttonstatus.comment = "控制器通信异常";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_NeedMaint
            imgbuttonstatus.name = "ico_NeedMaint";
            imgbuttonstatus.comment = "设备需要维护";
            imgbuttonstatus.value = false; //true as Programe is Stop
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_comunicatOK
            imgbuttonstatus.name = "ico_comunicatOK";
            imgbuttonstatus.comment = "控制器设备通讯正常";
            imgbuttonstatus.value = false; //
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_Fault
            imgbuttonstatus.name = "ico_Fault";
            imgbuttonstatus.comment = "设备出现报错信息";
            imgbuttonstatus.value = false; //
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_Error
            imgbuttonstatus.name = "ico_Error";
            imgbuttonstatus.comment = "设备报错";
            imgbuttonstatus.value = false; //
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_Warnning
            imgbuttonstatus.name = "ico_Warnning";
            imgbuttonstatus.comment = "有警告信息";
            imgbuttonstatus.value = false; //
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

            //ico_SystemOK
            imgbuttonstatus.name = "ico_SystemOK";
            imgbuttonstatus.comment = "设备运转正常";
            imgbuttonstatus.value = false; //
            GlobalData.ImgStatusList.Add(imgbuttonstatus);

        }
        #endregion

       


        /// <summary>
        /// 初始化运动轴比例尺设定
        /// </summary>
        private void InitAxises()
        {
         
            //加载配置文件
            // LoadAxisesConfig();
            //PreMoveParam.Corner_mode = 32;
            //PreMoveParam.DecelAngle=

            //

            ///初始化轴参数,定义 主轴,定义预处理参数
            ///
            //mc.InitAxis((int)enum_AxisesChannel.Axis_X, PreMoveParam,ref Axis,Tools.enum_ScalePerUnitsType.Scale_10um);
        }

        

        private void GetInput()
        {
            GlobalData.bInputValues = GlobalData.mc.GetInput_Modbus_BitArray(0, 24);
        }
        private void SetOutPut()
        {
            GlobalData.mc.SetOutput_modbus(0, GlobalData.bOutputValues);
        }
        private void StartCommunicat()
        {
            mc.Connect();
            NotAliveTime = 0;
            timer_comunicate.Start();
        }
        private void ico_ComunicatError_Click(object sender, EventArgs e)
        {
            //reset comunications

            StartCommunicat();
            StepRun();
        }

        int NotAliveTime = 0;

        //private void timer_CheckAlive_Tick(object sender, EventArgs e)
        //{

        //}
        //private void CheckAlive()
        //{

        //}
        private void CheckAlive()
        {

            //get MC  alive status ,try 3 time
            bool balive = false;

            do
            {
                balive = mc.CheckLiveBeat();
                trytime++;
            }
            while (!balive && trytime < 30);
            // always 
            if (!mc.bAlive)
            {
                NotAliveTime++;
            }
            else
            {
                if (!timer1.Enabled)
                    timer1.Start();
                NotAliveTime = 0;
            }
            if (NotAliveTime > 5)
            {

                timer_comunicate.Stop();
            }

        }

        private void timer_comunicate_Tick(object sender, EventArgs e)
        {
            //  log.Info("time tick message");
            CheckAlive();



            //refresh io if alive
            if (mc.bAlive)
            {
                //
                trytime = 0;
                //刷新输入信息
                if (!GlobalData.mc.GetInput_Modbus_BitArray(0, 24, out GlobalData.bInputValues))
                    GlobalData.log.Error(mc.errorMessage);

                //设置输出信息
                //if (!GlobalData.mc.SetOutput_modbus(0, GlobalData.bOutputValues))
                //    GlobalData.log.Error(mc.errorMessage);
                //获取轴状态信息
                if (!GlobalData.mc.GetAxisStatus(ref GlobalData.Axis))
                    GlobalData.log.Error(mc.errorMessage);
                RefreshStatusList();
            }
             CurrentMoveId=   mc.GetMoveId(AxisesChannel.Axis_A);
            BufferMoveId = mc.GetBuffMoveId(AxisesChannel.Axis_A);
            //获取Modbus 表80开始 16位 led状态显示
            GlobalData.bLedSta = GlobalData.mc.Get_Modbus_0x(80, 16);
            //GlobalData.log.Error(mc.errorMessage);
            CycleOPRemote();

         //当前剩余时间计时

        }
        ushort tmp_key = 0;
        //增加手柄操作按钮
        private void CycleOPRemote()
        {
            string mes;
            RMContol.GetSignal();
            //mc.SetVarValue("IkeyNum", RMContol.RMStatus.iKeyPressed);
            ushort[] value =new  ushort[2];
            value[0] =(ushort) RMContol.RMStatus.iKeyPressed;
            mc.SetModbusReg(99, value);
            BitArray leds = new BitArray(GlobalData.bLedSta);
            
           // GlobalData.bLedSta.CopyTo(leds, 16);
            if (value[0] != tmp_key)
            {
                x_message.Text= "按键[" + value[0].ToString() + "]按下";
                //mes = "按键[" + value[0].ToString() + "]按下";
                  if (value[0]==  (ushort)enumPHB09KeyValue.Laser)
                { 
                        bool laserStatus = mc.GetLaserStatus();
                    if (laserStatus)
                    {
                        mc.LaserOFFIM();
                        x_message.Text += "=> 关闭激光!";
                    }
                    else
                    {
                        mc.LaserONIM();
                        x_message.Text += "=> 打开激光!";
                    }
                    }
                if (value[0] == (ushort)enumPHB09KeyValue.StepMode)
                { 
                        if (leds[(ushort)enumPHB09LedStatus.Led_Step - 80])
                        {
                            mc.DoIM((ushort)enumPHB09LedStatus.Led_Step, false);
                        }
                        else
                        {
                            mc.DoIM((ushort)enumPHB09LedStatus.Led_Step, true);
                        }
                        ;
                }
                if (value[0] == (ushort)enumPHB09KeyValue.AxisJogSpeedSwit)
                {   
                        if (leds[(ushort)enumPHB09LedStatus.Led_High - 80])
                        {
                            mc.DoIM((ushort)enumPHB09LedStatus.Led_High, false);
                        }
                        else
                        {
                            mc.DoIM((ushort)enumPHB09LedStatus.Led_High, true);
                        }
                        ;
                }
              
            }
            if (ico_Manual.Visible)
            {
                //X正向
                if (value[0] == (ushort)enumPHB09KeyValue.AxisX_P)
                {
                    if (GlobalData.Axis[AxisesChannel.Axis_X].Status.IDLE == -1)
                    {
                        if (mc.Vmove(AxisesChannel.Axis_X, true))
                        {
                            log.Info("按钮按下,向前运动");
                            x_message.Text += "X 正向运动中";
                        }
                    }
                }
                if (value[0] == (ushort)enumPHB09KeyValue.AxisX_N)
                {
                    if (GlobalData.Axis[AxisesChannel.Axis_X].Status.IDLE == -1)
                    {
                        if (mc.Vmove(AxisesChannel.Axis_X, false))
                        {
                            log.Info("按钮按下,向后运动");
                            x_message.Text += "X 负向运动中";
                        }
                    }
                }
                if ((value[0] != (ushort)enumPHB09KeyValue.AxisX_P) && (value[0] != (ushort)enumPHB09KeyValue.AxisX_N))
                {
                    if (GlobalData.Axis[AxisesChannel.Axis_X].Status.IDLE == 0)
                    {
                        if (mc.Stopmove(AxisesChannel.Axis_X))
                        {
                            log.Info("按钮释放,停止 x 轴运动!");
                            x_message.Text = "按钮释放,停止 x 轴运动!";
                        }
                        else
                        {
                            log.Info("按钮释放,停止 x 轴运动失败!");
                            x_message.Text = "按钮释放,停止 x 轴运动失败!";
                        }
                    }
                }
                #region W A axis
                //W/A正向
                if (value[0] == (ushort)enumPHB09KeyValue.AxisW_P)
                {
                    if (GlobalData.Axis[AxisesChannel.Axis_A].Status.IDLE == -1)
                    {
                        if (mc.Vmove(AxisesChannel.Axis_A, true))
                        {
                            log.Info("按钮按下,W 正转");
                            x_message.Text += "A 正转运动中";
                        }
                    }
                }
                if (value[0] == (ushort)enumPHB09KeyValue.AxisW_N)
                {
                    if (GlobalData.Axis[AxisesChannel.Axis_A].Status.IDLE == -1)
                    {
                        if (mc.Vmove(AxisesChannel.Axis_A, false))
                        {
                            log.Info("按钮按下,A向后运动");
                            x_message.Text += "A 负向运动中";
                        }
                    }
                }
                if ((value[0] != (ushort)enumPHB09KeyValue.AxisW_N) && (value[0] != (ushort)enumPHB09KeyValue.AxisW_P))
                {
                    if (GlobalData.Axis[AxisesChannel.Axis_A].Status.IDLE == 0)
                    {
                        if (mc.Stopmove(AxisesChannel.Axis_A))
                        {
                            log.Info("按钮释放,停止 A 轴运动!");
                            x_message.Text = "按钮释放,停止 A 轴运动!";
                        }
                        else
                        {
                            log.Info("按钮释放,停止 A 轴运动失败!");
                            x_message.Text = "按钮释放,停止 A 轴运动失败!";
                        }
                    }
                }
            }
#endregion

            RMContol.SendLedStatus(GlobalData.bLedSta);
            tmp_key = value[0];
        }
        /// <summary>
        /// 更新status list的状态值
        /// </summary>
        private void RefreshStatusList()
        {
            foreach (Control i in this.Controls)
            {
                foreach (ImgStatus img in ImgStatusList)
                {
                    if (i.Name == img.name)
                    {
                        ImgStatus updateValue = img;
                        updateValue.value = i.Visible;

                        ImgStatusList.Update(ImgStatusList.FindIndex(e => e.name == i.Name), updateValue);

                    }
                }
            }

        }
        string _message = "";
        private void StartMessage(string x_message)
        {
            _message = x_message + "......  ";
            //txb_Content.Text+= x_message + "......  ";

            delay();
        }
        private void CompleteMessage()
        {
            _message += "     OK\n";
           
        }
        private void FailMessage()
        {
            _message += "     失败!\n";

            ShowErrorDialog(_message);
            x_message.Text = _message;
            this.Close();
            step = ErrorStep;
        }
        private void delay(int x_timems)
        {
            Thread.Sleep(x_timems);
        }
        private void delay()
        {
            delay(200);
        }
        string controllerip = "";
        int step = 0;
        const int ErrorStep = 401;
        // private void StepRun(object sender,DoWorkEventArgs e)
        public void StepRun()
        {
            AppPath = Application.StartupPath;

            //1 设置IP地址,连接  
            controllerip = ConfigurationManager.AppSettings["debug"] == "1" ? ConfigurationManager.AppSettings["debugip"] : ConfigurationManager.AppSettings["ControllerIp"];
            //关掉连接
           // mc.Close();
            StartMessage("尝试连接控制器");
            if (!mc.Connect(controllerip))
            {
                mc.IP = controllerip;
                FailMessage();
                step = ErrorStep;
            }
            else
            {
                CompleteMessage();
                step = 1;
            }
            //2 检测是否正确连接,程序是否正常运行
            StartMessage("开始系统程序检测");
            CheckAlive();

            if (mc.bAlive)
            {
                CompleteMessage();
                step = 2;
            }
            else
            {
                step = ErrorStep;
                FailMessage();
            }
            StartMessage("配置轴通道");
            AxisesChannel.Axis_X = int.Parse(ConfigurationManager.AppSettings["Axis_X"]);
            AxisesChannel.Axis_Y = int.Parse(ConfigurationManager.AppSettings["Axis_Y"]);
            AxisesChannel.Axis_Z = int.Parse(ConfigurationManager.AppSettings["Axis_Z"]);
            AxisesChannel.Axis_A = int.Parse(ConfigurationManager.AppSettings["Axis_A"]);
            AxisesChannel.Axis_C = int.Parse(ConfigurationManager.AppSettings["Axis_C"]);
            //AxisesChannel.Axis_X = 2;
            //AxisesChannel.Axis_Y = 1;
            //AxisesChannel.Axis_Z = 0;
            //AxisesChannel.Axis_A = 3;
            //AxisesChannel.Axis_C = 4;
            ///关键配置
            mc.Channels = AxisesChannel;
            CompleteMessage();
            //加载机床设置参数
            if (ConfigurationManager.AppSettings["debug"] == "0")
                GlobalData.settingfile =GlobalData.AppPath+ ConfigurationManager.AppSettings["Settings"];
            else
                GlobalData.settingfile = GlobalData.AppPath + ConfigurationManager.AppSettings["SettingsSimula"];
            GlobalData.Settings = new SettingsType();
           GlobalData.Settings = JsonConvert.DeserializeObject<SettingsType>(File.ReadAllText(GlobalData.settingfile));
            GlobalData.Axis = GlobalData.Settings.Axises;
            // StartMessage("开始配置轴数据...");
            //3加载轴数据
            StartMessage("初始化轴配置");
            // InitAxis();
            mc.InitAxis(AxisesChannel.Axis_X, GlobalData.Settings.PreMoveParam,  GlobalData.Settings.Axises);
            CompleteMessage();

            //4加载零位数据
            StartMessage("加载零位数据");         
            ZeroPhaseFile = GlobalData.AppPath + @"\configs\" + ConfigurationManager.AppSettings["ZeroPhaseFile"];
            GlobalData.ZeroPhase = JsonConvert.DeserializeObject<AxisZeroPhase>(File.ReadAllText(GlobalData.ZeroPhaseFile));
            
            CompleteMessage();
            //5 获取当前轴状态
            //获取轴状态信息
            StartMessage("获取轴状态");
            if (!GlobalData.mc.GetAxisStatus(ref GlobalData.Axis))
            {
                FailMessage();
            }
            else
            {
                CompleteMessage();
            }
            StartMessage("设置轴零位数据");
            if (mc.SetZeroConfig(ZeroPhase, Axis))
            {
                CompleteMessage();
            }
            else
            {
                FailMessage();
            }

            //StartMessage("加载线速度");
            //LineSpeedMax = double.Parse(ConfigurationManager.AppSettings["LineSpeedMax"]);
            //CompleteMessage();
            ////加载旋转数据
            LoadRotConfig();



            //初始化标准熔覆指令
            StandardCladdingInstr.CladdingBaseParam = GlobalData.Settings.claddingParam.CladdingBaseParam;  //基本熔覆参数获取


            // Settings = JsonConvert.DeserializeObject<SettingsType>(File.ReadAllText(settingfile));

            //step 
            //加载机床基本熔覆参数线宽 深度 激光功率等


            ///加载零位位置数据
            // 


            ///设置dPos值
            ///

            //初始化远程操作手柄
            StartMessage("初始化操作手柄");
            if ( !RMContol.Init())
            {
                FailMessage();
            }
            else
            {
          
                if (0 == RMContol.OpenChannel())
                { 
                
                }
                else
                {
                    StartMessage("初始化操作手柄");

                }
                
            }
            CompleteMessage();
            

        }

        //step 1 .获取IP地址 ,连接





        //private void timer_CheckAlive_Tick(object sender, EventArgs e)
        //{

        //}
        //private void CheckAlive()
        //{

        //}
        
        #region 运动轴轴配置和操作
        private void InitAxis()
        {

            ////设定XYZ比例尺
            //mc.scalePerunits = (int)enum_ScalePerUnitsType.Scale_1um;


        
            //配置轴
           // SetAxieConfig();

            ///复制全局数据设置
            //GlobalData.Settings.Axises = new AxisType[Axis.Length];
            //GlobalData.Settings.Axises = Axis;
            mc.GetAxisList();

        }
       // private void 
        private void SetAxieConfig()
        {
            
            ////Axis_x
            //Axis[(int)AxisesChannel.Axis_X].Config.AxisLable = "X";
            //Axis[(int)AxisesChannel.Axis_X].Config.AxisNum = (int)AxisesChannel.Axis_X;
            //Axis[(int)AxisesChannel.Axis_X].Config.Enable = true;
            //Axis[(int)AxisesChannel.Axis_X].Config.EncodeValue = 23;
            //Axis[(int)AxisesChannel.Axis_X].Config.FS_Limit = 500;
            //Axis[(int)AxisesChannel.Axis_X].Config.Lead = 5;
            //Axis[(int)AxisesChannel.Axis_X].Config.RS_limit = -100;
            //Axis[(int)AxisesChannel.Axis_X].Config.FWIN = (int)enum_InputLable.Axis_X_FwLimit;
            //Axis[(int)AxisesChannel.Axis_X].Config.REVIN = (int)enum_InputLable.Axis_X_ReLimit;
            //Axis[(int)AxisesChannel.Axis_X].Config.AxisType = Tools.enum_AxisType.EtherCAT_Pos;

            ////axis_y
            //Axis[(int)AxisesChannel.Axis_Y].Config.AxisLable = "Y";
            //Axis[(int)AxisesChannel.Axis_Y].Config.AxisNum = (int)AxisesChannel.Axis_Y;
            //Axis[(int)AxisesChannel.Axis_Y].Config.Enable = true;
            //Axis[(int)AxisesChannel.Axis_Y].Config.EncodeValue = 23;
            //Axis[(int)AxisesChannel.Axis_Y].Config.FS_Limit = 500;
            //Axis[(int)AxisesChannel.Axis_Y].Config.Lead = 5;
            //Axis[(int)AxisesChannel.Axis_Y].Config.RS_limit = -100;
            //Axis[(int)AxisesChannel.Axis_Y].Config.FWIN = (int)enum_InputLable.Axis_Y_FwLimit;
            //Axis[(int)AxisesChannel.Axis_Y].Config.REVIN = (int)enum_InputLable.Axis_Y_ReLimit;
            //Axis[(int)AxisesChannel.Axis_Y].Config.AxisType = Tools.enum_AxisType.EtherCAT_Pos;
            ////Z
            //Axis[(int)AxisesChannel.Axis_Z].Config.AxisLable = "Z";
            //Axis[(int)AxisesChannel.Axis_Z].Config.AxisNum = (int)AxisesChannel.Axis_Z;
            //Axis[(int)AxisesChannel.Axis_Z].Config.Enable = true;
            //Axis[(int)AxisesChannel.Axis_Z].Config.EncodeValue = 23;
            //Axis[(int)AxisesChannel.Axis_Z].Config.FS_Limit = 500;
            //Axis[(int)AxisesChannel.Axis_Z].Config.Lead = 5;
            //Axis[(int)AxisesChannel.Axis_Z].Config.RS_limit = -100;
            //Axis[(int)AxisesChannel.Axis_Z].Config.FWIN = (int)enum_InputLable.Axis_Z_FwLimit;
            //Axis[(int)AxisesChannel.Axis_Z].Config.REVIN = (int)enum_InputLable.Axis_Z_ReLimit;
            //Axis[(int)AxisesChannel.Axis_Z].Config.AxisType = Tools.enum_AxisType.EtherCAT_Pos;
            ////  Axis[(int)enum_AxisesIndex.Axis_Y].Config.Units=
            ////A
            //Axis[(int)AxisesChannel.Axis_A].Config.AxisLable = "A";
            //Axis[(int)AxisesChannel.Axis_A].Config.AxisNum = (int)AxisesChannel.Axis_A;
            //Axis[(int)AxisesChannel.Axis_A].Config.Enable = true;
            //Axis[(int)AxisesChannel.Axis_A].Config.EncodeValue = 23;
            //Axis[(int)AxisesChannel.Axis_A].Config.FS_Limit = 500;
            //Axis[(int)AxisesChannel.Axis_A].Config.Lead = 5;
            //Axis[(int)AxisesChannel.Axis_A].Config.RS_limit = -100;
            //Axis[(int)AxisesChannel.Axis_A].Config.FWIN = -1;
            //Axis[(int)AxisesChannel.Axis_A].Config.REVIN = -1;
            //Axis[(int)AxisesChannel.Axis_A].Config.AxisType = Tools.enum_AxisType.VirtualAxis;

            ////C
            //Axis[(int)AxisesChannel.Axis_C].Config.AxisLable = "C";
            //Axis[(int)AxisesChannel.Axis_C].Config.AxisNum = (int)AxisesChannel.Axis_C;
            //Axis[(int)AxisesChannel.Axis_C].Config.Enable = true;
            //Axis[(int)AxisesChannel.Axis_C].Config.EncodeValue = 23;
            //Axis[(int)AxisesChannel.Axis_C].Config.FS_Limit = 500;
            //Axis[(int)AxisesChannel.Axis_C].Config.Lead = 5;
            //Axis[(int)AxisesChannel.Axis_C].Config.RS_limit = -100;
            //Axis[(int)AxisesChannel.Axis_C].Config.FWIN = -1;
            //Axis[(int)AxisesChannel.Axis_C].Config.REVIN = -1;
            //Axis[(int)AxisesChannel.Axis_C].Config.AxisType = Tools.enum_AxisType.VirtualAxis;


        }
        #endregion
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 旋转相关参数
        /// </summary>
        private void LoadRotConfig()
        {
            StandardCladdingInstr.RotParam.RotConfigParam.RadiusMax = double.Parse(ConfigurationManager.AppSettings["RadiusMax"]);
            StandardCladdingInstr.RotParam.RotConfigParam.RadiusMin = double.Parse(ConfigurationManager.AppSettings["RadiusMin"]);
            StandardCladdingInstr.RotParam.RotConfigParam.RotSpeedMax = double.Parse(ConfigurationManager.AppSettings["RotSpeedMax"]);
            StandardCladdingInstr.RotParam.RotConfigParam.RotAxisIndex = (int)AxisesChannel.Axis_A;

        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            StartCommunicat();
        }

        private void ico_ComunicatError_MouseHover(object sender, EventArgs e)
        {
            //foreach()
        }
    }

    }

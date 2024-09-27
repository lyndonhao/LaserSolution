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
using static LaserSolution.GlobalData;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;
using System.Threading;
using Tools;

namespace LaserSolution
{
    public partial class Frm_LoadPage : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        public Frm_LoadPage()
        {
            InitializeComponent();


        }
        private void InitBKWorker()
        {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            //bw.DoWork += new DoWorkEventHandler(StepRun);
          //  bw.ProgressChanged += new ProgressChangedEventHandler(ProgessChanged);

        }
        //private void ProgessChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    e.us
        //}
        string controllerip;
        //string Content = "";
        List<string> message = new List<string>();
        string _mess = "";
        private void StartMessage(string x_message)
        {
              _mess=x_message+"......  " ;
            //txb_Content.Text+= x_message + "......  ";
            
            delay();
        }
        private void CompleteMessage()
        {
            _mess += "     OK\n";
            message.Add(_mess);
        }
        private void FailMessage()
        {
            _mess += "     失败!\n";
            message.Add(_mess);

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
        private void txb_Content_TextChanged(object sender, EventArgs e)
        {
            txb_Content.ScrollToCaret();
        }
        int step = 0;
        const int ErrorStep = 401;
        // private void StepRun(object sender,DoWorkEventArgs e)
        private void StepRun()
        {
       
           
            //1 设置IP地址,连接  

            controllerip = ConfigurationManager.AppSettings["ControllerIp"];
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

            // StartMessage("开始配置轴数据...");
            //3加载轴数据
            StartMessage("初始化轴配置");
            InitAxis();
            CompleteMessage();

            //4加载零位数据
            StartMessage("加载零位数据");

            AppPath = Application.StartupPath;
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

            StartMessage("加载线速度");
            LineSpeedMax = double.Parse(ConfigurationManager.AppSettings["LineSpeedMax"]);
            CompleteMessage();

            Frm_Main main = new Frm_Main();
            main.Show();
            this.Hide();

            ///加载零位位置数据
            // 


            ///设置dPos值

        }
        private void Error()
        {
            btn_Exit.Visible = true;
            return;
        }
            //step 1 .获取IP地址 ,连接

   
        
        

        //private void timer_CheckAlive_Tick(object sender, EventArgs e)
        //{

        //}
        //private void CheckAlive()
        //{

        //}
        private void CheckAlive()
        {

            //get MC  alive status ,try 5 time
            bool balive = false;
            int trytime = 0;
            mc.CheckLiveBeat();
            do
            {
                balive = mc.CheckLiveBeat();
                trytime++;
            }
            while (!balive && trytime < 5);
           
           
           

        }
        #region 运动轴轴配置和操作
        private void InitAxis()
        {
            


            StartMessage("配置轴通道");
            AxisesChannel.Axis_X = 0;
            AxisesChannel.Axis_Y = 1;
            AxisesChannel.Axis_Z = 2;
            AxisesChannel.Axis_A = 3;
            AxisesChannel.Axis_C = 4;
            mc.Channels = AxisesChannel;
            CompleteMessage();
            //geng
            //SetAxieConfig();

  
            mc.GetAxisList();

        }

        private void SetAxieConfig()
        {
            //Axis_x
            Axis[(int)AxisesChannel.Axis_X].Config.AxisLable = "X";
            Axis[(int)AxisesChannel.Axis_X].Config.AxisNum = (int)AxisesChannel.Axis_X;
            Axis[(int)AxisesChannel.Axis_X].Config.Enable = true;
            Axis[(int)AxisesChannel.Axis_X].Config.EncodeBits = 23;
            Axis[(int)AxisesChannel.Axis_X].Config.FS_Limit = 500;
            Axis[(int)AxisesChannel.Axis_X].Config.Lead = 5;
            Axis[(int)AxisesChannel.Axis_X].Config.RS_limit = -100;
            Axis[(int)AxisesChannel.Axis_X].Config.FWIN = (int)enum_InputLable.Axis_X_FwLimit;
            Axis[(int)AxisesChannel.Axis_X].Config.REVIN = (int)enum_InputLable.Axis_X_ReLimit;
            Axis[(int)AxisesChannel.Axis_X].Config.AxisType = Tools.enum_AxisType.EtherCAT_Pos;

            //axis_y
            Axis[(int)AxisesChannel.Axis_Y].Config.AxisLable = "Y";
            Axis[(int)AxisesChannel.Axis_Y].Config.AxisNum = (int)AxisesChannel.Axis_Y;
            Axis[(int)AxisesChannel.Axis_Y].Config.Enable = true;
            Axis[(int)AxisesChannel.Axis_Y].Config.EncodeBits = 23;
            Axis[(int)AxisesChannel.Axis_Y].Config.FS_Limit = 500;
            Axis[(int)AxisesChannel.Axis_Y].Config.Lead = 5;
            Axis[(int)AxisesChannel.Axis_Y].Config.RS_limit = -100;
            Axis[(int)AxisesChannel.Axis_Y].Config.FWIN = (int)enum_InputLable.Axis_Y_FwLimit;
            Axis[(int)AxisesChannel.Axis_Y].Config.REVIN = (int)enum_InputLable.Axis_Y_ReLimit;
            Axis[(int)AxisesChannel.Axis_Y].Config.AxisType = Tools.enum_AxisType.EtherCAT_Pos;
            //Z
            Axis[(int)AxisesChannel.Axis_Z].Config.AxisLable = "Z";
            Axis[(int)AxisesChannel.Axis_Z].Config.AxisNum = (int)AxisesChannel.Axis_Z;
            Axis[(int)AxisesChannel.Axis_Z].Config.Enable = true;
            Axis[(int)AxisesChannel.Axis_Z].Config.EncodeBits = 23;
            Axis[(int)AxisesChannel.Axis_Z].Config.FS_Limit = 500;
            Axis[(int)AxisesChannel.Axis_Z].Config.Lead = 5;
            Axis[(int)AxisesChannel.Axis_Z].Config.RS_limit = -100;
            Axis[(int)AxisesChannel.Axis_Z].Config.FWIN = (int)enum_InputLable.Axis_Z_FwLimit;
            Axis[(int)AxisesChannel.Axis_Z].Config.REVIN = (int)enum_InputLable.Axis_Z_ReLimit;
            Axis[(int)AxisesChannel.Axis_Z].Config.AxisType = Tools.enum_AxisType.EtherCAT_Pos;
            //  Axis[(int)enum_AxisesIndex.Axis_Y].Config.Units=
            //A
            Axis[(int)AxisesChannel.Axis_A].Config.AxisLable = "A";
            Axis[(int)AxisesChannel.Axis_A].Config.AxisNum = (int)AxisesChannel.Axis_A;
            Axis[(int)AxisesChannel.Axis_A].Config.Enable = true;
            Axis[(int)AxisesChannel.Axis_A].Config.EncodeBits = 23;
            Axis[(int)AxisesChannel.Axis_A].Config.FS_Limit = 500;
            Axis[(int)AxisesChannel.Axis_A].Config.Lead = 5;
            Axis[(int)AxisesChannel.Axis_A].Config.RS_limit = -100;
            Axis[(int)AxisesChannel.Axis_A].Config.FWIN = -1;
            Axis[(int)AxisesChannel.Axis_A].Config.REVIN = -1;
            Axis[(int)AxisesChannel.Axis_A].Config.AxisType = Tools.enum_AxisType.VirtualAxis;

            //C
            Axis[(int)AxisesChannel.Axis_C].Config.AxisLable = "C";
            Axis[(int)AxisesChannel.Axis_C].Config.AxisNum = (int)AxisesChannel.Axis_C;
            Axis[(int)AxisesChannel.Axis_C].Config.Enable = true;
            Axis[(int)AxisesChannel.Axis_C].Config.EncodeBits = 23;
            Axis[(int)AxisesChannel.Axis_C].Config.FS_Limit = 500;
            Axis[(int)AxisesChannel.Axis_C].Config.Lead = 5;
            Axis[(int)AxisesChannel.Axis_C].Config.RS_limit = -100;
            Axis[(int)AxisesChannel.Axis_C].Config.FWIN = -1;
            Axis[(int)AxisesChannel.Axis_C].Config.REVIN = -1;
            Axis[(int)AxisesChannel.Axis_C].Config.AxisType = Tools.enum_AxisType.VirtualAxis;
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
           GlobalData.StandardCladdingInstr.RotParam.RotConfigParam.RadiusMax = double.Parse(ConfigurationManager.AppSettings["RadiusMax"]);
           GlobalData.StandardCladdingInstr.RotParam.RotConfigParam.RadiusMin = double.Parse(ConfigurationManager.AppSettings["RadiusMin"]);
           GlobalData.StandardCladdingInstr.RotParam.RotConfigParam.RotSpeedMax = double.Parse(ConfigurationManager.AppSettings["RotSpeedMax"]);
           GlobalData.StandardCladdingInstr.RotParam.RotConfigParam.RotAxisIndex = (int)AxisesChannel.Axis_A;

        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (message.Count > count)
            {
                for (int i = count; i< message.Count; i++)
                {
                    txb_Content.Text += message[i];
                    count++;
                }
            }
        }

        private void Frm_LoadPage_Load(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(StepRun);
            Thread thread = new Thread(threadStart);
            thread.Start();
            StepRun();
        }
    }

}


        





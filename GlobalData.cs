using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools;
using System.Data;
using NLog;
using System.ComponentModel;
using System.Configuration;
namespace LaserSolution
{

    class GlobalData
    {


        public const int nPage_Login = 1000;
        public const int nPage_Operate = 1001;
        public const int nPage_Production = 1002;
        public const int nPage_Program = 1003;
        public const int nPage_Processing = 1004;
        public const int nPage_Diagnosis = 1005;
        public const int nPage_Settings = 1006;
        public const int nPage_Help = 1007;
        //public int nChosenPageIndex;
        //operate sub pages
        public const int nPage_Operate_Manual = 1101;
        public const int nPage_Operate_Status = 1102;
        public const int nPage_Operate_Frames = 1103;

        public static int OldPageIndex;
        //F1~F7                                                                      F1                     F2                         F3                         F4                     F5                         F6                            F7
        public string[] Operate_FunctionsKeys_Text = { "操作页面", "状态信息", "坐标系", "", "", "", "" };
        public string[] Production_FunctionsKeys_Text = { "生产信息", "程序配置", "统计数据", "", "", "", "" };
        public string[] Program_FunctionsKeys_Text = { "插入轨迹", "编辑", "坐标系", "", "", "新建程序", "保存" };

        public MyLogger mlog = new MyLogger("");

        /// <summary>
        /// define 5 axis in the system , x y z a c 
        /// status and  all infomation  there are no order for x yz .  indecate by AxiesChannel
        /// </summary>
        public static AxisType[] Axis = new AxisType[5];
        /// <summary>
        /// x y z 各轴铜套
        /// </summary>
        public static AxisesChannelType AxisesChannel = new AxisesChannelType();

        //public enum enum_AxisesChannel {
        //    Axis_X = 2,
        //    Axis_Y =1,
        //    Axis_Z = 0,
        //    Axis_A = 3,
        //    Axis_C = 4,
        //}
        /// <summary>
        /// 每个轴在控制器中的轴号
        /// </summary>
        public static int[] AxisNumber = new int[6];
        public Controller Controller = new Controller();

        public static MC mc = new MC();

        public static List<ImgStatus> ImgStatusList = new List<ImgStatus>();
   
        /// <summary>
        /// 输入端口信号, IO结构体数据数组
        /// </summary>
        public static IOType[] Inputs = new IOType[24];
        public static bool[] bInputValues = new bool[24];

        public static bool[] bLedStatus = new bool[16];
        /// <summary>
        /// 字节数据
        /// </summary>
        public static byte[] bLedSta = new byte[2];

        public static IOType[] Outputs =new IOType [12];
        public static bool[] bOutputValues = new bool[12];

        public static int LaserPower1 = 0;
        public static int LaserPower2 = 0;
        public static PWMType LaserPWM = new PWMType();

        /// <summary>
        /// analog signal max value is 4095 0~4095;
        /// </summary>
        public const int analogMax = 4095;
        //AO laser power
        /// <summary>
        /// laserpower
        /// </summary>
        public static float AO0 = 0;
        /// <summary>
        /// powder supply speed
        /// </summary>
        public static float AO1 = 0;
       
        //点位列表
        /// <summary>
        /// point list for current load job .
        /// </summary>
       // public static List<Point> pointList = new List<Point>();
        //cladding instructions

        
            /// <summary>
            /// job instruct list , for run .
            /// </summary>
        public static JobDataTypeListType CurrentJobDataList = new JobDataTypeListType();
        /// <summary>
        /// next job for call 
        /// </summary>
        public static List<InstructDataType> NextJoinstrctList = new List<InstructDataType>();


        /// <summary>
        /// //当前选中程序名
        /// </summary>
        public static string CurrentSelectProgram = "";

        /// <summary>
        /// 日志类
        /// </summary>
        public static Logger log = NLog.LogManager.GetLogger("LaserLog");

        

        /// <summary>
        /// the whole system status
        /// </summary>
        public static int SystemStatusCode = -99;

        public static int OperateModeCode = -1;
        public enum OperateModeType
        {
            MANUL=0,
            AUTO=1,
        }
        public static OperateModeType OperateMode = new OperateModeType();

        public static SystemStatusType SystemStatus = new SystemStatusType();
        public enum SystemStatusType
        {
            /// <summary>
            /// some error
            /// </summary>
            Error=1,
            /// <summary>
            /// system ready to run
            /// </summary>
            Standby=2,
            /// <summary>
            /// estop chain if open
            /// </summary>
            Estop=3,
            /// <summary>
            /// there are no task ,means no program was chosed,or not doing task
            /// </summary>
            None = 0,
            /// <summary>
            /// doing job
            /// </summary>
            Running = 4,
            /// <summary>
            /// job pause
            /// </summary>
            Pause = 5,
            /// <summary>
            /// has chose job,and but not runing or pause 
            /// </summary>
            Stop = 6
        }
        public static bool CycleStart = false;
        public static bool CycleRunning = false;
        public static bool CyclePause = false;
        public static bool CycleStop = false;
        public static int CycleStatus;

        public static int DoAction;
        public static  Position GetPos()
        {
            Position p = new Position();

            p.x = Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos;
            p.y = Axis[(int)AxisesChannel.Axis_Y].Status.CurrentPos;
            p.z = Axis[(int)AxisesChannel.Axis_Z].Status.CurrentPos;
            p.a = Axis[(int)AxisesChannel.Axis_A].Status.CurrentPos;
            p.c = Axis[(int)AxisesChannel.Axis_C].Status.CurrentPos;
          
           
            return p;
        }
  
        public static int ProgramPageSeletCellRow=-1;
        public static int ProgramPageSeletCellColumn = -1;

        /// <summary>
        /// this application start path e.g C:\\Kiss\bay  without last '\'
        /// </summary>
        public static string AppPath = "";

        /// <summary>
        ///    //\LaserAPP\Cladding\Jobs\
        /// </summary>
        public static string CladdingJobSavePath = @"\LaserAPP\Cladding\Jobs\";
        /// <summary>
        /// LaserAPP\Cladding\Products\
        /// </summary>
        public static string CladdingProgSavePath = @"LaserAPP\Cladding\Products\";

        public static ApplicationType application = ApplicationType.Cladding;

        /// <summary>
        /// 
        /// </summary>
        public static ProgramType CurrentProgram = new ProgramType();

        /// <summary>
        ///  当前加载程序指令列表
        /// </summary>
       //public static  BindingList<InstrDataViewType> ListofInstructionForView = new BindingList<InstrDataViewType>();

        public static Position CurrentPos = new Position();

        /// <summary>
        ///前瞻运动处理参数
        /// </summary>
        public static PreMoveParamType PreMoveParam = new PreMoveParamType();

        /// <summary>
        /// 零件直径
        /// </summary>
        public static double PartRadius = 0;


        public static double  InputValue(string  sName,double _min, double _max,double InValue)
        {
            double _value = 0;
            Frm_NumPad input = new Frm_NumPad();
            input.MaxValue = _max;
            input.MinValue = _min;
            input.sName = sName;
            input.TypeInValue = InValue;
            input.ShowDialog();
            if (input.bComplete)
            {
                _value =System.Math.Round( input.TypeInValue,3);

            }
            else
            {
                _value = InValue;
            }
            
            input.Dispose();
            return _value;
        }
        public static String InputString(string sName, string InString)
        {
            string str = "";
            Frm_keyboard frm_Keyboard = new Frm_keyboard();
            frm_Keyboard.sName = sName;
            frm_Keyboard.Content = InString;
            frm_Keyboard.ShowDialog();
            if (frm_Keyboard.bComplete)
            {
                str= frm_Keyboard.Content;
            }
            else
            {
                str= InString;
            }

            frm_Keyboard.Dispose();
            return str;

        }
        public const double Pi = 3.1415926;
        ///// <summary>
        ///// 当前零件旋转参数表
        ///// </summary>
        //public static RotParamType RotParam = new RotParamType();

        /// <summary>
        /// 最大线速度值
        /// </summary>
        public static double LineSpeedMax = 200;
        /// <summary>
        /// 整体速度百分比
        /// </summary>
        public static double SpeedRatio = 1;

        public static double LineSpeedNow;

        public static AxisZeroPhase ZeroPhase = new AxisZeroPhase();
        /// <summary>
        /// 设置当前零位数据文件路径
        /// </summary>
      public  static string   ZeroPhaseFile = GlobalData.AppPath + @"\configs\" + ConfigurationManager.AppSettings["ZeroPhaseFile"];
        /// <summary>
        /// 机床熔覆参数设定,需要在开机初始化(考虑保存一个模板)
        /// </summary>
      public static CladdingBaseParamType CladdingBaseParam;

        public static SettingsType Settings;
        /// <summary>
        /// 机床参数保存文件
        /// </summary>
        public static string settingfile = "";

        public  static StandardCladdingInstrType StandardCladdingInstr = new StandardCladdingInstrType();

        public static double Height;

        /// <summary>
        /// compare current position if whether same with the instr's position
        /// </summary>
        /// <param name="x_in1"></param>
        /// <param name="x_in2"></param>
        /// <returns></returns>
        public static   bool ComparePosSame(Position x_in1, Position x_in2)
        {

            bool equal = false;
            const double Tolerance = 0.05;
            equal = Math.Abs(x_in1.x - x_in2.x) < Tolerance &&
                Math.Abs(x_in1.y - x_in2.y) < Tolerance &&
                Math.Abs(x_in1.z - x_in2.z) < Tolerance;
                //Math.Abs(x_in1.a - x_in2.a) < Tolerance &&
                //Math.Abs(x_in1.c - x_in2.c) < Tolerance;

            return equal;
        }
        /// <summary>
        /// 缓冲的moveID
        /// </summary>
        public static int BufferMoveId = 0;
        /// <summary>
        /// 当前运动moveid
        /// </summary>
        public static int CurrentMoveId = 0;
    }

}

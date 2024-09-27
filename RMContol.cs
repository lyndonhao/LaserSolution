using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RemotContolTool
{
    public struct RMStatusType
    {

        public bool bInited;
        public bool bOpened;
        public bool bLostConnect;
        public bool bError;
        public int nErrorCode;
        public string sErrorMsg;
        public int HandleId;
        public string sSignal;
        /// <summary>
        /// 当前被按下键号
        /// </summary>
        public int iKeyPressed;
    }
    public struct RMLEDType
    {
        //public BitArray Led = new BitArray(16);
        public int nSelectedLed;
    }
    /// <summary>
    /// PHB09 键值表
    /// </summary>
    public enum enumPHB09KeyValue
    {
           Start=1,
           Stop=2,
           Pause=3,
           Estop=5,
           StepMode=6,
           Laser = 13,
           Blow = 14,
           Follow = 15,
           AxisW_P=17,
           AxisW_N=25,
           AxisX_P=21,
           AxisX_N=23,
           AxisY_P=18,
           AxisY_N=26,
           AxisJogSpeedSwit=22

        /*GLOBAL DIM IkeyNum ' 按键键值
GLOBAL DIM tmp_KeyNum '
GLOBAL CONST  key_Xp	 =21
GLOBAL CONST  Key_High  =22
GLOBAL CONST  key_Xm	 =23
GLOBAL CONST  key_Yp	 =18
GLOBAL CONST  key_Ym	 =26
GLOBAL CONST  key_Zp    =19
GLOBAL CONST  key_Zm	 = 27
GLOBAL CONST  key_Wp	 = 17
GLOBAL CONST  key_Wm    =25

GLOBAL CONST Key_Start=1
GLOBAL DIM tmp_KeyStart
GLOBAL CONST Key_Stop=2
GLOBAL DIM tmp_Key_Stop
GLOBAL CONST Key_Estop=5
GLOBAL DIM tmp_Key_Estop

GLOBAL CONST Key_Step=6 'step mode
GLOBAL dim stepmode

GLOBAL CONST key_Pause=3
GLOBAL DIM tmp_key_Pause
GLOBAL CONST Key_laser=13
GLOBAL CONST key_blow=14
GLOBAL CONST key_follow=15
        //led
*/
    }
    /// <summary>
    /// phb09 led status enum
    /// </summary>
    public enum enumPHB09LedStatus
    {
      Led_Step = 80,
      Led_Alarm = 83,
      Led_low = 86,
      Led_High = 91,

      Led_Follow = 89,
      Led_Blow = 92,
      Led_laserAtjob = 93,
      Led_Laser = 94,
      Led_Shutter = 95 
    }
    class RMContol
    {
        [DllImport("PHBX.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void Xinit();
        [DllImport("PHBX.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void XClose();
        [DllImport("PHBX.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int XOpen(int handle);
        [DllImport("PHBX.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int XSendOutput(byte[] sendbuffer, IntPtr length);
        [DllImport("PHBX.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int XGetInput(IntPtr getbuffer, IntPtr length);

        public static RMStatusType RMStatus;
        public static RMLEDType RMLED;

        public static  int _hdid = 10000;
        

        public int hdid
        {
            get {
                return _hdid;
            }
        }
        public static bool Init()
        {
            bool bok=false;
            try
            {
                Xinit();

                bok = true;
                RMStatus.bInited = true;
            }
            catch (Exception ex)
            {
                bok = false;
                RMStatus.bInited = false;
            }
             

                return bok;
        }
        public static int    OpenChannel()
        {
            int l_rst = -1;
            try
            {
                l_rst = XOpen(_hdid);
                RMStatus.bOpened = true;
                
            }
            catch (Exception ex)
            {
                l_rst = -1;
            }
            RMStatus.bOpened =( l_rst == 0);
            RMStatus.nErrorCode = l_rst;
            return l_rst ;
        }

        #region delegete cycle read data
        // // 初始化主动轮询计时器
        public static bool InitTimer()
        {
            System.Timers.Timer t = new System.Timers.Timer(100);//实例化Timer类，设置间隔时间为1000毫秒； 
            t.Elapsed += new System.Timers.ElapsedEventHandler(OrderTimer_Tick);//到时间的时候执行事件； 
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)； 
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件； 
            return true;
        }
        // 定义委托
        public delegate void Handlelist();
        // 定时轮询
        public static void  OrderTimer_Tick(object source, System.Timers.ElapsedEventArgs e)
        {

            GetSignal();
        }
        // 被委托的方法
        private void InvokedFunc()
        {
            SyncRead();
        }
        // 同步读
        private void SyncRead()
        {
            ;

        }

        /// <summary>
        /// 当前
        /// </summary>
        /// <returns></returns>
        public static int GetSignal()
        {
            //Handlelist m = new Handlelist(InvokedFunc);
            //Invoke(m);
            byte[] sendbufer = new byte[60];
            byte[] bsendlength = new byte[2];
            int[] getbufer = new int[2];
            IntPtr sendlengh;
            // IntPtr getlengh;
            IntPtr getdata;
            int ilength;
            bsendlength[0] = 60;
            
            ilength = 2;
            IntPtr getlengh = new IntPtr(ilength);

            GCHandle hObject1 = GCHandle.Alloc(getbufer, GCHandleType.Pinned);
            getdata = hObject1.AddrOfPinnedObject();
            GCHandle hObject2 = GCHandle.Alloc(bsendlength, GCHandleType.Pinned);
            sendlengh = hObject2.AddrOfPinnedObject();


            //textBox1.Text = sendlengh.ToString();
            //string str = "     1234567890";
            // sendbufer = System.Text.Encoding.Default.GetBytes(str);
            sendbufer[0] = 0xff;
            sendbufer[1] = 0xff;
           // XSendOutput(sendbufer, sendlengh);
            /*
            100:USB未打开
                101:USB 发送错误.
                102: USB接收错误.
                103: 参数错误.
            104, 手柄和控制器失去连接.如手柄关电或远距离操作.
            105,  手柄睡眠了.(邦德手柄)
            106,  手柄信号不好.此时手柄和控制器连接不稳定,需要检查接收器天线或接收器是否放在金属柜里面.或手柄距离太远.或环境有干扰等原因.

            */
            int result = XGetInput(getdata, sendlengh);
            RMStatus.bError = (result != 0);
            RMStatus.sSignal = "";
            if (result != 0)
                CheckRetrunCode(result);
            else
            {
                if (getbufer[0] != 0)
                {
                    RMStatus.sSignal = "keypressed" + getbufer[0].ToString();
                    RMStatus.iKeyPressed = getbufer[0];
                }
                else
                {
                    RMStatus.iKeyPressed = 0;
                }
            }

            return RMStatus.iKeyPressed;
            }
        public static bool SendLedStatus(byte[] x_ledStatsu)       
        {
            bool bok = false;
          

            //  BitArray x_signals = new BitArray(16);
            byte[] sendbufer = new byte[10];
            byte[] bsendlength = new byte[2];
            IntPtr sendlengh;
            int ilength;
            bsendlength[0] = 60;

            ilength = 2;
            IntPtr getlengh = new IntPtr(ilength);


            GCHandle hObject2 = GCHandle.Alloc(bsendlength, GCHandleType.Pinned);
            sendlengh = hObject2.AddrOfPinnedObject();


            //textBox1.Text = sendlengh.ToString();
            //string str = "     1234567890";
            // sendbufer = System.Text.Encoding.Default.GetBytes(str);


            //byte0[0] = true;
            //byte0[3] = true;
            //byte0[8]= true;
            //byte0[RMLED.nSelectedLed] = true;
            //  x_signals.CopyTo

            //sendbufer[0] = 0xff;
            //sendbufer[1] = 0xff;
            int l_rst = XSendOutput(x_ledStatsu, sendlengh);
            if (l_rst == 0)
            {

            }
            else
            {
                CheckRetrunCode(l_rst);
            }
            return bok;
        }
        public static bool SendSignal(bool [] x_signals)
        {
            bool bok = false;

          //  BitArray x_signals = new BitArray(16);
            byte[] sendbufer = new byte[10];
            byte[] bsendlength = new byte[2];
            IntPtr sendlengh;
            int ilength;
            bsendlength[0] = 60;

            ilength = 2;
            IntPtr getlengh = new IntPtr(ilength);

           
            GCHandle hObject2 = GCHandle.Alloc(bsendlength, GCHandleType.Pinned);
            sendlengh = hObject2.AddrOfPinnedObject();


            //textBox1.Text = sendlengh.ToString();
            //string str = "     1234567890";
            // sendbufer = System.Text.Encoding.Default.GetBytes(str);
            
            BitArray byte0 = new BitArray(16);
            sendbufer[0] = 0x00;
            sendbufer[1] = 0x00;
            for (int i = 0; i < x_signals.Length; i++)
                byte0[i] = x_signals[i];
            //byte0[0] = true;
            //byte0[3] = true;
            //byte0[8]= true;
            //byte0[RMLED.nSelectedLed] = true;
            //  x_signals.CopyTo
            byte0.CopyTo(sendbufer, 0);
            //sendbufer[0] = 0xff;
            //sendbufer[1] = 0xff;
           int l_rst= XSendOutput(sendbufer, sendlengh);
            if (l_rst == 0)
            {

            }
            else
            {
                CheckRetrunCode(l_rst);
            }
            return bok;
            
        }
        public static void  CheckRetrunCode(int x_rst)
        {
            switch (x_rst)
            {
              
                  

                case 100:
                    RMStatus.sErrorMsg = "usb is lost";
                    break;
                case 101:
                    RMStatus.sErrorMsg = "usb send msg error";
                    break;
                case 102:
                    RMStatus.sErrorMsg = "usb recive msg error";
                    break;
                case 103:
                    RMStatus.sErrorMsg = "param error";
                    break;

                case 104:
                    RMStatus.sErrorMsg = "phb02 is beome idle";
                    break;
                case 106:
                    RMStatus.sErrorMsg = "week signal ,check workstatus";
                    break;
            }


        }

        #endregion
    }
}

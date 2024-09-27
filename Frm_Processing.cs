
using Sunny.UI;
using Tools;
using LaserSolution.Properties;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;
using static LaserSolution.GlobalData;
using System.Threading;
using Newtonsoft.Json;
using System;

namespace LaserSolution
{
    public partial class Frm_Processing : UITitlePage
    {
        //private StandardCladdingInstrType  GlobalData.StandardCladdingInstr;
        /// <summary>
        /// 标准产品保存路径
        /// </summary>
        private string StandardPartFilePath = "";
        /// <summary>
        /// 参数确认,false 标识未确认
        /// </summary>
        bool bCheck = false;
        public Frm_Processing()
        {
            InitializeComponent();

            TypeList.SelectedIndex = -1;
            StandardPartFilePath = GlobalData.AppPath + ConfigurationManager.AppSettings["StandardCalddingPath"];
            LoadSaveStanderInstr(StandardPartFilePath + "template.stf");
            RefreshStandardPartList();
            InitList();
            RefreshRotParam();
            RefreshParamDisplay();
            JumpToTab(Enum_TabNameType.CreateNewJob);
            uiTabControl1.TabVisible = false;
            //lt_moveing.State = UILightState.Off;
            sbtn_F2.Text = "暂停";
        }
        int PageIndexNow = 0;
     
        private void InitList()
        {
            TypeList.Items.Clear();
            TypeList.AddImage(Resources.耐磨带, EnumHelper.GetDescription(SpecialInstrType.ShapeOnCylinder));   //0
            TypeList.AddImage(Resources.线, EnumHelper.GetDescription(SpecialInstrType.SurfaceOnAxis));
            TypeList.SelectedFirst();
        }
        /// <summary>
        /// create new job name for special  generate 
        /// </summary>
        string newProgName = "";

        enum Enum_TabNameType
        {
            /// <summary>
            /// 新建新的程序
            /// </summary>
            [EnumDescription("tab_NewApp")]
            CreateNewJob,
            [EnumDescription("tab_ParamSet")]
            ShapeONSuf,
            [EnumDescription("tab_CheckPos")]
            CheckCountur,
            [EnumDescription("tab_AxisCladdingParam")]
            AxisCladdingParam

        }
        List<InstructDataType> contur = new List<InstructDataType>();
        private void JumpToTab(Enum_TabNameType x_Tabname)
        {
            bCheck = false;
            uiTabControl1.SelectTab(EnumHelper.GetDescription(x_Tabname));
            //uiTabControl1.TabPages[uiTabControl1.sel
            if (x_Tabname == Enum_TabNameType.AxisCladdingParam || x_Tabname == Enum_TabNameType.ShapeONSuf)
            {
                sbtn_F7.Text = "保存";
                sbtn_F7.SymbolSize = 40;
                sbtn_F7.Enabled = true;
                sbtn_F6.Text = "确认";
                sbtn_F6.SymbolSize = 40;
                sbtn_F6.Enabled = true;
                sbtn_F5.Text = "修改";
                sbtn_F5.SymbolSize = 40;
                sbtn_F5.Enabled = true;
            }
            else
            {
                sbtn_F7.Text = "";
                sbtn_F7.SymbolSize = 0;
                sbtn_F7.Enabled = false;
                sbtn_F6.Text = "";
                sbtn_F6.SymbolSize = 40;
                sbtn_F6.Enabled = false;
                sbtn_F5.Text = "";
                sbtn_F5.SymbolSize = 40;
                sbtn_F5.Enabled = false;

            }
        }


        private void bt_newProgramCheck_Click(object sender, System.EventArgs e)
        {
            if (txtb_ProgramName.Text.IsValid() && txtb_ProgramName.Text != "")
            {
                newProgName = txtb_ProgramName.Text.Trim() + standExtenrString;
                if (File.Exists(StandardPartFilePath + newProgName))
                {
                    UIMessageBox.ShowInfo("程序名  [ " + newProgName + "  ]已存在,请重新输入");
                    txtb_ProgramName.Text = "";
                    newProgName = "";
                }
                else
                {
                    //  GlobalData.StandardCladdingInstr.Name = newProgName;
                    GlobalData.StandardCladdingInstr.Name = newProgName;
                    GlobalData.StandardCladdingInstr.PartType = (SpecialInstrType)TypeList.SelectedIndex;
                    GlobalData.StandardCladdingInstr.TypeName = EnumHelper.GetDescription(GlobalData.StandardCladdingInstr.PartType);
                    ParamPageJump((SpecialInstrType)TypeList.SelectedIndex);
                    //switch ((SpecialInstrType)TypeList.SelectedIndex)
                    //{
                    //    case SpecialInstrType.SurfaceOnAxis:
                    //        JumpToTab(Enum_TabNameType.AxisCladdingParam);
                    //        break;
                    //    case SpecialInstrType.ShapeOnCylinder:
                    //        JumpToTab(Enum_TabNameType.ShapeONSuf);
                    //        break;
                    //}
                    GlobalData.CurrentSelectProgram = GlobalData.StandardCladdingInstr.Name;
                    RefreshParamDisplay();
                    RefreshRotParam();

                    ;

                }
            }
            else
            {
                UIMessageBox.ShowError("正确输入程序名");
            }
        }
        private void ParamPageJump(SpecialInstrType x_Type)
        {
            switch (x_Type)
            {
                case SpecialInstrType.SurfaceOnAxis:
                    //JumpToTab(Enum_TabNameType.AxisCladdingParam);
                    JumpToTab(Enum_TabNameType.ShapeONSuf);
                    break;
                case SpecialInstrType.ShapeOnCylinder:
                    JumpToTab(Enum_TabNameType.ShapeONSuf);
                    break;
            }
        }
        private void tabPage3_Click(object sender, System.EventArgs e)
        {

        }

        private void TypeList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            GlobalData.StandardCladdingInstr.PartType = (SpecialInstrType)TypeList.SelectedIndex;
            StandardCladdingInstr.PartType = (SpecialInstrType)TypeList.SelectedIndex;
        }

        private void sbt_nextPage_Click(object sender, System.EventArgs e)
        {
            // if()
        }
        private void CheckShapeOnSufaceParam()
        {

            ///count every param ok, 
            int countStep = 0;

            countStep++;
            //width
            if (!double.TryParse(input_LineWidth.Text.Trim(), out GlobalData.StandardCladdingInstr.CladdingBaseParam.CladdingWidth))
            {
                UIMessageTip.ShowWarning("熔覆宽度数据输入有误,请重新输入");
            }
            else
                countStep++;
           
            GlobalData.StandardCladdingInstr.ProductParam.HeapParam.EnableTerHeap = uiSwitch1.Active;
            //  GlobalData.StandardCladdingInstr.Heap.LayerNum
          
            //  GlobalData.StandardCladdingInstr.Heap.TerValue
          
            // GlobalData.StandardCladdingInstr.LaserPower
            if (!int.TryParse(input_LaserPower.Text.Trim(), out GlobalData.StandardCladdingInstr.LaserPararm.Power) || GlobalData.StandardCladdingInstr.LaserPararm.Power < 0)
            {
                UIMessageTip.ShowWarning("激光功率数据输入有误,请重新输入");
            }
            else
            {
                countStep++;
            }
            // GlobalData.StandardCladdingInstr.PartRadius
            if (!double.TryParse(input_PartRadius.Text.Trim(), out GlobalData.StandardCladdingInstr.RotParam.Radius))
            {
                UIMessageTip.ShowWarning("零件半径数据输入有误,请重新输入");
            }
            else
            {
                if (StandardCladdingInstr.RotParam.Radius <= 0)
                {
                    ShowErrorTip("半径输入错误,不可为0或小于0");
                    return;
                }

                ////GlobalData.Axis[AxisesChannel.Axis_A].Config.Units = (float)(GlobalData.Settings.Axises[AxisesChannel.Axis_A].Config.Units * GlobalData.Settings.Axises[AxisesChannel.Axis_A].Config.RotRadius / StandardCladdingInstr.RotParam.Radius);
                ////mc.SetAxisUnits(GlobalData.Axis[AxisesChannel.Axis_A]);
                countStep++;
            }


           
                countStep++;

            bCheck = true;
        }
        private void btn_ParamConfirmed_Click(object sender, System.EventArgs e)
        {
            CheckShapeOnSufaceParam();
            ///double.TryParse()

            //生成指令列表

        }
        /// <summary>
        /// load template config  param data , only need to modify seldom to generate  job file
        /// </summary>
        private void loadTemplate(SpecialInstrType specialInstr)
        {
            switch (specialInstr)
            {
                ///圆周上有耐磨带
                case SpecialInstrType.ShapeOnCylinder:
                    // StandardCladdingInstr= JsonConvert.DeserializeObject<StandardCladdingInstrType>(File.ReadAllText());.
                    break;
                case SpecialInstrType.SurfaceOnAxis:

                    break;

            }
        }

      
        const string standExtenrString = ".stf";
        private void RefreshStandardPartList()
        {
            DirectoryInfo di = new DirectoryInfo(StandardPartFilePath);


            if (di != null)
            {
                saveProgramList.Items.Clear();
                foreach (FileInfo fi in di.GetFiles("*" + standExtenrString))
                {
                    saveProgramList.Items.Add(fi.Name);
                }
            }
            else
            {
                ShowErrorDialog("文件保存路径[ " + StandardPartFilePath + " ]不存在");
            }
        }




        private void RecordPos(int pointIndex)
        
        {
            switch (pointIndex)
            {
                case 1:
                    if (!mc.SetZeroConfig(GlobalData.ZeroPhase, GlobalData.Axis))
                    {
                        ShowErrorDialog("记录错误!,请重试");
                            return;
                    }
               
                    GlobalData.StandardCladdingInstr.Pos.P1 = GlobalData.GetPos();
                    GlobalData.StandardCladdingInstr.Pos.P1.a = 0;//默认奖第一个点当成起始点 旋转位置为0
                    ShowSuccessTip("记录点位P1位置成功");                    
                    break;
                case 2:
                    GlobalData.StandardCladdingInstr.Pos.P2 = GlobalData.GetPos();
                    ShowSuccessTip("记录点位P2位置成功");
                    break;
                case 3:
                    GlobalData.StandardCladdingInstr.Pos.P3 = GlobalData.GetPos();
                    ShowSuccessTip("记录点位P3位置成功");
                    break;
                case 4:
                    GlobalData.StandardCladdingInstr.Pos.P4 = GlobalData.GetPos();
                    ShowSuccessTip("记录点位P4位置成功");
                    break;
                default:
                    ShowErrorNotifier("记录点位有误!,请确认");
                    break;
            }

        }

        private void btn_recordP2_Click(object sender, System.EventArgs e)
        {
            if(ShowAskDialog("确认记录点P2的位置?"))
            {
                GlobalData.StandardCladdingInstr.Pos.P2 = GlobalData.GetPos();
                ShowSuccessTip("记录成功");
            }
            
        }

        private void btn_recordp3_Click(object sender, System.EventArgs e)
        {
            if (ShowAskDialog("确认记录点P3的位置?"))
            {
                GlobalData.StandardCladdingInstr.Pos.P3 = GlobalData.GetPos();
                ShowSuccessTip("记录成功");
            }

        }

        private void btn_recordP4_Click(object sender, System.EventArgs e)
        {
            if (ShowAskDialog("确认记录点P4的位置?"))
            {
                GlobalData.StandardCladdingInstr.Pos.P4 = GlobalData.GetPos();
                ShowSuccessTip("记录成功");
            }
        }

        private void btn_newProgram_Click(object sender, System.EventArgs e)
        {
            //if(GlobalData.InputString())
        }

        private void bt_refreshJoblist_Click(object sender, System.EventArgs e)
        {
            RefreshStandardPartList();
        }

        private void sbtn_F7_Click_1(object sender, System.EventArgs e)
        {
            if (!bCheck)
            {
                ShowErrorNotifier("未对参数进行确认,无法保存,请先按确认参数");
                return;
            }
            if (sbtn_F7.Text == "保存")
                Tools.Json.SaveJobData(GlobalData.StandardCladdingInstr, StandardPartFilePath + StandardCladdingInstr.Name);
        }
        /// <summary>
        /// 刷新参数项
        /// </summary>
        private void RefreshParamDisplay()
        {
            
            input_LineWidth.Text = GlobalData.StandardCladdingInstr.CladdingBaseParam.CladdingWidth.ToString("f1");
           
            input_LaserPower.Text = GlobalData.StandardCladdingInstr.LaserPararm.Power.ToString();
           
            input_MoveSpeed.Text = GlobalData.StandardCladdingInstr.MoveSpeed.Tvel.ToString("f1");
       
         
            CurrentSelectProgram = StandardCladdingInstr.Name;
            lb_ProgramName.Text = CurrentSelectProgram;
            input_shapeWidth.Text = GlobalData.StandardCladdingInstr.ProductParam.nCladdingLength.ToString();


        }

        private void lb_p1Pos_Click(object sender, System.EventArgs e)
        {
            DisplayPos(GlobalData.StandardCladdingInstr.Pos.P1, "P1位置");
        }

        private void lb_P2Pos_Click(object sender, System.EventArgs e)
        {
            DisplayPos(GlobalData.StandardCladdingInstr.Pos.P2, "P2位置");
        }

        private void DisplayPos(Position x_pos, string x_title)
        {
            uiTitlePanel1.Text = x_title;
       
        }
        private void lb_P3Pos_Click(object sender, System.EventArgs e)
        {
            DisplayPos(GlobalData.StandardCladdingInstr.Pos.P3, "P3位置");
        }

        private void lb_P4Pos_Click(object sender, System.EventArgs e)
        {
            DisplayPos(GlobalData.StandardCladdingInstr.Pos.P4, "P4位置");
        }
        private void StatusON(ref UIImageButton x_button)
        {
            x_button.Image = Resources.矩形绿色;
        }
        /// <summary>
        ///  确认各个灯状态
        /// </summary>
 
        private void SetStatus(Position p1, ref UIImageButton x_button)
        {
            if (GlobalData.ComparePosSame(p1, GetPos()))
                StatusON(ref x_button);
            else
                StatusOFF(ref x_button);
            //if (!bCheck)
            //   // lt_checkStatus.State = UILightState.Blink;
            //else
               // lt_checkStatus.State = UILightState.On;
        }
        private void StatusOFF(ref UIImageButton x_button)
        {
            x_button.Image = Resources.矩形灰色;
        }
        private bool CheckStatus(UIImageButton x_button)
        {
            return x_button.Image == Resources.矩形绿色;
        }

        private void btn_RotaEnable_Click(object sender, System.EventArgs e)
        {
            if (!CheckStatus(RotEnable))
            {
                if (mc.RotA((int)AxisesChannel.Axis_A, StandardCladdingInstr.RotParam))
                {; }
                else
                {
                    UIMessageBox.ShowError("错误," + mc.errorMessage);
                }
            }
            else
            {
                mc.StopRot((int)AxisesChannel.Axis_A, enum_StopMode.AllMove);
            }
        }

        private void enable_CCW_Click(object sender, System.EventArgs e)
        {



        }
        private void RefreshRotParam()
        {
            input_PartRadius.Text = StandardCladdingInstr.RotParam.Radius.ToString("f1");
            input_MoveSpeed.Text = StandardCladdingInstr.MoveSpeed.Tvel.ToString("f1");
            input_rotateSpeed.Text = StandardCladdingInstr.RotParam.RotSpeed.ToString("f1");
            input_LineSpeed.Text = StandardCladdingInstr.RotParam.LineSpeed.ToString("f1");
            enable_CCW.Active = StandardCladdingInstr.RotParam.CCW;
            StandardCladdingInstr.RotParam.RotConfigParam.LineSpeedMax
                = GetLineSpeed(StandardCladdingInstr.RotParam.Radius, StandardCladdingInstr.RotParam.RotConfigParam.RotSpeedMax);
        }

        private void input_PartRadius_TextChanged(object sender, System.EventArgs e)
        {

            // RefreshRotParam();

        }
        private double GetRotSpeed(double _radius, double _LineSpeed)
        {
            if (_radius <= 0 || _LineSpeed == 0)
            { return 0; }
            else
            {
                return _LineSpeed * 360 / (2 * GlobalData.Pi * _radius);
            }
        }
        private double GetLineSpeed(double _radius, double _rotSpeed)
        {
            if (_radius <= 0 || _rotSpeed == 0)
            { return 0; }
            else
            {
                return 2 * Pi * _radius * _rotSpeed / 360;
            }
        }


        private void input_LineSpeed_Click(object sender, System.EventArgs e)
        {
            

        }

        private void input_rotateSpeed_Click(object sender, System.EventArgs e)
        {
          
        }

        private void input_PartRadius_Click(object sender, System.EventArgs e)
        {
          
            //ChangeRadiusChangeAUnits();
        }

        T_ON checkStatus = new T_ON();
        TrigerON recodTrig = new TrigerON();
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (GlobalData.mc.Connected)
            {
                RefreshDisplayAxisStatus();

                //current moveid 
                lb_currentMoveID.Text = CurrentMoveId.ToString();
               
                double devs = StandardCladdingInstr.ProductParam.nCladdingLength / StandardCladdingInstr.CladdingBaseParam.CladdingWidth;
                lb_totleMoveID.Text = (Math.Abs(devs) + 2).ToString();
                double pecent = 100 * CurrentMoveId / (Math.Abs(devs) + 2);
                uiProcessBar1.Value =(int)pecent;
                uiProcessBar1.Text = pecent.ToString("f4");
                double timeinSecond = 0;
                if (Axis[(int)AxisesChannel.Axis_X].Status.FedbackSpeed!=0)
                          timeinSecond=   Math.Abs( Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos - a_targetpos)/ Axis[(int)AxisesChannel.Axis_X].Status.FedbackSpeed;
                lb_leftTime.Text = ((int)(timeinSecond / 3600)).ToString() + " 小时 /  " + ((int)(timeinSecond % 3600) / 60).ToString() + " 分 / " + ((int)(timeinSecond % 3600) % 60).ToString() + "秒";
                //axis x  and axis A  movestatus
                uiProcessBarline.Value =(int)( 100 - 100 * Math.Abs(Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos - a_targetpos) / _totleLength);
                if (GlobalData.Axis[AxisesChannel.Axis_X].Status.IDLE == 0)
                {
                    xMoveStatus.State = UILightState.Blink;
                }
                else
                {
                    xMoveStatus.State = Math.Abs(Axis[AxisesChannel.Axis_X].Status.CurrentPos- x_targetpos) <0.01 ? UILightState.On : UILightState.Off;
                }
                if (GlobalData.Axis[AxisesChannel.Axis_A].Status.IDLE == 0)
                {
                    aMoveStatus.State = UILightState.Blink;
                }
                else
                {
                    if (Math.Abs(Axis[AxisesChannel.Axis_A].Status.CurrentPos - a_targetpos) < 0.01)
                    {
                        aMoveStatus.State = UILightState.On;

                    }
                    else
                    {
                       aMoveStatus.State = UILightState.Off;
                    }

                }


            }
            //RefreshStatus();
            ///测试代码start
            ////   CheckTimeSpan(bStartCount, 5000);
            //   checkStatus.Enable = bStartCount;
            //   checkStatus.DelayTime = 2000;

            //   if (checkStatus.Q)
            //   {

            //       RecordPos(recordPointNumber);

            //       bStartCount = false;
            //   }
            //测试代码end



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
            CurrentPos.y = GlobalData.Axis[(int)AxisesChannel.Axis_Y].Status.CurrentPos;
            CurrentPos.z = GlobalData.Axis[(int)AxisesChannel.Axis_Z].Status.CurrentPos;
            CurrentPos.a = GlobalData.Axis[(int)AxisesChannel.Axis_A].Status.CurrentPos;
            CurrentPos.c = GlobalData.Axis[(int)AxisesChannel.Axis_C].Status.CurrentPos;
            lb_XPos.Text = CurrentPos.x.ToString("f3");
            //lb_Ypos.Text = CurrentPos.y.ToString("f3");
            //lb_Zpos.Text = CurrentPos.z.ToString("f3");
            lb_Apos.Text = CurrentPos.a.ToString("f3");

        }
        private void RotEnable_switch_Click(object sender, System.EventArgs e)
        {

        }



        private void sbtn_F4_Click(object sender, System.EventArgs e)
        {
            JumpToTab(Enum_TabNameType.CreateNewJob);
        }



        private void input_LineWidth_Click(object sender, System.EventArgs e)
        {
            input_LineWidth.Text = InputValue("输入熔覆线宽度", 0, 100, StandardCladdingInstr.CladdingBaseParam.CladdingWidth).ToString("f2");
            bCheck = false;
        }



        private void sbtn_F6_Click_1(object sender, System.EventArgs e)
        {
            if (StandardCladdingInstr.PartType == SpecialInstrType.ShapeOnCylinder)
                CheckShapeOnSufaceParam();
            if (StandardCladdingInstr.PartType == SpecialInstrType.SurfaceOnAxis)
                CheckAxisParam();
        }
        private void CheckAxisParam()
        {

            bCheck = true;
        }
        private void btn_CheckAxisParam_Click(object sender, System.EventArgs e)
        {

        }

        private void sbtn_F5_Click_1(object sender, System.EventArgs e)
        {
            _seletePosition = GetPos();
            //记录位置
            //RecodeSelectedPoint();
        }

        private void std_shapP1_select_ValueChanged(object sender, bool value)
        {
         //   GetSelectPosition();
        }
       
        Position _seletePosition = new Position();
        //Position _RecodePosition = new Position();
     

        private void LoadSaveStanderInstr(string file)
        {
            if (file != null)
                StandardCladdingInstr =
                    JsonConvert.DeserializeObject<StandardCladdingInstrType>(File.ReadAllText(file));
        }
        private void saveProgramList_DoubleClick(object sender, System.EventArgs e)
        {

        }

        private void saveProgramList_ItemDoubleClick(object sender, System.EventArgs e)
        {
            string _selectedfilepath = StandardPartFilePath + (string)saveProgramList.SelectedItem;
            LoadSaveStanderInstr(_selectedfilepath);
            RefreshParamDisplay();
            RefreshRotParam();
            ParamPageJump(StandardCladdingInstr.PartType);
            SetHomePos();
          
        }
        private void SetHomePos()
        {
            StandardCladdingInstr.Pos.HOME = GlobalData.Settings.Home;
        }

        private void std_shapP2_select_ValueChanged(object sender, bool value)
        {
            ///GetSelectPosition();
        }

        private void std_shapP3_select_ValueChanged(object sender, bool value)
        {
            ///GetSelectPosition();
        }


     
        private void RotEnable_switch_ValueChanged(object sender, bool value)
        {
            
        }

        private void enable_CCW_ValueChanged(object sender, bool value)
        {
           
        }


      

    
        //private void input_Radius_Click(object sender, System.EventArgs e)
        //{
        //    input_MoveSpeed.Text
        //      = InputValue("输入零件旋转半径", GlobalData.Settings.Axises[AxisesChannel.Axis_A].Config.MinRotRadius,
        //       GlobalData.Settings.Axises[AxisesChannel.Axis_A].Config.MaxRotRadius, StandardCladdingInstr.RotParam.Radius).ToString();


        //}
        private void input_MoveSpeed_Click(object sender, System.EventArgs e)
        {
          
            //  = InputValue("输入零件旋转半径", 0, 100, StandardCladdingInstr.MoveSpeed.Tvel).ToString();
            double tvel  = InputValue("输入零件旋转半径", 0, 100, StandardCladdingInstr.MoveSpeed.Tvel);
            input_MoveSpeed.Text = tvel.ToString();
            StandardCladdingInstr.MoveSpeed.Tvel = (float)tvel;
            StandardCladdingInstr.MoveSpeed.Acc = StandardCladdingInstr.MoveSpeed.Dec =(float)(Math.Sqrt( tvel * 10));
            mc.SetSpeed(AxisesChannel.Axis_X, StandardCladdingInstr.MoveSpeed);
        }

        //private void input_Radius_TextChanged(object sender, System.EventArgs e)
        //{
        //    StandardCladdingInstr.RotParam.Radius = double.Parse(input_MoveSpeed.Text.Trim());
        //    ChangeRadiusChangeAUnits();
        //}
        private void input_MoveSpeed_TextChanged(object sender, System.EventArgs e)
        {
            //StandardCladdingInstr.RotParam.Radius = double.Parse(input_MoveSpeed.Text.Trim());
            //ChangeRadiusChangeAUnits();
            //mc.SetSpeed(AxisesChannel.Axis_X, StandardCladdingInstr.MoveSpeed);
        }
        private void ChangeRadiusChangeAUnits()
        {
            if (StandardCladdingInstr.RotParam.Radius <= 0)
            {
                ShowErrorTip("半径输入错误,不可为0或小于0");
                return;
            }
            AxisType _axis = new AxisType();
            _axis = GlobalData.Axis[AxisesChannel.Axis_A];
            _axis.Config.Units = (float)(GlobalData.Settings.Axises[AxisesChannel.Axis_A].Config.Units * GlobalData.Settings.claddingParam.RefRadius / StandardCladdingInstr.RotParam.Radius);
            mc.SetAxisUnits(_axis);
        }
        ThreadStart threadStart;
        Thread thread;
        private void sbtn_F1_Click(object sender, System.EventArgs e)
        {
            mc.StopMove(enum_StopMode.AllMove);
          
            if (!bInputValues[(int)enum_InputLable.AutoIn])
            {
                ShowErrorDialog("手动模式下无法启动,请切换到自动模式再试!");
                return;
            }
            if (ShowAskDialog("确认", "确认执行加工程序?", UIStyle.Office2010Silver))
            {
                log.Info("开始加工程序");

                //mc.RunStanderInstr(StandardCladdingInstr);

                threadStart = new ThreadStart(runStand);
                 thread = new Thread(threadStart);
                thread.Start();
             
            }
           
            //mc.ConnectRot(ratio, ratio, ratio);
        }
    private void runStand()
    {
            mc.RunStanderInstr(StandardCladdingInstr);
     }

    private void sbtn_F3_Click(object sender, System.EventArgs e)
        {
             
            mc.LaserOFFIM();
            log.Info("关闭激光");
            mc.Pause(0);
            //if (!GlobalData.mc.SetOutput_modbus(0, GlobalData.bOutputValues))
            //    GlobalData.log.Error(mc.errorMessage);

            try
            {
                if (thread!=null)
                {
                    thread.Abort();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowInfo("发生错误.>>" + ex.Message);
            }
            mc.SetOut((int)enum_OutputLable.Gas, false);
            log.Info("关闭气体");
            mc.SetOut((int)enum_OutputLable.Powder, false);
            log.Info("停止送粉");
            mc.SetOut((int)enum_OutputLable.LaserPWM0, false);
            log.Info("关闭激光");
            mc.StopMove(enum_StopMode.AllMove);
            log.Info("停止运动");
            mc.CladdingEnd();
            DoAction =(int) DoActionType.Estop;
        }

        private void uiSymbolButton6_Click(object sender, EventArgs e)
        {

        }
        //TimeSpan tms = new TimeSpan();
        //// DateTime Recoednow = new DateTime();
        //DateTime TimeRecord = new DateTime();

        //TrigerON TON_StartCountTime = new TrigerON();
     
      
        private void RotEnable_switch_ValueChanged_1(object sender, bool value)
        {
            if (RotEnable_switch.Active)
            {
                if (mc.RotA((int)AxisesChannel.Axis_A, StandardCladdingInstr.RotParam))
                {
                    //RotEnable_switch.ButtonColor = System.Drawing.Color.LimeGreen;
                    ;
                }
                else
                {
                    UIMessageBox.ShowError("错误," + mc.errorMessage);
                }
            }
            else
            {
                mc.StopRot((int)AxisesChannel.Axis_A, enum_StopMode.AllMove);
                // RotEnable_switch.ButtonColor = System.Drawing.Color.White;
            }
        }

        private void input_PartRadius_Click_1(object sender, EventArgs e)
        {
            StandardCladdingInstr.RotParam.Radius
              = InputValue("输入半径", StandardCladdingInstr.RotParam.RotConfigParam.RadiusMin,
              StandardCladdingInstr.RotParam.RotConfigParam.RadiusMax, StandardCladdingInstr.RotParam.Radius);
            RefreshRotParam();
        }

        private void input_rotateSpeed_Click_1(object sender, EventArgs e)
        {
            StandardCladdingInstr.RotParam.RotSpeed
              = InputValue("输入旋转速度", 0, StandardCladdingInstr.RotParam.RotConfigParam.RotSpeedMax, StandardCladdingInstr.RotParam.RotSpeed);

            StandardCladdingInstr.RotParam.LineSpeed = GetLineSpeed(StandardCladdingInstr.RotParam.Radius, StandardCladdingInstr.RotParam.RotSpeed);
            RefreshRotParam();
        }

        private void input_LineSpeed_Click_1(object sender, EventArgs e)
        {
            StandardCladdingInstr.RotParam.LineSpeed
                = InputValue("输入线速度", 0, StandardCladdingInstr.RotParam.RotConfigParam.LineSpeedMax, StandardCladdingInstr.RotParam.LineSpeed);
            StandardCladdingInstr.RotParam.RotSpeed
                = GetRotSpeed(StandardCladdingInstr.RotParam.Radius, StandardCladdingInstr.RotParam.LineSpeed);
            RefreshRotParam();
        }

        private void enable_CCW_ValueChanged_1(object sender, bool value)
        {
            StandardCladdingInstr.RotParam.CCW = enable_CCW.Active;

        }

        private void input_PartRadius_TextChanged_1(object sender, EventArgs e)
        {
            //StandardCladdingInstr.RotParam.Radius = double.Parse(input_MoveSpeed.Text.Trim());
            //ChangeRadiusChangeAUnits();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            SpeedType sp = new SpeedType();
            sp.Acc = 1000;
            sp.Dec = 1000;
            sp.Tvel = StandardCladdingInstr.MoveSpeed.Tvel;
            if (ShowAskDialog("确认", "确认移动到安全点位置?", UIStyle.Office2010Silver))
            {
                switch (StandardCladdingInstr.PartType)
                {
                    case SpecialInstrType.Normal:
                    case SpecialInstrType.SurfaceOnAxis:
                        mc.MoveP(StandardCladdingInstr.Pos.HOME, sp);
                        break;
                    case SpecialInstrType.ShapeOnCylinder:
                        mc.MoveL_Abs(StandardCladdingInstr.Pos.HOME, sp);
                        break;
                }

                //lt_moveing.State = UILightState.Blink;

                ShowWaitForm("运动中,请等候");
            }
            else
            {
             //   lt_moveing.State = UILightState.Off;
            }

        }

        private void input_LaserPower_Click(object sender, EventArgs e)
        {
            input_LaserPower.Text = InputValue("输入功率", 0, 100, StandardCladdingInstr.LaserPararm.Power).ToString();
            StandardCladdingInstr.LaserPararm.Power = int.Parse(input_LaserPower.Text.Trim());
        }

        private void input_LineSpeed_TextChanged(object sender, EventArgs e)
        {
            ///总机时长多少.
           
        }

        private void input_rotateSpeed_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void btn_moveTo_FocusPlace_Click(object sender, EventArgs e)
        {
            float ratio =(float)( StandardCladdingInstr.CladdingBaseParam.CladdingWidth * StandardCladdingInstr.RotParam.RotSpeed / 360);
            ThreadStart threadStart = new ThreadStart(run);
            Thread thread = new Thread(threadStart);
            thread.Start();
           
            //mc.ConnectRot(ratio, ratio, ratio);
        }
        private void run()
        {
           // mc.RunStandarAxis(StandardCladdingInstr);
        }

        private void input_LineWidth_TextChanged(object sender, EventArgs e)
        {
            double width = 0;

        }

        private void btn_modifyParam_Click(object sender, EventArgs e)
        {
            if (!bCheck)
            {
                ShowErrorNotifier("请先按检查参数按钮确认参数!");
                return;
            }
            mc.SetXYZLineSpeed(StandardCladdingInstr.CladdingBaseParam.CladdingWidth, StandardCladdingInstr.RotParam.RotSpeed);
            mc.SetRotASpeed(AxisesChannel.Axis_A, StandardCladdingInstr.RotParam);
        }
        bool laserStatus;
        private void sbtn_F2_Click(object sender, EventArgs e)
        {// Doaction of cycle  0 null 1 start 2 pause 3 resume  4 stop/cancle 取消0（缺省）
         //      0      暂停当前运动。 //1
         // 在当前运动完成后正准备执行下一条运动指令时暂停//2
         // 在当前运动完成后正准备执行下一条运动指令时，并且两条指令的MARK标识不一样时暂停
         //这个模式可以用于一个动作由多个指令来实现时，可以在一整个动作完成后暂停
            if (sbtn_F2.Text.Trim() == "暂停")
            {
                laserStatus = mc.GetLaserStatus();
                mc.LaserOFFIM();
                mc.Pause(0);
                //保存激光器开启状态
                log.Info("暂停熔覆");
                sbtn_F2.Text = "恢复";
            }
            else
            {
                if (laserStatus)
                    mc.LaserONIM();
                mc.RESUME();
                sbtn_F2.Text = "暂停";
                log.Info("恢复熔覆");
            }
       
          }

        /// <summary>
        /// 复制程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copy_Click(object sender, EventArgs e)
        {
           
            string _selectedfilepath = StandardPartFilePath + (string)saveProgramList.SelectedItem;
           string newname= InputString("新程序名:", "");
            File.Copy(_selectedfilepath, StandardPartFilePath + newname);
            LoadSaveStanderInstr(StandardPartFilePath + newname);
            RefreshParamDisplay();
            RefreshRotParam();
            ParamPageJump(StandardCladdingInstr.PartType);
            SetHomePos();
        }

        private void input_deltaM_Click(object sender, EventArgs e)
        {
            StandardCladdingInstr.ProductParam.IndexNumber = (int)InputValue("输入分段数", 1, 100, (double)StandardCladdingInstr.ProductParam.IndexNumber);
           
        }

        private void input_LaserPower_TextChanged(object sender, EventArgs e)
        {
            StandardCladdingInstr.LaserPararm.Power = int.Parse(input_LaserPower.Text.Trim());
            if (StandardCladdingInstr.LaserPararm.Power > 100)
                StandardCladdingInstr.LaserPararm.Power = 100;
            if (StandardCladdingInstr.LaserPararm.Power < 0)
                StandardCladdingInstr.LaserPararm.Power = 0;
            mc.LaserPowerIM(StandardCladdingInstr.LaserPararm.Power);
        }

        private void Switch_Split_ValueChanged(object sender, bool value)
        {
          
           
        }

       


    

        private void input_shapeWidth_Click(object sender, EventArgs e)
        {
            StandardCladdingInstr.ProductParam.nCladdingLength = (double)InputValue("输入熔覆线距离", 0 - Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos, 5790 - Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos,double.Parse(input_shapeWidth.Text.Trim()));
            input_shapeWidth.Text = StandardCladdingInstr.ProductParam.nCladdingLength.ToString();
     
        }

        private void delta_Switch_ValueChanged(object sender, bool value)
        {
           // StandardCladdingInstr.RotParam.
        }

        private void btn_activeParam_Click(object sender, EventArgs e)
        {
            mc.SetRotASpeed(AxisesChannel.Axis_A, StandardCladdingInstr.RotParam);
        }
        double a_targetpos, x_targetpos;
        private void A_tarPos_Click(object sender, EventArgs e)
        {
             a_targetpos = (double)InputValue("输入旋转轴定位位置", 0 , 360 , double.Parse(A_tarPos.Text.Trim()));
            A_tarPos.Text = a_targetpos.ToString("f2");
        }
        double _totleLength = 0;
        private void btn_XMoveToPos_Click(object sender, EventArgs e)
        {
            if (GlobalData.Axis[AxisesChannel.Axis_X].Status.IDLE == -1)
            {
                _totleLength = Math.Abs(x_targetpos - Axis[(int)AxisesChannel.Axis_X].Status.CurrentPos);
                uiProcessBarline.Visible = true;
                mc.LaserON();
                mc.GasOn();
                mc.MoveSingalABS(AxisesChannel.Axis_X,(float) x_targetpos);
                log.Info("执行x轴运动命令到点位:=>"+x_targetpos.ToString());
                mc.LaserOFF();
                mc.GasOFF();
            }
            else
            {
                ShowErrorDialog("X 轴正在运动未停止,如果需要请先停止运动");
                
            }
        }

        private void btn_AMoveToPos_Click(object sender, EventArgs e)
        {
            if (GlobalData.Axis[AxisesChannel.Axis_A].Status.IDLE == -1)
            {
                ;
                mc.MoveSingalABS(AxisesChannel.Axis_A, (float)a_targetpos);
                log.Info("执行A轴运动命令到点位:=>" + a_targetpos.ToString());
            }
            else
            {
                ShowErrorDialog("A 轴正在运动未停止,如果需要请先停止运动");
                ;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //
        }

        private void x_targePos_Click(object sender, EventArgs e)
        {
             x_targetpos = (double)InputValue("输入X轴坐标", -10 , 5790 , double.Parse(x_targePos.Text.Trim()));
            x_targePos.Text = x_targetpos.ToString("f2");
        }
    }
}

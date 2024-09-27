
using Sunny.UI;
using Tools;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using System;
namespace LaserSolution
{
    public partial class Frm_Setting : UITitlePage
    {
        public Frm_Setting()
        {
            InitializeComponent();
            ///初始化各轴数据
            //InitAxies();
            //初始化轴类型
            //InitAtypeList();
            AxisNumList.SelectedIndex = 0;
            X_Select.Checked = true;

            CheckChange();
            _Selectedaxis.Config.AxisNum = GlobalData.AxisesChannel.Axis_X;
            _Selectedaxis = GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_X];
            RefreshAxisConfig(_Selectedaxis);
            RefreshSettingData();
        }
        private void InitBaseAxislist()
        {
            BaseAxisSelect.Items.Clear();
            for (int i = 0; i < GlobalData.AxisesChannel.Size(); i++)
            {
                foreach (AxisType axis in GlobalData.Settings.Axises)
                {
                    if (axis.Config.AxisNum == i)
                    {
                        BaseAxisSelect.Items.Add(axis.Config.AxisLable);
                    }
                }
            }
            BaseAxisSelect.SelectedIndex = GlobalData.Settings.BaseAxisNum;
        }
        /// <summary>
        /// 刷新参数数据
        /// </summary>
        /// <param name="settings"></param>
        public void RefreshSettingData()
        {
            SettingsType settings = GlobalData.Settings;
            input_centerY.Text = settings.claddingParam.RotCenterPlace_Y.ToString("f3");
            input_claddingThicness.Text = settings.claddingParam.CladdingBaseParam.CladdingThickness.ToString("f3");
            input_CladdingWidth.Text = settings.claddingParam.CladdingBaseParam.CladdingWidth.ToString("f3");
            input_focusOffset.Text = settings.FoucsOffset.ToString("f3");
            input_RefRadius.Text = settings.claddingParam.RefRadius.ToString("f3");
            input_Tvel.Text = settings.claddingParam.Speed.Tvel.ToString() ;

            input_Workheight.Text = settings.claddingParam.FocusHeight_Z.ToString("f3");
            input_LaserPower.Text = settings.claddingParam.LaserPararm.Power.ToString();
        
           
        }
        private void uiTextBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void uiComboboxEx1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void sbtn_S7_Click(object sender, System.EventArgs e)
        {
            
            //SaveSetting
            Tools.Json.SaveJobData(GlobalData.Settings, GlobalData.settingfile);
            UIMessageBox.ShowInfo("设置保存成功");

        }
        private void InitAxies()
        {
            //GlobalData.Axis[0].Config.AxisLable = "X";
            //GlobalData.Axis[0].Config.AxisNum = 0;
            //GlobalData.Axis[0].Config.AxisType = enum_AxisType.EtherCAT_Pos;
            //GlobalData.Axis[0].Config.Enable = true;
            //GlobalData.Axis[0].Config.FS_Limit = 20000;
            //GlobalData.Axis[0].Config.RS_limit = -20000;
            //GlobalData.Axis[0].Config.Units = 2 ^ 23;
            ////GlobalData.Axis[0].Config.

            //GlobalData.Axis[1].Config.AxisLable = "Y";
            //GlobalData.Axis[1].Config.AxisNum = 1;
            //GlobalData.Axis[1].Config.AxisType = enum_AxisType.EtherCAT_Pos;
            //GlobalData.Axis[1].Config.Enable = true;
            //GlobalData.Axis[1].Config.FS_Limit = 20000;
            //GlobalData.Axis[1].Config.RS_limit = -20000;
            //GlobalData.Axis[1].Config.Units = 2 ^ 23;

            //GlobalData.Axis[2].Config.AxisLable = "Z";
            //GlobalData.Axis[2].Config.AxisNum = 2;
            //GlobalData.Axis[2].Config.AxisType = enum_AxisType.EtherCAT_Pos;
            //GlobalData.Axis[2].Config.Enable = true;
            //GlobalData.Axis[2].Config.FS_Limit = 20000;
            //GlobalData.Axis[2].Config.RS_limit = -20000;
            //GlobalData.Axis[2].Config.Units = 2 ^ 23;

            //GlobalData.Axis[3].Config.AxisLable = "A";
            //GlobalData.Axis[3].Config.AxisNum = 3;
            //GlobalData.Axis[3].Config.AxisType = enum_AxisType.VirtualAxis;
            //GlobalData.Axis[3].Config.Enable = false;
            //GlobalData.Axis[3].Config.FS_Limit = 20000;
            //GlobalData.Axis[3].Config.RS_limit = -20000;
            //GlobalData.Axis[3].Config.Units = 2 ^ 23;

            //GlobalData.Axis[4].Config.AxisLable = "C";
            //GlobalData.Axis[4].Config.AxisNum = 4;
            //GlobalData.Axis[4].Config.AxisType = enum_AxisType.VirtualAxis;
            //GlobalData.Axis[4].Config.Enable = true;
            //GlobalData.Axis[4].Config.FS_Limit = 20000;
            //GlobalData.Axis[4].Config.RS_limit = -20000;
            //GlobalData.Axis[4].Config.Units = 2 ^ 23;

            //GlobalData.Axis[5].Config.AxisLable = "E";
            //GlobalData.Axis[5].Config.AxisNum = 5;
            //GlobalData.Axis[5].Config.AxisType = enum_AxisType.EtherCAT_Pos;
            //GlobalData.Axis[5].Config.Enable = false;
            //GlobalData.Axis[5].Config.FS_Limit = 20000;
            //GlobalData.Axis[5].Config.RS_limit = -20000;
            //GlobalData.Axis[5].Config.Units = 2 ^ 23;

        }
        private void SetAxisConfig(AxisType[] x_Aixs)
        {
            for (int i = 0; i<x_Aixs.Length; i++)
            {
                //设置单位
                ;
            }
        }
        private void btn_SavePhase_Click(object sender, System.EventArgs e)
        {
            Tools.Json.SaveJobData(GlobalData.ZeroPhase, GlobalData.ZeroPhaseFile);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lb_x_pos.Text = GlobalData.CurrentPos.x.ToString();
            lb_y_pos.Text = GlobalData.CurrentPos.y.ToString();
            lb_z_pos.Text = GlobalData.CurrentPos.z.ToString();
            lb_a_pos.Text = GlobalData.CurrentPos.a.ToString();
            lb_c_pos.Text = GlobalData.CurrentPos.c.ToString();

            lb_xPhase.Text = GlobalData.ZeroPhase.x.ToString("f6");
            lb_Yphase.Text = GlobalData.ZeroPhase.y.ToString("f6");
            lb_zPhase.Text = GlobalData.ZeroPhase.z.ToString("f6");
            lb_aPhase.Text = GlobalData.ZeroPhase.a.ToString("f6");
            lb_cPhase.Text = GlobalData.ZeroPhase.c.ToString("f6");
        }

        private void btn_RecordPhase_Click(object sender, System.EventArgs e)
        {
            GlobalData.ZeroPhase.x = GlobalData.Axis[GlobalData.AxisesChannel.Axis_X].Status.Mpos;
            GlobalData.ZeroPhase.y = GlobalData.Axis[GlobalData.AxisesChannel.Axis_Y].Status.Mpos;
            GlobalData.ZeroPhase.z = GlobalData.Axis[GlobalData.AxisesChannel.Axis_Z].Status.Mpos;
            GlobalData.ZeroPhase.a = GlobalData.Axis[GlobalData.AxisesChannel.Axis_A].Status.Mpos;
            GlobalData.ZeroPhase.c = GlobalData.Axis[GlobalData.AxisesChannel.Axis_C].Status.Mpos;
            GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_X].Config.ZeroPhase= GlobalData.Axis[GlobalData.AxisesChannel.Axis_X].Status.Mpos;
            GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_Y].Config.ZeroPhase = GlobalData.Axis[GlobalData.AxisesChannel.Axis_Y].Status.Mpos;
            GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_Z].Config.ZeroPhase = GlobalData.Axis[GlobalData.AxisesChannel.Axis_Z].Status.Mpos;
            GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_A].Config.ZeroPhase = GlobalData.Axis[GlobalData.AxisesChannel.Axis_A].Status.Mpos;
            GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_C].Config.ZeroPhase = GlobalData.Axis[GlobalData.AxisesChannel.Axis_C].Status.Mpos;
            lb_xPhase.Text = GlobalData.ZeroPhase.x.ToString("f6");
            lb_Yphase.Text = GlobalData.ZeroPhase.y.ToString("f6");
            lb_zPhase.Text = GlobalData.ZeroPhase.z.ToString("f6");
            lb_aPhase.Text = GlobalData.ZeroPhase.a.ToString("f6");
            lb_cPhase.Text = GlobalData.ZeroPhase.c.ToString("f6");
            GlobalData.mc.SetZeroConfig(GlobalData.ZeroPhase, GlobalData.Axis);
            // GlobalData.ZeroPhase.
        }

        private void btn_Loadphase_Click(object sender, System.EventArgs e)
        {
            GlobalData.ZeroPhase= JsonConvert.DeserializeObject<AxisZeroPhase>(File.ReadAllText(GlobalData.ZeroPhaseFile));
        }

        private void record_centPosY_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.RotCenterPlace_Y = GlobalData.GetPos().y;
            RefreshSettingData();
        }

        private void uiSymbolButton3_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.Home = GlobalData.GetPos();
        }

        //private void input_focus_Click(object sender, System.EventArgs e)
        //{
        //   
        //}

        private void input_centerY_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.RotCenterPlace_Y=(float)GlobalData.InputValue("熔覆Y轴位置", -100, 600, GlobalData.Settings.claddingParam.RotCenterPlace_Y);
            RefreshSettingData();
        }

        private void input_focusOffset_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.FoucsOffset = (float)GlobalData.InputValue("工作位置偏移", 0, 600, GlobalData.Settings.FoucsOffset);
            RefreshSettingData();
        }

        private void input_Workheight_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.FocusHeight_Z = (float)GlobalData.InputValue("工作位置高度", 0, 600, GlobalData.Settings.claddingParam.FocusHeight_Z);
            RefreshSettingData();
        }

        private void input_RefRadius_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.RefRadius= (float)GlobalData.InputValue("高度设定参考零件半径", 0, 600, GlobalData.Settings.claddingParam.RefRadius);
            RefreshSettingData();
        }

        private void input_CladdingWidth_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.CladdingBaseParam.CladdingWidth 
                = (float)GlobalData.InputValue("熔覆宽度值", 0, 100, GlobalData.Settings.claddingParam.CladdingBaseParam.CladdingWidth);
            RefreshSettingData();
        }

        private void input_claddingThicness_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.CladdingBaseParam.CladdingThickness
               = (float)GlobalData.InputValue("熔覆厚度值", 0, 10, GlobalData.Settings.claddingParam.CladdingBaseParam.CladdingThickness);
            RefreshSettingData();
        }

        private void input_Tvel_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.Speed.Tvel
               = (float)GlobalData.InputValue("熔覆线速度", 0, 300, GlobalData.Settings.claddingParam.Speed.Tvel);
            RefreshSettingData();
        }

        private void input_LaserPower_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.LaserPararm.Power
            = (int)GlobalData.InputValue("激光功率", 0, GlobalData.Settings.Laser.MaxPower, GlobalData.Settings.claddingParam.LaserPararm.Power);
            RefreshSettingData();
        }

        private void record_centerPosZ_Click(object sender, System.EventArgs e)
        {
            GlobalData.Settings.claddingParam.FocusHeight_Z = GlobalData.GetPos().z- GlobalData.Settings.claddingParam.RefRadius;
            RefreshSettingData();
        }
        private void RefreshAxisConfig(AxisType axis)
        {
            lb_CurrentSelectedAxis.Text = axis.Config.AxisLable;
            input_encodeBits.Text = axis.Config.EncodeBits.ToString();
            input_GearLeap.Text = axis.Config.Lead.ToString();
            input_GearRatio.Text = axis.Config.GearRatio.ToString();
            Input_Atype.Text = ((int)axis.Config.AxisType).ToString();
            AxisNumList.SelectedIndex = axis.Config.AxisNum;
            input_AxisStatus.Text = axis.Status.StatusCode.ToString();
            input_Units.Text = axis.Config.Units.ToString();
            input_RPM.Text = axis.Config.RPM.ToString();
            MoveType_switch.Active = axis.Config.LinearAxis;
            input_FwdLimit.Text = axis.Config.FS_Limit.ToString();
            input_RevLimit.Text = axis.Config.RS_limit.ToString();
            
            if (!axis.Config.LinearAxis)
            {
                input_MaxRotRadius.Text = axis.Config.MaxRotRadius.ToString();
                input_MinRotRadius.Text = axis.Config.MinRotRadius.ToString();
            }
            else
            {
                input_MaxRotRadius.Text = "NULL";
                input_MinRotRadius.Text = "NULL";
            }

        }

        //private void InitAtypeList()
        //{
        //    AtypeList.Items.Clear();

        //    foreach (int myCode in Enum.GetValues(typeof(enum_AxisType)))
        //    {
        //        string strName = Enum.GetName(typeof(enum_AxisType), myCode);//获取名称
        //        AtypeList.Items.Add(strName);
        //        string strVaule = myCode.ToString();//获取值
        //    }
        //    if (AtypeList.Items.Count>0)
        //    { AtypeList.SelectedIndex = 0; }
           
        //}
        //public void  GetAxisTypeValue(enum_AxisType x_atype)
        //{

        //        if (x_atype == null)
        //        {
        //            throw new ArgumentException("value");
        //        }
        //        foreach (string v in Enum.GetValues(typeof(enum_AxisType)))
        //        {
        //            Enum.GetName(typeof(enum_AxisType), v) == Enum.GetName(typeof(enum_AxisType),x_atype.get)
        //        }
        //    }
        //}
        AxisType _Selectedaxis = new AxisType();
        private void CheckChange()
        {
          
            if (X_Select.Checked)
            {
                _Selectedaxis = GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_X];
                _Selectedaxis.Config.AxisNum = GlobalData.AxisesChannel.Axis_X;
            }
            if (Y_select.Checked)
            {
                _Selectedaxis = GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_Y];
                _Selectedaxis.Config.AxisNum = GlobalData.AxisesChannel.Axis_Y; 
            }
            if (Z_Select.Checked)
            {
                _Selectedaxis = GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_Z];
                _Selectedaxis.Config.AxisNum = GlobalData.AxisesChannel.Axis_Z;
            }
            if (A_Select.Checked)
            {
                _Selectedaxis = GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_A];
                _Selectedaxis.Config.AxisNum = GlobalData.AxisesChannel.Axis_A;
            }
            if (C_Select.Checked)
            {
                _Selectedaxis = GlobalData.Settings.Axises[GlobalData.AxisesChannel.Axis_C];
                _Selectedaxis.Config.AxisNum = GlobalData.AxisesChannel.Axis_C;
            }
            _Selectedaxis = GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum];
            RefreshAxisConfig(_Selectedaxis);
            //SetValueToAxis();
        }

        private void X_Select_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void Y_select_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void Z_Select_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void A_Select_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void C_Select_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void input_encodeBits_TextChanged(object sender, EventArgs e)
        {
            //SetValueToAxis();


        }
        private void SetValueToAxis()
        {

            //lb_CurrentSelectedAxis.Text = axis.Config.AxisLable;
            //input_encodeBits.Text = axis.Config.EncodeBits.ToString();
            //input_GearLeap.Text = axis.Config.Lead.ToString();
            //input_GearRatio.Text = axis.Config.GearRatio.ToString();
            //AtypeList.SelectedText = EnumHelper.GetDescription(axis.Config.AxisType);
            //AxisNumList.SelectedIndex = axis.Config.AxisNum;
            //input_Units.Text = axis.Config.Units.ToString();
            //GlobalData.Axis[_Selectedaxis.Config.AxisNum].Config.AxisLable = lb_CurrentSelectedAxis.Text;
            //GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum].Config.EncodeBits = int.Parse(input_encodeBits.Text);
            //GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum].Config.Lead = float.Parse(input_GearLeap.Text);
            //GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum].Config.GearRatio = float.Parse(input_GearRatio.Text);
            //GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum].Config.AxisType =( enum_AxisType) int.Parse(Input_Atype.Text.Trim());
            //GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum].Config.LinearAxis = MoveType_switch.Active;
            //GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum].Config.MaxRotRadius = float.Parse(input_MaxRotRadius.Text);
            //GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum].Config.MinRotRadius = float.Parse(input_MinRotRadius.Text);
            //_Selectedaxis.Config.AxisLable = lb_CurrentSelectedAxis.Text;


           // GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum] = _Selectedaxis;
        }

        private void input_GearRatio_TextChanged(object sender, EventArgs e)
        {
           // SetValueToAxis();
        }

        private void input_GearLeap_TextChanged(object sender, EventArgs e)
        {
            //SetValueToAxis();
        }

        private void AtypeList_SelectedValueChanged(object sender, EventArgs e)
        {
           // SetValueToAxis();
        }

        private void AxisNumList_SelectedValueChanged(object sender, EventArgs e)
        {
            //SetValueToAxis();
        }

        private void Input_Atype_TextChanged(object sender, EventArgs e)
        {
           // SetValueToAxis();
        }

        private void input_FwdLimit_Click(object sender, EventArgs e)
        {
            _Selectedaxis.Config.FS_Limit   = (float)GlobalData.InputValue(_Selectedaxis.Config.AxisLable+"轴正限位", -20000, 20000, _Selectedaxis.Config.FS_Limit);
            GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum] = _Selectedaxis;
            RefreshSettingData();
        }

        private void input_RevLimit_Click(object sender, EventArgs e)
        {
            _Selectedaxis.Config.FS_Limit = (float)GlobalData.InputValue(_Selectedaxis.Config.AxisLable + "轴负限位", -20000, 20000, _Selectedaxis.Config.FS_Limit);
            GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum] = _Selectedaxis;
            RefreshSettingData();
        }

        private void input_MinRotRadius_Click(object sender, EventArgs e)
        {
            if (!_Selectedaxis.Config.LinearAxis)
            {
                _Selectedaxis.Config.MinRotRadius=(float)(float)GlobalData.InputValue(_Selectedaxis.Config.AxisLable + "轴最小旋转半径", 0, 1, _Selectedaxis.Config.MinRotRadius);
                GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum] = _Selectedaxis;
                input_MinRotRadius.Text = _Selectedaxis.Config.MinRotRadius.ToString();

                RefreshSettingData();
            }
        }

        private void input_MaxRotRadius_Click(object sender, EventArgs e)
        {
            if (!_Selectedaxis.Config.LinearAxis)
            {
                _Selectedaxis.Config.MaxRotRadius = (float)(float)GlobalData.InputValue(_Selectedaxis.Config.AxisLable + "轴最大旋转半径",0.01, 10000, _Selectedaxis.Config.MaxRotRadius);
                GlobalData.Settings.Axises[_Selectedaxis.Config.AxisNum] = _Selectedaxis;
                input_MaxRotRadius.Text = _Selectedaxis.Config.MaxRotRadius.ToString();
                RefreshSettingData();
            }
        }

        private void uiTitlePanel2_Click(object sender, EventArgs e)
        {

        }
    }
}

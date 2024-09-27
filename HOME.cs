using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using Sunny.UI;

namespace LaserSolution
{
    public partial class HOME : UIHeaderAsideMainFooterFrame
    {
        public HOME()
        {
            InitializeComponent();
            ///get buttonlist 
  
            AddPage(new Frm_Operate(), GlobalData.nPage_Operate);
            AddPage(new Frm_Program(), GlobalData.nPage_Program);
            AddPage(new Frm_Processing(), GlobalData.nPage_Processing);
            AddPage(new Frm_Diagnosis(), GlobalData.nPage_Diagnosis);

            AddPage(new Frm_Production(), GlobalData.nPage_Production);
            AddPage(new Frm_Setting(), GlobalData.nPage_Settings);
            //设置关联
            Aside.TabControl = MainTabControl;
            Aside.CreateNode("1", GlobalData.nPage_Operate);
            Aside.CreateNode("2", GlobalData.nPage_Production);
            Aside.CreateNode("3", GlobalData.nPage_Program);
            Aside.CreateNode("4", GlobalData.nPage_Processing);
            Aside.CreateNode("5", GlobalData.nPage_Diagnosis);
            Aside.CreateNode("6", GlobalData.nPage_Settings);
            Aside.CreateNode("7", GlobalData.nPage_Help);
            Aside.SelectFirst();
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Operate_Click(object sender, EventArgs e)
        {
            RefreshChoseStatus(GlobalData.nPage_Operate);
        }

        List<UISymbolButton> ControlButtons = new List<UISymbolButton>();
        private void NewControlButtons()
        {
            ControlButtons.Add( btn_Operate);
            ControlButtons.Add( btn_Production);
            ControlButtons.Add(btn_Program);
            ControlButtons.Add(btn_Processing);
            ControlButtons.Add(btn_Diagnosis);
            ControlButtons.Add(btn_Setting);
            ControlButtons.Add(btn_Help);
        }
        /// <summary>
        /// define seleted and released button color
        /// </summary>
        Color l_Seleted = Color.FromArgb(249, 226, 137);
        Color l_Released = Color.FromArgb(247, 248, 249);
        private void RefreshChoseStatus( int SelectPageIndex)
        {
            //deal with chosen status of the button . change the  color of the button background
            Color l_Seleted = Color.FromArgb(249,226,137);
            Color l_Released = Color.FromArgb(247, 248, 249);
            //jump to page 
            Aside.SelectPage(SelectPageIndex);
            //x_SButton.FillColor = l_Seleted;
            switch (SelectPageIndex)
            {
                case GlobalData.nPage_Operate:
                    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;           
                    btn_Operate.FillColor = l_Seleted;break;
                case GlobalData.nPage_Diagnosis:
                    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
                    btn_Diagnosis.FillColor = l_Seleted; break;
                //case GlobalData.nPage_Login:
                //    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
                //    btn.FillColor = l_Seleted; break;
                case GlobalData.nPage_Processing:
                    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
                    btn_Processing.FillColor = l_Seleted; break;
                case GlobalData.nPage_Production:
                    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
                    btn_Production.FillColor = l_Seleted; break;
                case GlobalData.nPage_Program:
                    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
                    btn_Program.FillColor = l_Seleted; break;
                case GlobalData.nPage_Settings:
                    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
                    btn_Setting.FillColor = l_Seleted; break;
                case GlobalData.nPage_Help:
                    btn_Operate.FillColor = btn_Diagnosis.FillColor = btn_Help.FillColor = btn_Processing.FillColor = btn_Production.FillColor = btn_Program.FillColor = btn_Setting.FillColor = l_Released;
                    btn_Help.FillColor = l_Seleted; break;
            }
            //foreach (UISymbolButton uiButton in ControlButtons)
            //{
            //    if (uiButton.Name == x_SButton.Name)
            //    {
            //        uiButton.FillColor = l_Seleted;
            //        uiButton.FillSelectedColor = l_Seleted;
            //        uiButton.Selected = true;
            //    }
            //    else
            //    {
            //        uiButton.FillColor = l_Released;
            //        uiButton.FillSelectedColor = l_Released;
            //        uiButton.Selected = false;
            //    }
            //}


        }
        private void btn_Production_Click(object sender, EventArgs e)
        {
            RefreshChoseStatus( GlobalData.nPage_Production);
        }

        private void HOME_Load(object sender, EventArgs e)
        {
           //
        }

        private void imglogo_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Program_Click(object sender, EventArgs e)
        {
            RefreshChoseStatus(GlobalData.nPage_Program);
        }

        private void btn_Processing_Click(object sender, EventArgs e)
        {
            RefreshChoseStatus(GlobalData.nPage_Processing);
        }

        private void btn_Diagnosis_Click(object sender, EventArgs e)
        {
            RefreshChoseStatus(GlobalData.nPage_Diagnosis);
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            RefreshChoseStatus(GlobalData.nPage_Settings);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            RefreshChoseStatus(GlobalData.nPage_Help);
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void ico_Estop_Click(object sender, EventArgs e)
        {

        }

        private void ico_RUNNING_Click(object sender, EventArgs e)
        {

        }

        private void ico_Pause_Click(object sender, EventArgs e)
        {

        }

        private void ico_STOP_Click(object sender, EventArgs e)
        {

        }

        private void ico_Manual_Click(object sender, EventArgs e)
        {

        }

        private void ico_AUTO_Click(object sender, EventArgs e)
        {

        }

        private void ico_LaserON_Click(object sender, EventArgs e)
        {

        }

        private void ico_GuideON_Click(object sender, EventArgs e)
        {

        }

        private void ico_LaserError_Click(object sender, EventArgs e)
        {

        }

        private void ico_PowderError_Click(object sender, EventArgs e)
        {

        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {

        }

        private void ico_PowderRunning_Click(object sender, EventArgs e)
        {

        }

        private void ico_Fault_Click(object sender, EventArgs e)
        {

        }

        private void ico_comunicatOK_Click(object sender, EventArgs e)
        {

        }
    }


    }

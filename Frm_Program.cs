
using Sunny.UI;
using System.Collections.Generic;
using Tools;
using System;
using System.Data;
using System.Windows.Forms;
using static LaserSolution.GlobalData;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace LaserSolution
{
    public partial class Frm_Program : UITitlePage
    {

        private int SelectColumn = -1;
        private int SelectRow = -1;
        public Frm_Program()
        {
            InitializeComponent();
           
            //init function key 
            initkeyFunction();// init function key display
            RefreshFunctionkey();

            //默认在joblist页面
            this.Text = "";
            JumpToTap(Enum_TapNameType.Joblist);
            RefreshJobList();


            // InitDataGrideView();
            //if()
            //Point pthead = new Point();
            //pointList.Add(pthead);
            InitJobDataList();
        }
        /// <summary>
        /// add end symble to the end of instruction list .
        /// make sure there have no instruct first .
        /// </summary>
        private void AddEndinstrution()
        {
            if (!CurrentJobDataList.instructDataViewList.IsValid())
            {
                CurrentJobDataList.instructDataViewList = new BindingList<InstrDataViewType>();
            }
            if (CurrentJobDataList.instructDataViewList.Count == 0)
            {
                CurrentJobDataList.instructDataViewList.Add(GetInitEndInstructData());
            }
        }
        private InstrDataViewType GetInitEndInstructData()
        {
            InstrDataViewType data = new InstrDataViewType();
            data.Index = EnumHelper.GetDescription(enum_Instruct.END);
            data.Status = "";
            data.Instruct = "";
            data.Speed = "";
            data.Blend = "";
            return data;
        }

        //List<InstrDataType> InstrctionList = new List<InstrDataType>();
        private void InitJobDataList()
        {
            if (!CurrentJobDataList.pointList.IsValid())
                CurrentJobDataList.pointList = new List<Point>();
            if (!CurrentJobDataList.instructDataList.IsValid())
                CurrentJobDataList.instructDataList = new List<InstructDataType>();
            if (CurrentJobDataList.instructDataViewList.IsNullOrEmpty())
                CurrentJobDataList.instructDataViewList = new BindingList<InstrDataViewType>();


            CurrentJobDataList.instructDataViewList.AllowNew = true;
            // Raise ListChanged events when new parts are added.
            CurrentJobDataList.instructDataViewList.RaiseListChangedEvents = true;

            // allow parts to be edited.
            CurrentJobDataList.instructDataViewList.AllowEdit = false;

            ///init add end symble to the List
            AddEndinstrution();

            //dataGridView1.Rows.
            dataGridView1.DataSource = CurrentJobDataList.instructDataViewList;

            //set cell size
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 50;

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 180;

        }




        private void uiTextBox1_Click(object sender, System.EventArgs e)
        {
            UITextBox tb = (UITextBox)sender;

            Frm_NumPad np = new Frm_NumPad();
            np.MaxValue = 10000;
            np.MinValue = -1000;
            np.ShowDialog();

        }

        private void tp_Edit_Click(object sender, System.EventArgs e)
        {

        }

        private void bt_instr_Cladding_Click(object sender, System.EventArgs e)
        {
            //
           
            ParamType param = new ParamType();
            param.Blend.Enable = false;
           // param.Speed.Tvel = 100;
          //  param.Pi1 = CurrentJobDataList.pointList.Count + 1;//point list start from 1,  cause 0 may comfuse .
            param.Enable = false;
            InsertNewInstruct(enum_Instruct.Laser, param);
        }

        private void bt_instr_point_Click(object sender, System.EventArgs e)
        {
            if (CurrentSelectProgram == "")
            {
                UIMessageBox.ShowWarning("请先新建程序");
                //step 1  refresh joblist data and  select tap to joblist tp           
                uiTabControl_Edit.SelectTab("tp_JobList");
                //step2
                RefreshJobList();
                return;
            }
            ParamType param = new ParamType();
            param.Blend.Enable = false;
            param.Speed.Tvel = 100;
            param.Pi1 = CurrentJobDataList.pointList.Count + 1;//point list start from 1,  cause 0 may comfuse .

            InsertNewInstruct(enum_Instruct.Point, param);
            ////dataGridView1.Rows.
            //dataGridView1.DataSource = CurrentJobDataList.instructDataViewList;


            ////step1  new a  claddinginstruct
            //InstructDataType instruct = new InstructDataType();

            ////step2 get now position,and then add the point infomation to pointlist
            //Position p = new Position();
            //p = GetPos();
            //Point currentpoint = new Point();
            //currentpoint.index = CurrentJobDataList.pointList.Count+1;//point list start from 1,  cause 0 may comfuse .
            //currentpoint.position = p;
            //CurrentJobDataList.pointList.Add(currentpoint);

            ////step3 set instruct type ,e.g. point arc line ...
            //instruct.type = TrajInstructType.Point;

            ////step 4 set instruct index
            //instruct.index = CurrentJobDataList.instructDataList.Count+1 ;

            ////step 5 create param, laserpower 
            //Param param = new Param();

            //param.Pi1 = currentpoint.index;
            //param.Speed = 100;
            //instruct.param = param;

            //InstrDataViewType data = new InstrDataViewType();

            //data.Index = instruct.index.ToString("D4");
            //data.Status = " ";
            //data.Instruct = "点";
            //data.PointIndex = "P[" + currentpoint.index.ToString() + "] " ;
            //data.Speed = "速度=" + param.Speed.ToString();
            //data.Blend = GetBlendString(param.Blend);
            ////data for gridview
            //// InstrctionList.Add(data);
            ////   ListofInstruction.Add(data);
            //ListofInstructionForView.Insert(ListofInstructionForView.Count - 1, data);
            //GlobalData.CurrentJobDataList.Add(instruct);
            ////uiDataGridView1.DataSource = InstrctionList;
        }
        private string GetBlendString(Blend x_blend)
        {
            if (x_blend.CNT==0)              
            {
                return "FINE";
            }
            else
            {
                return "CNT " + x_blend.CNT.ToString();
            }


        }
        /// <summary>
        /// F1 F7功能键页面 0 为默认
        /// 1位第二页
        /// </summary>
        int functionKeyPageindex = 0;
        string[] keyFunctions = new string[14];
        private void initkeyFunction()
        {
            keyFunctions[0] = "运行"; keyFunctions[7] = "";       //F1
            keyFunctions[1] = "暂停"; keyFunctions[8] = "";     //F2
            keyFunctions[2] = "停止"; keyFunctions[9] = "";       //F3
            keyFunctions[3] = "修改位置"; keyFunctions[10] = "";        //F4
            keyFunctions[4] = "移动到此"; keyFunctions[11] = "程序";                                             //F5
            keyFunctions[5] = "指令"; keyFunctions[12] = "新建";                                              //F6
            keyFunctions[6] = "编辑"; keyFunctions[13] = "保存";                                                 //F7

        }
        /// <summary>
        /// 标准程序模板,逐步操作实现
        /// </summary>
        private void GenerateStanderProgramCode()
        {
            Frm_SpecailProgramEdit newProg = new Frm_SpecailProgramEdit();
            newProg.ShowDialog();
            if (newProg.IsOK)
            {
                GlobalData.CurrentProgram = newProg.Program;
                ///圆筒,相贯线耐磨带
                if (CurrentProgram.InstrType == SpecialInstrType.ShapeOnCylinder)
                {
                    Frm_ShapeOnCylinderEdit shap = new Frm_ShapeOnCylinderEdit();
                    shap.Program = CurrentProgram;
                    shap.Show();
                }
                //标准轴类表面熔覆
                if (CurrentProgram.InstrType == SpecialInstrType.SurfaceOnAxis)
                {

                }
            }
            newProg.Dispose();
        }
        private void sbtn_F6_Click(object sender, System.EventArgs e)
        {
            //生成标准加工程序
            if (functionKeyPageindex == 1)
            {
                //生成标准程序
                GenerateStanderProgramCode();

            }
            if (functionKeyPageindex == 0)
            {
                //jump to tab instruction
                // tp_Instructs
                uiTabControl_Edit.SelectTab("tp_Instructs");

            }

            //datas.Insert()
        }
        private void SetFunctionKey(string[] x_sfunction)
        {

        }
        private int GetlastInstrIndex()
        {
            int i = -1;

            for (i = CurrentJobDataList.instructDataList.Count - 1; i > 0; i--)
            {


            }
            return i;
        }

        private void DisplayInstructionList()
        {
            //GlobalData.CladdingInstructlist.Sort()
            //  dg_instructionList.
        }


        private void dg_instructionList_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {
            GlobalData.ProgramPageSeletCellColumn = dataGridView1.CurrentCell.ColumnIndex;
            GlobalData.ProgramPageSeletCellRow = dataGridView1.CurrentRow.Index;
            lb_row.Text = "行:" + dataGridView1.CurrentRow.Index.ToString();
            lb_colum.Text = "列" + dataGridView1.CurrentCell.ColumnIndex.ToString();
            richTextBox1.Text = "SelectRow =" + dataGridView1.CurrentRow.Index.ToString() + "//" + "当前Celle rowindex=" + dataGridView1.CurrentCell.RowIndex.ToString() +
                "当前columnindex=" + dataGridView1.CurrentCell.ColumnIndex.ToString();
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                this.dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            if (CurrentJobDataList.instructDataList.Count == 0 || ProgramPageSeletCellRow > CurrentJobDataList.instructDataList.Count - 1)
            {
                return;
            }
            ///第4列为速度值
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
             

                InstructDataType ins = new InstructDataType();
                ins = CurrentJobDataList.instructDataList[ProgramPageSeletCellRow];
            
                switch (ins.type)
                {
                    case enum_Instruct.Gas:
                    case enum_Instruct.Laser:
                        ins.param.Enable=!CurrentJobDataList.instructDataList[ProgramPageSeletCellRow].param.Enable;
                        CurrentJobDataList.instructDataList.Update(ProgramPageSeletCellRow, ins);
                        break;
                    case enum_Instruct.Point:
                    case enum_Instruct.Line:
                        double value = CurrentJobDataList.instructDataList[ProgramPageSeletCellRow].param.Speed.Tvel;
                    break;
                    case enum_Instruct.Delay:
                        ins.param.DelayTime = InputValue("等待时间", 0, 100000, ins.param.DelayTime);
                        break;
                }
                //if (UIInputDialog.InputDoubleDialog(ref value, 2, true, "请输入速度值:", UIStyle.Gray))
                //{ 
                //    ins.param.Speed.Tvel = (float)value;
                //    richTextBox1.Text +="  >tvel s"+ ins.param.Speed.Tvel.ToString();
                //    CurrentJobDataList.instructDataList.Update(ProgramPageSeletCellRow, ins);
                //    RefreshDataGrid();
                //}
                switch (CurrentJobDataList.instructDataList[ProgramPageSeletCellRow].type)
                {
                    case enum_Instruct.Rotate:
                        ins.param.Speed.Tvel = (float)InputValue("旋转轴速度", 0, StandardCladdingInstr.RotParam.RotConfigParam.LineSpeedMax, ins.param.Speed.Tvel);
                        CurrentJobDataList.instructDataList.Update(ProgramPageSeletCellRow, ins);
                        RefreshDataGrid();
                        break;
                    default:
                        ins.param.Speed.Tvel = (float)InputValue("直线轴速度", 0, LineSpeedMax, ins.param.Speed.Tvel);
                        CurrentJobDataList.instructDataList.Update(ProgramPageSeletCellRow, ins);
                        RefreshDataGrid();
                        break;
                }

            }
            //参数栏
            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                InstructDataType ins = new InstructDataType();
                ins = CurrentJobDataList.instructDataList[ProgramPageSeletCellRow];
                
                switch (CurrentJobDataList.instructDataList[ProgramPageSeletCellRow].type)
                {
                    case enum_Instruct.Rotate:
                        double value = CurrentJobDataList.instructDataList[ProgramPageSeletCellRow].param.RotParam.Radius;
                        PartRadius = ins.param.RotParam.Radius = (float)InputValue("旋转轴半径", 0, StandardCladdingInstr.RotParam.RotConfigParam.RadiusMax, ins.param.RotParam.Radius);
                        
                        CurrentJobDataList.instructDataList.Update(ProgramPageSeletCellRow, ins);
                        RefreshDataGrid();
                        break;
                    default:
                        ins.param.Blend.CNT = (float)InputValue("圆角比例", 0, 100, ins.param.Blend.CNT);
                        CurrentJobDataList.instructDataList.Update(ProgramPageSeletCellRow, ins);
                        RefreshDataGrid();
                        break;
                }
            }
            //点位信息
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {

                //if (CurrentJobDataList.instructDataViewList[i].PointIndex != "")
                //{
                //    string indexstring = CurrentJobDataList.instructDataViewList[i].PointIndex.Trim();

                //    ///e.g.  indexstring : P[10]
                //    if (int.TryParse(indexstring.Substring(2, indexstring.Length - 3), out int indexnow))
                //    {
                //        if (ComparePosSame(GlobalData.CurrentJobDataList.pointList[indexnow - 1].position, CurrentPos))
                //        {
                //            // InstrDataViewType instrDataView= 
                //            CurrentJobDataList.instructDataViewList[i].Status = "@";
                //        }
                //        else
                //            CurrentJobDataList.instructDataViewList[i].Status = "";


                //    }

                //}
            }
            //  if(instr)
        }
        private ParamType SetInstParam(ParamType x_param)
        {
            ParamType param = new ParamType();

            param.Pi1 = CurrentJobDataList.pointList[CurrentJobDataList.pointList.Count - 1].index;
            param.Speed.Tvel = 10;
            param.Blend.Enable = true;
            param.Blend.CNT = param.Blend.CNT = 50;
            return param;
        }
        private void RefreshStatusOfPoint()
        {
            try
            {
                //if(ListofInstructionForView.IsValid()&& ListofInstructionForView.Count>1)
                if (CurrentJobDataList.pointList.IsValid() && CurrentJobDataList.instructDataViewList.Count > 1)
                {


                    for (int i = 0; i < CurrentJobDataList.instructDataViewList.Count - 1; i++)
                    {
                        //check pos              


                        //int pindex=int.pare
               
                        if (CurrentJobDataList.instructDataViewList[i].PointIndex != "")
                        {
                            string indexstring = CurrentJobDataList.instructDataViewList[i].PointIndex.Trim();

                            ///e.g.  indexstring : P[10]
                            if (int.TryParse(indexstring.Substring(2, indexstring.Length - 3), out int indexnow))
                            {
                                if (ComparePosSame(GlobalData.CurrentJobDataList.pointList[indexnow - 1].position, CurrentPos))
                                {
                                    // InstrDataViewType instrDataView= 
                                    CurrentJobDataList.instructDataViewList[i].Status = "@";
                                }
                                else
                                    CurrentJobDataList.instructDataViewList[i].Status = "";

                                
                            }
                          
                        }


                    }
                }
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataSource = CurrentJobDataList.instructDataViewList;
               // dataGridView1.Update();

            }
            catch (Exception ex)
            {
                log.Warn("刷新点位状态错误,错误信息:[" + ex.Message + "]");
                throw ex;
            }
        }

        private int GetInsertNewInstructIndex()
        {
            int l_ret = -1;
            int inserpos = GetInstrViewListInsertPos();
            if (inserpos == CurrentJobDataList.instructDataViewList.Count - 1)
            {
                l_ret = CurrentJobDataList.instructDataList.Count;
            }
            else
            {
                if (int.TryParse(CurrentJobDataList.instructDataViewList[inserpos].Index.Trim(), out int index))
                {
                    l_ret = index;
                }
            }

            return l_ret;
        }
        /// <summary>
        /// 
        /// </summary>
        bool InsetEnable = false;
        int insertLineNum = 0;
        int insertRowIndex = -1;
        /// <summary>
        /// 新增指令函数(非显示用),
        /// </summary>
        /// <param name="x_trajType">指令类别</param>
        /// <param name="x_param">指令参数</param>
        /// <param name="x_insertPos">插入位置,与最后一个参数匹配使用,</param>
        /// <param name="IsInsert">是否是插入,true表示需要,匹配上一个位置一起使用</param>
        private void InsertNewInstruct(enum_Instruct x_trajType, ParamType x_param, int x_insertPos = 0, bool IsInsert = false)
        { 
            //step1  new a   instruct
            InstructDataType instruct = new InstructDataType();
            switch (x_trajType)
            {
                case enum_Instruct.Line:
                case enum_Instruct.Point:
                    // step2 get now position,and then add the point infomation to pointlist
                    Point currentpoint = new Point();
                    currentpoint.index = CurrentJobDataList.pointList.Count;//point list start from 1,  cause 0 may comfuse  .define 0 as a home position
                    currentpoint.position = GetPos();
                    CurrentJobDataList.pointList.Add(currentpoint);
                    break;
                case enum_Instruct.Gas:

                    break;
                case enum_Instruct.Laser:
                    break;
                case enum_Instruct.Delay:
                    break;
            }
           

            

            //step3 set instruct type ,e.g. point arc line ...
            instruct.type = x_trajType;

            //step 4 create param,  
            instruct.param = x_param;
            //step 5 set instruct index check  insert or  just add instruct at the end
            if (!IsInsert) //仅仅新增
            {
                instruct.index = CurrentJobDataList.instructDataList.Count;
                CurrentJobDataList.instructDataList.Add(instruct);
            }
            else
            {
                int i = GetInstrViewListInsertPos();
                // 
                if (CurrentJobDataList.instructDataViewList[i].Index == EnumHelper.GetDescription(enum_Instruct.END))
                {
                    instruct.index = CurrentJobDataList.instructDataList.Count;
                }
                else
                {
                    if (int.TryParse(CurrentJobDataList.instructDataViewList[i].Index, out int _index))
                    {
                        instruct.index = _index;
                        //处理列表后面新的序号, 递增 ,如果是删除得递减了
                    }
                }
                CurrentJobDataList.instructDataList.Insert(x_insertPos, instruct);

            }
            RefreshDataGrid();
        }

        private InstrDataViewType GetInstructViewData(int x_InstrIndex, enum_Instruct x_type, ParamType x_param)
        {

            InstrDataViewType data = new InstrDataViewType();

            data.Index = x_InstrIndex.ToString("D4");
            //data.Status = ComparePosSame(;
            data.Instruct = EnumHelper.GetDescription(x_type);           
            switch (x_type)
            {
                case enum_Instruct.Line :                  
               case enum_Instruct.Point:
                    data.PointIndex = "P[" + x_param.Pi1.ToString() + "]";
                    data.Speed = "速度=" + x_param.Speed.Tvel.ToString();
                    break;
                case enum_Instruct.Laser:
                    data.PointIndex = "激光";
                    data.Speed = x_param.Enable ? "ON" : "OFF";
                    break;
                case enum_Instruct.Gas:
                    data.PointIndex = "气体";
                    data.Speed = x_param.Enable ? "ON" : "OFF";
                    break;
                case enum_Instruct.Delay:
                    data.PointIndex = "Delay ";
                    data.Speed = x_param.ToString() +" ms";
                    break;
                case enum_Instruct.Rotate:
                    data.PointIndex = "P[" + x_param.Pi1.ToString() + "]";
                    data.Speed = "速度=" + x_param.Speed.Tvel.ToString();
                    data.Blend = "半径=" + x_param.RotParam.Radius.ToString();
                    break;
                default:                   
                    data.Blend = GetBlendString(x_param.Blend);
                    break;

            }

            return data;
        }
        /// <summary>
        /// 获取插入指令位置,根据选择位置插入数据
        /// 如果在END或在END之后,都在end这行插入
        /// 如果在arc标识行,当前行, 
        /// </summary>
        /// <returns></returns>
        private int GetInstrViewListInsertPos()
        {
            int ret = -1;
            ///at end then next line
            ///under end then  at end next line >=end line row
            ///at arc line   check
            if (SelectRow >= CurrentJobDataList.instructDataViewList.Count - 1)
                ret = CurrentJobDataList.instructDataViewList.Count - 1;
            else
            {
                if (CurrentJobDataList.instructDataViewList[SelectRow].Instruct == EnumHelper.GetDescription(enum_Instruct.Arc))
                {
                    ret = SelectRow;
                }
                if (CurrentJobDataList.instructDataViewList[SelectRow].Instruct == EnumHelper.GetDescription(enum_Instruct.RelateToUp))
                {
                    ret = SelectRow - 1;
                }
            }
            return ret;
        }
        /// <summary>
        /// refresh instructlist view  ,
        /// </summary>
        private void RefreshDataGrid()
        {
            CurrentJobDataList.instructDataViewList.Clear();
            AddEndinstrution();
            if (!CurrentJobDataList.instructDataList.IsValid())
                return;
            if (CurrentJobDataList.instructDataList.Count == 0)
            {
                AddEndinstrution();
            }
            foreach (InstructDataType instr in CurrentJobDataList.instructDataList)
            {
                InsertNewInstructView(instr, CurrentJobDataList.instructDataViewList.Count - 1);
            }
            //dataGridView1.RowHeadersWidth = 10;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].Width = 70;          
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 180;

            //dataGridView1.Rows.
           // dataGridView1.data
            dataGridView1.DataSource = CurrentJobDataList.instructDataViewList;
            //dataGridView1.Update();

        }
        private void InsertNewInstructView(InstructDataType x_instructdata, int x_insertPos)
        {
            InstrDataViewType instrViewData = new InstrDataViewType();
            switch (x_instructdata.type)
            {
                case enum_Instruct.Point:
                    instrViewData = GetInstructViewData(x_instructdata.index + 1, enum_Instruct.Point, x_instructdata.param);
                    CurrentJobDataList.instructDataViewList.Insert(x_insertPos, instrViewData);
                    break;
                case enum_Instruct.Line:
                    instrViewData = GetInstructViewData(x_instructdata.index + 1, enum_Instruct.Line, x_instructdata.param);
                    CurrentJobDataList.instructDataViewList.Insert(x_insertPos, instrViewData);
                    break;
                case enum_Instruct.Arc:
                    instrViewData = GetInstructViewData(x_instructdata.index + 1, enum_Instruct.Arc, x_instructdata.param);
                    CurrentJobDataList.instructDataViewList.Insert(x_insertPos, instrViewData);
                    instrViewData = GetInstructViewData(x_instructdata.index + 1, enum_Instruct.RelateToUp, x_instructdata.param);
                    CurrentJobDataList.instructDataViewList.Insert(x_insertPos, instrViewData);
                    break;
                case enum_Instruct.Rotate:
                    instrViewData = GetInstructViewData(x_instructdata.index + 1, enum_Instruct.Rotate, x_instructdata.param);
                    CurrentJobDataList.instructDataViewList.Insert(x_insertPos, instrViewData);
                    break;
                    //case TrajInstructType.END:
                    //    instrViewData= GetInstructViewData(0,TrajInstructType.END,x_instructdata.param));
                    //    break;

            }
            // InsertNewInstructView(x_instructdata, CurrentJobDataList.instructDataViewList.Count - 1);

            //InstrDataViewType data = new InstrDataViewType();

            //data.Index = x_instructdata.index.ToString("D4");
            //data.Status = " ";
            //data.Instruct = EnumHelper.GetDescription(x_instructdata.type);
            //data.PointIndex = "P[" + x_instructdata.param.Pi1.ToString() + "] ";
            //data.Speed = "速度=" + x_instructdata.param.Speed.ToString();
            ////ListofInstruction.Add(data);


        }
        private void bt_instr_Line_Click(object sender, EventArgs e)
        {
            ParamType param = new ParamType();
            param.Blend.Enable = false;
            param.Speed.Tvel = 100;
            param.Pi1 = CurrentJobDataList.pointList.Count + 1;//point list start from 1,  cause 0 may comfuse .

            InsertNewInstruct(enum_Instruct.Line, param);
        }

        private int GetPointindex(int x_nSelectRowindex)
        {
            string pointindexstring = CurrentJobDataList.instructDataViewList[x_nSelectRowindex].PointIndex;
            return int.Parse(pointindexstring.Substring(pointindexstring.IndexOf('[') + 1, pointindexstring.IndexOf(']') - pointindexstring.IndexOf('[') - 1));
        }
        private int GetInstrIndex(int x_nSelectRow)
        {
            string instrindexstring = CurrentJobDataList.instructDataViewList[x_nSelectRow].Index;
            return int.Parse(instrindexstring) - 1;
        }
        private void sbtn_F5_Click(object sender, EventArgs e)
        {
            if (functionKeyPageindex == 0)
            {
        
                /// ProgramPageSeletCellRow = 0;
                int instrIndex = GetInstrIndex(ProgramPageSeletCellRow);
                int pointindex = CurrentJobDataList.instructDataList[instrIndex].param.Pi1;
                //Point p = CurrentJobDataList.pointList[pointindex];

                int moveid = mc.Execute_Instr(CurrentJobDataList.instructDataList[instrIndex], CurrentJobDataList.pointList[CurrentJobDataList.instructDataList[instrIndex].param.Pi1 - 1].position);

                richTextBox1.Text = "当前运动指令为: " + EnumHelper.GetDescription(CurrentJobDataList.instructDataList[instrIndex].type)
                    + " 点位:" + CurrentJobDataList.pointList[CurrentJobDataList.instructDataList[instrIndex].param.Pi1 - 1].position.ToString()
                    + "速度" + CurrentJobDataList.instructDataList[instrIndex].param.ToString();
            }
            if (functionKeyPageindex == 1)
            {
                //step 1  refresh joblist data and  select tap to joblist tp           
              //  uiTabControl_Edit.SelectTab("tp_JobList");
                JumpToTap(Enum_TapNameType.Joblist);
                //step2
                RefreshJobList();
            }
        }
        //  const symbolSave=
        private void RefreshFunctionkey()
        {
            if (functionKeyPageindex == 0)
            {
                sbtn_F1.Text = keyFunctions[0];
                sbtn_F1.SymbolSize = 40;

                sbtn_F2.Text = keyFunctions[1];
                sbtn_F2.SymbolSize = 40;

                sbtn_F3.Text = keyFunctions[2];
                sbtn_F3.SymbolSize = 40;
                sbtn_F3.Symbol = 0;
                sbtn_F4.Text = keyFunctions[3];
                sbtn_F5.Text = keyFunctions[4];
                sbtn_F6.Text = keyFunctions[5];
                sbtn_F7.Text = keyFunctions[6];

            }
            if (functionKeyPageindex == 1)
            {
                sbtn_F1.Text = keyFunctions[7];
                sbtn_F1.SymbolSize = 0;

                sbtn_F2.Text = keyFunctions[8];
                sbtn_F2.SymbolSize = 0;

                sbtn_F3.Text = keyFunctions[9];
                sbtn_F3.SymbolSize = 0;

                sbtn_F4.Text = keyFunctions[10];
                sbtn_F5.Text = keyFunctions[11];
                sbtn_F6.Text = keyFunctions[12];
                sbtn_F7.Text = keyFunctions[13];
            }
        }
        private void sbtn_Next_Click(object sender, EventArgs e)
        {
            functionKeyPageindex++;
            if (functionKeyPageindex > 1)
                functionKeyPageindex = 0;
            RefreshFunctionkey();
        }

        private void sbtn_Pre_Click(object sender, EventArgs e)
        {
            functionKeyPageindex--;
            if (functionKeyPageindex < 0)
                functionKeyPageindex = 1;
            RefreshFunctionkey();
        }
        /// <summary>
        /// save job 
        /// </summary>
        /// <param name="x_nameofJob"></param>
        public void SaveJobFile(string x_nameofJob, string path)
        {
            if (File.Exists(path + CladdingJobSavePath + x_nameofJob))
            {
                UIMessageBox.ShowWarning("文件名" + x_nameofJob + "已存在!");
                return;
            }
            else
            {
                string[] content = new string[CurrentJobDataList.instructDataViewList.Count];
                for (int i = 0; i < CurrentJobDataList.instructDataViewList.Count; i++)
                {
                    content[i] = CurrentJobDataList.instructDataViewList[i].Index.ToString();
                    content[i] += "  " + CurrentJobDataList.instructDataViewList[i].Status;
                    content[i] += "  " + CurrentJobDataList.instructDataViewList[i].Instruct;
                    content[i] += "  " + CurrentJobDataList.instructDataViewList[i].PointIndex;
                    content[i] += "  " + CurrentJobDataList.instructDataViewList[i].Speed;
                    content[i] += "  " + CurrentJobDataList.instructDataViewList[i].Blend;
                }

                File.WriteAllLines(path + CladdingJobSavePath + x_nameofJob, content);



            }
        }
        private void SaveJobData(List<JobDataTypeListType> x_jobList)
        {
            string JobdataViewString = JsonConvert.SerializeObject(CurrentJobDataList.instructDataViewList, Formatting.Indented);
            

        }
        private void SaveDataToJsonFile(object data, string filepath)
        {
            using (StreamWriter sw = File.CreateText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sw, data);
          
            }
        }
        //编辑  和保存
        private void sbtn_F7_Click(object sender, EventArgs e)
        {
            if (functionKeyPageindex == 1)
            {
                //save
                //SaveJobFile("new1.job", AppPath);
                string dirctorypath = AppPath + CladdingJobSavePath + CurrentSelectProgram + @"\";
                Directory.CreateDirectory(dirctorypath);
                SaveDataToJsonFile(CurrentJobDataList.instructDataList, dirctorypath + CurrentSelectProgram + ".idf");
                SaveDataToJsonFile(CurrentJobDataList.instructDataViewList, dirctorypath + CurrentSelectProgram + ".vdf");
                SaveDataToJsonFile(CurrentJobDataList.pointList, dirctorypath + CurrentSelectProgram + ".adf");


            }
            if (functionKeyPageindex == 0) //jump to edit  tabpage
            {
                //  uiTabControl_Edit.SelectTab("tp_Edit");
                JumpToTap(Enum_TapNameType.Edit);
            }
        }
        /// <summary>
        /// refresh job list on the disk   ,path is GlobalData.CladdingJobSavePath
        /// </summary>
        private void RefreshJobList()
        {
            DirectoryInfo di = new DirectoryInfo(GlobalData.AppPath + GlobalData.CladdingJobSavePath);

            listbox_JobsList.Items.Clear();
            if (di != null)
            {
                foreach (DirectoryInfo fi in di.GetDirectories())
                {
                    listbox_JobsList.Items.Add(fi.Name);
                }
            }
        }
        private void bt_selectJob_Click(object sender, EventArgs e)
        {
            //step 1  refresh joblist data and  select tap to joblist tp           
            uiTabControl_Edit.SelectTab("tp_JobList");
            //step2
            RefreshJobList();


            //Frm_SelectJob sj = new Frm_SelectJob();
            //sj.JobsPath = CladdingJobSavePath;
            //sj.ShowDialog();
            //if (sj.OK)
            //{
            //    GlobalData.CurrentSelectProgram = sj.SelectedJobName;
            //}
            //sj.Dispose();
        }
        enum Enum_TapNameType
        {
            [EnumDescription("tp_Instructs")]
            Instruct = 0,
            [EnumDescription("tp_JobList")]
            Joblist = 1,
            [EnumDescription("tp_Edit")]
            Edit = 2,
        }
        private void JumpToTap(Enum_TapNameType x_tapename)
        {
            uiTabControl_Edit.SelectTab(EnumHelper.GetDescription(x_tapename));
        }
        private void bt_newProgramCheck_Click(object sender, EventArgs e)
        {
            if (txb_newProgramNameinput.Text.IsValid() && txb_newProgramNameinput.Text != "")
            {
                CurrentSelectProgram = txb_newProgramNameinput.Text;
                this.Text = "当前打开程序=>" + CurrentSelectProgram;
                CurrentJobDataList.instructDataList.Clear();
                CurrentJobDataList.instructDataViewList.Clear();
                CurrentJobDataList.pointList.Clear();

                //跳转到指令列表
                // uiTabControl_Edit.SelectTab("tp_Instructs");
                JumpToTap(Enum_TapNameType.Instruct);
            }
            else
            {
                UIMessageBox.ShowError("正确输入程序名");
            }
        }

        private void listbox_JobsList_DoubleClick(object sender, EventArgs e)
        {
            //load selected programe
            listbox_JobsList.SelectedItem.ToString();
            UIMessageBox.ShowAsk("");
        }

        private void bt_refreshJoblist_Click(object sender, EventArgs e)
        {
            RefreshJobList();
        }

        private void listbox_JobsList_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //RefreshDataGrid();
            RefreshStatusOfPoint();

            lb_x.Text = "x: " + CurrentPos.x.ToString("f3");
            lb_y.Text = "y: " + CurrentPos.y.ToString("f3");
            lb_z.Text = "z: " + CurrentPos.z.ToString("f3");
            lb_a.Text = "a: " + CurrentPos.a.ToString("f3");
            //if()

        }
        private void LoadJobData(string jobname)
        {
            CurrentSelectProgram = jobname;
            string path = AppPath + CladdingJobSavePath + jobname + @"\";
            List<InstrDataViewType> vdf = JsonConvert.DeserializeObject<List<InstrDataViewType>>(File.ReadAllText(path + jobname + ".vdf"));
            CurrentJobDataList.instructDataViewList.Clear();
            foreach (InstrDataViewType insv in vdf)
            {
                CurrentJobDataList.instructDataViewList.Add(insv);
            }
            List<InstructDataType> idf = JsonConvert.DeserializeObject<List<InstructDataType>>(File.ReadAllText(path + jobname + ".idf"));
            CurrentJobDataList.instructDataList.Clear();
            foreach (InstructDataType insd in idf)
            {
                CurrentJobDataList.instructDataList.Add(insd);
            }
            List<Point> adf = JsonConvert.DeserializeObject<List<Point>>(File.ReadAllText(path + jobname + ".adf"));
            CurrentJobDataList.pointList.Clear();
            foreach (Point p in adf)
            {
                CurrentJobDataList.pointList.Add(p);
            }

            //using (StreamReader sr = File.OpenText(path + jobname + ".vdf"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    CurrentJobDataList.instructDataViewList = (List<InstrDataViewType>)serializer.Deserialize(sr, typeof(InstrDataViewType));
            //}
        }
        private void listbox_JobsList_ItemDoubleClick(object sender, EventArgs e)
        {
            string name = (string)listbox_JobsList.SelectedItem;
            CurrentSelectProgram = name;
            LoadJobData(name);
        }

        private void sbtn_F1_Click(object sender, EventArgs e)
        {///第一页 为运行按钮
            if (functionKeyPageindex == 0)
            {
                ThreadStart threadStart = new ThreadStart(run);
                Thread thread = new Thread(threadStart);
                thread.Start();
            }
        }
        private void run()
        {
            if (mc.bAlive)
            {
                mc.RunProg(CurrentJobDataList.instructDataList, CurrentJobDataList.pointList);
            }
            else
            {
                MessageBox.Show("未能正确连接控制器");
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (GlobalData.ProgramPageSeletCellRow != -1 && CurrentJobDataList.instructDataViewList.Count > 1)
            {
                if (UIMessageBox.ShowAsk("确认删除指令=" + CurrentJobDataList.instructDataViewList[ProgramPageSeletCellRow].Instruct + "指令号=>" + ProgramPageSeletCellRow.ToString()))
                {
                    DeleteInstr(ProgramPageSeletCellRow);
                    UIMessageTip.Show("确认了删除按钮+" + CurrentJobDataList.instructDataViewList[ProgramPageSeletCellRow].Instruct + "指令号=>" + ProgramPageSeletCellRow.ToString());
                }
                else
                {
                    UIMessageTip.Show("不正确.");
                }
            }
            else
            {
                UIMessageTip.Show("请正确选择删除指令行!", TipStyle.Gray);
            }
        }
        private void DeleteInstr(int instrIndex)
        {
            if (instrIndex > CurrentJobDataList.instructDataList.Count - 1 || instrIndex < 0)
            {
                UIMessageTip.Show("超过范围!");
                return;
            }


            //如果指令数小于1
            if (CurrentJobDataList.instructDataList.Count < 1)
            {
                UIMessageTip.Show("当前指令为空!"); ;
            }
            else
            {
                // if(CurrentJobDataList.instructDataList.Count ==instrIndex)
                if (CurrentJobDataList.instructDataList[instrIndex].index == instrIndex)
                {
                    CurrentJobDataList.instructDataList.RemoveAt(instrIndex);
                    if (instrIndex== CurrentJobDataList.instructDataList.Count+1)
                    {
                        ;
                    }
                    else 
                    {
                        for (int i = instrIndex; i < CurrentJobDataList.instructDataList.Count; i++)
                        {
                            InstructDataType ins = new InstructDataType();
                            ins = CurrentJobDataList.instructDataList[i];
                            ins.index--;
                            CurrentJobDataList.instructDataList.Update(i, ins);
                        }
                        RefreshDataGrid();

                    }
                    //else
                    //{
                    //    UIMessageTip.Show("删除后数据index不正确!");
                    //}

                }
                else
                {
                    UIMessageTip.Show("删除数据不正确!");
                }


            }
        }

       

        private void bt_instr_Rota_Click(object sender, EventArgs e)
        {
            ParamType param = new ParamType();
            param.Blend.Enable = false;
            param.Speed.Tvel = 10;
            param.RotParam.Radius= GlobalData.PartRadius;
            param.RotParam.RotConfigParam = StandardCladdingInstr.RotParam.RotConfigParam;
            param.Pi1 = CurrentJobDataList.pointList.Count + 1;//point list start from 1,  cause 0 may comfuse .
            param.RotParam.RotConfigParam.RotAxisIndex = (int)AxisesChannel.Axis_A;

            InsertNewInstruct(enum_Instruct.Rotate, param);
        }

        private void txb_newProgramNameinput_Click(object sender, EventArgs e)
        {
            txb_newProgramNameinput.Text = InputString("输入新程序名", txb_newProgramNameinput.Text);
        }

        private void btn_instr_PowerON_Click(object sender, EventArgs e)
        {

        }

        private void bt_newProgrameClear_Click(object sender, EventArgs e)
        {
            ///shanchu  删除程序文件
        }

        private void sbtn_F3_Click(object sender, EventArgs e)
        {
            if (functionKeyPageindex == 0)
            {
                mc.StopMove(enum_StopMode.AllMove);
            }
        }

        private void PagePanel_Click(object sender, EventArgs e)
        {

        }

        private void btn_instr_Delay_Click(object sender, EventArgs e)
        {
            ParamType param = new ParamType();
            param.Blend.Enable = false;
            // param.Speed.Tvel = 100;
            //  param.Pi1 = CurrentJobDataList.pointList.Count + 1;//point list start from 1,  cause 0 may comfuse .
            param.Enable = false;
            param.DelayTime = InputValue("停止时间(ms)", 0, 10000, param.DelayTime);
            InsertNewInstruct(enum_Instruct.Delay, param);
        }
    }
}

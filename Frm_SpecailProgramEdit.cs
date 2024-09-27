using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaserSolution.Properties;
using Sunny.UI;
using Tools;


namespace LaserSolution
{
    public partial class Frm_SpecailProgramEdit : UIEditForm
    {
        public Frm_SpecailProgramEdit()
        {
            InitializeComponent();
            InitList();
        }
        protected override bool CheckData()
        {
            return base.CheckData();
        }
        private ProgramType _Program = new ProgramType();
        public ProgramType Program
        {
            get
            {
                _Program.ProgramName = txtb_ProgramName.Text;
                _Program.laserApp = GlobalData.application;
                _Program.InstrType = (SpecialInstrType)uiImageListBox1.SelectedIndex;
                return _Program;
            }
        }
        private void InitList()
        {
            uiImageListBox1.Items.Clear();
            uiImageListBox1.AddImage(Resources.耐磨带, EnumHelper.GetDescription(SpecialInstrType.ShapeOnCylinder));   //0
            uiImageListBox1.AddImage(Resources.线, EnumHelper.GetDescription(SpecialInstrType.SurfaceOnAxis));
            


        }

        private void uiImageListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            enum_Instruct instrt = (enum_Instruct)uiImageListBox1.SelectedIndex;
            lb_PogramType.Text = EnumHelper.GetDescription(instrt);

        }

        private void Frm_NewProgramEdit_Load(object sender, EventArgs e)
        {
            uiImageListBox1.SelectedFirst();
        }
    }
}

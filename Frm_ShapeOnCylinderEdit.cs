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
using Tools;

namespace LaserSolution
{
    public partial class Frm_ShapeOnCylinderEdit : UIEditForm
    {
        public Frm_ShapeOnCylinderEdit()
        {
            InitializeComponent();
            maxpageIndex = uiTabControl1.TabPages.Count - 1;

        }
        private int SeletedPageIndex = 0;
        private int maxpageIndex = 0;
        private ProgramType _program = new ProgramType();
        public ProgramType Program
        {
            set { _program = value; }
            get { return _program; }
        }

        public void ChangeSelectPage()
        {
            //uiTabControl1.SelectPage(SeletedPageIndex);
            uiTabControl1.SelectTab(SeletedPageIndex);
        }
        private void sbt_nextPage_Click(object sender, EventArgs e)
        {
           
            SeletedPageIndex++;
            if (SeletedPageIndex > maxpageIndex)
            {
                SeletedPageIndex = 0;
            }
          
            ChangeSelectPage();
        }

        private void sbtn_prePage_Click(object sender, EventArgs e)
        {
            SeletedPageIndex--;
            if (SeletedPageIndex < 0)
            {
                SeletedPageIndex =maxpageIndex;
            }

            ChangeSelectPage();
        }

        private void Frm_ShapeOnCylinderEdit_Load(object sender, EventArgs e)
        {
            this.Text = _program.ProgramName;
        }
    }
}

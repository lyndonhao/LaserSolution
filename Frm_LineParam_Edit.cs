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
    public partial class Frm_LineParam_Edit : UIEditForm
    {
        public Frm_LineParam_Edit()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_XPos.Text = GlobalData.Axis[GlobalData.AxisesChannel.Axis_X].Status.CurrentPos.ToString("F3");
            lb_Ypos.Text = GlobalData.Axis[GlobalData.AxisesChannel.Axis_Y].Status.CurrentPos.ToString("F3");
            lb_Zpos.Text = GlobalData.Axis[GlobalData.AxisesChannel.Axis_Z].Status.CurrentPos.ToString("F3");
            lb_Apos.Text = GlobalData.Axis[GlobalData.AxisesChannel.Axis_A].Status.CurrentPos.ToString("F3");
        }
    }
}

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
    public partial class Frm_Rotate_Param : UIEditForm
    {
        public Frm_Rotate_Param()
        {
            InitializeComponent();
        }
        protected override bool CheckData()
        {
            return CheckEmpty(input_Radius, "请输入旋转半径")
                   && CheckEmpty(input_rotateSpeed, "请输如旋转速度")
                   && CheckRange(input_rotateSpeed, 0, 100, "输入范围有误,0~100之内")
                    && CheckRange(input_Radius,30, 400, "输入范围有误,30~400之内")
                   && CheckEmpty(input_LineSpeed, "请输入线速度");
        }
        private RotParamType _param = new RotParamType();
        public RotParamType param
        {

            get {

              //  _param.bRotate = !uiSwitch1.Active;
                _param.LineSpeed = input_LineSpeed.DoubleValue;
                _param.Radius = input_Radius.DoubleValue;
                _param.RotSpeed = input_rotateSpeed.DoubleValue;
                return _param; }
            set { _param = value;
                input_Radius.DoubleValue = value.Radius;
                input_LineSpeed.DoubleValue = value.LineSpeed;
                input_rotateSpeed.DoubleValue = value.RotSpeed;
               // uiSwitch1.Active = !value.bRotate;
            }
        }

    }
}

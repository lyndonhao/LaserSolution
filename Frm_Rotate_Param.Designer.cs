namespace LaserSolution
{
    partial class Frm_Rotate_Param
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.input_Radius = new Sunny.UI.UITextBox();
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.input_rotateSpeed = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.input_LineSpeed = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 299);
            this.pnlBtm.Size = new System.Drawing.Size(597, 55);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(20, 73);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(159, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "旋转半径(mm)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_Radius
            // 
            this.input_Radius.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_Radius.FillColor = System.Drawing.Color.White;
            this.input_Radius.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.input_Radius.Location = new System.Drawing.Point(186, 73);
            this.input_Radius.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_Radius.Maximum = 2147483647D;
            this.input_Radius.Minimum = -2147483648D;
            this.input_Radius.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_Radius.Name = "input_Radius";
            this.input_Radius.Padding = new System.Windows.Forms.Padding(5);
            this.input_Radius.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.input_Radius.Size = new System.Drawing.Size(129, 29);
            this.input_Radius.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.input_Radius.TabIndex = 3;
            this.input_Radius.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiSwitch1.ActiveText = "定位";
            this.uiSwitch1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSwitch1.InActiveText = "回转";
            this.uiSwitch1.Location = new System.Drawing.Point(470, 73);
            this.uiSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(115, 44);
            this.uiSwitch1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiSwitch1.TabIndex = 4;
            this.uiSwitch1.Text = "uiSwitch1";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(20, 133);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(148, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "旋转角速度(°/s)";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_rotateSpeed
            // 
            this.input_rotateSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_rotateSpeed.DoubleValue = 100.01D;
            this.input_rotateSpeed.FillColor = System.Drawing.Color.White;
            this.input_rotateSpeed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.input_rotateSpeed.Location = new System.Drawing.Point(186, 127);
            this.input_rotateSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_rotateSpeed.Maximum = 2147483647D;
            this.input_rotateSpeed.Minimum = -2147483648D;
            this.input_rotateSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_rotateSpeed.Name = "input_rotateSpeed";
            this.input_rotateSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.input_rotateSpeed.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.input_rotateSpeed.Size = new System.Drawing.Size(129, 29);
            this.input_rotateSpeed.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.input_rotateSpeed.TabIndex = 4;
            this.input_rotateSpeed.Text = "100.01";
            this.input_rotateSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(20, 216);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(144, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "旋转线速度(mm/s)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_LineSpeed
            // 
            this.input_LineSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_LineSpeed.DoubleValue = 100.01D;
            this.input_LineSpeed.Enabled = false;
            this.input_LineSpeed.FillColor = System.Drawing.Color.White;
            this.input_LineSpeed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.input_LineSpeed.Location = new System.Drawing.Point(186, 216);
            this.input_LineSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_LineSpeed.Maximum = 2147483647D;
            this.input_LineSpeed.Minimum = -2147483648D;
            this.input_LineSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_LineSpeed.Name = "input_LineSpeed";
            this.input_LineSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.input_LineSpeed.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.input_LineSpeed.Size = new System.Drawing.Size(129, 29);
            this.input_LineSpeed.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.input_LineSpeed.TabIndex = 5;
            this.input_LineSpeed.Text = "100.01";
            this.input_LineSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(322, 127);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(136, 29);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "最大值为100度/s";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Rotate_Param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 357);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.input_LineSpeed);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.input_rotateSpeed);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiSwitch1);
            this.Controls.Add(this.input_Radius);
            this.Controls.Add(this.uiLabel1);
            this.Name = "Frm_Rotate_Param";
            this.Text = "旋转参数设置";
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.input_Radius, 0);
            this.Controls.SetChildIndex(this.uiSwitch1, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.input_rotateSpeed, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.input_LineSpeed, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox input_Radius;
        private Sunny.UI.UISwitch uiSwitch1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox input_rotateSpeed;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox input_LineSpeed;
        private Sunny.UI.UILabel uiLabel4;
    }
}
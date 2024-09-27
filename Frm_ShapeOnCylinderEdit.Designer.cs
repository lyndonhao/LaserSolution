namespace LaserSolution
{
    partial class Frm_ShapeOnCylinderEdit
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
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbin_deltaM = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.delta_Switch = new Sunny.UI.UISwitch();
            this.tbin_speed = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.tbin_LaserPower = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.tbin_LayerNumber = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tbIn_LineWidth = new Sunny.UI.UITextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sbtn_prePage = new Sunny.UI.UISymbolButton();
            this.sbt_nextPage = new Sunny.UI.UISymbolButton();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 542);
            this.pnlBtm.Size = new System.Drawing.Size(998, 55);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(4, 38);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(992, 441);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.tabPage1.Controls.Add(this.tbin_deltaM);
            this.tabPage1.Controls.Add(this.uiLabel6);
            this.tabPage1.Controls.Add(this.uiLabel5);
            this.tabPage1.Controls.Add(this.delta_Switch);
            this.tabPage1.Controls.Add(this.tbin_speed);
            this.tabPage1.Controls.Add(this.uiLabel4);
            this.tabPage1.Controls.Add(this.uiSymbolButton4);
            this.tabPage1.Controls.Add(this.uiSymbolButton3);
            this.tabPage1.Controls.Add(this.tbin_LaserPower);
            this.tabPage1.Controls.Add(this.uiLabel3);
            this.tabPage1.Controls.Add(this.tbin_LayerNumber);
            this.tabPage1.Controls.Add(this.uiLabel2);
            this.tabPage1.Controls.Add(this.uiLabel1);
            this.tabPage1.Controls.Add(this.tbIn_LineWidth);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(992, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tbin_deltaM
            // 
            this.tbin_deltaM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbin_deltaM.DoubleValue = 1D;
            this.tbin_deltaM.FillColor = System.Drawing.Color.White;
            this.tbin_deltaM.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbin_deltaM.IntValue = 1;
            this.tbin_deltaM.Location = new System.Drawing.Point(578, 86);
            this.tbin_deltaM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbin_deltaM.Maximum = 2147483647D;
            this.tbin_deltaM.Minimum = -2147483648D;
            this.tbin_deltaM.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbin_deltaM.Name = "tbin_deltaM";
            this.tbin_deltaM.Padding = new System.Windows.Forms.Padding(5);
            this.tbin_deltaM.Size = new System.Drawing.Size(113, 38);
            this.tbin_deltaM.TabIndex = 4;
            this.tbin_deltaM.Text = "1";
            this.tbin_deltaM.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(426, 91);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(150, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 10;
            this.uiLabel6.Text = "梯度值(mm)";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(426, 47);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(150, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "梯度堆叠";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delta_Switch
            // 
            this.delta_Switch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.delta_Switch.Location = new System.Drawing.Point(578, 34);
            this.delta_Switch.MinimumSize = new System.Drawing.Size(1, 1);
            this.delta_Switch.Name = "delta_Switch";
            this.delta_Switch.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.delta_Switch.Size = new System.Drawing.Size(113, 38);
            this.delta_Switch.SwitchShape = Sunny.UI.UISwitch.UISwitchShape.Square;
            this.delta_Switch.TabIndex = 8;
            this.delta_Switch.Text = "uiSwitch1";
            // 
            // tbin_speed
            // 
            this.tbin_speed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbin_speed.DoubleValue = 1D;
            this.tbin_speed.FillColor = System.Drawing.Color.White;
            this.tbin_speed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbin_speed.IntValue = 1;
            this.tbin_speed.Location = new System.Drawing.Point(217, 184);
            this.tbin_speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbin_speed.Maximum = 2147483647D;
            this.tbin_speed.Minimum = -2147483648D;
            this.tbin_speed.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbin_speed.Name = "tbin_speed";
            this.tbin_speed.Padding = new System.Windows.Forms.Padding(5);
            this.tbin_speed.Size = new System.Drawing.Size(113, 38);
            this.tbin_speed.TabIndex = 4;
            this.tbin_speed.Text = "1";
            this.tbin_speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(9, 182);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(150, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "行走速度(mm/s)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.uiSymbolButton4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.uiSymbolButton4.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiSymbolButton4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiSymbolButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton4.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton4.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton4.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton4.Location = new System.Drawing.Point(827, 221);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiSymbolButton4.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.uiSymbolButton4.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiSymbolButton4.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiSymbolButton4.Size = new System.Drawing.Size(150, 66);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiSymbolButton4.Symbol = 61508;
            this.uiSymbolButton4.TabIndex = 6;
            this.uiSymbolButton4.Text = "修改";
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.uiSymbolButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.uiSymbolButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiSymbolButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiSymbolButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton3.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton3.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton3.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton3.Location = new System.Drawing.Point(827, 315);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiSymbolButton3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.uiSymbolButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiSymbolButton3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiSymbolButton3.Size = new System.Drawing.Size(150, 66);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiSymbolButton3.TabIndex = 5;
            this.uiSymbolButton3.Text = "确认";
            // 
            // tbin_LaserPower
            // 
            this.tbin_LaserPower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbin_LaserPower.DoubleValue = 1D;
            this.tbin_LaserPower.FillColor = System.Drawing.Color.White;
            this.tbin_LaserPower.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbin_LaserPower.IntValue = 1;
            this.tbin_LaserPower.Location = new System.Drawing.Point(217, 136);
            this.tbin_LaserPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbin_LaserPower.Maximum = 2147483647D;
            this.tbin_LaserPower.Minimum = -2147483648D;
            this.tbin_LaserPower.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbin_LaserPower.Name = "tbin_LaserPower";
            this.tbin_LaserPower.Padding = new System.Windows.Forms.Padding(5);
            this.tbin_LaserPower.Size = new System.Drawing.Size(113, 38);
            this.tbin_LaserPower.TabIndex = 3;
            this.tbin_LaserPower.Text = "1";
            this.tbin_LaserPower.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(9, 132);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(150, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "激光功率(W)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbin_LayerNumber
            // 
            this.tbin_LayerNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbin_LayerNumber.DoubleValue = 1D;
            this.tbin_LayerNumber.FillColor = System.Drawing.Color.White;
            this.tbin_LayerNumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbin_LayerNumber.IntValue = 1;
            this.tbin_LayerNumber.Location = new System.Drawing.Point(217, 88);
            this.tbin_LayerNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbin_LayerNumber.Maximum = 2147483647D;
            this.tbin_LayerNumber.Minimum = -2147483648D;
            this.tbin_LayerNumber.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbin_LayerNumber.Name = "tbin_LayerNumber";
            this.tbin_LayerNumber.Padding = new System.Windows.Forms.Padding(5);
            this.tbin_LayerNumber.Size = new System.Drawing.Size(113, 38);
            this.tbin_LayerNumber.TabIndex = 2;
            this.tbin_LayerNumber.Text = "1";
            this.tbin_LayerNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(9, 86);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(150, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "熔覆层数";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(9, 40);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(150, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "熔覆线宽(mm)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIn_LineWidth
            // 
            this.tbIn_LineWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIn_LineWidth.DoubleValue = 1D;
            this.tbIn_LineWidth.FillColor = System.Drawing.Color.White;
            this.tbIn_LineWidth.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbIn_LineWidth.IntValue = 1;
            this.tbIn_LineWidth.Location = new System.Drawing.Point(217, 40);
            this.tbIn_LineWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIn_LineWidth.Maximum = 2147483647D;
            this.tbIn_LineWidth.Minimum = -2147483648D;
            this.tbIn_LineWidth.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbIn_LineWidth.Name = "tbIn_LineWidth";
            this.tbIn_LineWidth.Padding = new System.Windows.Forms.Padding(5);
            this.tbIn_LineWidth.Size = new System.Drawing.Size(113, 38);
            this.tbIn_LineWidth.TabIndex = 0;
            this.tbIn_LineWidth.Text = "1";
            this.tbIn_LineWidth.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(992, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // sbtn_prePage
            // 
            this.sbtn_prePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_prePage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_prePage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_prePage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_prePage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_prePage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sbtn_prePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_prePage.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_prePage.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_prePage.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_prePage.Location = new System.Drawing.Point(4, 482);
            this.sbtn_prePage.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_prePage.Name = "sbtn_prePage";
            this.sbtn_prePage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_prePage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_prePage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_prePage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_prePage.Size = new System.Drawing.Size(119, 57);
            this.sbtn_prePage.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_prePage.Symbol = 61513;
            this.sbtn_prePage.TabIndex = 3;
            this.sbtn_prePage.Text = "上一步";
            this.sbtn_prePage.Click += new System.EventHandler(this.sbtn_prePage_Click);
            // 
            // sbt_nextPage
            // 
            this.sbt_nextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbt_nextPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbt_nextPage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbt_nextPage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbt_nextPage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbt_nextPage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sbt_nextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbt_nextPage.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbt_nextPage.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbt_nextPage.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbt_nextPage.Location = new System.Drawing.Point(877, 482);
            this.sbt_nextPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbt_nextPage.Name = "sbt_nextPage";
            this.sbt_nextPage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbt_nextPage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbt_nextPage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbt_nextPage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbt_nextPage.Size = new System.Drawing.Size(119, 57);
            this.sbt_nextPage.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbt_nextPage.Symbol = 61520;
            this.sbt_nextPage.TabIndex = 4;
            this.sbt_nextPage.Text = "下一步";
            this.sbt_nextPage.Click += new System.EventHandler(this.sbt_nextPage_Click);
            // 
            // Frm_ShapeOnCylinderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.sbt_nextPage);
            this.Controls.Add(this.sbtn_prePage);
            this.Controls.Add(this.uiTabControl1);
            this.Name = "Frm_ShapeOnCylinderEdit";
            this.Text = "轴上耐磨带程序编辑";
            this.Load += new System.EventHandler(this.Frm_ShapeOnCylinderEdit_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiTabControl1, 0);
            this.Controls.SetChildIndex(this.sbtn_prePage, 0);
            this.Controls.SetChildIndex(this.sbt_nextPage, 0);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UISwitch delta_Switch;
        private Sunny.UI.UITextBox tbin_speed;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UITextBox tbin_LaserPower;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox tbin_LayerNumber;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox tbIn_LineWidth;
        private Sunny.UI.UISymbolButton sbtn_prePage;
        private Sunny.UI.UISymbolButton sbt_nextPage;
        private Sunny.UI.UITextBox tbin_deltaM;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
    }
}
namespace LaserSolution
{
    partial class Frm_Operate
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
            this.components = new System.ComponentModel.Container();
            PCHMI.InterLock interLock2 = new PCHMI.InterLock();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Operate));
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.数据显示器1 = new PCHMI.数据显示器();
            this.y = new PCHMI.面板();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiMarkLabel6 = new Sunny.UI.UIMarkLabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.sbtn_F2 = new Sunny.UI.UISymbolButton();
            this.sbtn_F1 = new Sunny.UI.UISymbolButton();
            this.sbtn_Next = new Sunny.UI.UISymbolButton();
            this.sbtn_F6 = new Sunny.UI.UISymbolButton();
            this.sbtn_F7 = new Sunny.UI.UISymbolButton();
            this.sbtn_F5 = new Sunny.UI.UISymbolButton();
            this.sbtn_F4 = new Sunny.UI.UISymbolButton();
            this.sbtn_F3 = new Sunny.UI.UISymbolButton();
            this.sbtn_Pre = new Sunny.UI.UISymbolButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiLabel21 = new Sunny.UI.UILabel();
            this.lb_ASpeed = new Sunny.UI.UILabel();
            this.uiLabel27 = new Sunny.UI.UILabel();
            this.lb_Xspeed = new Sunny.UI.UILabel();
            this.lb_XPos = new Sunny.UI.UILabel();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.lb_Apos = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.实际位置 = new Sunny.UI.UITitlePanel();
            this.uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            this.RotEnable = new Sunny.UI.UIImageButton();
            this.RotEnable_switch = new Sunny.UI.UISwitch();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.enable_CCW = new Sunny.UI.UISwitch();
            this.input_LineSpeed = new Sunny.UI.UITextBox();
            this.input_PartRadius = new Sunny.UI.UITextBox();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.input_rotateSpeed = new Sunny.UI.UITextBox();
            this.PagePanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.实际位置.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotEnable)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiTitlePanel2);
            this.PagePanel.Controls.Add(this.实际位置);
            this.PagePanel.Controls.Add(this.uiTitlePanel1);
            this.PagePanel.Controls.Add(this.sbtn_F2);
            this.PagePanel.Controls.Add(this.sbtn_F1);
            this.PagePanel.Controls.Add(this.sbtn_Next);
            this.PagePanel.Controls.Add(this.sbtn_F6);
            this.PagePanel.Controls.Add(this.sbtn_F7);
            this.PagePanel.Controls.Add(this.sbtn_F5);
            this.PagePanel.Controls.Add(this.sbtn_F4);
            this.PagePanel.Controls.Add(this.sbtn_F3);
            this.PagePanel.Controls.Add(this.sbtn_Pre);
            this.PagePanel.Controls.Add(this.uiLabel12);
            this.PagePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.PagePanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.PagePanel.Size = new System.Drawing.Size(1130, 665);
            this.PagePanel.Style = Sunny.UI.UIStyle.Office2010Silver;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1130, 685);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.tabPage1.Controls.Add(this.uiLabel9);
            this.tabPage1.Controls.Add(this.uiLabel8);
            this.tabPage1.Controls.Add(this.uiLabel7);
            this.tabPage1.Controls.Add(this.uiLabel6);
            this.tabPage1.Controls.Add(this.uiLabel5);
            this.tabPage1.Controls.Add(this.uiLabel4);
            this.tabPage1.Controls.Add(this.uiLabel3);
            this.tabPage1.Controls.Add(this.uiLabel2);
            this.tabPage1.Controls.Add(this.数据显示器1);
            this.tabPage1.Controls.Add(this.y);
            this.tabPage1.Controls.Add(this.uiLabel1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1130, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "操作页面";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(137, 242);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(261, 67);
            this.uiLabel9.TabIndex = 14;
            this.uiLabel9.Text = "99999.99";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(137, 174);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(261, 67);
            this.uiLabel8.TabIndex = 13;
            this.uiLabel8.Text = "99999.99";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(137, 106);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(261, 67);
            this.uiLabel7.TabIndex = 12;
            this.uiLabel7.Text = "99999.99";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(137, 38);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(261, 67);
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "99999.99";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(38, 241);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(93, 68);
            this.uiLabel5.TabIndex = 7;
            this.uiLabel5.Text = "R:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(38, 173);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(93, 68);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "Z:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(38, 105);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(93, 68);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "Y:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(38, 37);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(93, 68);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "X:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 数据显示器1
            // 
            this.数据显示器1.HDADDR = "";
            this.数据显示器1.Location = new System.Drawing.Point(805, 365);
            this.数据显示器1.Name = "数据显示器1";
            this.数据显示器1.PLC = ((uint)(0u));
            this.数据显示器1.Size = new System.Drawing.Size(100, 29);
            this.数据显示器1.TabIndex = 2;
            this.数据显示器1.Text = "0";
            this.数据显示器1.Value = ((ulong)(0ul));
            this.数据显示器1.七段码显示 = false;
            interLock2.HDADDR = "";
            interLock2.PLC = ((uint)(0u));
            interLock2.互锁启用值 = ((uint)(1u));
            interLock2.互锁地址 = "";
            interLock2.互锁显示图标 = null;
            interLock2.互锁显示文本 = "LOCK";
            interLock2.互锁类型 = PCHMI.InterLock.DatType.Bit;
            this.数据显示器1.互锁 = interLock2;
            this.数据显示器1.值限制 = false;
            this.数据显示器1.字符串长度 = ((uint)(10u));
            this.数据显示器1.安全级别 = ((uint)(0u));
            this.数据显示器1.小数位数 = ((uint)(0u));
            this.数据显示器1.总显示位数 = ((uint)(8u));
            this.数据显示器1.数值改变事件参数 = "NULL";
            this.数据显示器1.数据类型 = PCHMI.数据显示器.DatType.INT16;
            this.数据显示器1.最大值 = "100";
            this.数据显示器1.最小值 = "0";
            this.数据显示器1.监控地址 = "";
            this.数据显示器1.输入方式 = PCHMI.数据显示器.INTYPE.软键盘;
            this.数据显示器1.键盘输入事件参数 = "NULL";
            this.数据显示器1.键盘进入方式 = PCHMI.数据显示器.KeyInMode.单击;
            this.数据显示器1.零抑制 = false;
            this.数据显示器1.零显示 = false;
            // 
            // y
            // 
            this.y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("y.BackgroundImage")));
            this.y.Location = new System.Drawing.Point(755, 133);
            this.y.Margin = new System.Windows.Forms.Padding(5);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(200, 137);
            this.y.TabIndex = 1;
            this.y.圆角半径 = 0;
            this.y.填充颜色 = System.Drawing.Color.DarkSlateGray;
            this.y.拖动窗口 = false;
            this.y.边框颜色 = System.Drawing.Color.DarkSlateGray;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(469, 622);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "operate";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(450, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "机床状态";
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(0, 35);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(1130, 3);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel10.TabIndex = 1;
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(0, 582);
            this.uiLabel11.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(1130, 2);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel11.TabIndex = 2;
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel6
            // 
            this.uiMarkLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiMarkLabel6.Location = new System.Drawing.Point(1128, 0);
            this.uiMarkLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.uiMarkLabel6.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiMarkLabel6.MarkSize = 1;
            this.uiMarkLabel6.Name = "uiMarkLabel6";
            this.uiMarkLabel6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.uiMarkLabel6.Size = new System.Drawing.Size(10, 585);
            this.uiMarkLabel6.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiMarkLabel6.TabIndex = 65;
            this.uiMarkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(0, 580);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(1128, 2);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel12.TabIndex = 0;
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbtn_F2
            // 
            this.sbtn_F2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_F2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_F2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_F2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_F2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F2.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F2.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F2.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F2.Location = new System.Drawing.Point(232, 587);
            this.sbtn_F2.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_F2.Name = "sbtn_F2";
            this.sbtn_F2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_F2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_F2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F2.Size = new System.Drawing.Size(126, 74);
            this.sbtn_F2.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_F2.Symbol = 61641;
            this.sbtn_F2.SymbolSize = 0;
            this.sbtn_F2.TabIndex = 17;
            this.sbtn_F2.Text = "激光";
            this.sbtn_F2.Click += new System.EventHandler(this.sbtn_F2_Click);
            // 
            // sbtn_F1
            // 
            this.sbtn_F1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_F1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_F1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_F1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_F1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F1.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F1.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F1.Location = new System.Drawing.Point(97, 587);
            this.sbtn_F1.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_F1.Name = "sbtn_F1";
            this.sbtn_F1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_F1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_F1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F1.Size = new System.Drawing.Size(126, 74);
            this.sbtn_F1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_F1.Symbol = 61641;
            this.sbtn_F1.SymbolSize = 0;
            this.sbtn_F1.TabIndex = 16;
            this.sbtn_F1.Text = "复位";
            this.sbtn_F1.Click += new System.EventHandler(this.sbtn_F1_Click);
            this.sbtn_F1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sbtn_F1_MouseDown);
            this.sbtn_F1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sbtn_F1_MouseUp);
            // 
            // sbtn_Next
            // 
            this.sbtn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_Next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_Next.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_Next.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_Next.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_Next.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Next.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Next.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Next.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Next.Location = new System.Drawing.Point(1042, 587);
            this.sbtn_Next.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_Next.Name = "sbtn_Next";
            this.sbtn_Next.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_Next.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_Next.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_Next.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_Next.Size = new System.Drawing.Size(80, 74);
            this.sbtn_Next.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_Next.Symbol = 61697;
            this.sbtn_Next.SymbolSize = 64;
            this.sbtn_Next.TabIndex = 15;
            // 
            // sbtn_F6
            // 
            this.sbtn_F6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_F6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_F6.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_F6.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F6.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F6.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_F6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F6.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F6.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F6.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F6.Location = new System.Drawing.Point(772, 587);
            this.sbtn_F6.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_F6.Name = "sbtn_F6";
            this.sbtn_F6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_F6.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_F6.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F6.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F6.Size = new System.Drawing.Size(126, 74);
            this.sbtn_F6.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_F6.Symbol = 61641;
            this.sbtn_F6.SymbolSize = 0;
            this.sbtn_F6.TabIndex = 14;
            this.sbtn_F6.Text = "Z";
            this.sbtn_F6.Click += new System.EventHandler(this.sbtn_F6_Click);
            // 
            // sbtn_F7
            // 
            this.sbtn_F7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_F7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_F7.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_F7.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F7.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F7.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_F7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F7.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F7.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F7.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F7.Location = new System.Drawing.Point(907, 587);
            this.sbtn_F7.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_F7.Name = "sbtn_F7";
            this.sbtn_F7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_F7.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_F7.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F7.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F7.Size = new System.Drawing.Size(126, 74);
            this.sbtn_F7.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_F7.Symbol = 61641;
            this.sbtn_F7.SymbolSize = 0;
            this.sbtn_F7.TabIndex = 13;
            this.sbtn_F7.Text = "R";
            this.sbtn_F7.Click += new System.EventHandler(this.sbtn_F7_Click);
            // 
            // sbtn_F5
            // 
            this.sbtn_F5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_F5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_F5.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_F5.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F5.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F5.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_F5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F5.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F5.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F5.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F5.Location = new System.Drawing.Point(637, 587);
            this.sbtn_F5.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_F5.Name = "sbtn_F5";
            this.sbtn_F5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_F5.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_F5.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F5.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F5.Size = new System.Drawing.Size(126, 74);
            this.sbtn_F5.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_F5.Symbol = 61641;
            this.sbtn_F5.SymbolSize = 0;
            this.sbtn_F5.TabIndex = 12;
            this.sbtn_F5.Text = "Y";
            this.sbtn_F5.Click += new System.EventHandler(this.sbtn_F5_Click);
            // 
            // sbtn_F4
            // 
            this.sbtn_F4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_F4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_F4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_F4.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F4.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_F4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F4.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F4.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F4.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F4.Location = new System.Drawing.Point(502, 587);
            this.sbtn_F4.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_F4.Name = "sbtn_F4";
            this.sbtn_F4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_F4.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_F4.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F4.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F4.Size = new System.Drawing.Size(126, 74);
            this.sbtn_F4.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_F4.Symbol = 61641;
            this.sbtn_F4.SymbolSize = 0;
            this.sbtn_F4.TabIndex = 11;
            this.sbtn_F4.Text = "X";
            this.sbtn_F4.Click += new System.EventHandler(this.sbtn_F4_Click);
            // 
            // sbtn_F3
            // 
            this.sbtn_F3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_F3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_F3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_F3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_F3.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_F3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F3.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F3.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F3.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_F3.Location = new System.Drawing.Point(367, 587);
            this.sbtn_F3.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_F3.Name = "sbtn_F3";
            this.sbtn_F3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_F3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_F3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_F3.Size = new System.Drawing.Size(126, 74);
            this.sbtn_F3.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_F3.Symbol = 61641;
            this.sbtn_F3.SymbolSize = 0;
            this.sbtn_F3.TabIndex = 10;
            this.sbtn_F3.Text = "F3";
            this.sbtn_F3.Click += new System.EventHandler(this.sbtn_F3_Click);
            // 
            // sbtn_Pre
            // 
            this.sbtn_Pre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_Pre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_Pre.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_Pre.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_Pre.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_Pre.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_Pre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Pre.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Pre.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Pre.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_Pre.Location = new System.Drawing.Point(8, 587);
            this.sbtn_Pre.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_Pre.Name = "sbtn_Pre";
            this.sbtn_Pre.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_Pre.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_Pre.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_Pre.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_Pre.Size = new System.Drawing.Size(80, 74);
            this.sbtn_Pre.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_Pre.Symbol = 61696;
            this.sbtn_Pre.SymbolSize = 64;
            this.sbtn_Pre.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiLabel21);
            this.uiTitlePanel1.Controls.Add(this.lb_ASpeed);
            this.uiTitlePanel1.Controls.Add(this.uiLabel27);
            this.uiTitlePanel1.Controls.Add(this.lb_Xspeed);
            this.uiTitlePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiTitlePanel1.Location = new System.Drawing.Point(374, 15);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiTitlePanel1.Size = new System.Drawing.Size(362, 212);
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiTitlePanel1.TabIndex = 49;
            this.uiTitlePanel1.Text = "速度 ";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.Silver;
            // 
            // uiLabel21
            // 
            this.uiLabel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uiLabel21.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel21.Location = new System.Drawing.Point(12, 45);
            this.uiLabel21.Name = "uiLabel21";
            this.uiLabel21.Size = new System.Drawing.Size(59, 68);
            this.uiLabel21.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel21.TabIndex = 18;
            this.uiLabel21.Text = "X";
            this.uiLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ASpeed
            // 
            this.lb_ASpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.lb_ASpeed.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_ASpeed.Location = new System.Drawing.Point(86, 123);
            this.lb_ASpeed.Name = "lb_ASpeed";
            this.lb_ASpeed.Size = new System.Drawing.Size(259, 68);
            this.lb_ASpeed.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.lb_ASpeed.TabIndex = 25;
            this.lb_ASpeed.Text = "99999.99";
            this.lb_ASpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel27
            // 
            this.uiLabel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uiLabel27.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel27.Location = new System.Drawing.Point(12, 123);
            this.uiLabel27.Name = "uiLabel27";
            this.uiLabel27.Size = new System.Drawing.Size(59, 68);
            this.uiLabel27.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel27.TabIndex = 21;
            this.uiLabel27.Text = "A";
            this.uiLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Xspeed
            // 
            this.lb_Xspeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.lb_Xspeed.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Xspeed.Location = new System.Drawing.Point(86, 45);
            this.lb_Xspeed.Name = "lb_Xspeed";
            this.lb_Xspeed.Size = new System.Drawing.Size(259, 68);
            this.lb_Xspeed.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.lb_Xspeed.TabIndex = 22;
            this.lb_Xspeed.Text = "99999.99";
            this.lb_Xspeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_XPos
            // 
            this.lb_XPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.lb_XPos.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_XPos.Location = new System.Drawing.Point(86, 45);
            this.lb_XPos.Name = "lb_XPos";
            this.lb_XPos.Size = new System.Drawing.Size(259, 68);
            this.lb_XPos.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.lb_XPos.TabIndex = 22;
            this.lb_XPos.Text = "99999.99";
            this.lb_XPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel16
            // 
            this.uiLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uiLabel16.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel16.Location = new System.Drawing.Point(12, 123);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(59, 68);
            this.uiLabel16.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel16.TabIndex = 21;
            this.uiLabel16.Text = "A";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Apos
            // 
            this.lb_Apos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.lb_Apos.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Apos.Location = new System.Drawing.Point(86, 123);
            this.lb_Apos.Name = "lb_Apos";
            this.lb_Apos.Size = new System.Drawing.Size(259, 68);
            this.lb_Apos.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.lb_Apos.TabIndex = 25;
            this.lb_Apos.Text = "99999.99";
            this.lb_Apos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel13
            // 
            this.uiLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(12, 45);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(59, 68);
            this.uiLabel13.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel13.TabIndex = 18;
            this.uiLabel13.Text = "X";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 实际位置
            // 
            this.实际位置.Controls.Add(this.uiLabel13);
            this.实际位置.Controls.Add(this.lb_Apos);
            this.实际位置.Controls.Add(this.uiLabel16);
            this.实际位置.Controls.Add(this.lb_XPos);
            this.实际位置.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.实际位置.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.实际位置.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.实际位置.Location = new System.Drawing.Point(4, 15);
            this.实际位置.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.实际位置.MinimumSize = new System.Drawing.Size(1, 1);
            this.实际位置.Name = "实际位置";
            this.实际位置.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.实际位置.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.实际位置.Size = new System.Drawing.Size(362, 212);
            this.实际位置.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.实际位置.TabIndex = 48;
            this.实际位置.Text = "绝对坐标";
            this.实际位置.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.实际位置.TitleColor = System.Drawing.Color.Silver;
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.RotEnable);
            this.uiTitlePanel2.Controls.Add(this.RotEnable_switch);
            this.uiTitlePanel2.Controls.Add(this.uiLabel15);
            this.uiTitlePanel2.Controls.Add(this.uiLabel14);
            this.uiTitlePanel2.Controls.Add(this.enable_CCW);
            this.uiTitlePanel2.Controls.Add(this.input_LineSpeed);
            this.uiTitlePanel2.Controls.Add(this.input_PartRadius);
            this.uiTitlePanel2.Controls.Add(this.uiLabel17);
            this.uiTitlePanel2.Controls.Add(this.input_rotateSpeed);
            this.uiTitlePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiTitlePanel2.Location = new System.Drawing.Point(812, 15);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiTitlePanel2.Size = new System.Drawing.Size(305, 270);
            this.uiTitlePanel2.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiTitlePanel2.TabIndex = 136;
            this.uiTitlePanel2.Text = "回转轴参数";
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.Silver;
            // 
            // RotEnable
            // 
            this.RotEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RotEnable.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RotEnable.Image = global::LaserSolution.Properties.Resources.矩形绿色;
            this.RotEnable.Location = new System.Drawing.Point(132, 195);
            this.RotEnable.Name = "RotEnable";
            this.RotEnable.Size = new System.Drawing.Size(29, 70);
            this.RotEnable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RotEnable.TabIndex = 61;
            this.RotEnable.TabStop = false;
            this.RotEnable.Text = null;
            // 
            // RotEnable_switch
            // 
            this.RotEnable_switch.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.RotEnable_switch.ActiveText = "运行";
            this.RotEnable_switch.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RotEnable_switch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.RotEnable_switch.InActiveText = "停止";
            this.RotEnable_switch.Location = new System.Drawing.Point(17, 195);
            this.RotEnable_switch.MinimumSize = new System.Drawing.Size(1, 1);
            this.RotEnable_switch.Name = "RotEnable_switch";
            this.RotEnable_switch.Size = new System.Drawing.Size(119, 70);
            this.RotEnable_switch.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.RotEnable_switch.SwitchShape = Sunny.UI.UISwitch.UISwitchShape.Square;
            this.RotEnable_switch.TabIndex = 62;
            this.RotEnable_switch.Text = "uiSwitch1";
            // 
            // uiLabel15
            // 
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel15.Location = new System.Drawing.Point(13, 146);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(132, 39);
            this.uiLabel15.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel15.TabIndex = 36;
            this.uiLabel15.Text = "线速度(mm/s)";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel14.Location = new System.Drawing.Point(13, 40);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(134, 51);
            this.uiLabel14.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel14.TabIndex = 28;
            this.uiLabel14.Text = "旋转半径(mm)";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enable_CCW
            // 
            this.enable_CCW.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.enable_CCW.ActiveText = "顺时针";
            this.enable_CCW.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enable_CCW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.enable_CCW.InActiveText = "逆时针";
            this.enable_CCW.Location = new System.Drawing.Point(165, 194);
            this.enable_CCW.MinimumSize = new System.Drawing.Size(1, 1);
            this.enable_CCW.Name = "enable_CCW";
            this.enable_CCW.Size = new System.Drawing.Size(130, 70);
            this.enable_CCW.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.enable_CCW.SwitchShape = Sunny.UI.UISwitch.UISwitchShape.Square;
            this.enable_CCW.TabIndex = 31;
            this.enable_CCW.Text = "uiSwitch1";
            // 
            // input_LineSpeed
            // 
            this.input_LineSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_LineSpeed.DoubleValue = 100.01D;
            this.input_LineSpeed.FillColor = System.Drawing.Color.White;
            this.input_LineSpeed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.input_LineSpeed.Location = new System.Drawing.Point(166, 146);
            this.input_LineSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_LineSpeed.Maximum = 2147483647D;
            this.input_LineSpeed.Minimum = -2147483648D;
            this.input_LineSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_LineSpeed.Name = "input_LineSpeed";
            this.input_LineSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.input_LineSpeed.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.input_LineSpeed.Size = new System.Drawing.Size(120, 38);
            this.input_LineSpeed.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.input_LineSpeed.TabIndex = 32;
            this.input_LineSpeed.Text = "100.01";
            this.input_LineSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_PartRadius
            // 
            this.input_PartRadius.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_PartRadius.FillColor = System.Drawing.Color.White;
            this.input_PartRadius.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.input_PartRadius.Location = new System.Drawing.Point(166, 42);
            this.input_PartRadius.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_PartRadius.Maximum = 2147483647D;
            this.input_PartRadius.Minimum = -2147483648D;
            this.input_PartRadius.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_PartRadius.Name = "input_PartRadius";
            this.input_PartRadius.Padding = new System.Windows.Forms.Padding(5);
            this.input_PartRadius.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.input_PartRadius.Size = new System.Drawing.Size(120, 38);
            this.input_PartRadius.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.input_PartRadius.TabIndex = 29;
            this.input_PartRadius.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel17
            // 
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel17.Location = new System.Drawing.Point(13, 94);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(134, 39);
            this.uiLabel17.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel17.TabIndex = 33;
            this.uiLabel17.Text = "旋转角速度(°/s)";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_rotateSpeed
            // 
            this.input_rotateSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_rotateSpeed.DoubleValue = 100.01D;
            this.input_rotateSpeed.FillColor = System.Drawing.Color.White;
            this.input_rotateSpeed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.input_rotateSpeed.Location = new System.Drawing.Point(166, 94);
            this.input_rotateSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_rotateSpeed.Maximum = 2147483647D;
            this.input_rotateSpeed.Minimum = -2147483648D;
            this.input_rotateSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_rotateSpeed.Name = "input_rotateSpeed";
            this.input_rotateSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.input_rotateSpeed.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.input_rotateSpeed.Size = new System.Drawing.Size(120, 38);
            this.input_rotateSpeed.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.input_rotateSpeed.TabIndex = 30;
            this.input_rotateSpeed.Text = "100.01";
            this.input_rotateSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Operate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 700);
            this.Controls.Add(this.uiLabel10);
            this.Name = "Frm_Operate";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.Text = "机床操作";
            this.Controls.SetChildIndex(this.uiLabel10, 0);
            this.Controls.SetChildIndex(this.PagePanel, 0);
            this.PagePanel.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.实际位置.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RotEnable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UILabel uiLabel1;
        private PCHMI.面板 y;
        private PCHMI.数据显示器 数据显示器1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIMarkLabel uiMarkLabel6;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UISymbolButton sbtn_F2;
        private Sunny.UI.UISymbolButton sbtn_F1;
        private Sunny.UI.UISymbolButton sbtn_Next;
        private Sunny.UI.UISymbolButton sbtn_F6;
        private Sunny.UI.UISymbolButton sbtn_F7;
        private Sunny.UI.UISymbolButton sbtn_F5;
        private Sunny.UI.UISymbolButton sbtn_F4;
        private Sunny.UI.UISymbolButton sbtn_F3;
        private Sunny.UI.UISymbolButton sbtn_Pre;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UILabel uiLabel21;
        private Sunny.UI.UILabel lb_ASpeed;
        private Sunny.UI.UILabel uiLabel27;
        private Sunny.UI.UILabel lb_Xspeed;
        private Sunny.UI.UITitlePanel 实际位置;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel lb_Apos;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UILabel lb_XPos;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UIImageButton RotEnable;
        private Sunny.UI.UISwitch RotEnable_switch;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UISwitch enable_CCW;
        private Sunny.UI.UITextBox input_LineSpeed;
        private Sunny.UI.UITextBox input_PartRadius;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UITextBox input_rotateSpeed;
    }
}

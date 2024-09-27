
namespace LaserSolution
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel6 = new Sunny.UI.UIMarkLabel();
            this.btn_Diagnosis = new Sunny.UI.UISymbolButton();
            this.btn_Processing = new Sunny.UI.UISymbolButton();
            this.btn_Program = new Sunny.UI.UISymbolButton();
            this.btn_Operate = new Sunny.UI.UISymbolButton();
            this.btn_Production = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel4 = new Sunny.UI.UIMarkLabel();
            this.sbtn_Pre = new Sunny.UI.UISymbolButton();
            this.sbtn_F3 = new Sunny.UI.UISymbolButton();
            this.sbtn_F4 = new Sunny.UI.UISymbolButton();
            this.sbtn_F5 = new Sunny.UI.UISymbolButton();
            this.sbtn_S7 = new Sunny.UI.UISymbolButton();
            this.sbtn_F6 = new Sunny.UI.UISymbolButton();
            this.sbtn_Next = new Sunny.UI.UISymbolButton();
            this.sbtn_F1 = new Sunny.UI.UISymbolButton();
            this.sbtn_F2 = new Sunny.UI.UISymbolButton();
            this.lb_LaserPower = new Sunny.UI.UISymbolLabel();
            this.lb_SpeedRatio = new Sunny.UI.UISymbolLabel();
            this.lb_programName = new Sunny.UI.UISymbolLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.x_message = new Sunny.UI.UIScrollingText();
            this.timer_comunicate = new System.Windows.Forms.Timer(this.components);
            this.lb_SpeedT = new Sunny.UI.UISymbolLabel();
            this.ico_SystemOK = new Sunny.UI.UIImageButton();
            this.ico_Warnning = new Sunny.UI.UIImageButton();
            this.ico_Error = new Sunny.UI.UIImageButton();
            this.ico_MotorFault = new Sunny.UI.UIImageButton();
            this.ico_comunicatOK = new Sunny.UI.UIImageButton();
            this.ico_ComunicatError = new Sunny.UI.UIImageButton();
            this.ico_PowderRunning = new Sunny.UI.UIImageButton();
            this.ico_PowderError = new Sunny.UI.UIImageButton();
            this.ico_LaserError = new Sunny.UI.UIImageButton();
            this.ico_GuideON = new Sunny.UI.UIImageButton();
            this.ico_LaserON = new Sunny.UI.UIImageButton();
            this.ico_AUTO = new Sunny.UI.UIImageButton();
            this.ico_Manual = new Sunny.UI.UIImageButton();
            this.ico_InstrType = new Sunny.UI.UIImageButton();
            this.ico_Pause = new Sunny.UI.UIImageButton();
            this.ico_RUNNING = new Sunny.UI.UIImageButton();
            this.ico_Estop = new Sunny.UI.UIImageButton();
            this.imglogo = new Sunny.UI.UIImageButton();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico_SystemOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Warnning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_MotorFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_comunicatOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_ComunicatError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_PowderRunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_PowderError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_LaserError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_GuideON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_LaserON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_AUTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Manual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_InstrType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_RUNNING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Estop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.Footer.Location = new System.Drawing.Point(0, 849);
            this.Footer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.Footer.Size = new System.Drawing.Size(1280, 1);
            this.Footer.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.lb_SpeedT);
            this.Header.Controls.Add(this.x_message);
            this.Header.Controls.Add(this.lb_programName);
            this.Header.Controls.Add(this.lb_SpeedRatio);
            this.Header.Controls.Add(this.lb_LaserPower);
            this.Header.Controls.Add(this.uiMarkLabel4);
            this.Header.Controls.Add(this.ico_SystemOK);
            this.Header.Controls.Add(this.ico_Warnning);
            this.Header.Controls.Add(this.ico_Error);
            this.Header.Controls.Add(this.ico_MotorFault);
            this.Header.Controls.Add(this.uiMarkLabel1);
            this.Header.Controls.Add(this.uiMarkLabel6);
            this.Header.Controls.Add(this.ico_comunicatOK);
            this.Header.Controls.Add(this.ico_ComunicatError);
            this.Header.Controls.Add(this.ico_PowderRunning);
            this.Header.Controls.Add(this.ico_PowderError);
            this.Header.Controls.Add(this.ico_LaserError);
            this.Header.Controls.Add(this.ico_GuideON);
            this.Header.Controls.Add(this.ico_LaserON);
            this.Header.Controls.Add(this.ico_AUTO);
            this.Header.Controls.Add(this.ico_Manual);
            this.Header.Controls.Add(this.ico_InstrType);
            this.Header.Controls.Add(this.ico_Pause);
            this.Header.Controls.Add(this.ico_RUNNING);
            this.Header.Controls.Add(this.ico_Estop);
            this.Header.Controls.Add(this.uiLabel1);
            this.Header.Controls.Add(this.imglogo);
            this.Header.Margin = new System.Windows.Forms.Padding(1);
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Padding = new System.Windows.Forms.Padding(3);
            this.Header.Size = new System.Drawing.Size(1280, 100);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.StyleCustomMode = true;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(104, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(109, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 42;
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(389, 0);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiMarkLabel1.MarkSize = 1;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(3, 100);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 65;
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel6
            // 
            this.uiMarkLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiMarkLabel6.Location = new System.Drawing.Point(207, 0);
            this.uiMarkLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.uiMarkLabel6.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiMarkLabel6.MarkSize = 1;
            this.uiMarkLabel6.Name = "uiMarkLabel6";
            this.uiMarkLabel6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.uiMarkLabel6.Size = new System.Drawing.Size(3, 100);
            this.uiMarkLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel6.TabIndex = 64;
            this.uiMarkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Diagnosis
            // 
            this.btn_Diagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Diagnosis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btn_Diagnosis.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.btn_Diagnosis.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Diagnosis.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Diagnosis.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Diagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Diagnosis.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Diagnosis.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Diagnosis.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Diagnosis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Diagnosis.Location = new System.Drawing.Point(5, 503);
            this.btn_Diagnosis.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Diagnosis.Name = "btn_Diagnosis";
            this.btn_Diagnosis.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_Diagnosis.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.btn_Diagnosis.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.btn_Diagnosis.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Diagnosis.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Diagnosis.Size = new System.Drawing.Size(142, 96);
            this.btn_Diagnosis.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Diagnosis.StyleCustomMode = true;
            this.btn_Diagnosis.Symbol = 61680;
            this.btn_Diagnosis.SymbolSize = 60;
            this.btn_Diagnosis.TabIndex = 68;
            this.btn_Diagnosis.Text = "诊断信息";
            this.btn_Diagnosis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Processing
            // 
            this.btn_Processing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Processing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btn_Processing.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.btn_Processing.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Processing.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Processing.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Processing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Processing.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Processing.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Processing.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Processing.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Processing.Location = new System.Drawing.Point(5, 404);
            this.btn_Processing.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Processing.Name = "btn_Processing";
            this.btn_Processing.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_Processing.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.btn_Processing.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.btn_Processing.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Processing.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Processing.Size = new System.Drawing.Size(142, 96);
            this.btn_Processing.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Processing.StyleCustomMode = true;
            this.btn_Processing.Symbol = 61450;
            this.btn_Processing.SymbolSize = 60;
            this.btn_Processing.TabIndex = 67;
            this.btn_Processing.Text = "标准工艺";
            this.btn_Processing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Program
            // 
            this.btn_Program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Program.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btn_Program.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.btn_Program.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Program.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Program.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Program.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Program.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Program.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Program.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Program.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Program.Location = new System.Drawing.Point(5, 305);
            this.btn_Program.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Program.Name = "btn_Program";
            this.btn_Program.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_Program.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.btn_Program.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.btn_Program.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Program.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Program.Size = new System.Drawing.Size(142, 96);
            this.btn_Program.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Program.StyleCustomMode = true;
            this.btn_Program.Symbol = 61897;
            this.btn_Program.SymbolSize = 60;
            this.btn_Program.TabIndex = 66;
            this.btn_Program.Text = "编程调试";
            this.btn_Program.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Operate
            // 
            this.btn_Operate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Operate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Operate.FillColor = System.Drawing.Color.White;
            this.btn_Operate.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.btn_Operate.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Operate.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Operate.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Operate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Operate.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Operate.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Operate.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Operate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Operate.Location = new System.Drawing.Point(5, 107);
            this.btn_Operate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Operate.Name = "btn_Operate";
            this.btn_Operate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_Operate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.btn_Operate.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.btn_Operate.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Operate.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Operate.Size = new System.Drawing.Size(142, 96);
            this.btn_Operate.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Operate.StyleCustomMode = true;
            this.btn_Operate.Symbol = 61473;
            this.btn_Operate.SymbolSize = 60;
            this.btn_Operate.TabIndex = 65;
            this.btn_Operate.Text = "机床操作";
            this.btn_Operate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Production
            // 
            this.btn_Production.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Production.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btn_Production.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.btn_Production.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Production.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Production.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Production.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Production.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Production.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Production.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Production.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Production.Location = new System.Drawing.Point(5, 206);
            this.btn_Production.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Production.Name = "btn_Production";
            this.btn_Production.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_Production.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.btn_Production.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.btn_Production.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Production.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Production.Size = new System.Drawing.Size(142, 96);
            this.btn_Production.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Production.StyleCustomMode = true;
            this.btn_Production.Symbol = 61568;
            this.btn_Production.SymbolSize = 60;
            this.btn_Production.TabIndex = 64;
            this.btn_Production.Text = "生产页面";
            this.btn_Production.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // uiMarkLabel4
            // 
            this.uiMarkLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiMarkLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel4.Location = new System.Drawing.Point(492, 50);
            this.uiMarkLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.uiMarkLabel4.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiMarkLabel4.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel4.MarkSize = 1;
            this.uiMarkLabel4.Name = "uiMarkLabel4";
            this.uiMarkLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel4.Size = new System.Drawing.Size(788, 3);
            this.uiMarkLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel4.TabIndex = 70;
            this.uiMarkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sbtn_Pre.Location = new System.Drawing.Point(11, 3);
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
            this.sbtn_Pre.TabIndex = 0;
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
            this.sbtn_F3.Location = new System.Drawing.Point(370, 3);
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
            this.sbtn_F3.TabIndex = 1;
            this.sbtn_F3.Text = "F3";
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
            this.sbtn_F4.Location = new System.Drawing.Point(505, 3);
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
            this.sbtn_F4.TabIndex = 2;
            this.sbtn_F4.Text = "RESET";
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
            this.sbtn_F5.Location = new System.Drawing.Point(640, 3);
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
            this.sbtn_F5.TabIndex = 3;
            this.sbtn_F5.Text = "F5";
            // 
            // sbtn_S7
            // 
            this.sbtn_S7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtn_S7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sbtn_S7.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sbtn_S7.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_S7.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sbtn_S7.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_S7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_S7.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_S7.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_S7.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sbtn_S7.Location = new System.Drawing.Point(910, 3);
            this.sbtn_S7.MinimumSize = new System.Drawing.Size(1, 1);
            this.sbtn_S7.Name = "sbtn_S7";
            this.sbtn_S7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sbtn_S7.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sbtn_S7.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_S7.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sbtn_S7.Size = new System.Drawing.Size(126, 74);
            this.sbtn_S7.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sbtn_S7.Symbol = 61641;
            this.sbtn_S7.SymbolSize = 0;
            this.sbtn_S7.TabIndex = 4;
            this.sbtn_S7.Text = "F7";
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
            this.sbtn_F6.Location = new System.Drawing.Point(775, 3);
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
            this.sbtn_F6.TabIndex = 5;
            this.sbtn_F6.Text = "F6";
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
            this.sbtn_Next.Location = new System.Drawing.Point(1045, 3);
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
            this.sbtn_Next.TabIndex = 6;
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
            this.sbtn_F1.Location = new System.Drawing.Point(100, 3);
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
            this.sbtn_F1.TabIndex = 7;
            this.sbtn_F1.Text = "F1";
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
            this.sbtn_F2.Location = new System.Drawing.Point(235, 3);
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
            this.sbtn_F2.TabIndex = 8;
            this.sbtn_F2.Text = "F2";
            // 
            // lb_LaserPower
            // 
            this.lb_LaserPower.BackColor = System.Drawing.Color.White;
            this.lb_LaserPower.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lb_LaserPower.Location = new System.Drawing.Point(209, 0);
            this.lb_LaserPower.Margin = new System.Windows.Forms.Padding(0);
            this.lb_LaserPower.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_LaserPower.Name = "lb_LaserPower";
            this.lb_LaserPower.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lb_LaserPower.Size = new System.Drawing.Size(72, 33);
            this.lb_LaserPower.Style = Sunny.UI.UIStyle.Custom;
            this.lb_LaserPower.Symbol = 61953;
            this.lb_LaserPower.SymbolOffset = new System.Drawing.Point(-100, 0);
            this.lb_LaserPower.SymbolSize = 0;
            this.lb_LaserPower.TabIndex = 71;
            this.lb_LaserPower.Text = "6000瓦";
            this.lb_LaserPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_SpeedRatio
            // 
            this.lb_SpeedRatio.BackColor = System.Drawing.Color.Silver;
            this.lb_SpeedRatio.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SpeedRatio.Location = new System.Drawing.Point(208, 33);
            this.lb_SpeedRatio.Margin = new System.Windows.Forms.Padding(0);
            this.lb_SpeedRatio.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_SpeedRatio.Name = "lb_SpeedRatio";
            this.lb_SpeedRatio.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lb_SpeedRatio.Size = new System.Drawing.Size(180, 33);
            this.lb_SpeedRatio.Style = Sunny.UI.UIStyle.Custom;
            this.lb_SpeedRatio.Symbol = 61668;
            this.lb_SpeedRatio.SymbolSize = 36;
            this.lb_SpeedRatio.TabIndex = 72;
            this.lb_SpeedRatio.Text = "100%";
            this.lb_SpeedRatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_programName
            // 
            this.lb_programName.BackColor = System.Drawing.Color.White;
            this.lb_programName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_programName.Location = new System.Drawing.Point(209, 66);
            this.lb_programName.Margin = new System.Windows.Forms.Padding(0);
            this.lb_programName.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_programName.Name = "lb_programName";
            this.lb_programName.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lb_programName.Size = new System.Drawing.Size(180, 33);
            this.lb_programName.Style = Sunny.UI.UIStyle.Custom;
            this.lb_programName.Symbol = 61892;
            this.lb_programName.SymbolSize = 36;
            this.lb_programName.TabIndex = 73;
            this.lb_programName.Text = "程序名";
            this.lb_programName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiStyleManager1
            // 
            this.uiStyleManager1.Style = Sunny.UI.UIStyle.Office2010Silver;
            // 
            // x_message
            // 
            this.x_message.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.x_message.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.x_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.x_message.Location = new System.Drawing.Point(494, 55);
            this.x_message.MinimumSize = new System.Drawing.Size(1, 1);
            this.x_message.Name = "x_message";
            this.x_message.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.x_message.Size = new System.Drawing.Size(780, 43);
            this.x_message.Style = Sunny.UI.UIStyle.Custom;
            this.x_message.TabIndex = 79;
            this.x_message.Text = "Message";
            // 
            // timer_comunicate
            // 
            this.timer_comunicate.Interval = 10;
            this.timer_comunicate.Tick += new System.EventHandler(this.timer_comunicate_Tick);
            // 
            // lb_SpeedT
            // 
            this.lb_SpeedT.BackColor = System.Drawing.Color.White;
            this.lb_SpeedT.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SpeedT.Location = new System.Drawing.Point(281, -1);
            this.lb_SpeedT.Margin = new System.Windows.Forms.Padding(0);
            this.lb_SpeedT.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_SpeedT.Name = "lb_SpeedT";
            this.lb_SpeedT.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lb_SpeedT.Size = new System.Drawing.Size(105, 33);
            this.lb_SpeedT.Style = Sunny.UI.UIStyle.Custom;
            this.lb_SpeedT.Symbol = 61668;
            this.lb_SpeedT.SymbolOffset = new System.Drawing.Point(-100, 0);
            this.lb_SpeedT.SymbolSize = 0;
            this.lb_SpeedT.TabIndex = 80;
            this.lb_SpeedT.Text = "100mm/s";
            this.lb_SpeedT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ico_SystemOK
            // 
            this.ico_SystemOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_SystemOK.Enabled = false;
            this.ico_SystemOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_SystemOK.Image = global::LaserSolution.Properties.Resources.对;
            this.ico_SystemOK.Location = new System.Drawing.Point(1229, 5);
            this.ico_SystemOK.Name = "ico_SystemOK";
            this.ico_SystemOK.Size = new System.Drawing.Size(45, 45);
            this.ico_SystemOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_SystemOK.TabIndex = 69;
            this.ico_SystemOK.TabStop = false;
            this.ico_SystemOK.Text = null;
            // 
            // ico_Warnning
            // 
            this.ico_Warnning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_Warnning.Enabled = false;
            this.ico_Warnning.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_Warnning.Image = global::LaserSolution.Properties.Resources.警告信号l;
            this.ico_Warnning.Location = new System.Drawing.Point(1180, 5);
            this.ico_Warnning.Name = "ico_Warnning";
            this.ico_Warnning.Size = new System.Drawing.Size(45, 45);
            this.ico_Warnning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_Warnning.TabIndex = 68;
            this.ico_Warnning.TabStop = false;
            this.ico_Warnning.Text = null;
            // 
            // ico_Error
            // 
            this.ico_Error.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_Error.Enabled = false;
            this.ico_Error.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ico_Error.ForeColor = System.Drawing.Color.Black;
            this.ico_Error.Image = global::LaserSolution.Properties.Resources.报错;
            this.ico_Error.Location = new System.Drawing.Point(1082, 5);
            this.ico_Error.Name = "ico_Error";
            this.ico_Error.Size = new System.Drawing.Size(45, 45);
            this.ico_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_Error.TabIndex = 67;
            this.ico_Error.TabStop = false;
            this.ico_Error.Text = null;
            this.ico_Error.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ico_MotorFault
            // 
            this.ico_MotorFault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_MotorFault.Enabled = false;
            this.ico_MotorFault.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_MotorFault.Image = ((System.Drawing.Image)(resources.GetObject("ico_MotorFault.Image")));
            this.ico_MotorFault.Location = new System.Drawing.Point(1131, 5);
            this.ico_MotorFault.Name = "ico_MotorFault";
            this.ico_MotorFault.Size = new System.Drawing.Size(45, 45);
            this.ico_MotorFault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_MotorFault.TabIndex = 66;
            this.ico_MotorFault.TabStop = false;
            this.ico_MotorFault.Text = null;
            // 
            // ico_comunicatOK
            // 
            this.ico_comunicatOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_comunicatOK.Enabled = false;
            this.ico_comunicatOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_comunicatOK.Image = global::LaserSolution.Properties.Resources.连接green;
            this.ico_comunicatOK.Location = new System.Drawing.Point(1033, 5);
            this.ico_comunicatOK.Name = "ico_comunicatOK";
            this.ico_comunicatOK.Size = new System.Drawing.Size(45, 45);
            this.ico_comunicatOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_comunicatOK.TabIndex = 61;
            this.ico_comunicatOK.TabStop = false;
            this.ico_comunicatOK.Text = null;
            this.ico_comunicatOK.Visible = false;
            // 
            // ico_ComunicatError
            // 
            this.ico_ComunicatError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_ComunicatError.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_ComunicatError.Image = global::LaserSolution.Properties.Resources.连接red;
            this.ico_ComunicatError.Location = new System.Drawing.Point(984, 5);
            this.ico_ComunicatError.Name = "ico_ComunicatError";
            this.ico_ComunicatError.Size = new System.Drawing.Size(45, 45);
            this.ico_ComunicatError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_ComunicatError.TabIndex = 58;
            this.ico_ComunicatError.TabStop = false;
            this.ico_ComunicatError.Text = null;
            this.ico_ComunicatError.Click += new System.EventHandler(this.ico_ComunicatError_Click);
            this.ico_ComunicatError.MouseHover += new System.EventHandler(this.ico_ComunicatError_MouseHover);
            // 
            // ico_PowderRunning
            // 
            this.ico_PowderRunning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_PowderRunning.Enabled = false;
            this.ico_PowderRunning.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_PowderRunning.Image = global::LaserSolution.Properties.Resources.送粉中;
            this.ico_PowderRunning.Location = new System.Drawing.Point(935, 5);
            this.ico_PowderRunning.Name = "ico_PowderRunning";
            this.ico_PowderRunning.Size = new System.Drawing.Size(45, 45);
            this.ico_PowderRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_PowderRunning.TabIndex = 57;
            this.ico_PowderRunning.TabStop = false;
            this.ico_PowderRunning.Text = null;
            // 
            // ico_PowderError
            // 
            this.ico_PowderError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_PowderError.Enabled = false;
            this.ico_PowderError.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_PowderError.Image = global::LaserSolution.Properties.Resources.送粉异常;
            this.ico_PowderError.Location = new System.Drawing.Point(886, 5);
            this.ico_PowderError.Name = "ico_PowderError";
            this.ico_PowderError.Size = new System.Drawing.Size(45, 45);
            this.ico_PowderError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_PowderError.TabIndex = 56;
            this.ico_PowderError.TabStop = false;
            this.ico_PowderError.Text = null;
            // 
            // ico_LaserError
            // 
            this.ico_LaserError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_LaserError.Enabled = false;
            this.ico_LaserError.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_LaserError.Image = global::LaserSolution.Properties.Resources.激光报警1;
            this.ico_LaserError.Location = new System.Drawing.Point(837, 5);
            this.ico_LaserError.Name = "ico_LaserError";
            this.ico_LaserError.Size = new System.Drawing.Size(45, 45);
            this.ico_LaserError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_LaserError.TabIndex = 55;
            this.ico_LaserError.TabStop = false;
            this.ico_LaserError.Text = null;
            // 
            // ico_GuideON
            // 
            this.ico_GuideON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_GuideON.Enabled = false;
            this.ico_GuideON.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_GuideON.Image = global::LaserSolution.Properties.Resources.指引红光;
            this.ico_GuideON.Location = new System.Drawing.Point(788, 5);
            this.ico_GuideON.Name = "ico_GuideON";
            this.ico_GuideON.Size = new System.Drawing.Size(45, 45);
            this.ico_GuideON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_GuideON.TabIndex = 54;
            this.ico_GuideON.TabStop = false;
            this.ico_GuideON.Text = null;
            // 
            // ico_LaserON
            // 
            this.ico_LaserON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_LaserON.Enabled = false;
            this.ico_LaserON.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_LaserON.Image = global::LaserSolution.Properties.Resources.激光yello;
            this.ico_LaserON.Location = new System.Drawing.Point(739, 5);
            this.ico_LaserON.Name = "ico_LaserON";
            this.ico_LaserON.Size = new System.Drawing.Size(45, 45);
            this.ico_LaserON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_LaserON.TabIndex = 53;
            this.ico_LaserON.TabStop = false;
            this.ico_LaserON.Text = null;
            // 
            // ico_AUTO
            // 
            this.ico_AUTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_AUTO.Enabled = false;
            this.ico_AUTO.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_AUTO.Image = global::LaserSolution.Properties.Resources.自动对应;
            this.ico_AUTO.Location = new System.Drawing.Point(690, 5);
            this.ico_AUTO.Name = "ico_AUTO";
            this.ico_AUTO.Size = new System.Drawing.Size(45, 45);
            this.ico_AUTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_AUTO.TabIndex = 52;
            this.ico_AUTO.TabStop = false;
            this.ico_AUTO.Text = null;
            // 
            // ico_Manual
            // 
            this.ico_Manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_Manual.Enabled = false;
            this.ico_Manual.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_Manual.Image = global::LaserSolution.Properties.Resources.手动1;
            this.ico_Manual.Location = new System.Drawing.Point(641, 5);
            this.ico_Manual.Name = "ico_Manual";
            this.ico_Manual.Size = new System.Drawing.Size(45, 45);
            this.ico_Manual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_Manual.TabIndex = 51;
            this.ico_Manual.TabStop = false;
            this.ico_Manual.Text = null;
            // 
            // ico_InstrType
            // 
            this.ico_InstrType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_InstrType.Enabled = false;
            this.ico_InstrType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_InstrType.Image = global::LaserSolution.Properties.Resources.轴类;
            this.ico_InstrType.Location = new System.Drawing.Point(394, 3);
            this.ico_InstrType.Name = "ico_InstrType";
            this.ico_InstrType.Size = new System.Drawing.Size(95, 95);
            this.ico_InstrType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_InstrType.TabIndex = 50;
            this.ico_InstrType.TabStop = false;
            this.ico_InstrType.Text = null;
            // 
            // ico_Pause
            // 
            this.ico_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_Pause.Enabled = false;
            this.ico_Pause.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_Pause.Image = global::LaserSolution.Properties.Resources.暂停;
            this.ico_Pause.Location = new System.Drawing.Point(543, 5);
            this.ico_Pause.Name = "ico_Pause";
            this.ico_Pause.Size = new System.Drawing.Size(45, 45);
            this.ico_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_Pause.TabIndex = 49;
            this.ico_Pause.TabStop = false;
            this.ico_Pause.Text = null;
            // 
            // ico_RUNNING
            // 
            this.ico_RUNNING.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_RUNNING.Enabled = false;
            this.ico_RUNNING.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_RUNNING.Image = global::LaserSolution.Properties.Resources.播放;
            this.ico_RUNNING.Location = new System.Drawing.Point(494, 5);
            this.ico_RUNNING.Name = "ico_RUNNING";
            this.ico_RUNNING.Size = new System.Drawing.Size(45, 45);
            this.ico_RUNNING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_RUNNING.TabIndex = 48;
            this.ico_RUNNING.TabStop = false;
            this.ico_RUNNING.Text = null;
            // 
            // ico_Estop
            // 
            this.ico_Estop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ico_Estop.Enabled = false;
            this.ico_Estop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ico_Estop.Image = global::LaserSolution.Properties.Resources.急停;
            this.ico_Estop.Location = new System.Drawing.Point(592, 5);
            this.ico_Estop.Name = "ico_Estop";
            this.ico_Estop.Size = new System.Drawing.Size(45, 45);
            this.ico_Estop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_Estop.TabIndex = 47;
            this.ico_Estop.TabStop = false;
            this.ico_Estop.Text = null;
            // 
            // imglogo
            // 
            this.imglogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imglogo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.imglogo.Image = ((System.Drawing.Image)(resources.GetObject("imglogo.Image")));
            this.imglogo.Location = new System.Drawing.Point(8, 5);
            this.imglogo.Name = "imglogo";
            this.imglogo.Size = new System.Drawing.Size(86, 88);
            this.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imglogo.TabIndex = 5;
            this.imglogo.TabStop = false;
            this.imglogo.Text = null;
            this.imglogo.Click += new System.EventHandler(this.imglogo_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 850);
            this.Controls.Add(this.btn_Diagnosis);
            this.Controls.Add(this.btn_Processing);
            this.Controls.Add(this.btn_Program);
            this.Controls.Add(this.btn_Operate);
            this.Controls.Add(this.btn_Production);
            this.Name = "Frm_Main";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "雷克斯激光内孔熔覆专用";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Controls.SetChildIndex(this.Footer, 0);
            this.Controls.SetChildIndex(this.btn_Production, 0);
            this.Controls.SetChildIndex(this.btn_Operate, 0);
            this.Controls.SetChildIndex(this.btn_Program, 0);
            this.Controls.SetChildIndex(this.btn_Processing, 0);
            this.Controls.SetChildIndex(this.btn_Diagnosis, 0);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ico_SystemOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Warnning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_MotorFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_comunicatOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_ComunicatError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_PowderRunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_PowderError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_LaserError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_GuideON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_LaserON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_AUTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Manual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_InstrType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_RUNNING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Estop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIImageButton imglogo;
        private Sunny.UI.UIImageButton ico_comunicatOK;
        private Sunny.UI.UIImageButton ico_ComunicatError;
        private Sunny.UI.UIImageButton ico_PowderRunning;
        private Sunny.UI.UIImageButton ico_PowderError;
        private Sunny.UI.UIImageButton ico_LaserError;
        private Sunny.UI.UIImageButton ico_GuideON;
        private Sunny.UI.UIImageButton ico_LaserON;
        private Sunny.UI.UIImageButton ico_AUTO;
        private Sunny.UI.UIImageButton ico_Manual;
        private Sunny.UI.UIImageButton ico_InstrType;
        private Sunny.UI.UIImageButton ico_Pause;
        private Sunny.UI.UIImageButton ico_RUNNING;
        private Sunny.UI.UIImageButton ico_Estop;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel6;
        private Sunny.UI.UISymbolButton btn_Diagnosis;
        private Sunny.UI.UISymbolButton btn_Processing;
        private Sunny.UI.UISymbolButton btn_Program;
        private Sunny.UI.UISymbolButton btn_Operate;
        private Sunny.UI.UISymbolButton btn_Production;
        private Sunny.UI.UIImageButton ico_SystemOK;
        private Sunny.UI.UIImageButton ico_Warnning;
        private Sunny.UI.UIImageButton ico_Error;
        private Sunny.UI.UIImageButton ico_MotorFault;
        private Sunny.UI.UIMarkLabel uiMarkLabel4;
        private Sunny.UI.UISymbolButton sbtn_F2;
        private Sunny.UI.UISymbolButton sbtn_F1;
        private Sunny.UI.UISymbolButton sbtn_Next;
        private Sunny.UI.UISymbolButton sbtn_F6;
        private Sunny.UI.UISymbolButton sbtn_S7;
        private Sunny.UI.UISymbolButton sbtn_F5;
        private Sunny.UI.UISymbolButton sbtn_F4;
        private Sunny.UI.UISymbolButton sbtn_F3;
        private Sunny.UI.UISymbolButton sbtn_Pre;
        private Sunny.UI.UISymbolLabel lb_programName;
        private Sunny.UI.UISymbolLabel lb_SpeedRatio;
        private Sunny.UI.UISymbolLabel lb_LaserPower;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIStyleManager uiStyleManager1;
        private Sunny.UI.UIScrollingText x_message;
        private System.Windows.Forms.Timer timer_comunicate;
        private Sunny.UI.UISymbolLabel lb_SpeedT;
    }
}
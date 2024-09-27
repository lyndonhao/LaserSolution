namespace LaserSolution
{
    partial class Frm_LoadPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoadPage));
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.uiWaitingBar1 = new Sunny.UI.UIWaitingBar();
            this.txb_Content = new Sunny.UI.UIRichTextBox();
            this.btn_Exit = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton1.Image")));
            this.uiImageButton1.Location = new System.Drawing.Point(11, 12);
            this.uiImageButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(177, 73);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 0;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            // 
            // uiWaitingBar1
            // 
            this.uiWaitingBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiWaitingBar1.Location = new System.Drawing.Point(15, 364);
            this.uiWaitingBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiWaitingBar1.MinimumSize = new System.Drawing.Size(70, 22);
            this.uiWaitingBar1.Name = "uiWaitingBar1";
            this.uiWaitingBar1.Size = new System.Drawing.Size(699, 30);
            this.uiWaitingBar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiWaitingBar1.TabIndex = 1;
            this.uiWaitingBar1.Text = "uiWaitingBar1";
            // 
            // txb_Content
            // 
            this.txb_Content.AutoWordSelection = true;
            this.txb_Content.FillColor = System.Drawing.Color.White;
            this.txb_Content.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Content.Location = new System.Drawing.Point(11, 148);
            this.txb_Content.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txb_Content.MinimumSize = new System.Drawing.Size(1, 1);
            this.txb_Content.Name = "txb_Content";
            this.txb_Content.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txb_Content.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.txb_Content.Size = new System.Drawing.Size(699, 180);
            this.txb_Content.Style = Sunny.UI.UIStyle.Custom;
            this.txb_Content.TabIndex = 2;
            this.txb_Content.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txb_Content.TextChanged += new System.EventHandler(this.txb_Content_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btn_Exit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.btn_Exit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Exit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 22F);
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Exit.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Exit.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Exit.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Exit.Location = new System.Drawing.Point(487, 12);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.btn_Exit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.btn_Exit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Exit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Exit.Size = new System.Drawing.Size(223, 73);
            this.btn_Exit.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Exit.Symbol = 61532;
            this.btn_Exit.SymbolSize = 48;
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.Visible = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.Location = new System.Drawing.Point(193, 21);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(269, 54);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "激光熔覆系统V1.02";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_LoadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 446);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txb_Content);
            this.Controls.Add(this.uiWaitingBar1);
            this.Controls.Add(this.uiImageButton1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_LoadPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_LoadPage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_LoadPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIWaitingBar uiWaitingBar1;
        private Sunny.UI.UIRichTextBox txb_Content;
        private Sunny.UI.UISymbolButton btn_Exit;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}
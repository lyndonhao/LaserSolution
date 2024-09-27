
namespace LaserSolution
{
    partial class test
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btn_Exit = new Sunny.UI.UISymbolButton();
            this.txb_Content = new Sunny.UI.UIRichTextBox();
            this.uiWaitingBar1 = new Sunny.UI.UIWaitingBar();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.btn_Exit);
            this.PagePanel.Controls.Add(this.txb_Content);
            this.PagePanel.Controls.Add(this.uiWaitingBar1);
            this.PagePanel.Controls.Add(this.uiImageButton1);
            this.PagePanel.Size = new System.Drawing.Size(1264, 726);
            this.PagePanel.Style = Sunny.UI.UIStyle.Custom;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(960, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1101, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.Location = new System.Drawing.Point(316, 65);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(269, 55);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "激光熔覆系统V1.02";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_Exit.Location = new System.Drawing.Point(609, 56);
            this.btn_Exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.btn_Exit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.btn_Exit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Exit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.btn_Exit.Size = new System.Drawing.Size(128, 74);
            this.btn_Exit.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Exit.Symbol = 61532;
            this.btn_Exit.SymbolSize = 48;
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.Visible = false;
            // 
            // txb_Content
            // 
            this.txb_Content.AutoWordSelection = true;
            this.txb_Content.FillColor = System.Drawing.Color.White;
            this.txb_Content.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Content.Location = new System.Drawing.Point(134, 193);
            this.txb_Content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Content.MinimumSize = new System.Drawing.Size(1, 1);
            this.txb_Content.Name = "txb_Content";
            this.txb_Content.Padding = new System.Windows.Forms.Padding(2);
            this.txb_Content.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.txb_Content.Size = new System.Drawing.Size(599, 180);
            this.txb_Content.Style = Sunny.UI.UIStyle.Custom;
            this.txb_Content.TabIndex = 7;
            this.txb_Content.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiWaitingBar1
            // 
            this.uiWaitingBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiWaitingBar1.Location = new System.Drawing.Point(134, 381);
            this.uiWaitingBar1.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiWaitingBar1.Name = "uiWaitingBar1";
            this.uiWaitingBar1.Size = new System.Drawing.Size(600, 29);
            this.uiWaitingBar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiWaitingBar1.TabIndex = 6;
            this.uiWaitingBar1.Text = "uiWaitingBar1";
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton1.Image")));
            this.uiImageButton1.Location = new System.Drawing.Point(134, 56);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(176, 74);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 5;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "test";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "YAMING LASER";
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton btn_Exit;
        private Sunny.UI.UIRichTextBox txb_Content;
        private Sunny.UI.UIWaitingBar uiWaitingBar1;
        private Sunny.UI.UIImageButton uiImageButton1;
        private System.Windows.Forms.Timer timer1;
    }
}


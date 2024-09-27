using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sunny.UI;

namespace LaserSolution
{
    public partial class test : UITitlePage
    {
        public test()
        {
            InitializeComponent();

        }

        public class InstrDataType
        {//

            /// <summary>
            /// index of this instr ,start from 0,only move instruct have index ,
            /// </summary>
            public string Column1 { get; set; }
            /// <summary>
            /// status of the instruction .  @ mean now at this position  " "
            /// </summary>
            public string Column2 { get; set; }
            /// <summary>
            /// instruct name ,e.g. 点, 直线  圆弧,等等
            /// </summary>
            public string Column3 { get; set; }
            /// <summary>
            /// param, 参数
            /// </summary>
            public string Column4 { get; set; }

            public override string ToString()
            {
                return Column3 + "  " + Column4;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "Column1");
            dataGridView1.Columns.Add("Column2", "Column2");
            dataGridView1.Columns.Add("Column3", "Column3");
            dataGridView1.Columns.Add("Column4", "Column4");
            List<InstrDataType> datas = new List<InstrDataType>();
            for (int i = 0; i < 3; i++)
            {
                InstrDataType data = new InstrDataType();
                data.Column1 = "Data" + i.ToString("D2");
                data.Column2 = i.Mod(2) == 0 ? "A" : "B";
                data.Column3 = "编辑";
                data.Column4 = "eil" + "[" + i.ToString() + "";
                datas.Add(data);

            }
            dataGridView1.DataSource = datas;
        }
    }
}

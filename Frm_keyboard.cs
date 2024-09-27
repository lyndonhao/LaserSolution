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
namespace LaserSolution
{
    public partial class Frm_keyboard : UIEditForm
    {
        public Frm_keyboard()
        {
            InitializeComponent();
            RefreshKeypboardDisplay(UPPER);
        }
        private  string _Content;
        public string Content
        {
            set { textboxnew.Text = value;
                _Content = value;
            }
            get { return _Content; }
        }
        public bool _bOk;
        public bool bOK
        {
            get { return _bOk; }
        }
        private string _sName;
        public string sName
        {
            set { this.Text = value;
                _sName = value;
            }
        }
   
        private void AddNew(char x_char)
        {
            _Content = _Content + x_char;
            textboxnew.Text = _Content;
 
            
        }
        public bool bComplete = false;
        /// <summary>
        /// 大小写标志符
        /// </summary>
        private bool UPPER = false;
        private void uiButton1_Click(object sender, EventArgs e)
        {
            AddNew('A');
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            AddNew('B');
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            AddNew('C');
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            AddNew('D');
        }
        private void DeleteOne()
        {
            if(_Content.Length>0)
            {
                _Content = _Content.Substring(0, _Content.Length - 1);
                textboxnew.Text = _Content;
            }

        }
        private void uiButton5_Click(object sender, EventArgs e)
        {
            DeleteOne();
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {

        }


        private void bta_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('A');
            }
            else
            {
                AddNew('a');
            }
        }

        private void btb_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('B');
            }
            else
            {
                AddNew('b');
            }
        }

        private void btc_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('C');
            }
            else
            {
                AddNew('c');
            }
        }

        private void btd_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('D');
            }
            else
            {
                AddNew('d');
            }
        }

        private void bte_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('E');
            }
            else
            {
                AddNew('e');
            }
        }

        private void btf_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('F');
            }
            else
            {
                AddNew('f');
            }
        }

        private void btg_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('G');
            }
            else
            {
                AddNew('g');
            }
        }

        private void bth_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('H');
            }
            else
            {
                AddNew('h');
            }
        }

        private void bti_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('I');
            }
            else
            {
                AddNew('i');
            }
        }

        private void btj_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('J');
            }
            else
            {
                AddNew('j');
            }
        }

        private void btk_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('K');
            }
            else
            {
                AddNew('k');
            }
        }

        private void btl_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('L');
            }
            else
            {
                AddNew('l');
            }
        }

        private void btm_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('M');
            }
            else
            {
                AddNew('m');
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('N');
            }
            else
            {
                AddNew('n');
            }
        }

        private void bto_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('O');
            }
            else
            {
                AddNew('o');
            }
        }

        private void btp_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('P');
            }
            else
            {
                AddNew('p');
            }
        }

        private void btq_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('Q');
            }
            else
            {
                AddNew('q');
            }
        }

        private void btr_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('R');
            }
            else
            {
                AddNew('r');
            }
        }

        private void bts_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('S');
            }
            else
            {
                AddNew('s');
            }
        }

        private void btt_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('T');
            }
            else
            {
                AddNew('t');
            }
        }

        private void btu_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('U');
            }
            else
            {
                AddNew('u');
            }
        }

        private void btv_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('V');
            }
            else
            {
                AddNew('v');
            }
        }

        private void btw_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('W');
            }
            else
            {
                AddNew('w');
            }
        }

        private void btx_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('X');
            }
            else
            {
                AddNew('x');
            }
        }

        private void bty_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('Y');
            }
            else
            {
                AddNew('y');
            }
        }

        private void btz_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('Z');
            }
            else
            {
                AddNew('z');
            }
        }

        private void btSym_Click(object sender, EventArgs e)
        {
            if (UPPER)
            {
                AddNew('-');
            }
            else
            {
                AddNew('_');
            }
        }

        private void bt_CAPChange_Click(object sender, EventArgs e)
        {
            UPPER = !UPPER;
            RefreshKeypboardDisplay(UPPER);
        }
        private void RefreshKeypboardDisplay(bool x_bUPPER)
        {
            if (x_bUPPER)
            {
                bta.Text = "A";
                btb.Text = "B";
                btc.Text = "C";
                btd.Text = "D";
                bte.Text = "E";
                btf.Text = "F";
                btg.Text = "G";
                bth.Text = "H";
                bti.Text = "I";
                btj.Text = "J";
                btk.Text = "K";
                btl.Text = "L";
                btm.Text = "M";
                btn.Text = "N";
                bto.Text = "O";
                btp.Text = "P";
                btq.Text = "Q";
                btr.Text = "R";
                bts.Text = "S";
                btt.Text = "T";
                btu.Text = "U";
                btv.Text = "V";
                btw.Text = "W";
                btx.Text = "X";
                bty.Text = "Y";
                btz.Text = "Z";
                bt_CAPChange.Text = "A/a";
                btSym.Text = "-";
            }
            else
            {
                bta.Text = "a";
                btb.Text = "b";
                btc.Text = "c";
                btd.Text = "d";
                bte.Text = "e";
                btf.Text = "f";
                btg.Text = "g";
                bth.Text = "h";
                bti.Text = "i";
                btj.Text = "j";
                btk.Text = "k";
                btl.Text = "l";
                btm.Text = "m";
                btn.Text = "n";
                bto.Text = "o";
                btp.Text = "p";
                btq.Text = "q";
                btr.Text = "r";
                bts.Text = "s";
                btt.Text = "t";
                btu.Text = "u";
                btv.Text = "v";
                btw.Text = "w";
                btx.Text = "x";
                bty.Text = "y";
                btz.Text = "z";
                bt_CAPChange.Text = "a/A";
                btSym.Text = "_";
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            DeleteOne();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            bComplete = true;
            Close();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            AddNew('1');
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            AddNew('2');
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            AddNew('3');
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            AddNew('4');
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            AddNew('5');
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            AddNew('6');
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            AddNew('7');
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            AddNew('8');
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            AddNew('9');
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            AddNew('0');
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            bComplete = false;
  
            Close();
        }
    }
    
}

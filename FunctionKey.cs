
using Sunny.UI;
using System.Drawing;
namespace LaserSolution
{
    class FunctionKey
    {
        UISymbolButton[] FunctionKeys = new UISymbolButton[9];
        FunctionKey(ref UISymbolButton x_Pre, ref UISymbolButton x_F1, ref UISymbolButton x_F2, ref UISymbolButton x_F3, ref UISymbolButton x_F4, 
                             ref UISymbolButton x_F5, ref UISymbolButton x_F6, ref UISymbolButton x_F7, ref UISymbolButton x_FNext)
        {
            FunctionKeys[0] = x_Pre;
            FunctionKeys[1] = x_F1;
            FunctionKeys[2] = x_F2;
            FunctionKeys[3] = x_F3;
            FunctionKeys[4] = x_F4;
            FunctionKeys[5] = x_F5;
            FunctionKeys[6] = x_F6;
            FunctionKeys[7] = x_F7;
            FunctionKeys[8] = x_FNext;
        }
        Color l_Seleted = Color.FromArgb(249, 226, 137);
        Color l_Released = Color.FromArgb(247, 248, 249);
        FunctionKey(bool b_F1, bool b_F2, bool b_F3, bool b_F4, bool b_F5, bool b_F6, bool b_F7) {
            //FunctionKeys[0].Visible = b_F1;
            FunctionKeys[1].Visible = b_F1;
            FunctionKeys[2].Visible = b_F2;
            FunctionKeys[3].Visible = b_F3;
            FunctionKeys[4].Visible = b_F4;
            FunctionKeys[5].Visible = b_F5;
            FunctionKeys[6].Visible = b_F6;
            FunctionKeys[7].Visible = b_F7;
        }
  
    }
}


using Sunny.UI;
using static LaserSolution.GlobalData;
using Tools;
namespace LaserSolution
{
    public partial class Frm_Diagnosis : UITitlePage
    {
        public Frm_Diagnosis()
        {
            InitializeComponent();

            ///init all the io information
            InitIO();
            //timer start
            timer1.Start();
            //pointveiw.DataSourceChanged()
           
        }
        Position position = new Position();
        private void tp_Laser_Click(object sender, System.EventArgs e)
        {

        }


        private void RefreshDisplay()
        {
            position = GetPos();
            ;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

            RefreshDisplay();

        }
        #region  IO MAPPING
        /// <summary>
        /// init all input and output
        /// </summary>
        private void InitIO()
        {
            InitInputs();
            InitOutpus();
        }
        /// <summary>
        /// init input port  define every function
        /// </summary>
        private void InitInputs()
        {

            //input 0  
            Inputs[0].index = 0;
            Inputs[0].name = "";
            Inputs[0].value = false;
            Inputs[0].comment = "";
            Inputs[0].Invert = false;

            //input 1
            Inputs[1].index = 0;
            Inputs[1].name = "";
            Inputs[1].value = false;
            Inputs[1].comment = "";
            Inputs[1].Invert = false;

        }
        private void InitOutpus()
        {
            //output 0

            Outputs[0].index = 0;
            Outputs[0].name = "";
            Outputs[0].value = false;
            Outputs[0].comment = "";
            Outputs[0].Invert = false;
            ;
        }


        #endregion
    }
}

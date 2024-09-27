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
using System.IO;

namespace LaserSolution
{
    public partial class Frm_SelectJob : UIEditForm
    {
        public Frm_SelectJob()
        {
            InitializeComponent();
            GetFileList(_JobsPath);
        }
        private string _JobsPath;
        public string JobsPath
        {
            set { _JobsPath = value; }
            get { return _JobsPath; }
        }
        private string _SelectedJobName;
        public string SelectedJobName
        {
            get { return _SelectedJobName; }
        }
        private bool _OK=false;
        public bool OK
        {
            get { return _OK; }
        }
        
        private void GetFileList(string filepath)
        {
            
            DirectoryInfo di = new DirectoryInfo(filepath);
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo file in fi)
            { JobsList.Items.Add(file.Name); }
           

        }
        int selectedIndex = -1;
        
        private void JobsList_Click(object sender, EventArgs e)
        {
            selectedIndex = JobsList.SelectedIndex;
            lb_selectJobName.Text = JobsList.SelectedItem.ToString();
        }
    }
}

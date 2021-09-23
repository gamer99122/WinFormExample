using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormOpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //資料夾路徑
            string myPath = @"D:\筆記";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }
    }
}

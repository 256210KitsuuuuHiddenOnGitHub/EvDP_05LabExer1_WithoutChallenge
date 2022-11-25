using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvDP_05LabExer2_11242022
{
    public partial class frmFileName : Form
    {
        private String inputText;
        public frmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            //Create Directory
            FileInfo take = new FileInfo(@"D:\"+txtFileName.Text.ToString()+".txt");
            //Open File and Set read and Write Mode
            FileStream thisTxt = take.Open(FileMode.OpenOrCreate,FileAccess.Write,FileShare.Read);
            //Put Text Here
            //not gonna use Flush() for demonstration Purposes, flush uses realtime while write uses desired
            StreamWriter streamMe = new StreamWriter(thisTxt);
            streamMe.Write(inputText);
            streamMe.Close();
        }

        public string doText(String t)
        {
            return inputText = t;
        }

    }
}

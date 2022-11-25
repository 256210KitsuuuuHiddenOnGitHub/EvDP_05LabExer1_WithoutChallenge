namespace EvDP_05LabExer2_11242022
{
    public partial class frmLab1 : Form
    {
        //Create Instantiation
        frmFileName fn = new frmFileName();
        public frmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Show and Put text on another Window
            fn.doText(txtInput.Text.ToString());
            fn.ShowDialog();
        }
    }

}
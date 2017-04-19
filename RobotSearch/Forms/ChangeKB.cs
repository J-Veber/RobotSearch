using System;
using System.Windows.Forms;

namespace RobotSearch.Forms
{
    public partial class ChangeKb : Form
    {
        public Form PrevForm;
        public ChangeKb(Form inputForm)
        {
            PrevForm = inputForm;
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitbtn_toAdminPanel_adm_Click(object sender, EventArgs e)
        {
            PrevForm.Enabled = true;
            this.Close();
        }

        private void splitbtn_toMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Login mainForm = new Login();
            mainForm.Show();
        }
    }
}

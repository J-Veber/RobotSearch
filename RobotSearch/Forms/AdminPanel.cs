using System;
using System.Windows.Forms;

namespace RobotSearch.Forms
{
    public partial class AdminPanel : Form
    {
        public Form MyForm;
        private string _userLogin;
        public AdminPanel(Form inpForm, string userLogin)
        {
            _userLogin = userLogin;
            MyForm = inpForm;
            InitializeComponent();
            tb_AdminName.Text = _userLogin;
            tb_AdminName.Enabled = false;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
        }

        private void button_changeKB_adm_Click(object sender, EventArgs e)
        {
            var changeForm = new ChangeKb(this);
            this.Enabled = false;
            changeForm.Show();
        }

        private void button_createNewUsr_adm_Click(object sender, EventArgs e)
        {
            var createUsrForm = new SpRegistration(this);
            this.Enabled = false;
            createUsrForm.Show();
        }

        private void button_Exit_adm_Click(object sender, EventArgs e)
        {
            MyForm.Enabled = true;
            this.Close();
        }
    }
}

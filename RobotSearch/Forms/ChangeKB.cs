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
            dataGridViewTextBoxColumn1.Width = 55;
            dataGridViewTextBoxColumn2.Width = 75;
            dataGridViewTextBoxColumn3.Width = 135;
            dataGridViewTextBoxColumn4.Width = 80;
            dataGridViewTextBoxColumn5.Width = 75;
            dataGridViewTextBoxColumn6.Width = 110;
            dataGridViewTextBoxColumn7.Width = 110;
            dataGridViewTextBoxColumn8.Width = 107;
            dataGridViewTextBoxColumn9.Width = 100;
            dataGridViewTextBoxColumn10.Width = 70;
            dataGridViewTextBoxColumn11.Width = 132;
            dataGridViewTextBoxColumn12.Width = 110;
            dataGridViewTextBoxColumn13.Width = 100;
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

        private void ChangeKb_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "robot_search_dbDataSet1.robots". При необходимости она может быть перемещена или удалена.
            this.robotsTableAdapter.Fill(this.robot_search_dbDataSet1.robots);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "robot_search_dbDataSet1.robots". При необходимости она может быть перемещена или удалена.
            //this.robotsTableAdapter.Fill(this.robot_search_dbDataSet.robots);

        }
    }
}

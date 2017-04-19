using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotSearch.Forms
{
    public partial class Registration : Form
    {
        public Form MyForm;
        public Registration(Form inpForm)
        {
            MyForm = inpForm;
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void stripbtn_Exit_Click(object sender, EventArgs e)
        {
            MyForm.Enabled = true;
            this.Close();
        }
    }
}

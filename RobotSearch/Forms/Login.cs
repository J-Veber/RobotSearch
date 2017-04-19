using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotSearch.Forms
{
    public partial class Login : Form
    {
        private string _userLogin;
        private string _userPassw;
        private int _userRights;
        private int _userID;

        private void callAdmPanel(string userLogin)
        {
            var adminPanel = new AdminPanel(this, userLogin);
            this.Enabled = false;
            adminPanel.Show();
        }

        private void callUserPanel(string userLogin)
        {
            var userPanel = new UserPanel(this, userLogin);
            this.Enabled = false;
            userPanel.Show();
        }

        public Login()
        {
            InitializeComponent();
            tb_UserName_auth.Clear();
            tb_UserPassw_auth.Clear();
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var regForm = new Registration(this);
            this.Enabled = false;
            regForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?",
             "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes) {
                e.Cancel = false;
            }
            else {
                e.Cancel = true;
            }
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            _userLogin = Convert.ToString(tb_UserName_auth.Text);
            _userPassw = Convert.ToString(tb_UserPassw_auth.Text);
            _userID = -1;
            int count = 0;

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koval\documents\visual studio 2017\Projects\RobotSearch\RobotSearch\robot_search_db.mdf;Integrated Security=True");

            using (SqlCommand command = new SqlCommand("SELECT * FROM users " +
                                                       "WHERE users_login='" + _userLogin + "' AND users_passw='" + _userPassw + "';", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count++;
                        if (count == 1)
                        {
                            _userID = reader.GetInt32(0);
                            _userLogin = reader.GetString(1);
                            _userPassw = reader.GetString(2);
                            _userRights = reader.GetByte(3);
                        }
                    }
                    
                }

                //connection.Close();
            }
            switch (count)
            {
                case 1:
                    if (_userRights == 1)
                    {
                        tb_UserName_auth.Clear();
                        tb_UserPassw_auth.Clear();
                        callAdmPanel(_userLogin);
                    } else if (_userRights == 0)
                    {
                        tb_UserName_auth.Clear();
                        tb_UserPassw_auth.Clear();
                        callUserPanel(_userLogin);
                    }
                    break;
                default:
                    MessageBox.Show("Неверный логин или пароль!");
                    tb_UserName_auth.Clear();
                    tb_UserPassw_auth.Clear();
                    break;
            }
            {
                    
            }
        }

        private void tb_UserName_auth_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

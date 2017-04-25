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
    public partial class SpRegistration : Form
    {
        public Form MyForm;
        private string _userLogin;
        private string _userPassw;
        private int _userRights; // 1 is Admin
        private int _userID;

        public SpRegistration(Form inputForm)
        {
            InitializeComponent();
            MyForm = inputForm;
            tb_UserName_regAdm.Clear();
            tb_UserPassw_regAdm.Clear();
        }

       private void button_regAdm_Click_1(object sender, EventArgs e)
        {
            _userLogin = Convert.ToString(tb_UserName_regAdm.Text);
            _userPassw = Convert.ToString(tb_UserPassw_regAdm.Text);
            if (checkBox_regAdmin.Checked) _userRights = 1;
            else _userRights = 0;

            SqlConnection connection = new SqlConnection
            {
                ConnectionString =
                    (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koval\documents\visual studio 2017\Projects\RobotSearch\RobotSearch\robot_search_db.mdf;Integrated Security=True")
            };


            using (SqlCommand command = new SqlCommand("SELECT * FROM users " +
                                                       "WHERE users_login='" + _userLogin + "' AND users_passw='" + _userPassw + "';", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Пользователь с таким логином или паролем уже существует.");
                    tb_UserName_regAdm.Clear();
                    tb_UserPassw_regAdm.Clear();
                    checkBox_regAdmin.Checked = false;
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    reader.Close();
                    string sqlcommand = "INSERT INTO dbo.users (users_login, users_passw, users_admin) VALUES (@userLogin, " +
                                        "@userPassw, @userRights);";
                    using (var sqlSaveCommand = new SqlCommand(sqlcommand, connection))
                    {
                        sqlSaveCommand.Parameters.Add("@userLogin", SqlDbType.VarChar, 15).Value = _userLogin;
                        sqlSaveCommand.Parameters.Add("@userPassw", SqlDbType.VarChar, 10).Value = _userPassw;
                        sqlSaveCommand.Parameters.Add("@userRights", SqlDbType.TinyInt).Value = _userRights;

                        sqlSaveCommand.ExecuteNonQuery();

                        if (_userRights == 1)
                        {
                            MessageBox.Show("Пользователь " + _userLogin + " успешно добавлен с паролем " + _userPassw
                                            + " и с правами администратора.");
                        }
                        else
                        {
                            MessageBox.Show("Пользователь " + _userLogin + " успешно добавлен с паролем " + _userPassw
                                            + " и с правами пользователя.");
                        }
                    }
                }
                connection.Close();
            }
        }

        private void stripbtn_Exit_Click_1(object sender, EventArgs e)
        {
            MyForm.Enabled = true;
            this.Close();
        }

        private void checkBox_regAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

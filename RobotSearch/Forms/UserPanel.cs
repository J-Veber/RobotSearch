using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RobotSearch.Forms
{
    public partial class UserPanel : Form
    {
        public Form MyForm;
        private string _userLogin;

        public UserPanel(Form inForm, string userLogin)
        {
            InitializeComponent();

            _userLogin = userLogin;
            tb_UserName.Text = userLogin;
            MyForm = inForm;
            var connection = new SqlConnection
            {
                ConnectionString =
                    (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koval\documents\visual studio 2017\Projects\RobotSearch\RobotSearch\robot_search_db.mdf;Integrated Security=True")
            };

            using (var command = new SqlCommand("SELECT method_of_piloting_val FROM method_of_piloting;", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetString(0))
                        {
                            case "no":
                                comboBox1.Items.Add("Нет");
                                break;
                            case "from_within":
                                comboBox1.Items.Add("Изнутри");
                                break;
                            case "outside":
                                comboBox1.Items.Add("Снаружи");
                                break;
                        }
                    }
                }
                connection.Close();
            }

            comboBox2.Items.Add("Да");
            comboBox2.Items.Add("Нет");

            using (var command = new SqlCommand("SELECT depth_value_val FROM depth_value;", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetString(0))
                        {
                            case "average":
                                comboBox3.Items.Add("Небольшая");
                                break;
                            case "big":
                                comboBox3.Items.Add("Большая");
                                break;
                            case "small":
                                comboBox3.Items.Add("Малая");
                                break;
                        }
                    }
                }
            }

            comboBox4.Items.Add("Динамический");
            comboBox4.Items.Add("Не динамический");

            comboBox5.Items.Add("Да");
            comboBox5.Items.Add("Нет");

            numericUpDown1.Minimum = -1;
            numericUpDown1.Maximum = 5;

            comboBox7.Items.Add("Да");
            comboBox7.Items.Add("Нет");

            comboBox8.Items.Add("Да");
            comboBox8.Items.Add("Нет");

            numericUpDown2.Minimum = -1;
            numericUpDown2.Maximum = 10;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            MyForm.Enabled = true;
            this.Close();
        }

        private void btn_SearchRobot_Click(object sender, EventArgs e)
        {
            Robot robotForSearch = new Robot(comboBox1.Text, comboBox2.Text, comboBox3.Text, 
                comboBox4.Text, comboBox5.Text, numericUpDown1.Text, comboBox7.Text, 
                comboBox8.Text, numericUpDown2.Text);
            string sqlCommand = "";
            int sqlCommandNum = 0;

            var connection = new SqlConnection
                {
                    ConnectionString =
                        (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koval\documents\visual studio 2017\Projects\RobotSearch\RobotSearch\robot_search_db.mdf;Integrated Security=True")
                };

            robotForSearch.CheckParameters();
            switch (robotForSearch.RobotFieldsNum)
            {
                case 0:
                    sqlCommand += "SELECT robots_name FROM robots;";
                    sqlCommandNum = 0;
                    break;
                default:
                    sqlCommand += "SELECT robots_name FROM robots WHERE ";
                    sqlCommandNum = robotForSearch.RobotFieldsNum;
                    break;
            }

            if (robotForSearch.RobotSqlAtr[0])
            {
                switch (robotForSearch.RobotMethodOfPiloting)
                {
                    case "Изнутри":
                        sqlCommand += "robots_method_of_piloting='0' "; // from within
                        break;
                    case "Снаружи":
                        sqlCommand += "robots_method_of_piloting='1' "; // outside
                        break;
                    case "Нет":
                        sqlCommand += "robots_method_of_piloting='2' "; // no
                        break;
                }
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[1])
            {
                if (robotForSearch.RobotBobber.Equals("Да"))
                    sqlCommand += "robots_bobber='1' ";
                else sqlCommand += "robots_bobber='0' ";
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[2])
            {
                switch (robotForSearch.RobotDepth)
                {
                    case "Небольшая":
                        sqlCommand += "robots_depth='1' "; // average
                        break;
                    case "Большая":
                        sqlCommand += "robots_depth='2' "; // big
                        break;
                    case "Малая":
                        sqlCommand += "robots_depth='0' "; // small
                        break;
                }
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[3])
            {
                if (robotForSearch.RobotDiveMethod.Equals("Динамический"))
                    sqlCommand += "robots_dive_method = '0' ";
                else sqlCommand += "robots_dive_method = '1' ";
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[4])
            {
                if (robotForSearch.RobotExitToWater.Equals("Да"))
                    sqlCommand += "robots_exit_to_water='1' ";
                else sqlCommand += "robots_exit_to_water='0' ";
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[5])
            {
                sqlCommand += "robots_cameras_from <= '" + robotForSearch.RobotExitToWater +
                              "' AND robots_cameras_to >='" +
                              robotForSearch.RobotCameras + "' ";
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[6])
            {
                if (robotForSearch.RobotIllums.Equals("Да"))
                    sqlCommand += "robots_illums = '1' ";
                else sqlCommand += "robots_illums = '0' ";
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[7])
            {
                if (robotForSearch.RobotConnectionWithSurface.Equals("Да"))
                    sqlCommand += "robots_conn_with_surface='1' ";
                else sqlCommand += "robots_conn_with_surface='0' ";
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            if (robotForSearch.RobotSqlAtr[8])
            {
                sqlCommand += "robots_capacity_from <= '" + robotForSearch.RobotCapacity +
                              "' AND robots_capacity_to >='" +
                              robotForSearch.RobotCapacity + "' ";
                if (sqlCommandNum >= 2)
                {
                    sqlCommandNum--;
                    sqlCommand += "AND ";
                }
            }
            sqlCommand += ";";

            using (var command = new SqlCommand(sqlCommand, connection))
            {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        string answer = "";
                        while (reader.Read())
                        {
                            answer += reader.GetString(0) + ";";
                        }
                    MessageBox.Show(answer);

                }
                connection.Close();
                }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
        }

    }


}

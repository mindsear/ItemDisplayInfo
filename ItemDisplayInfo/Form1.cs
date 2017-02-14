using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace ItemDisplayInfo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textbox_mysql_pass.Text = Properties.Settings.Default.mysql_pass;
            textbox_mysql_username.Text = Properties.Settings.Default.mysql_username;
            textbox_mysql_hostname.Text = Properties.Settings.Default.mysql_hostname;
            textbox_mysql_port.Text = Properties.Settings.Default.mysql_port;
            textbox_mysql_worldDB.Text = Properties.Settings.Default.mysql_worldDB;
            textBox_mysql_authDB.Text = Properties.Settings.Default.mysql_authDB;
            textBox_mysql_charactersDB.Text = Properties.Settings.Default.mysql_charactersDB;

            textBox3.Text = Properties.Settings.Default.FolderPath;
            //textbox_mysql_username.Text = Properties.Settings.Default.mysql_username;

            pictureBox1.Image = Properties.Resources.INV_Misc_QuestionMark;

            //string constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            //MySqlCommand com = new MySqlCommand("select displayid, entry, name from " + textbox_mysql_worldDB.Text + ".item_template where displayid LIKE '%%';", conDataBase);

            //try
            //{
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //    sda.SelectCommand = com;
            //    DataTable dbdataset = new DataTable();
            //    sda.Fill(dbdataset);
            //    BindingSource bsource = new BindingSource();

            //    bsource.DataSource = dbdataset;
            //    dataGridView1.DataSource = bsource;
            //    sda.Update(dbdataset);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            ////-------------------------------------------------------------------------------------------------

            //string _constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            //MySqlConnection _conDataBase = new MySqlConnection(_constring);
            //MySqlCommand com2 = new MySqlCommand("select ID, icon1, icon2 from test.itemdisplayinfo WHERE ID LIKE '%%';", _conDataBase);

            //try
            //{
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //    sda.SelectCommand = com2;
            //    DataTable dbdataset = new DataTable();
            //    sda.Fill(dbdataset);
            //    BindingSource bsource = new BindingSource();

            //    bsource.DataSource = dbdataset;
            //    dataGridView2.DataSource = bsource;
            //    sda.Update(dbdataset);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand com = new MySqlCommand("select displayid, entry, name from " + textbox_mysql_worldDB.Text + ".item_template where displayid LIKE '%" + textBox1.Text + "%';", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = com;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-------------------------------------------------------------------------------------------------

            string _constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            MySqlConnection _conDataBase = new MySqlConnection(_constring);
            MySqlCommand com2 = new MySqlCommand("select ID, icon1, icon2 from " + textbox_mysql_worldDB.Text + ".itemdisplayinfo WHERE ID LIKE '%" + textBox1.Text + "%';"
            // "select icon1 from test.itemdisplayinfo WHERE ID LIKE '%" + textBox1.Text + "%';"

            , _conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = com2;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //===========================================================================================

            MySqlConnection connection = new MySqlConnection("datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text);
            string insertQuery = "select icon1 from " + textbox_mysql_worldDB.Text + ".itemdisplayinfo WHERE ID LIKE '%" + textBox1.Text + "%';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {

                //textBox5.Text = command.ExecuteScalar().ToString();
                //label_query_executed_successfully2.Visible = false;

                if (command.ExecuteNonQuery() == 1)
                {
                    //textBox5.Text = command.ExecuteScalar().ToString();
                    //label7.Visible = true;
                    //label_query_executed_successfully2.Visible = false;

                }
                else
                {
                    textBox5.Text = command.ExecuteScalar().ToString();
                    //MessageBox.Show("Data Not Inserted");
                    //label2.ForeColor = Color.Red;
                    //label2.Text = "Eroare!";
                    //MessageBox.Show("Unable to connect to any of the specified MySQL hosts.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            string constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand com = new MySqlCommand("select displayid, entry, name from " + textbox_mysql_worldDB.Text + ".item_template where name LIKE '%" + textBox2.Text + "%';", conDataBase);

            //MySqlCommand com2 = new MySqlCommand("select icon1, icon2 from test.itemdisplayinfo WHERE ID LIKE '%" + textBox1.Text + "%';", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = com;
                //sda.SelectCommand = com2;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                //dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-------------------------------------------------------------------------------------------------

            string _constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            MySqlConnection _conDataBase = new MySqlConnection(_constring);
            MySqlCommand com2 = new MySqlCommand("select ID, icon1, icon2 from " + textbox_mysql_worldDB.Text + ".itemdisplayinfo WHERE icon1 LIKE '%" + textBox2.Text + "%';", _conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = com2;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_fill_default_Click(object sender, EventArgs e)
        {
            textbox_mysql_hostname.Text = "127.0.0.1";
            textbox_mysql_port.Text = "3306";
            textbox_mysql_username.Text = "root";
            textbox_mysql_worldDB.Text = "world";
            textBox_mysql_authDB.Text = "auth";
            textBox_mysql_charactersDB.Text = "characters";
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            textbox_mysql_hostname.Clear();
            textbox_mysql_port.Clear();
            textbox_mysql_username.Clear();
            textbox_mysql_worldDB.Clear();
            textbox_mysql_pass.Clear();
            textBox_mysql_authDB.Clear();
            textBox_mysql_charactersDB.Clear();
        }

        private void button_mysql_connect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            try
            {
                string myConnection = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                DataSet ds = new DataSet();

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox6.Visible = true;
                pictureBox1.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label8.Visible = true;
                tabControl1.Visible = false;
                button2.Visible = true;
                label7.Visible = true;
                Size = new Size(754, 509);
                CenterToScreen();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //==================================================================================

            //string constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            //MySqlCommand com = new MySqlCommand("select displayid, entry, name from " + textbox_mysql_worldDB.Text + ".item_template where displayid LIKE '%%';", conDataBase);

            //try
            //{
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //    sda.SelectCommand = com;
            //    DataTable dbdataset = new DataTable();
            //    sda.Fill(dbdataset);
            //    BindingSource bsource = new BindingSource();

            //    bsource.DataSource = dbdataset;
            //    dataGridView1.DataSource = bsource;
            //    sda.Update(dbdataset);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            ////-------------------------------------------------------------------------------------------------

            //string _constring = "datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text;
            //MySqlConnection _conDataBase = new MySqlConnection(_constring);
            //MySqlCommand com2 = new MySqlCommand("select ID, icon1, icon2 from test.itemdisplayinfo WHERE ID LIKE '%%';", _conDataBase);

            //try
            //{
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //    sda.SelectCommand = com2;
            //    DataTable dbdataset = new DataTable();
            //    sda.Fill(dbdataset);
            //    BindingSource bsource = new BindingSource();

            //    bsource.DataSource = dbdataset;
            //    dataGridView2.DataSource = bsource;
            //    sda.Update(dbdataset);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text == "INV_Robe_02"
              || textBox5.Text == "INV_Misc_Ale_01"
              || textBox5.Text == ""
              || textBox5.Text == "INV_Misc_Igot_01"
              || textBox5.Text == "INV_Robe_01"
              || textBox5.Text == "INV_Robe_03"
              )
                textBox5.Text = "INV_Misc_QuestionMark";
            //pictureBox1.Image = Properties.Resources.INV_Misc_QuestionMark;



            if (textBox5.Text == "")
                return;
            if (textBox3.Text == "")
                return;

            pictureBox1.Image = Image.FromFile(@textBox3.Text + textBox5.Text + ".png");

            //----------------------------------

            MySqlConnection connection = new MySqlConnection("datasource=" + textbox_mysql_hostname.Text + ";port=" + textbox_mysql_port.Text + ";username=" + textbox_mysql_username.Text + ";password=" + textbox_mysql_pass.Text);
            string insertQuery = "select icon1 from " + textbox_mysql_worldDB.Text + ".itemdisplayinfo WHERE ID = %" + textBox1.Text + "%;";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {

                //textBox5.Text = command.ExecuteScalar().ToString();
                //label_query_executed_successfully2.Visible = false;

                if (command.ExecuteNonQuery() == 1)
                {
                    textBox5.Text = command.ExecuteScalar().ToString();
                    //label7.Visible = true;
                    //label_query_executed_successfully2.Visible = false;
                }
                else
                {
                    //textBox5.Text = command.ExecuteScalar().ToString();
                    //MessageBox.Show("Data Not Inserted");
                    //label2.ForeColor = Color.Red;
                    //label2.Text = "Eroare!";
                    //MessageBox.Show("Unable to connect to any of the specified MySQL hosts.");
                }
            }
            catch (Exception /*ex*/)
            {
                //MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                pictureBox1.Image = Properties.Resources.INV_Misc_QuestionMark;
            else
                pictureBox1.Image = Properties.Resources.INV_Misc_QuestionMark;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //string file = "";
        //private object openFileDialog1;

        private void button2_Click(object sender, EventArgs e)
        {
            //int size = -1;
            //DialogResult result = openFileDialog1.ShowDialog();
            //OpenFileDialog dialog = new OpenFileDialog();
            //if (result == DialogResult.OK)
            //{
            //    //file = openFileDialog1.FileName;
            //    try
            //    {
            //        string text = File.ReadAllText(file);
            //        size = text.Length;
            //        textBox3.Text = file; // for full location
            //        //textBox2.Text = Path.GetFileName(Path.GetDirectoryName(file)); // for last folder name
            //    }
            //    catch (IOException)
            //    {
            //    }
            //}

            FolderBrowserDialog fbd = new FolderBrowserDialog();
           // fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = fbd.SelectedPath + "\\";
                //string sSelectedPath = fbd.SelectedPath;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.FolderPath = textBox3.Text;

            Properties.Settings.Default.mysql_pass = textbox_mysql_pass.Text;
            Properties.Settings.Default.mysql_username = textbox_mysql_username.Text;
            Properties.Settings.Default.mysql_hostname = textbox_mysql_hostname.Text;
            Properties.Settings.Default.mysql_port = textbox_mysql_port.Text;
            Properties.Settings.Default.mysql_worldDB = textbox_mysql_worldDB.Text;
            Properties.Settings.Default.mysql_authDB = textBox_mysql_authDB.Text;
            Properties.Settings.Default.mysql_charactersDB = textBox_mysql_charactersDB.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "") Process.Start("http://wotlk.openwow.com/");
            else if (textBox6.Text == "0") Process.Start("http://wotlk.openwow.com/");
            else Process.Start("http://wotlk.openwow.com/item=" + textBox6.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe; // importing SQL
using System.Data.SQLite; // imoprting SQLite
using System.IO; // importing IO for files handling
using MySql.Data.MySqlClient; // import MySQL 
using System.Globalization;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            #region SQLServer CE
            //string dataBase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string connection = @"DataSource = " + dataBase + "; Password = ''";
            //SqlCeEngine db = new SqlCeEngine(connection);

            //if (!File.Exists(connection))
            //{
            //    db.CreateDatabase(); // create
            //}
            //db.Dispose(); // close db and free resources

            //SqlCeConnection connect = new SqlCeConnection(connection); // connect 
            //try
            //{
            //    connect.Open(); // open connection

            //    label1.Text = "SQLServerCe connected";
            //}
            //catch (Exception ex)
            //{
            //    label1.Text = "SQLServerCe not connected\n" + ex;
            //}
            //finally
            //{
            //    connect.Close();
            //}

            #endregion

            #region SQLite


            //string dataBase = Application.StartupPath + @"\db\DBSQLite.sdf";
            //string connection = @"DataSource = " + dataBase + "; Version = 3";

            //if (!File.Exists(dataBase))
            //{
            //    SQLiteConnection.CreateFile(dataBase); // create
            //}

            //SQLiteConnection connect = new SQLiteConnection(connection); // connect 
            //try
            //{
            //    connect.Open(); // open connection

            //    label1.Text = "SQLite connected";
            //}
            //catch (Exception ex)
            //{
            //    label1.Text = "SQLite not connected\n" + ex;
            //}
            //finally
            //{
            //    connect.Close();
            #endregion

            #region MySQL
            string strConnection = "server=127.0.0.1; User Id=root ;password=";
            MySqlConnection connect= new MySqlConnection(strConnection);


            try
            {
                connect.Open(); // open connection

                label1.Text = "MySQL connected";

                MySqlCommand comand= new MySqlCommand();
                comand.Connection = connect;
                comand.CommandText = "CREATE DATABASE IF NOT EXISTS course_db";

                comand.ExecuteNonQuery();
                label1.Text = "DataBase course_db created!";
                comand.Dispose();

            }
            catch (Exception ex)
            {
                label1.Text = "MySQL not connected\n" + ex;
            }
            finally
            {
                connect.Close();

            #endregion
        }
    }

        private void btnTable_Click(object sender, EventArgs e)
        {
            #region SQL Server
            //string dataBase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string connection = @"DataSource = " + dataBase + "; Password = ''";
            //SqlCeConnection connect= new SqlCeConnection(connection);

            //try
            //{
            //    connect.Open();

            //    SqlCeCommand command= new SqlCeCommand();
            //    command.Connection = connect;

            //    command.CommandText = "CREATE TABLE persons(id INT NOT NULL PRIMARY KEY, name NVARCHAR(50), email NVARCHAR(50))";
            //    command.ExecuteNonQuery();

            //    label1.Text = "Table persons created (SQL Server) !";

            //    command.Dispose();
            //}
            //catch(Exception ex)
            //{
            //    label1.Text = ex.Message;
            //}
            //finally
            //{
            //    connect.Close();
            //}
            #endregion

            // to SQLite is the same code, just change SqlCe

            #region MySQL

            
            string connection = "Server=127.0.0.1; User Id=root;database=course_db;password=";
            MySqlConnection connect = new MySqlConnection(connection);

            try
            {
                connect.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;

                command.CommandText = "CREATE TABLE persons(id INT NOT NULL, name NVARCHAR(50), email NVARCHAR(50), PRIMARY KEY(id))";
                command.ExecuteNonQuery();

                label1.Text = "Table persons created (SQL Server) !";

                command.Dispose();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {
                connect.Close();
            }

            #endregion
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            #region SQL Server
            //string dataBase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string connection = @"DataSource = " + dataBase + "; Password = ''";
            //SqlCeConnection connect = new SqlCeConnection(connection);

            //try
            //{
            //    connect.Open();

            //    SqlCeCommand command = new SqlCeCommand();
            //    command.Connection = connect;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string name = textBox1.Text;
            //    string email = textBox2.Text;

            //    command.CommandText = "INSERT INTO persons VALUES ("+ id +", '"+ name +"', '"+email+"')";

            //    command.ExecuteNonQuery();

            //    label1.Text = "Register created (SQL Server) !";

            //    command.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    label1.Text = ex.Message;
            //}
            //finally
            //{
            //    connect.Close();
            //}
            #endregion

            // to SQLite is the same code, just change SqlCe 


            #region MySQL
            string connection = "Server=127.0.0.1; User Id=root;database=course_db;password=";
            MySqlConnection connect = new MySqlConnection(connection);

            try
            {
                connect.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string name = textBox1.Text;
                string email = textBox2.Text;

                command.CommandText = "INSERT INTO persons VALUES (" + id + ", '" + name + "', '" + email + "')";

                command.ExecuteNonQuery();

                label1.Text = "Register created (MySQL)!";

                command.Dispose();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {
                connect.Close();
            }
            #endregion

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            #region SQLServer

            //string dataBase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string connection = @"DataSource = " + dataBase + "; Password = ''";

            //SqlCeConnection connect = new SqlCeConnection(connection);

            //try
            //{
            //    string sqlquery = "SELECT * FROM persons";

            //    if (textBox1.Text != "")
            //    {
            //        sqlquery = "SELECT * FROM persons WHERE name LIKE '"+ textBox1.Text +"'";

            //    }
            //    DataTable dataTable= new DataTable();

            //    SqlCeDataAdapter adapter= new SqlCeDataAdapter(sqlquery,connection); // fill DataTable

            //    connect.Open();

            //    adapter.Fill(dataTable); 

            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        dataGridView1.Rows.Add(row.ItemArray); // each row is an array 
            //    }
            //        textBox1.Text = "";
            //}
            //catch (Exception ex)
            //{
            //    dataGridView1.Rows.Clear();
            //    textBox1.Text = ex.Message;
            //}
            //finally
            //{
            //    connect.Close();
            //}

            #endregion

            // to SQLite is the same code, just change SqlCe 

            #region MySQL

            string connection = "Server=127.0.0.1; User Id=root;database=course_db;password=";
            MySqlConnection connect = new MySqlConnection(connection);

            try
            {
                string sqlquery = "SELECT * FROM persons";

                if (textBox1.Text != "")
                {
                    sqlquery = "SELECT * FROM persons WHERE name LIKE '" + textBox1.Text + "'";

                }
                DataTable dataTable = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlquery, connection); // fill DataTable

                connect.Open();

                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray); // each row is an array 
                }
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
                textBox1.Text = ex.Message;
            }
            finally
            {
               
                connect.Close();
            }

            #endregion
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region SQL Server
            //string dataBase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string connection = @"DataSource = " + dataBase + "; Password = ''";

            //SqlCeConnection connect = new SqlCeConnection(connection);

            //try
            //{
            //    connect.Open();

            //    SqlCeCommand command = new SqlCeCommand();
            //    command.Connection = connect;

            //    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value; // index 0 is id string converted to int

            //    command.CommandText = "DELETE FROM persons WHERE id = '" + id + "'";

            //    command.ExecuteNonQuery();

            //    label1.Text = "Register deleted (SQL Server) !";

            //    command.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    label1.Text = ex.Message;
            //}
            //finally
            //{
            //    connect.Close();
            //}
            #endregion

            // to SQLite is the same code, just change SqlCe 


            #region MySQL
            string connection = "Server=127.0.0.1; User Id=root;database=course_db;password=";
            MySqlConnection connect = new MySqlConnection(connection);

            try
            {
                connect.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value; // index 0 is id string converted to int

                command.CommandText = "DELETE FROM persons WHERE id = '" + id + "'";

                command.ExecuteNonQuery();

                label1.Text = "Register deleted (MySQL)!";

                command.Dispose();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {
                connect.Close();
            }
            #endregion
        }

        private void S_Click(object sender, EventArgs e)
        {
            #region SQL Server
            //string dataBase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string connection = @"DataSource = " + dataBase + "; Password = ''";

            //SqlCeConnection connect = new SqlCeConnection(connection);

            //try
            //{
            //    connect.Open();

            //    SqlCeCommand command = new SqlCeCommand();
            //    command.Connection = connect;

            //    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value; // index 0 is id string converted to int

            //    string query = "UPDATE persons SET name = '"+textBox1+"', email = '"+textBox2.Text+"' WHERE id LIKE '"+id+"' ";

            //    command.CommandText = query;

            //    command.ExecuteNonQuery();

            //    label1.Text = "Register modified (SQL Server) !";

            //    command.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    label1.Text = ex.Message;
            //}
            //finally
            //{
            //    connect.Close();
            //}
            #endregion

            // to SQLite is the same code, just change SqlCe 


            #region MySQL
            string connection = "Server=127.0.0.1; User Id=root;database=course_db;password=";
            MySqlConnection connect = new MySqlConnection(connection);

            try
            {
                connect.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value; // index 0 is id string converted to int

                string query = "UPDATE persons SET name = '" + textBox1.Text + "', email = '" + textBox2.Text + "' WHERE id LIKE '" + id + "' ";

                command.CommandText = query;

                command.ExecuteNonQuery();

                label1.Text = "Register modified (MySQL)!";
                textBox1.Text = "";
                textBox2.Text = "";

                command.Dispose();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {
                connect.Close();
            }
            #endregion
        }
    }
}












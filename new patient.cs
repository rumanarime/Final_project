using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace final
{
    public partial class new_patient : Form
    {
        
        public new_patient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                string name = txtName.Text;
                string address = txtAddress.Text;
            string contact = txtContact.Text;
            string age = txtAge.Text;
            string gender = combogender.Text;
            string blood = txtBlood.Text;
            string any = txtAny.Text;
            string pid = txtPid.Text;
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user id=root;database=hospital;allowuservariables=True");
                string insertQuery = "insert into addpatient values(' " + name + "',' " + address + " ',' " + contact
        + " ',' " + age + " ',' " + gender + " ',' " + blood + " ',' " + any + " ',' " + pid + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                    MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();


            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();
            txtPid.Clear();
            txtAny.Clear();
            combogender.ResetText();

        }
            }
    }


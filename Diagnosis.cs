using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string pid = textBox3.Text;



            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;user id=root;database=hospital;allowuservariables=True";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from addpatient where pid= '"+ pid + "' ";
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pid = textBox3.Text;
            string symp = txtsymptoms.Text;
            string diag = txtdiagnosis.Text;
            string medi = txtmedicine.Text;
            string ward = cmbward.Text;
            string wardtype = cmbwardtype.Text;


            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user id=root;database=hospital;allowuservariables=True");


            string insertQuery = "insert into patientmore values(' " + pid + "',' " + symp + " ',' " + diag
    + " ',' " + medi + " ',' " + ward + " ',' " + wardtype + "')";
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
            textBox3.Clear();    
            txtmedicine.Clear();
            txtdiagnosis.Clear();
            txtsymptoms.Clear();
            cmbward.ResetText();
            cmbwardtype.ResetText();


        }
    }
}

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
    public partial class full_history : Form
    {
        public full_history()
        {
            InitializeComponent();
        }

        private void dataGView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void full_history_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;user id=root;database=hospital;allowuservariables=True";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from addpatient inner join patientmore on addpatient.pid=patientmore.pid";
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGView2.DataSource = DS.Tables[0];
        }
    }
}

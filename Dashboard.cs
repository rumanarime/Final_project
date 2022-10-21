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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
             new_patient np = new new_patient();
            np.Show();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis ds = new Diagnosis();
            ds.Show();
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            full_history fh = new full_history();
            fh.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

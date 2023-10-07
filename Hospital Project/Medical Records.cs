using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Project
{
    public partial class Medical_Records : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0NT4E3L\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter sd;
        DataTable DT = new DataTable();
        SqlCommandBuilder cmd;
        public Medical_Records()
        {
            InitializeComponent();
            DT.Clear();
             sd = new SqlDataAdapter("select *  from [Medical Recorder] ", con);
            sd.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void Medical_Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Medical_Recorder' table. You can move, or remove it, as needed.
            this.medical_RecorderTableAdapter.Fill(this.hospitalDataSet.Medical_Recorder);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(sd);
            sd.Update(DT);
            MessageBox.Show(" Passed Successful", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

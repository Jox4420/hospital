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
    public partial class Patient : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source=DESKTOP-0NT4E3L\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;
        public Patient()
        {
            InitializeComponent();
            Da = new SqlDataAdapter ("Select *from Patient", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Reception' table. You can move, or remove it, as needed.
            this.receptionTableAdapter.Fill(this.hospitalDataSet.Reception);
            // TODO: This line of code loads data into the 'hospitalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);
            // TODO: This line of code loads data into the 'hospitalDataSet.Medical_Recorder' table. You can move, or remove it, as needed.
            this.medical_RecorderTableAdapter.Fill(this.hospitalDataSet.Medical_Recorder);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show(" Passed Successful", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

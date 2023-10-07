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
    public partial class Appointment : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source=DESKTOP-0NT4E3L\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        SqlCommandBuilder cmd;
        public Appointment()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("Select *from Appointment", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.hospitalDataSet.Appointment);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show(" Passed Successful", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

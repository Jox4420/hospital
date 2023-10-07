using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HospitalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.HospitalDataSet.Patient);
            // TODO: This line of code loads data into the 'HospitalDataSet.RebyPatient' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport(); 
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RebyPatientTableAdapter.Fill(this.HospitalDataSet.RebyPatient,textBox1.Text);
                

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RebyPatientTableAdapter.Fill(this.HospitalDataSet.RebyPatient, comboBox1.Text);


            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

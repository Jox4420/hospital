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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient Pa = new Patient();
            Pa.Show();
            
        }

        private void receptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reception  re = new Reception();
            re.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment App = new Appointment();
            App.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room Ro = new Room();
            Ro.Show();
        }

        private void medicalRecorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medical_Records mr = new Medical_Records();
            mr.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test Te = new Test();
            Te.Show();
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report de = new Report();
            de.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report re = new Report();
            re.Show();
        }
    }
}

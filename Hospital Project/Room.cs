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
    public partial class Room : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source=DESKTOP-0NT4E3L\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;
        public Room()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("Select *from Room", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hospitalDataSet.Room);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show(" Passed Successful", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

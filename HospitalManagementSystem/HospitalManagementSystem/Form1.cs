using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\HospitalManagementSystem\HospitalManagementSystem\Hospital.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into PatientReg(Patient_Id,Patient_Name,Gender,Age,Address,Contact) values (@id,@name,@gender,@age,@add,@cont)",con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("name", textBox2.Text);
            cmd.Parameters.AddWithValue("gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("age", textBox3.Text);
            cmd.Parameters.AddWithValue("add", textBox4.Text);
            cmd.Parameters.AddWithValue("cont", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully");

        }
    }
}

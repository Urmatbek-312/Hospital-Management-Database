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

namespace Hospital
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labelIndecator2.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            
        }

 
        private void btnHospital_Click(object sender, EventArgs e)
        {
            labelIndecator4.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            

            
            panel1.Visible=false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible=false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            try 
            { 

            String name = txtName.Text;
            String address = txtAddress.Text;
            Int64 contact = Convert.ToInt64(txtContact.Text);
            int age = Convert.ToInt32(txtAge.Text);
            String gender = comboGender.Text;
            String blood = txtBlood.Text;
            String any = txtAny.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString="data source=DESKTOP-7HF6S7H\\sqlexpress;database=hospital;integrated security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into AddPatient values('" + name + "','" + address + "','" + contact + "','" + age + "','" + gender + "','" + blood + "','" + any + "')";


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Please fill form correctly !");
            }

            MessageBox.Show("Data saved !");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();   
            txtAny.Clear(); 
            comboGender.ResetText();

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {

                String name = txtName.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7HF6S7H\\sqlexpress; database=hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM AddPatient where name = " + name + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String name = txtName.Text;
                String sympt = txtBxSymptoms.Text;
                String diag = txtBxDiagnosis.Text;
                String medicine = txtBxMedicines.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7HF6S7H\\sqlexpress; database=hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into PatientMore values ('"+ name +"','" + sympt + "','"+ diag + "','"+ medicine +"','"+ ward +"','"+ wardType +"')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Any field is empty OR data is in wrong format");
            }
            MessageBox.Show("Data saved");
        }
    }
}

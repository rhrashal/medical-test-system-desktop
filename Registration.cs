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

namespace Desktop_Application
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = MedicalTestDB; Integrated Security = True; Pooling=False");

        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isExist = true;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from WindowUser where Email = '"+ txtEmail.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    isExist = false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (textuserName.Text == "" || txtEmail.Text == "" || txtpassword2.Text == "")
            {
                MessageBox.Show("Field can not be empty");
            }
            else if(txtPassword.Text != txtpassword2.Text)
            {
                MessageBox.Show("Password not match.");
            }
            else if (!isExist)
            {
                MessageBox.Show("This email already exists.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT into WindowUser values ('" + textuserName.Text + "', '" + txtEmail.Text + "','" + txtpassword2.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Wellcome " + textuserName.Text + "! You are Registrated Successfully");

                    FirstPage firstPage = new FirstPage();
                    this.Hide();
                    firstPage.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

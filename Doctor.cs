using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class Doctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = MedicalTestDB; Integrated Security = True; Pooling=False");
        public Doctor()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            display();

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into DoctorInfo values ('" + txt_dr_Name.Text + "', '" + txt_dr_email.Text + "','" + txt_dr_mbl.Text + "','" + txt_dr_dprt.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }


        private void display() //for Display
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from DoctorInfo";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                txt_dr_ID.Text = "";
                txt_dr_Name.Text = "";
                txt_dr_email.Text = "";
                txt_dr_mbl.Text = "";
                txt_dr_dprt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update DoctorInfo set DoctorName ='" + txt_dr_Name.Text + "', Email ='" + txt_dr_email.Text + "', Mobile ='" + txt_dr_mbl.Text + "', DepartmentName ='" + txt_dr_dprt.Text + "' where DoctorID = '" + txt_dr_ID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from DoctorInfo where DoctorID ='" + txt_dr_ID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    txt_dr_ID.Text = dataGridView1.Rows[e.RowIndex].Cells["DoctorID"].FormattedValue.ToString();
                    txt_dr_Name.Text = dataGridView1.Rows[e.RowIndex].Cells["DoctorName"].FormattedValue.ToString();
                    txt_dr_email.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    txt_dr_mbl.Text = dataGridView1.Rows[e.RowIndex].Cells["Mobile"].FormattedValue.ToString();
                    txt_dr_dprt.Text = dataGridView1.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

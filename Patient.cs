﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class Patient : Form
    {

        string connection = @"Data Source=.\sqlexpress;Initial Catalog=MedicalTestDB;Integrated Security=True";
        string filePath = "";
        public Patient()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string queryInsert = @"INSERT INTO [dbo].[PatientInfo] VALUES( '"+txt_Name.Text+"', "+txt_age.Text+"," + combDoctorName.SelectedValue + ", '"+ filePath +"' )";

            DataTable dtInsert = fillData(queryInsert);

            dataGridView1.DataSource = fillData(@"select p.PatientID, p.PatientName, p.Age, 
                    d.DoctorName, d.DepartmentName, d.Email, d.Mobile, p.ImageUrl 
                    from PatientInfo p join DoctorInfo d on p.DoctorID = d.DoctorID;");

        }

        private void Patient_Load(object sender, EventArgs e)
        {

            string query = @"select DoctorID, DoctorName from DoctorInfo";
            DataTable dt = fillData(query);
            combDoctorName.DataSource = dt;
            combDoctorName.DisplayMember = "DoctorName";
            combDoctorName.ValueMember = "DoctorID";



            dataGridView1.DataSource = fillData(@"select p.PatientID, p.PatientName, p.Age, 
                    d.DoctorName, d.DepartmentName, d.Email, d.Mobile, p.ImageUrl 
                    from PatientInfo p join DoctorInfo d on p.DoctorID = d.DoctorID;");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PatientInfo set PatientName ='" + txt_Name.Text + "', Age =" + txt_age.Text + ", DoctorID =" + combDoctorName.SelectedValue + ", ImageUrl ='" + filePath + "' where PatientID = '" + txt_Id.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView1.DataSource = fillData(@"select p.PatientID, p.PatientName, p.Age, 
                    d.DoctorName, d.DepartmentName, d.Email, d.Mobile, p.ImageUrl 
                    from PatientInfo p join DoctorInfo d on p.DoctorID = d.DoctorID;");

        }


        private DataTable fillData(string query)
        {



            using (System.Data.SqlClient.SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {

                    da.SelectCommand = new SqlCommand(query, conn);
                    da.SelectCommand.CommandType = CommandType.Text;

                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "PatientInfo");
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message.ToString());
                    }

                    if (ds.Tables.Count == 0)
                    {
                        DataTable dt = new DataTable();
                        ds.Tables.Add(dt);
                    }
                    return ds.Tables[0];

                }
            }
        }
        
        private void Btn_imgUplode_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Multiselect = false;
            op1.ShowDialog();
            op1.Filter = "allfiles|*";
            lbl_fileName.Text = op1.FileName;
            pictureBox1.ImageLocation = lbl_fileName.Text;


            int count = 0;
            string[] FName;
            foreach (string s in op1.FileNames)
            {
                try
                {
                    FName = s.Split('\\');
                    File.Copy(s, "D:\\" + FName[FName.Length - 1], true);
                    filePath = "D:\\" + FName[FName.Length - 1];
                    count++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
            }

            MessageBox.Show(Convert.ToString(count) + " File(s) copied");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PatientInfo where PatientID ='" + txt_Id.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();


            dataGridView1.DataSource = fillData(@"select p.PatientID, p.PatientName, p.Age, 
                    d.DoctorName, d.DepartmentName, d.Email, d.Mobile, p.ImageUrl 
                    from PatientInfo p join DoctorInfo d on p.DoctorID = d.DoctorID;");

        }
    }
}
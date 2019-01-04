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

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.44\MSSQLSERVER_2017;Initial Catalog=CDAC;Persist Security Info=True;User ID=cdacdev;Password=cdacdev123#;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Form1()
        {
            InitializeComponent();
        }

        //Insert button
        private void button1_Click(object sender, EventArgs e)
        {
            var empInsert = new Employee(firstname_txt.Text.Trim(), lastname_txt.Text.Trim(),
                email_txt.Text.Trim(), Convert.ToInt32(age_txt.Text.Trim()));
            

            if (firstname_txt.Text != "" && lastname_txt.Text != "")
            {
                cmd = new SqlCommand("insert into tbl_empRecord(Firstname,Lastname,Email,Age) values(@fname,@lname,@email,@age)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@fname", empInsert.firstName);
                cmd.Parameters.AddWithValue("@lname", empInsert.lastName);
                cmd.Parameters.AddWithValue("@email", empInsert.email);
                cmd.Parameters.AddWithValue("@age", empInsert.age);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //update button update based on email ID
        private void button2_Click(object sender, EventArgs e)
        {
            //email is unique in database 
            //for updating record use email

            var empUpdate = new Employee(firstname_txt.Text.Trim(), lastname_txt.Text.Trim(),
              email_txt.Text.Trim(), Convert.ToInt32(age_txt.Text.Trim()));

            if (email_txt.Text != "")
            {
                cmd = new SqlCommand("update tbl_empRecord set Firstname=@fname,Lastname=@lname,Age=@age where Email=@email", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@fname",empUpdate.firstName);
                cmd.Parameters.AddWithValue("@lname",empUpdate.lastName);
                cmd.Parameters.AddWithValue("@email", empUpdate.email);
                cmd.Parameters.AddWithValue("@age",empUpdate.age);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please Enter valid details(update on previous mail ID) to Update");
            }
        }

        // To delete the record 
        private void button3_Click(object sender, EventArgs e)
        {
            if (email_txt_delete.Text!= "")
            {
                cmd = new SqlCommand("delete tbl_empRecord where Email=@email", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@email", email_txt_delete.Text.Trim());
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            
        }

        //display data in grid view
        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_empRecord", connection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}

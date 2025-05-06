using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginForm.Form2;

namespace LoginForm
{
    public partial class Form4 : Form
    {

        string dob;

        int age;

        private Point lastclick;
        public Form4()
        {
            InitializeComponent();


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cbocategory.SelectedIndex = 0;
            cbotype.SelectedIndex = 0;




        }

        private void cboname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbocategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            cboname.Items.Clear();

            if (cbocategory.SelectedIndex == 0 && cbotype.SelectedIndex == 0)
            {

                cboname.Items.Add("Electrical");
                cboname.Items.Add("Electronics");
            }
            else if (cbotype.SelectedIndex == 1 && cbocategory.SelectedIndex == 0)
            {

                cboname.Items.Add("Mechanical");
            }
            else if (cbotype.SelectedIndex == 0 && cbocategory.SelectedIndex == 1)
            {

                cboname.Items.Add("Civil");
            }
            else if (cbotype.SelectedIndex == 1 && cbocategory.SelectedIndex == 1)
            {

                cboname.Items.Add("Computer Science");
                cboname.Items.Add("information technology");
            }


        }

        private void cbocategory_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboname.Items.Clear();

            if (cbocategory.SelectedIndex == 0 && cbotype.SelectedIndex == 0)
            {

                cboname.Items.Add("Electrical");
                cboname.Items.Add("Electronics");
            }
            else if (cbotype.SelectedIndex == 1 && cbocategory.SelectedIndex == 0)
            {

                cboname.Items.Add("Mechanical");
            }
            else if (cbotype.SelectedIndex == 0 && cbocategory.SelectedIndex == 1)
            {

                cboname.Items.Add("Civil");
            }
            else if (cbotype.SelectedIndex == 1 && cbocategory.SelectedIndex == 1)
            {

                cboname.Items.Add("Computer Science");
                cboname.Items.Add("information technology");
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtage_TextChanged(object sender, EventArgs e)
        {


        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = dtp.Value;
            dob = dtp.Value.ToString("dd/MM/yyyy");
            age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;

            txtage.Text = age.ToString();

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (cboname.SelectedItem == null)
            {
                lblcheckname.Text = "Please select a course name";
            }
            if (txtage.Text == "" || age < 18)
            {
                lblcheckage1.Text = "Please Select your DOB and must > 18";
            }

            // Fix for CS0103 and CS1525

            else
            {
                string query = "INSERT INTO course_info (c_category, c_type, c_name, DOB, age,id) VALUES (@Category, @Type, @Name, @DOB, @Age,@id)";
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-\\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;Trust Server Certificate=True"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Category", cbocategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Type", cbotype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Name", cboname.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@id", Program.userid);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    conn.Close();

                }

                MessageBox.Show("Info", " ✔ Data Entered Successfuly", MessageBoxButtons.OK);
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-\\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;Trust Server Certificate=True");
            string query = "Select *from course_info where id = @userid ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userid", Program.userid);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            Dgv.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbocategory.SelectedIndex = 0;
            cbotype.SelectedIndex = 0;
            cboname.SelectedIndex = -1;
            txtage.Text = "";

            dtp.Value = DateTime.Today;
            lblcheckage1.Text = "";
            lblcheckname.Text = "";



        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Dgv.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }
            else
            {
                string selectedId = Dgv.CurrentRow.Cells["id"].Value.ToString();

                // Delete from the database
                string query = "DELETE FROM course_info WHERE id = @Id";
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-\\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;Trust Server Certificate=True"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", selectedId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                // Remove the row from the DataGridView
                Dgv.Rows.RemoveAt(Dgv.CurrentRow.Index);
            }


        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (Dgv.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to update.");
            }
            else
            {
                string selectedId = Dgv.CurrentRow.Cells["id"].Value.ToString();

                // Get updated values from the form
                string updatedCategory = cbocategory.Text;
                string updatedType = cbotype.Text;
                string updatedName = cboname.Text;
                string updatedDOB = dtp.Value.ToString("dd/MM/yyyy");
                string updatedAge = txtage.Text;

                // Update the database
                string query = "UPDATE course_info SET c_category = @Category, c_type = @Type, c_name = @Name, DOB = @DOB, age = @Age WHERE id = @Id";
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-\\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;Trust Server Certificate=True"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Category", updatedCategory);
                    cmd.Parameters.AddWithValue("@Type", updatedType);
                    cmd.Parameters.AddWithValue("@Name", updatedName);
                    cmd.Parameters.AddWithValue("@DOB", updatedDOB);
                    cmd.Parameters.AddWithValue("@Age", updatedAge);
                    cmd.Parameters.AddWithValue("@id", selectedId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                // Update the DataGridView
                Dgv.CurrentRow.Cells["c_category"].Value = updatedCategory;
                Dgv.CurrentRow.Cells["c_type"].Value = updatedType;
                Dgv.CurrentRow.Cells["c_name"].Value = updatedName;
                Dgv.CurrentRow.Cells["DOB"].Value = updatedDOB;
                Dgv.CurrentRow.Cells["age"].Value = updatedAge;

                MessageBox.Show("Record updated successfully.");
            }

        }

        private void lblx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - lastclick.X, this.Location.Y + e.Y - lastclick.Y);
            }
        }
    }
}

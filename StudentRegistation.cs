using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.sql;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject 
{
    public partial class StudentRegistation : Form
    {

        public StudentRegistation()
        {
            InitializeComponent();
            RegisterNo();
        }
        public void ClearRegister()
        {
            tb_address.Text = "";
            tb_firstName.Text = "";
            tb_homeNumber.Text = "";
            tb_lastName.Text = "";
            tb_mobileNumber.Text = "";
            tb_NIC.Text = "";
            tb_parentContact.Text = "";
            tb_parentName.Text = "";
            tb_parentNIC.Text = "";
            tb_email.Text = "";
            rb_female.Checked = false;
            rb_male.Checked = false;
            dtp_dof.Text = DateTime.Today.ToString("yyyy - MM - dd");
            
        }
        public void AddInformations()
        {
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();

            string gender = rb_male.Checked && !rb_female.Checked ? "male" : "female";

            string insertQuery = "INSERT INTO " + connectionsVariable.Database + "." + connectionsVariable.Table +
                                 "(regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo, parentNic) " +
                                 "VALUES (@RegNo, @FirstName, @LastName, @DateOfBirth, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @ParentName, @NIC, @ContactNo, @ParentNic)";

            using (MySqlConnection connection = new MySqlConnection($"datasource={connectionsVariable.Server}; port={connectionsVariable.Port}; username={connectionsVariable.User}; password={connectionsVariable.Password};"))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@RegNo", cb_regNo.Text);
                        command.Parameters.AddWithValue("@FirstName", tb_firstName.Text);
                        command.Parameters.AddWithValue("@LastName", tb_lastName.Text);
                        command.Parameters.AddWithValue("@DateOfBirth", dtp_dof.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", tb_address.Text);
                        command.Parameters.AddWithValue("@Email", tb_email.Text);
                        command.Parameters.AddWithValue("@MobilePhone", tb_mobileNumber.Text);
                        command.Parameters.AddWithValue("@HomePhone", tb_homeNumber.Text);
                        command.Parameters.AddWithValue("@ParentName", tb_parentName.Text);
                        command.Parameters.AddWithValue("@NIC", tb_NIC.Text);
                        command.Parameters.AddWithValue("@ContactNo", tb_parentContact.Text);
                        command.Parameters.AddWithValue("@ParentNic", tb_parentNIC.Text);

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Recode Added Successful!", "Register Student");
                        }
                        else
                        {
                            MessageBox.Show("Data Not Inserted!");
                        }
                    }
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void UpdateInformation()
        {
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();

            string gender = rb_male.Checked && !rb_female.Checked ? "male" : "female";

            string updateQuery = "UPDATE " + connectionsVariable.Database + "." + connectionsVariable.Table +
                                " SET firstName = @FirstName, lastName = @LastName, dateOfBirth = @DateOfBirth, gender = @Gender, " +
                                "address = @Address, email = @Email, mobilePhone = @MobilePhone, homePhone = @HomePhone, " +
                                "parentName = @ParentName, nic = @NIC, contactNo = @ContactNo, parentNic = @ParentNic " +
                                "WHERE regNo = @RegNo";

            using (MySqlConnection connection = new MySqlConnection($"datasource={connectionsVariable.Server}; port={connectionsVariable.Port}; username={connectionsVariable.User}; password={connectionsVariable.Password};"))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", tb_firstName.Text);
                        command.Parameters.AddWithValue("@LastName", tb_lastName.Text);
                        command.Parameters.AddWithValue("@DateOfBirth", dtp_dof.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", tb_address.Text);
                        command.Parameters.AddWithValue("@Email", tb_email.Text);
                        command.Parameters.AddWithValue("@MobilePhone", tb_mobileNumber.Text);
                        command.Parameters.AddWithValue("@HomePhone", tb_homeNumber.Text);
                        command.Parameters.AddWithValue("@ParentName", tb_parentName.Text);
                        command.Parameters.AddWithValue("@NIC", tb_NIC.Text);
                        command.Parameters.AddWithValue("@ContactNo", tb_parentContact.Text);
                        command.Parameters.AddWithValue("@RegNo", cb_regNo.Text);
                        command.Parameters.AddWithValue("@ParentNic", tb_parentNIC.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recode Updated Successful!", "Update Student");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void RegisterNo()
        {
            cb_regNo.Items.Clear();
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();
            MySqlConnection connection = new MySqlConnection($"datasource={connectionsVariable.Server}; port={connectionsVariable.Port}; username={connectionsVariable.User}; password={connectionsVariable.Password};");
            try
            {
                String selectQuery = $"SELECT * FROM {connectionsVariable.Database}.{connectionsVariable.Table}";
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cb_regNo.Items.Add(reader.GetValue(0));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        
        }
        public void UpdateTextBoxes()
        {
            ClearRegister();
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();
            MySqlConnection connection = new MySqlConnection($"datasource={connectionsVariable.Server}; port={connectionsVariable.Port}; username={connectionsVariable.User}; password={connectionsVariable.Password};");

            try
            { 
                string query = $"SELECT * FROM {connectionsVariable.Database}.{connectionsVariable.Table} WHERE regNo=@RegNo";

                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RegNo", cb_regNo.Text);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_address.Text = reader["address"].ToString();
                            tb_firstName.Text = reader["firstName"].ToString();
                            tb_homeNumber.Text = reader["homePhone"].ToString();
                            tb_lastName.Text = reader["lastName"].ToString();
                            tb_mobileNumber.Text = reader["mobilePhone"].ToString();
                            tb_NIC.Text = reader["nic"].ToString();
                            tb_parentContact.Text = reader["contactNo"].ToString();
                            tb_parentName.Text = reader["parentName"].ToString();
                            tb_parentNIC.Text = reader["parentnic"].ToString();
                            tb_email.Text = reader["email"].ToString();
                            dtp_dof.Text = reader["dateOfBirth"].ToString();

                            if (reader["gender"].ToString() == "male")
                            {
                                rb_male.Checked = true;
                                rb_female.Checked = false;
                            }
                            else if(reader["gender"].ToString() == "female")
                            {
                                rb_female.Checked = true;
                                rb_male.Checked = false;
                            }
                            
                        }
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("Data update not successfully!", "Update");
            }
            finally
            {
                connection.Close();
            }
        }
        public void deleteIthem()
        {
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();
            MySqlConnection connection = new MySqlConnection($"datasource={connectionsVariable.Server}; port={connectionsVariable.Port}; username={connectionsVariable.User}; password={connectionsVariable.Password}; database={connectionsVariable.Database}");
            string query = $"DELETE FROM {connectionsVariable.Table} WHERE regNo = {cb_regNo.Text}";
            connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deleted successfully!", "Delete");
                ClearRegister();
                RegisterNo();
            }
            catch
            {
                MessageBox.Show("Data deleted not successfully!", "Delete");
            }
            finally
            {
                connection.Close();
            }
        }





        // ----------------------------------------------------------------------------------------------
        // ---------------------------------user input functions--------(**warning to change**)----------
        // ----------------------------------------------------------------------------------------------
        private void StudentRegistation_Load(object sender, EventArgs e)
        {
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearRegister();
            cb_regNo.Text = "";
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loggin_form loggin_Form = new loggin_form();
            loggin_Form.Show();
            this.Hide();
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            AddInformations();
            RegisterNo();
        }
        private void cb_regNo_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateTextBoxes();
        }
        private void cb_regNo_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateInformation();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult askDelete = MessageBox.Show("Are you sure, Do you really want to Delete this Recode...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (askDelete == DialogResult.Yes)
            {
                deleteIthem();
                ClearRegister();
                RegisterNo();
                cb_regNo.Text = "";
            }
        }

        
    }
}

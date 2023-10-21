﻿using System;
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
        }
        public void AddInformations()
        {
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();

            string gender = rb_male.Checked && !rb_female.Checked ? "male" : "female";

            string insertQuery = "INSERT INTO " + connectionsVariable.Database + "." + connectionsVariable.Table +
                                 "(regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                                 "VALUES (@RegNo, @FirstName, @LastName, @DateOfBirth, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @ParentName, @NIC, @ContactNo)";

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

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data Inserted!");
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
        public void UpdateInformation(int regNo, string firstName, string lastName, string dateOfBirth, string gender, string address, string email, string mobilePhone, string homePhone, string parentName, string nic, string contactNo)
        {
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();

            string updateQuery = "UPDATE " + connectionsVariable.Database + "." + connectionsVariable.Table +
                                " SET firstName = @FirstName, lastName = @LastName, dateOfBirth = @DateOfBirth, gender = @Gender, " +
                                "address = @Address, email = @Email, mobilePhone = @MobilePhone, homePhone = @HomePhone, " +
                                "parentName = @ParentName, nic = @NIC, contactNo = @ContactNo " +
                                "WHERE regNo = @RegNo";

            using (MySqlConnection connection = new MySqlConnection($"datasource={connectionsVariable.Server}; port={connectionsVariable.Port}; username={connectionsVariable.User}; password={connectionsVariable.Password};"))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@MobilePhone", mobilePhone);
                        command.Parameters.AddWithValue("@HomePhone", homePhone);
                        command.Parameters.AddWithValue("@ParentName", parentName);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@ContactNo", contactNo);
                        command.Parameters.AddWithValue("@RegNo", regNo);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Updated!");
                        }
                        else
                        {
                            MessageBox.Show("No matching record found for the given registration number.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
                String selectQuery = $"SELECT * From {connectionsVariable.Database}.{connectionsVariable.Table}";
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
                MessageBox.Show (ex.Message);
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
            MySqlConnection Connection = new MySqlConnection($"datasource={connectionsVariable.Server}; port={connectionsVariable.Port}; username={connectionsVariable.User}; password={connectionsVariable.Password};");

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
            this.Close();
        }

        private void btnConnections_Click(object sender, EventArgs e)
        {
            //ConnectionsVariable connectionsVariable = new ConnectionsVariable();
            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            AddInformations();
        }
    }
}

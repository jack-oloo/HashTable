using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

//This hashtable uses an object instead if a string - first name and employee's last name

namespace HashTableAssignment
{
    public partial class Form1 : Form
    {
        private Hashtable table;
        public Form1()
        {
            InitializeComponent();

            table = new Hashtable();
        }

        //clearing field after every time data has been added
        private void clear_fields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }
        private void btnAddToHash_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    throw new Exception("No Data Entered!");
                }
                //calling constructor
                Employee emp = new Employee(txtFirstName.Text, txtLastName.Text);
                //generating last name as key - used to retrieve the hash table data
                table.Add(emp.lastName, emp);
                //updating status
                lblStatus.Text = emp.ToString() + " has been added";

                clear_fields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblStatus.Text = "ERROR: " + ex.Message;
            }
        }

        private void btnRetrieveFromHash_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLastName.Text == "")
                    throw new Exception("No last name entered");

                object result = table[txtLastName.Text];
                if (result != null)
                    lblStatus.Text = "Results: " + result.ToString();
                else
                    lblStatus.Text = txtLastName.Text + " is not part of the hash table.";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveFromHash_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLastName.Text == "")
                    throw new Exception("Please enter last name!");
                table.Remove(txtLastName.Text);
                lblStatus.Text = txtLastName.Text + " was removed!";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "The table is currently: ";
            if (table.Count == 0)
                lblStatus.Text += " empty!";
            else
                lblStatus.Text += " not empty!";
        }

        private void btnContainsKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLastName.Text == "")
                    throw new Exception("Please enter last name!");
                lblStatus.Text = "Contains Keys: " + table.ContainsKey(txtLastName.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearHashTable_Click(object sender, EventArgs e)
        {
            table.Clear();
            lblStatus.Text = "Hash table has been cleared";
        }

        private void btnListEmployees_Click(object sender, EventArgs e)
        {
            //getting enumerator to build enumeration
            //itterating every element that the hash table contains
            IDictionaryEnumerator eNum = table.GetEnumerator();

            //building the string
            StringBuilder buffer = new StringBuilder();

            while (eNum.MoveNext())
                buffer.Append(eNum.Value + "\r\n");
            txtContainer.Text = buffer.ToString();

        }

        private void btnListKeys_Click(object sender, EventArgs e)
        {
            IDictionaryEnumerator eNum = table.GetEnumerator();

            //building the string
            StringBuilder buffer = new StringBuilder();

            while (eNum.MoveNext())
                buffer.Append(eNum.Key + "\r\n");
            txtContainer.Text = buffer.ToString();
        }
    }
}

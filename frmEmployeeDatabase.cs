using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeApplication;

namespace EmployeeApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //static identifiers, because the class Employee requires a static variable
        static int EID = 0;
        static string FirstN = "";
        static string LastN = "";
        static string POS = "";

        //Declaring new Employee, from Employee class
        Employee EmployeeData = new Employee(EID, FirstN, LastN, POS);

        //Declaring a button event, actions to be performed are inside its code block
        private void button1_Click(object sender, EventArgs e)
        {
            //Specified returning error if button is clicked and a textbox is empty
            if (string.IsNullOrWhiteSpace(textBox_EID.Text))
            {
                MessageBox.Show("Empty ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_FN.Text))
            {
                MessageBox.Show("Empty First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_LN.Text))
            {
                MessageBox.Show("Empty Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_Pos.Text))
            {
                MessageBox.Show("Position is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString();
                return;
            }     

            //The try-catch block for handling exceptions and errors
            try
            {
                EID = Int32.Parse(textBox_EID.Text);
                FirstN = textBox_FN.Text;
                LastN = textBox_LN.Text;
                POS = textBox_Pos.Text;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Called the function, when button is clicked, this will be called and perform the function
            AddData();

            //Clears all the textbox after adding data
            textBox_EID.Clear();
            textBox_FN.Clear();
            textBox_LN.Clear();
            textBox_Pos.Clear();
        }

        //Function for adding data of the user to the DataGridView
        public void AddData()
        {
            this.dataGridView1.Rows.Add(EmployeeData);
        }

    }
}

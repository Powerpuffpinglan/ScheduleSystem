using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personalInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.powiDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'powiDataSet.PersonalInfo' table. You can move, or remove it, as needed.
            this.personalInfoTableAdapter1.Fill(this.powiDataSet.PersonalInfo);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void personellNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void personellNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void scheduleCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void scheduleCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalInfoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personalInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.powiDataSet);

        }

        private void AddScheduleBtn_Click(object sender, EventArgs e)
        {
            ScheduleUpload scheduleupload = new ScheduleUpload();
            scheduleupload.Show();

        }
    }
}

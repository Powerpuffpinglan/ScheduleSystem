using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Transactions;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data.Common;
using Microsoft.Office.Interop.Excel;

namespace EmployeeApp
{
    public partial class AddSchedule : Form
    {
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void scheduleTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduleTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.powiDataSet);

        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'powiDataSet.ScheduleFile' table. You can move, or remove it, as needed.
            this.scheduleFileTableAdapter.Fill(this.powiDataSet.ScheduleFile);
            // TODO: This line of code loads data into the 'powiDataSet.ScheduleTable' table. You can move, or remove it, as needed.
            this.scheduleTableTableAdapter.Fill(this.powiDataSet.ScheduleTable);

        }
        //Go to AddEmployee
        private void addEmployeeBnt_Click(object sender, EventArgs e)
        {
            AddEmployee goTo = new AddEmployee();
            goTo.Show();
        }
        
        //Here we read from a file and adds the values to the database
        private void choseFilBnt_Click(object sender, EventArgs e)
        {
            ChoseFile goTo = new ChoseFile();
            goTo.Show();
            
         

        }

        private void fileUploaderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

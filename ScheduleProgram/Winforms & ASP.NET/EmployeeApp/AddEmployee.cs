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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        //Save, Delite, Add in to the database
        private void personalInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.powiDataSet);

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'powiDataSet.PersonalInfo' table. You can move, or remove it, as needed.
            this.personalInfoTableAdapter.Fill(this.powiDataSet.PersonalInfo);

        }
        //Go to AddSchedule
        private void AddScheduleBtn_Click(object sender, EventArgs e)
        {
            AddSchedule goTo = new AddSchedule();
            goTo.Show();
        }
    }
}

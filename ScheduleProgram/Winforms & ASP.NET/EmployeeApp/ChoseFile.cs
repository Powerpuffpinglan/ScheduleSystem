using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace EmployeeApp
{
    public partial class ChoseFile : Form
    {
        private string path;
        public ChoseFile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void choseFileBnt_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files(*.csv)| *.csv|All files (*.*)|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                fileNameTxb.Text = path;
            }

        }

        private void saveBnt_Click(object sender, EventArgs e)
        {
            imoprtFile(path);
            
        }
        private void imoprtFile(string path)
        {
            Stream myStream = null;
            try
            {
               
              using (myStream)
                    {
                    
                     var connString = "Data Source=79.137.79.36;Initial Catalog=Powi;User ID=powi;Password=pinglan";
                     var sqlConnection = new SqlConnection(connString);
                     List<ScheduleFileModel> values = File.ReadAllLines(fileNameTxb.Text).Skip(1).Select(v => ScheduleFileModel.FromCsv(v)).ToList();
                     sqlConnection.Open();
                     using (var scope = new TransactionScope())
                        {
                          string sqlIns = "INSERT INTO ScheduleFile (Week, Day, Time, ScheduleCode) VALUES(@week, @day, @time, @scheduleCode)";

                          foreach (var value in values)
                            {
                                var cmdIns = new SqlCommand(sqlIns, sqlConnection);
                                cmdIns.Parameters.AddWithValue("@week", value.Week);
                                cmdIns.Parameters.AddWithValue("@day", value.Day);
                                cmdIns.Parameters.AddWithValue("@time", value.Time);
                                cmdIns.Parameters.AddWithValue("@scheduleCode", value.ScheduleCode);
                                cmdIns.ExecuteNonQuery();
                            }
                            scope.Complete();
                        }
                        sqlConnection.Close();
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void closeBnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

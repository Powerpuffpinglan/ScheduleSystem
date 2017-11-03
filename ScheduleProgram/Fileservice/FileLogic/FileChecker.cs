using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Transactions;
namespace FileLogic
{
    class FileChecker
    {
        string _path="";
        string _MovePath = "";
        public FileChecker(string path)
        {
            try
            {
                _path = path;
                _MovePath = _path + @"\moved\";
                if (Directory.Exists(_path) == false)
                    Directory.CreateDirectory(_path);

                if (Directory.Exists(_MovePath) == false)
                    Directory.CreateDirectory(_MovePath);
            }
            catch (Exception ex)
            {
                //ToDo: Logga till loggfil eller eventlog
                Console.WriteLine(ex.Message);
            }

        }

        //ToDo: Logga till loggfil
        public void MoveFilesFromFolder()
        {
            DirectoryInfo myFileList = new DirectoryInfo(_path);
            FileInfo[] filer =  myFileList.GetFiles();
            if (filer.Length == 0)
                Console.WriteLine("No files found");
                
            
            foreach (FileInfo item in filer)
            {
                Connect(item);
                item.MoveTo(_MovePath + item.Name);
                Console.WriteLine(item.Name + " moved to: " + _MovePath);
            }
        }
        //Contecting to database and insert the difrent values form the file in the map.
        private void Connect(FileInfo fI)
        {
            var connString = "Data Source=79.137.79.36;Initial Catalog=Powi;User ID=powi;Password=pinglan";
            var sqlConnection = new SqlConnection(connString);
            List<ScheduleFileModel> values = File.ReadAllLines(_path  +"\\"+ fI.Name).Skip(1).Select(v => ScheduleFileModel.FromCsv(v)).ToList();
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

}

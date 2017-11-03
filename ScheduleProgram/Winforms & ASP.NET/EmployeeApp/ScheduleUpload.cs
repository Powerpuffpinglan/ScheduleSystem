using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class ScheduleUpload : Form
    {
        public ScheduleUpload()
        {
            InitializeComponent();
        }

        private void ScheduleUpload_Load(object sender, EventArgs e)
        {

        }

        private void scheduleTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduleTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.powiDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fileUploader_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {


                    //            [ResponseType(typeof(FileUpload))]
                    //public IHttpActionResult PostFileUpload()
                    //{
                    //    if (HttpContext.Current.Request.Files.AllKeys.Any())
                    //    {
                    //        // Get the uploaded image from the Files collection  
                    //        var httpPostedFile = HttpContext.Current.Request.Files["UploadedImage"];
                    //        if (httpPostedFile != null)
                    //        {
                    //            FileUploader imgupload = new FileUpload();
                    //            int length = httpPostedFile.ContentLength;
                    //            imgupload.imagedata = new byte[length]; //get imagedata  
                    //            httpPostedFile.InputStream.Read(imgupload.imagedata, 0, length);
                    //            imgupload.imagename = Path.GetFileName(httpPostedFile.FileName);
                    //            db.FileUploads.Add(imgupload);
                    //            db.SaveChanges();
                    //            // Make sure you provide Write permissions to destination folder
                    //            string sPath = @"C:\Users\xxxx\Documents\UploadedFiles";
                    //            var fileSavePath = Path.Combine(sPath, httpPostedFile.FileName);
                    //            // Save the uploaded file to "UploadedFiles" folder  
                    //            httpPostedFile.SaveAs(fileSavePath);
                    //            return Ok("Image Uploaded");
                    //        }
                    //    }

                    //    return Ok("Image is not Uploaded");


                }
            }
        }
    }
}
        


        // POST: api/FileUploads
        //[ResponseType(typeof(FileUpload))]
        //    public IHttpActionResult PostFileUpload()
        //    {
        //        if (HttpContext.Current.Request.Files.AllKeys.Any())
        //        {
        //            // Get the uploaded image from the Files collection  
        //            var httpPostedFile = HttpContext.Current.Request.Files["UploadedImage"];
        //            if (httpPostedFile != null)
        //            {
        //                FileUpload imgupload = new FileUpload();
        //                int length = httpPostedFile.ContentLength;
        //                imgupload.imagedata = new byte[length]; //get imagedata  
        //                httpPostedFile.InputStream.Read(imgupload.imagedata, 0, length);
        //                imgupload.imagename = Path.GetFileName(httpPostedFile.FileName);
        //                db.FileUploads.Add(imgupload);
        //                db.SaveChanges();
        //                // Make sure you provide Write permissions to destination folder
        //                string sPath = @"C:\Users\xxxx\Documents\UploadedFiles";
        //                var fileSavePath = Path.Combine(sPath, httpPostedFile.FileName);
        //                // Save the uploaded file to "UploadedFiles" folder  
        //                httpPostedFile.SaveAs(fileSavePath);
        //                return Ok("Image Uploaded");
        //            }
        //        }
        //        return Ok("Image is not Uploaded");
//        //    }
//    }
//            }
//        }
//    }
//}

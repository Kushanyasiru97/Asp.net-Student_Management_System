using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_Systems
{
    public partial class CS : System.Web.UI.Page
    {
        protected void FTPUpload(object sender, EventArgs e)
        {
           //Server URL
            string ftp = "server_name";

            //FTP Folder name. Leave blank if you want to upload to root folder.
            string ftpFolder = "D://FTP/";

            byte[] fileBytes = null;

            //Read the FileName and convert it to Byte array.
            string fileName = Path.GetFileName(FileUpload1.FileName);
            using (StreamReader fileStream = new StreamReader(FileUpload1.PostedFile.InputStream))
            {
                fileBytes = Encoding.UTF8.GetBytes(fileStream.ReadToEnd());
                fileStream.Close();
            }

            try
            {
                //Create FTP Request.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftp + ftpFolder + fileName);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                //Enter FTP Server credentials.
                request.Credentials = new NetworkCredential("UserName", "Password");
                request.ContentLength = fileBytes.Length;
                request.UsePassive = true;
                request.UseBinary = true;
                request.ServicePoint.ConnectionLimit = fileBytes.Length;
                request.EnableSsl = false;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileBytes, 0, fileBytes.Length);
                    requestStream.Close();
                }

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                lblMessage.Text += fileName + " uploaded.<br />";
                response.Close();
            }
            catch (WebException ex)
            {
                throw new Exception((ex.Response as FtpWebResponse).StatusDescription);
            }
        }
    }
}
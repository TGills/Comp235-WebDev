using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Lab01
{
    public partial class FileUpload : System.Web.UI.Page
    {
        private bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            
            

            if(Request.QueryString["id"] != null)
            {
                string fileName = Request.QueryString["id"].ToString();
                string filePath = "~/UploadedFiles/" + fileName;
                File.Delete(Server.MapPath(filePath));
                if (File.Exists(Server.MapPath("~/UploadedFiles/thumbs.db")))
                {
                    File.Delete(Server.MapPath("~/UploadedFiles/thumbs.db"));
                }
            }
            DirectoryInfo dir = new DirectoryInfo(MapPath("~/UploadedFiles/"));
            dlstImages.DataSource = dir.GetFiles();
            dlstImages.DataBind();






        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = "~/UploadedFiles/" + fupUploader.FileName;
            if (CheckFileType(filePath))
            {
                fupUploader.SaveAs(MapPath(filePath));
            }
        }
    }
}
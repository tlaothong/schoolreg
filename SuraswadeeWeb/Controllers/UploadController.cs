using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace SuraswadeeWeb.Controllers
{
    public class UploadController : ApiController
    {      
        public async System.Threading.Tasks.Task<string> Post()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = System.Web.HttpContext.Current.Server.MapPath("~/ImgUpload");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder(); // Holds the response body

                // Read the form data and return an async task.
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the form data.
                foreach (var key in provider.FormData.AllKeys)
                {
                    foreach (var val in provider.FormData.GetValues(key))
                    {
                        sb.Append(string.Format("{0}: {1}\n", key, val));
                    }
                }

                var localfileURL = string.Empty;
                var serverfileURL = string.Empty;
                // This illustrates how to get the file names for uploaded files.
                foreach (var file in provider.FileData)
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.LocalFileName);
                    sb.Append(string.Format("Uploaded file: {0} ({1} bytes)\n", fileInfo.Name, fileInfo.Length));

                    var fileName = Guid.NewGuid().ToString() + ".jpg";

                    localfileURL = System.Web.HttpContext.Current.Server.MapPath("~/ImgUpload/Img/" + fileName);


                    fileInfo.MoveTo(localfileURL);

                    //Fix URL
                    serverfileURL = new StringBuilder().Append("http://echecker-vanlek.azurewebsites.net").Append("/ImgUpload/Img/").Append(fileName).ToString();
                }


                return serverfileURL;
                //return new HttpResponseMessage()
                //{
                //    Content = new StringContent(sb.ToString())
                //};
            }
            catch (System.Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    }
}

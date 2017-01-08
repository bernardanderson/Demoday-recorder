using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using demoday_record.Private;
using demoday_record.Models;
using System.Threading.Tasks;
using System.IO;

namespace demoday_record.Controllers
{
    public class TakePhoto
    {
        private static HttpClient Client = new HttpClient();

        public async Task<Picture> CameraSnapshot(long sentCaptureTime)
        {
            HttpResponseMessage response = await Client.GetAsync($"http://{PrivateParameters.cameraIP}/shot.jpg");

            Picture pictureStream = new Picture
            {
                data = await response.Content.ReadAsByteArrayAsync(),
                encodeType = "image/jpeg",
            };
            File.WriteAllBytes($"/demodaypics/{sentCaptureTime}.jpg", pictureStream.data);
            return pictureStream;
        }
    }
}

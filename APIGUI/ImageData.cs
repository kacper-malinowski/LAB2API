using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APIGUI
{
    internal class ImageData
    {
        public int Id { get; set; }
        public string? Copyright { get; set; }
        public string Date { get; set; }
        public string? Explanation { get; set; }
        public string Hdurl { get; set; }
        public string Title { get; set; }
        public string? Url { get; set; }
        public byte[] imageBytes;
        public override string ToString()
        {
            return Title;
        }

        public ImageData() { }

        public ImageData(Response response)
        {
            Copyright = response.copyright;
            Date = response.date;
            Explanation = response.explanation;
            Hdurl = response.hdurl;
            Title = response.title;
            Url = response.url;
            WebClient webClient = new WebClient();
            if (Hdurl != "")
            {
                imageBytes = webClient.DownloadData(Hdurl);
            }
            else
            {
                imageBytes = webClient.DownloadData("https://freesvg.org/img/Simple-Image-Not-Found-Icon.png");
            }
        }
    }
}


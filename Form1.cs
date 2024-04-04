using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Windows.Forms;
using System.Web;
using System.IO;

namespace APIGUI {
    public partial class Form1 : Form
    {
        private Cosmic cosmic;
        List<Response> toBeAdded;
        public Form1()
        {
            InitializeComponent();
            cosmic = new Cosmic();
            toBeAdded = new List<Response>();
            cosmic.SaveChanges();
            dbListBox.DataSource = cosmic.CosmicImages.ToList();
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private bool DoesImageExist(DbSet<ImageData> CosmicImages, Response response)
        {
            foreach (ImageData image in CosmicImages)
            {
                if (image.Hdurl == response.hdurl)
                {
                    return true;
                }
            }
            return false;
        }

        private void addButtonOnClikc(object sender, EventArgs e)
        {
            foreach (Response response in toBeAdded)
            {
                if (!DoesImageExist(cosmic.CosmicImages, response))
                    cosmic.CosmicImages.Add(new ImageData(response));
            }
            cosmic.SaveChanges();
            dbListBox.DataSource = cosmic.CosmicImages.ToList();
            toBeAdded.Clear();

        }



        private async void requestButtonOnClick(object sender, EventArgs e)
        {
            Httprequests httprequests = new Httprequests();
            Input input = new Input();

            input = input.LoadInput(this);
            await httprequests.GetData(input);
            deserializedTextBox.Text = string.Empty;

            foreach (var item in httprequests.deserialized)
            {
                toBeAdded.Add(item);
                deserializedTextBox.Text += item.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cosmic.CosmicImages.RemoveRange(cosmic.CosmicImages);
            cosmic.SaveChanges();
            dbListBox.DataSource = cosmic.CosmicImages.ToList();
        }


        private void DisplayImageFromTitle(string imageTitle)
        {

            ImageData imageData = cosmic.CosmicImages.FirstOrDefault(imageData => imageData.Title == imageTitle);
            titleText.Text = "Title: " + imageData.Title;
            dateText.Text = "Date: " + imageData.Date;
            explanationText.Text = imageData.Explanation;

            using (var stream = new System.IO.MemoryStream(imageData.imageBytes))
            {
                Image image = Image.FromStream(stream);
                imageBox.Image = image;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            string imageTitle = dbListBox.Text;

            DisplayImageFromTitle(imageTitle);

        }

    }
}

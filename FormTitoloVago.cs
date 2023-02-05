using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Xml.Linq;

namespace OMDB_API
{
    public partial class FormTitoloVago : Form
    {
        static HttpClient client = new HttpClient();
        static string apiKey = "61f7411";
        public Film[] film { set; get; }
        public FormTitoloVago()
        {
            InitializeComponent();
            InitializeComponent();
            client.BaseAddress = new Uri("http://www.omdbapi.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void FormTitoloVago_Load(object sender, EventArgs e)
        {
            GenerateControls();
        }

        private async void label_title_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTitoloPreciso formTitoloPreciso= new FormTitoloPreciso();
            //formTitoloPreciso.filmPreciso = await GetFilmPrecisoAsync($"?apikey={apiKey}&t={label_title.Text}");
            formTitoloPreciso.Show();
        }
        private static async Task<FilmPreciso> GetFilmPrecisoAsync(string s)
        {
            FilmPreciso filmPreciso = null;
            HttpResponseMessage response = await client.GetAsync(s);
            if (response.IsSuccessStatusCode)
            {
                filmPreciso = await JsonSerializer.DeserializeAsync<FilmPreciso>(await response.Content.ReadAsStreamAsync());
            }
            return filmPreciso;
        }
        private void GenerateControls()
        {
            int x = 10;
            int y = 10;
            int height = 100;
            int width = 100;

            for (int i = 0; i < 6; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(x, y);
                pictureBox.Size = new Size(width, height);
                pictureBox.Load("https://images.unsplash.com/photo-1472457897821-70d3819a0e24?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8c21hbGx8ZW58MHx8MHx8&w=1000&q=80");
                this.Controls.Add(pictureBox);

                for (int j = 0; j < 3; j++)
                {
                    Label label = new Label();
                    label.Location = new Point(x+100, y + height);
                    label.Text = "Label " + (j + 1);
                    Controls.Add(label);
                }

                y += height;
            }
        }
    }
}

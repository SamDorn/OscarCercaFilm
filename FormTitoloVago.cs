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
        public RisultatoRicerca risultatoRicerca { set; get; }
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
            int num = 0;
            int x = 10;
            int y = 10;
            int height = 100;
            int width = 100;

            for (int i = 0; i <risultatoRicerca.Search.Length; i++)
            {
                num += 1;
                if (num == 6)
                    break;      
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(x, y);
                pictureBox.Size = new Size(width, height);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Load(risultatoRicerca.Search[i].Poster);
                Controls.Add(pictureBox);

                for (int j = 0; j < 3; j++)
                {
                    Label label = new Label();
                    label.Location = new Point(x+100, y + height);
                    label.Text = "Label " + (j + 1);
                    Controls.Add(label);
                }

                y += height;
            }
            height = 100;
            y = 10;
            for(int i = num-1; i < risultatoRicerca.Search.Length; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(x+300, y);
                pictureBox.Size = new Size(width, height);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Load(risultatoRicerca.Search[i].Poster);
                Controls.Add(pictureBox); y += height;
            }
        }
    }
}

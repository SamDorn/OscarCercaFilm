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
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        static string apiKey = "61f7411";

        public FilmPreciso filmPreciso = null;
        Film[] film = null;

        public Form1()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://www.omdbapi.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }


        private async void btn_search_Click(object sender, EventArgs e)
        {
            if (check_box_isPrecise.Checked)
            {
                FormTitoloPreciso FormTitoloPreciso = new FormTitoloPreciso();
                filmPreciso = await GetFilmPrecisoAsync($"?apikey={apiKey}&t={txt_box_title.Text}");
                FormTitoloPreciso.filmPreciso = filmPreciso;
                FormTitoloPreciso.Show();
            }
            else
            {
                FormTitoloVago formTitoloVago= new FormTitoloVago();
                //film = await GetFilmVagoAsync($"?apikey={apiKey}&s={txt_box_title.Text}");
                //formTitoloVago.film = film;
                formTitoloVago.Show();
            }
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
        private static async Task<Film[]> GetFilmVagoAsync(string s)
        {
            Film[] filmVago = null;
            HttpResponseMessage response = await client.GetAsync(s);
            if (response.IsSuccessStatusCode)
            {
                for(int i = 0; i < 9; i++)
                {
                    Film film = await JsonSerializer.DeserializeAsync<Film>(await response.Content.ReadAsStreamAsync());

                    filmVago.Append(film);
                }
                
            }
            return filmVago;
        }
    }
}

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMDB_API
{
    public partial class FormPrincipale : Form
    {
        static HttpClient client = new HttpClient();
        static string apiKey = "61f7411";

        public FilmPreciso filmPreciso = null;
        RisultatoRicerca risultatoRicerca = null;


        public FormPrincipale()
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
                FormTitoloVago formTitoloVago = new FormTitoloVago();
                risultatoRicerca = await GetFilmVagoAsync($"?apikey={apiKey}&s={txt_box_title.Text}");
                formTitoloVago.risultatoRicerca = risultatoRicerca;
                if (risultatoRicerca.Response == "False")
                {
                    MessageBox.Show("Film non trovato o troppi film", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                formTitoloVago.search = $"?apikey={apiKey}&s={txt_box_title.Text}";
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
        private static async Task<RisultatoRicerca> GetFilmVagoAsync(string s)
        {
            RisultatoRicerca risultatoRicerca = null;
            HttpResponseMessage response = await client.GetAsync(s);
            if (response.IsSuccessStatusCode)
            {
                risultatoRicerca = await JsonSerializer.DeserializeAsync<RisultatoRicerca>(await response.Content.ReadAsStreamAsync());


            }
            return risultatoRicerca;
        }
    }


    public class RisultatoRicerca
    {
        public Film[] Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }


}

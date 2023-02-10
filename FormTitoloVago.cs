using System;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMDB_API
{
    public partial class FormTitoloVago : Form
    {
        public string title { get; set; }
        private int page = 1;
        public string search { get; set; }
        string apiKey = "61f7411";
        static HttpClient client = null;
        public RisultatoRicerca risultatoRicerca { set; get; }
        public FormTitoloVago()
        {
            InitializeComponent();

            client = new HttpClient();
            try
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
            }
            catch 
            {
                client = null;
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
            }
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void FormTitoloVago_Load(object sender, EventArgs e)
        {
            GenerateControls();
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

            for (int i = 0; i < risultatoRicerca.Search.Length; i++)
            {
                num += 1;
                if (num == 6)
                    break;
                
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(x, y);
                pictureBox.Size = new Size(width, height);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (risultatoRicerca.Search[i].Poster == "N/A")
                    pictureBox.Load("https://thegoldrivercompany.com.au/wp-content/uploads/2017/09/not-available.jpg");
                else
                    pictureBox.Load(risultatoRicerca.Search[i].Poster);
                Controls.Add(pictureBox);

                Controls.Add(pictureBox);
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Location = new Point(x + 100, y + 35);
                linkLabel.Text = risultatoRicerca.Search[i].Title;
                linkLabel.Font = new Font("Arial", 12);
                linkLabel.Size = new Size(200, 50);
                linkLabel.Click += async (s, e) => 
                {

                    FormTitoloPreciso formTitoloPreciso = new FormTitoloPreciso();

                    formTitoloPreciso.filmPreciso = await GetFilmPrecisoAsync($"?apikey={apiKey}&t={linkLabel.Text}");

                    formTitoloPreciso.Show();

                };
                Controls.Add(linkLabel);

                y += height;
            }
            height = 100;
            y = 10;
            for (int i = num - 1; i < risultatoRicerca.Search.Length; i++)
            {
                if (num == risultatoRicerca.Search.Length)
                    break;
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(x + 300, y);
                pictureBox.Size = new Size(width, height);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (risultatoRicerca.Search[i].Poster == "N/A")
                    pictureBox.Load("https://thegoldrivercompany.com.au/wp-content/uploads/2017/09/not-available.jpg");

                else
                    pictureBox.Load(risultatoRicerca.Search[i].Poster);
                
                Controls.Add(pictureBox);
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Location = new Point(x + 400, y+35);
                linkLabel.Text = risultatoRicerca.Search[i].Title;
                linkLabel.Font = new Font("Arial", 12);
                linkLabel.Size = new Size(200, 50);
                
                linkLabel.Click += async (s, e) =>
                {

                    FormTitoloPreciso formTitoloPreciso = new FormTitoloPreciso();

                    formTitoloPreciso.filmPreciso = await GetFilmPrecisoAsync($"?apikey={apiKey}&t={linkLabel.Text}");

                    formTitoloPreciso.Show();

                };
                Controls.Add(linkLabel);

                y += height;

                if(i == 9)
                {
                    Button button= new Button();
                    button.Location = new Point(x+250,y+20);
                    button.Size = new Size(100, 50);
                    button.Text = "Visualizza altri";
                    button.Font = new Font("Arial", 8);

                    button.Click += async (s, e) =>
                    {

                        FormTitoloVago formTitoloVago = new FormTitoloVago();
                        formTitoloVago.page = page +1;
                        formTitoloVago.title = title;

                        formTitoloVago.risultatoRicerca = await FormTitoloVago.GetFilmVagoAsync($"?apikey={formTitoloVago.apiKey}&s={formTitoloVago.title}&page={formTitoloVago.page}");

                        formTitoloVago.Show(); 
                        
                        Close();

                    };
                    Controls.Add(button);

                }
            }

        }
        public static async Task<RisultatoRicerca> GetFilmVagoAsync(string s)
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
}

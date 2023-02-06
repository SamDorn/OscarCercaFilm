using System;
using System.Windows.Forms;

namespace OMDB_API
{
    public partial class FormTitoloPreciso : Form
    {
        public FilmPreciso filmPreciso { set; get; }
        public FormTitoloPreciso()
        {
            InitializeComponent();
        }

        private void FormTitoloPreciso_Load(object sender, EventArgs e)
        {
            if(filmPreciso.Poster == "N/A")
            {
                picture_box.Load("https://thegoldrivercompany.com.au/wp-content/uploads/2017/09/not-available.jpg");
                label1_genre.Text += filmPreciso.Genre;
                label_actors.Text += filmPreciso.Actors;
                label_awards.Text += filmPreciso.Awards;
                label_director.Text += filmPreciso.Director;
                label_rating.Text += filmPreciso.Metascore;
                label_title.Text += filmPreciso.Title;
                label_writer.Text += filmPreciso.Writer;
                label_year.Text += filmPreciso.Year;
                return;
            }
            picture_box.Load(filmPreciso.Poster);
            label1_genre.Text += filmPreciso.Genre;
            label_actors.Text += filmPreciso.Actors;
            label_awards.Text += filmPreciso.Awards;
            label_director.Text += filmPreciso.Director;
            label_rating.Text += filmPreciso.Metascore;
            label_title.Text += filmPreciso.Title;
            label_writer.Text += filmPreciso.Writer;
            label_year.Text += filmPreciso.Year;
        }
    }
}

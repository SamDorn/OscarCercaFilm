using System;

namespace OMDB_API
{
    public class Film
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }

        override
        public string ToString()
        {
            return "Titolo: " + Title + Environment.NewLine + "Anno: " + Year + Environment.NewLine + "Tipo: " + Type + Environment.NewLine;
        }
    }
}

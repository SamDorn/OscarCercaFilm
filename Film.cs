using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMDB_API
{
    public class Film 
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Poster { get; set; }
        public string Type { get; set; }

        override
        public string ToString()
        {
            return "Titolo: " + Title+ Environment.NewLine + "Anno: " + Year + Environment.NewLine + "Tipo: " + Type + Environment.NewLine;
        }
    }
}

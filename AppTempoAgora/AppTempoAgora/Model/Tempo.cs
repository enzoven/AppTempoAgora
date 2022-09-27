using System;
using System.Collections.Generic;
using System.Text;

namespace AppTempoAgora.Model
{
    class Tempo
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visiblity { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }



        public Tempo()
        {
            this.Title = " ";
            this.Temperature = " ";
            this.Wind = " ";
            this.Humidity = " ";
            this.Visiblity = " ";
            this.Sunrise = " ";
            this.Sunset = " ";

        }

    }

}

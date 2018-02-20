using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Parking
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Double Longitude { get; set; }

        public Double Latitude { get; set; }

        public int TotalPlaces { get; set; }

        public int FreePlaces { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Concert
    {
        public int ArtisteId { get; set; }
        public int FestivalId { get; set; }

        public double Cachet {  get; set; }
        public DateTime DateConcert { get; set; }
        public int Duree {  get; set; }
    }
}

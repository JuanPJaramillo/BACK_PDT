using System;
using System.Collections.Generic;

namespace PDT.CORE.Entities
{
    public partial class Flight
    {
        public Flight()
        {
            DetailsFlights = new HashSet<DetailsFlight>();
        }

        public decimal IdxFlights { get; set; }
        public string? DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public decimal? Money { get; set; }
        public DateTime? Hour { get; set; }
        public decimal? Adult { get; set; }
        public decimal? Child { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<DetailsFlight> DetailsFlights { get; set; }
    }
}

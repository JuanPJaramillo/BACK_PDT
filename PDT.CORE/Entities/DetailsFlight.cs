using System;
using System.Collections.Generic;

namespace PDT.CORE.Entities
{
    public partial class DetailsFlight
    {
        public decimal IdxDetailsFlights { get; set; }
        public decimal? IdxFlights { get; set; }
        public string? DocumentPerson { get; set; }
        public string? NamePerson { get; set; }
        public DateTime? DateBirth { get; set; }
        public bool? IsChild { get; set; }

        public virtual Flight? IdxFlightsNavigation { get; set; }
    }
}

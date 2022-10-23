namespace PDT.CORE.DTOs
{
    public partial class FlightDto
    {
        public decimal IdxFlights { get; set; }
        public string? DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public decimal? Money { get; set; }
        public DateTime? Hour { get; set; }
        public decimal? Adult { get; set; }
        public decimal? Child { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

using AutoMapper;
using PDT.CORE.DTOs;
using PDT.CORE.Entities;

namespace Servicios.Infrastructure.Mapeos
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Flight, FlightDto>();
            CreateMap<DetailsFlight, DetailsFlightDto>();
          
            //--------------------------------------------------

            CreateMap<FlightDto, Flight>();
            CreateMap<DetailsFlightDto, DetailsFlight>();
        }
    }
}

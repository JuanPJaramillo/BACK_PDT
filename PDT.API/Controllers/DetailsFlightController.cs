using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDT.CORE.DTOs;
using PDT.CORE.Entities;
using PDT.CORE.Interfaces;
using Servicios.Infrastructure.Mapeos;

namespace PDT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsFlightController : ControllerBase
    {
        private readonly IDetailsFlightRepository _flight;
        private readonly IMapper _mapper;

        public DetailsFlightController(IDetailsFlightRepository flight, IMapper mapper )
        {
            _flight = flight;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var flight = await _flight.GetAll();
            var mapping = _mapper.Map<IEnumerable<DetailsFlightDto>>(flight);
            return Ok(mapping);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DetailsFlightDto flightDto)
        {
            var mapping = _mapper.Map<DetailsFlight>(flightDto);
            await _flight.Add(mapping);
            flightDto = _mapper.Map<DetailsFlightDto>(mapping);

            return Ok(flightDto);
        }
    }
}

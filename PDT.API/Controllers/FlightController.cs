using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PDT.CORE.DTOs;
using PDT.CORE.Entities;
using PDT.CORE.Interfaces;

namespace PDT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightRepository _flight;
        private readonly IMapper _mapper;
        public FlightController(IFlightRepository flight, IMapper mapper)
        {
            _flight = flight;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var flight = await _flight.GetAll();
            var mapping = _mapper.Map<IEnumerable<FlightDto>>(flight);
            return Ok(mapping);
        }

        [HttpPost]
        public async Task<IActionResult> Add(FlightDto flightDto)
        {
            var mapping = _mapper.Map<Flight>(flightDto);
            await _flight.Add(mapping);
            flightDto = _mapper.Map<FlightDto>(mapping);

            return Ok(flightDto);
        }

    }
}

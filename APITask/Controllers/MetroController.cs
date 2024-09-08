using APITask.DTO;
using APITask.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetroController : ControllerBase
    {
        private readonly IMetroTicketService _service;

        public MetroController(IMetroTicketService service)
        {
            _service = service;
        }
        [HttpPost("ticket-price")]
        public IActionResult GetTicketPrice([FromForm] MetroDto request)
        {
            if (request.StartStationId == request.DestinationStationId)
            {
                return BadRequest("Starting and destination stations cannot be the same.");
            }

            try
            {
                int startStationId = (int)request.StartStationId;
                int destinationStationId = (int)request.DestinationStationId;

                // Pass the station IDs to the service
                int price = _service.CalculateTicketPrice(startStationId, destinationStationId);
                return Ok(new { TicketPrice = price });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

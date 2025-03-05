using AutoMapper;
using Common.DTO;
using DB;
using IBEXDATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _OwnerService;
        private readonly ILogger<BankController> _logger;
        private readonly IMapper _mapper;

        public OwnerController(IOwnerService OwnerService, ILogger<BankController> logger, IMapper mapper)
        {
            _OwnerService = OwnerService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var owners = await _OwnerService.Get();
            if (owners != null)
            {
               // var ownerDTOs = _mapper.Map<List<Owner>, List<OwnerDTO>>(owners.ToList());
               // _logger.LogInformation("Successfully retrieved all owners.");
                return Ok(owners);
            }

            _logger.LogWarning("Failed to retrieve owners.");
            return BadRequest();
        }
    }
}

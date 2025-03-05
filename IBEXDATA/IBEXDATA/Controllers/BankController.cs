using IBEXDATA.Models;
using Microsoft.AspNetCore.Mvc;
using Common.DTO;
using Service;
using AutoMapper;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService _BankService;
        private readonly ILogger<BankController> _logger;
        private readonly IMapper _mapper;

        public BankController(IBankService BankService, ILogger<BankController> logger, IMapper mapper)
        {
            _BankService = BankService;
            _logger = logger;
            _mapper = mapper;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var banks = await _BankService.Get();
            if (banks != null)
            {
                var bankDTOs = _mapper.Map<List<Bank>, List<BankDTO>>(banks.ToList());
                _logger.LogInformation("Successfully retrieved all banks.");
                return Ok(bankDTOs);
            }

            _logger.LogWarning("Failed to retrieve banks.");
            return BadRequest();
        }

        [Route("GetNames")]
        [HttpGet]
        public async Task<IActionResult> GetNames()
        {
            var banks = await _BankService.GetNames();

            if (banks != null)
            {
                var bankDTOs = _mapper.Map<List<Bank>, List<BankNamesDTO>>(banks.ToList());
                _logger.LogInformation("Successfully retrieved all banks.");
                return Ok(bankDTOs);
            }

            _logger.LogWarning("Failed to retrieve banks.");
            return BadRequest();
        }
    }
}
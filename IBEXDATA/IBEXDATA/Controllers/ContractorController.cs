using Common.DTO;
using IBEXDATA.Models;
using IBEXDATA.Models;
using IBEXDATA.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractorController : ControllerBase
    {

        private readonly IContractorService _contractorService;

        public ContractorController(IContractorService contractorService)
        {
            _contractorService = contractorService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllContractors()
        {
            var contractors = await _contractorService.GetAllContractors();
            return Ok(contractors);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContractor(ContractorDTO contractor)
        {

            try
            {
                await _contractorService.UpdateContractor(contractor);
                return Ok(new { message = "success" });
            }
            catch (KeyNotFoundException ex)
            {
                return Conflict(ex.Message);
            }
        }

        /// not work


        [HttpPost]
        public async Task<IActionResult> CreateContractor(ContractorDTO contractor)
        {
            await _contractorService.CreateContractor(contractor);
            return Ok(new { message = "success" });
        }

        [Route("GetContractorById/{userId}")]
        [HttpGet]
        public async Task<IActionResult> GetAllContractorById(int userId)
        {
            var contractor = await _contractorService.GetAllContractorById(userId);
            return Ok(contractor);
        }
    }
}

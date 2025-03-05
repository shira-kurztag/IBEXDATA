using IBEXDATA.Models;
using Common.DTO;
using System.Threading.Tasks;
using DB;

namespace IBEXDATA.Services
{
    public class ContractorService : IContractorService
    {
        private readonly IContractorRepository _contractorRepository;



        public ContractorService(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;

        }
        public async Task<List<Contractor>> GetAllContractors()
        {
            return await _contractorRepository.GetAllContractors();
        }
        public async Task CreateContractor(ContractorDTO contractor)
        {
            await _contractorRepository.CreateContractor(contractor);

        }
        public async Task UpdateContractor(ContractorDTO contractor)
        {
            await _contractorRepository.UpdateContractor(contractor);
        }
        public async Task<Contractor> GetAllContractorById(int Id)
        {
            var contractors = await _contractorRepository.GetAllContractors();
            return contractors.Find(x => x.ContractorId == Id);
        }
        
    }
}

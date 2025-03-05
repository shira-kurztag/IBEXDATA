using Common.DTO;
using IBEXDATA.Models;

using System.Threading.Tasks;

namespace DB
{
    public interface IContractorRepository
    {
        Task CreateContractor(ContractorDTO contractor);
        Task<List<Contractor>> GetAllContractors();
        Task UpdateContractor(ContractorDTO contractor);
    }
}

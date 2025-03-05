using IBEXDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IBankService
    {
        Task<IEnumerable<Bank>> Get();
        Task<IEnumerable<Bank>> GetNames();
    }
}

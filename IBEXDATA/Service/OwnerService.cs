using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Common;
using IBEXDATA.Models;

namespace Service
{
    public class OwnerService : IOwnerService
    {
        IOwnerDB _OwnerDB;
        public OwnerService(IOwnerDB OwnerDB)
        {
            _OwnerDB = OwnerDB;
        }

        public async Task<IEnumerable<Owner>> Get()
        {
            return await _OwnerDB.Get();
        }
    }
}

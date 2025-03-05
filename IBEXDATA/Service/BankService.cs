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
    public class BankService : IBankService
    {
        IBankDB _BankDB;
        public BankService(IBankDB BankDB)
        {
            _BankDB = BankDB;
        }

        public async Task<IEnumerable<Bank>> Get()
        {
            return await _BankDB.Get();
        }

        public async Task<IEnumerable<Bank>> GetNames()
        {
            return await _BankDB.GetNames();
        }
    }
}
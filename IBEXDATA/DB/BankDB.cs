using IBEXDATA.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class BankDB : IBankDB
    {
        private readonly dbContext _context;
        private static readonly Serilog.ILogger _logger = Log.ForContext<ProjectDB>(); // Create a logger instance

        public BankDB(dbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Bank>> Get()
        {
            try
            {
                var banks = await _context.Banks.ToListAsync();
               
                if (banks != null)
                {
                    _logger.Information("Successfully get all the banks.");
                    return banks;
                }
                else
                {
                    _logger.Warning("Bank list not loaded successfully.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in Get method of Get in BankDB.");
                return null;
            }
        }

        public async Task<IEnumerable<Bank>> GetNames()
        {
            try
            {
                var banks = await _context.Banks.ToListAsync();

                if (banks != null)
                {
                    _logger.Information("Successfully get all the banks.");
                    return banks;
                }
                else
                {
                    _logger.Warning("Bank list not loaded successfully.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in Get method of Get in BankDB.");
                return null;
            }
        }
    }
}

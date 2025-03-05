using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public record BankDTO(
    string? BankText,
    DateOnly InsertDate,
    DateOnly? UpdateDate,
    int? BankStatus,
    string? LastNameBank);
}

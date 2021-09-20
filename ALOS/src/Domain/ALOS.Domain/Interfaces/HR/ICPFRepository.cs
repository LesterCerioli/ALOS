using ALOS.Domain.Models.HR;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.HR
{
    public interface ICPFRepository : IRepository<CPF>
    {
        Task<CPF> GetById(Guid id);
        Task<CPF> GetByCPFNumber(string cpfNumber);
        Task<IEnumerable<CPF>> GetAll();

        void Add(CPF cPF);
        void Update(CPF cPF);
        void Remove(CPF cPF);

    }
}

using ALOS.Domain.Models.HR;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.HR
{
    public interface IPisRepository : IRepository<Pis>
    {
        Task<Pis> GetById(Guid id);
        Task<Pis> GetByNumber(string number);
        Task<IEnumerable<Pis>> GetAll();

        void Add(Pis pis);
        void Update(Pis pis);
        void Remove(Pis pis);
    }
}

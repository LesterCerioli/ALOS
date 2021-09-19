using ALOS.Domain.Models.Finance;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.Finance
{
    public interface IBankRepository : IRepository<Bank>
    {
        Task<Bank> GetById(Guid id);
        Task<Bank> GetByNome(string nome);
        Task<IEnumerable<Bank>> GetAll();

        void Add(Bank bank);
        void Update(Bank bank);
        void Remove(Bank bank);
         
    }
}
using ALOS.Domain.Models.HR;
using ALOS.Domain.ValueObjects;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.HR
{
    public interface IFuncionarioRepository : IRepository<Funcionario>
    {
        Task<Funcionario> GetById(Guid id);
        Task<Funcionario> GetByName(Name name);
        Task<Funcionario> GetByDtBirth(DateTime dtBirth);
        Task<IEnumerable<Funcionario>> GetAll();

        void Add(Funcionario funcionario);
        void Update(Funcionario funcionario);
        void Remove(Funcionario funcionario);
    }
}

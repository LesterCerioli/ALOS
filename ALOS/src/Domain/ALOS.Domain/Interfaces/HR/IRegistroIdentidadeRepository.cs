using ALOS.Domain.Models.HR;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.HR
{
    public interface IRegistroIdentidadeRepository : IRepository<RegistroIdentidade>
    {
        Task<RegistroIdentidade> GetById(Guid id);
        Task<RegistroIdentidade> GetByNumeroIdentidade(string numeroIdentidade);
        Task<IEnumerable<RegistroIdentidade>> GetAll();

        void Add(RegistroIdentidade registroIdentidade);
        void Update(RegistroIdentidade registroIdentidade);
        void Remove(RegistroIdentidade registroIdentidade);
    }
}

using ALOS.Domain.Models.HR;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.HR
{
    public interface ITituloEleitorRepository : IRepository<TituloEleitor>
    {
        Task<TituloEleitor> GetById(Guid id);
        Task<TituloEleitor> GetByNumeroTitulo(string numeroTitulo);
        Task<IEnumerable<TituloEleitor>> GetAll();

        void Add(TituloEleitor tituloEleitor);
        void Update(TituloEleitor tituloEleitor);
        void Remove(TituloEleitor tituloEleitor);
    }
}

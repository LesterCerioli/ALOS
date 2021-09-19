using ALOS.Domain.Models.ServiceDesk;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.ServiceDesk
{
    public interface IOrdemServicoRepository : IRepository<OrdemServico>
    {
        Task<OrdemServico> GetById(Guid id);
        Task<OrdemServico> GetByOSNumero(string osNumero);
        Task<IEnumerable<OrdemServico>> GetAll();

        void Add(OrdemServico ordemServico);
        void Update(OrdemServico ordemServico);
        void Remove(OrdemServico ordemServico);

    }
}

using System;
using NetDevPack.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.HR
{
    public class RegistroIdentidade : Entity, IAggregateRoot
    {
        public RegistroIdentidade(Guid id, string numeroIdentidade, string emissor) 
        {
            Id = id;
            NumeroIdentidade = numeroIdentidade;
            Emissor = emissor;
            DtExpedicao = DateTime.Now;
               
        }
               
        
        protected RegistroIdentidade() { }
        public string NumeroIdentidade { get; private set; }
        public DateTime? DtExpedicao { get; private set; }
        public string Emissor { get; private set; }
        
    }
}
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
        public RegistroIdentidade(string numeroIdentidade, string emissor) 
        {
            NumeroIdentidade = numeroIdentidade;
            Emissor = emissor;
            DtExpedicao = DateTime.Now;
               
        }
                public string NumeroIdentidade { get; private set; }
        
        protected RegistroIdentidade() { }
        public DateTime? DtExpedicao { get; private set; }
        public string Emissor { get; private set; }
        
    }
}
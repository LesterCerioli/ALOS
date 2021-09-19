using System;
using ALOS.Domain.Enums;
using NetDevPack.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.HR
{
    public class TituloEleitor : Entity, IAggregateRoot
    {
        
        protected TituloEleitor() {}
        public string NumeroTitulo { get; private set; }
        public string Zoma { get; private set; }
        public string Secao { get; private set; }

        
    }
}
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
        
        
        public TituloEleitor(Guid id, string numeroTitulo, string zona, string secao) 
        {
            Id = id;
            NumeroTitulo = numeroTitulo;
            Zona = zona;
            Secao = secao;
               
        }
        public string NumeroTitulo { get; private set; }
        protected TituloEleitor() {}
        public string Zona { get; private set; }
        public string Secao { get; private set; }

        
    }
}
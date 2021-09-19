using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.HR
{
    public class EducationLevel : Entity, IAggregateRoot
    {

        
        
        public EducationLevel(Guid id, string descricao) 
        {
            Id = id;
            Descricao = descricao;
               
        }
        
        protected EducationLevel() { }
        public string Descricao { get; private set; }
        
    }
}
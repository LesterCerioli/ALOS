using NetDevPack.Domain;
using System;

namespace ALOS.Domain.Models.HR
{
    public class Pis : Entity, IAggregateRoot
    {
               
        
        public Pis(Guid id, string number) 
        {
            Id = id;
            Number = number;
               
        }
        
        protected Pis() { }
        public string Number { get; set; }
        
    }
}
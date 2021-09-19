using System;
using ALOS.Domain.Enums;
using NetDevPack.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALOS.Domain.ValueObjects;
using ALOS.Domain.Models.Core;

namespace ALOS.Domain.Models.HR
{
    public class Funcionario : Entity, IAggregateRoot
    {

        private readonly IList<Address> _addresses;
        private readonly IList<TituloEleitor> _tituloEleitors;
        
        public Funcionario(Name name, Gerender gerender, ERace eRace, string nacionalidade) 
        {
            Name = name;
            Gerender = gerender;
            ERace = eRace;
            Nacionalidade = nacionalidade;
            _addresses = new List<Address>();
            _tituloEleitors = new List<TituloEleitor>();
               
        }
                
        protected Funcionario() { }
        public Name Name { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();
        public IReadOnlyCollection<TituloEleitor> TituloEleitors => _tituloEleitors.ToArray();
        public DateTime? dtBirth { get; private set; }
        public Gerender Gerender { get; private set; }
        public ERace ERace { get; private set; }
        public string Nacionalidade { get; private set; }

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public void AddTituloEleitor(TituloEleitor tituloEleitor)
        {
            _tituloEleitors.Add(tituloEleitor);
        }


    }
}
        
    

    
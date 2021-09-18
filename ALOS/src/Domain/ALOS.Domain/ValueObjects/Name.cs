using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string primeiroNome, string nomeMeio, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            NomeMeio = nomeMeio;
            SobreNome = sobreNome;
        }

        
        public string PrimeiroNome { get; private set; }
        public string NomeMeio { get; private set; }
        public string SobreNome { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {SobreNome}";
        }
    }
}

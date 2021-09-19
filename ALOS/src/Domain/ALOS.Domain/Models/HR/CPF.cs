
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.HR
{
    public class CPF : Entity, IAggregateRoot
    {
        public CPF(string cpfNumber)
        {
            CpfNumber = cpfNumber;
        }

        protected CPF() {  }
        public string CpfNumber { get; private set; }

        


    }
}

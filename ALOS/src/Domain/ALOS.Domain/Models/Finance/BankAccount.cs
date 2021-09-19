
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.Finance
{
    public class BankAccount : Entity, IAggregateRoot
    {
        public BankAccount(Guid id, string branch, string branchDigit, string account, string accountDigit) 
        {
            
            Id = id;
            Branch = branch;
            BranchDigit = branchDigit;
            Account = account;
            AccountDigit = accountDigit;
               
        }
                
        
        protected BankAccount() { }
        public string Branch { get; set; }
        public string BranchDigit { get; set; }
        public string Account { get; set; }
        public string AccountDigit { get; set; }
        
    }
}

using ALOS.Domain.Models.Core;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Interfaces.Core
{
    public interface IAdressRepository : IRepository<Address>
    {
        Task<Address> GetById(Guid id);
        Task<Address> GetByZipCode(string zipCode);
        Task<IEnumerable<Address>> GetAll();

        void Add(Address address);
        void Update(Address address);
        void remove(Address address);
    }
}

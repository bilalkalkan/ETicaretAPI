using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Customer(int id, string name, DateTime createdTime)
        {
            Name = name;
            Id = id;
            CreatedDate = createdTime;
        }

        public Customer()
        {
        }

        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
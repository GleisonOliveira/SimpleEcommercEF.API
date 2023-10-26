using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public enum Status : ushort
    {
        Active = 1,
        Inactive = 0,
    }
    public class User : ModelBase<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Document { get; set; }
        public string FinancialDocument { get;set; }
        public string MotherName { get; set; }
        public Status Status { get; set; }
        public DateTimeOffset  CreatedAt { get; set; }
        public Contact Contact { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Department>? Departments { get; set; }
    }
}

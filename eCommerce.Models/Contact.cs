using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Contact : ModelBase<int>
    {
        public int UserId { get; set; }
        public string Phone { get; set; }
        public string? CellPhone { get; set; }
        public User User { get; set; }
    }
}

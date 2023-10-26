using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Department : ModelBase<int>
    {
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

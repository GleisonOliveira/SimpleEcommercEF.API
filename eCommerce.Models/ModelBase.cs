using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public abstract class ModelBase<T>
    {
        public T Id { get; set; }
    }
}

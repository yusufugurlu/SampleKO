using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// roller entity
    /// </summary>
    public class Role:BaseEntities
    {
        public Role()
        {
             Customers = new HashSet<Customer>();
        }
        public string RoleName { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }
    }
}

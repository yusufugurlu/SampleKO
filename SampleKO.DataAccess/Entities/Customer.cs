using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Online Kullanıcılar
    /// </summary>
    public class Customer:BaseEntities
    {
        public Customer()
        {
            ProductComments = new HashSet<ProductComment>();
        }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryDate { get; set; }
        public virtual IEnumerable<ProductComment> ProductComments { get; set; }
    }
}

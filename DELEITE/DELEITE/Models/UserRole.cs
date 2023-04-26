using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DELEITE.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public string UserRoleDescription { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }


        public UserRole()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
    public class UserStatus
    {
        public int UserStatusId { get; set; }
        public string UserStatusDescription { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }


    }
}

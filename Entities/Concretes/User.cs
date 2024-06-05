using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User //Entity<Guid>, IUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; } 
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Assignment //Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } 
        public DateTime CreationDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public User User { get; set; }


    }
}

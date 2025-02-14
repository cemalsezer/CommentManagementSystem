﻿using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class OperationClaim : Entity<Guid>, IOperationClaim
    {
        public string Name { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}

﻿
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Entities
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; } = true;
      
    }
}
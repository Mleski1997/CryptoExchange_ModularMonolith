﻿using CryptoExchange.Modules.Wallets.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Tokens.Core.Entities
{
    public class Token
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
        

    }
}

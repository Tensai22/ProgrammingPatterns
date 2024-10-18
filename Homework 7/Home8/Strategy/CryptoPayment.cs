﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8.Strategy
{
    public class CryptoPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Spend {amount} with Crypto.");
        }
    }

}
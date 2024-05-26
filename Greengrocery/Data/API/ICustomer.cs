﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greengrocery.Data.API
{
    internal interface ICustomer : IUser
    {
        int CustomerId { get; set; }
        double Balance { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greengrocery.Data.API
{
    public interface ISupplier : IUser
    {
        int SupplierId { get; set; }
        Product[] Products { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greengrocery.Data.API
{
    public interface ICatalog
    {
        int Id
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
  
    }
}

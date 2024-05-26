﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greengrocery.Data.API
{
    internal interface IEmployee : IUser
    {
        int EmployeeId { get; set; }
        decimal Salary { get; set; }
    }
}

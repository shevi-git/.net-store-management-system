﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDal
    {
        public IProduct product{ get;}
        public ISale sale { get;}
        public ICustomer customer { get;}
    }
}

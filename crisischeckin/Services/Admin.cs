﻿using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Admin : IAdmin
    {
        public IEnumerable<string> GetVolunteers(int disasterId)
        {
            throw new NotImplementedException();
        }
    }
}

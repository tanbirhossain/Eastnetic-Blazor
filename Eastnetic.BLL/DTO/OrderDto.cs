﻿using Eastnetic.DAL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.BLL.DTO
{
    public class OrderDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
   
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace exampleApi.Models
{
    public class User
    {
		public long Id { get; set; }
		public string Name { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models
{
    class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }
    }
}

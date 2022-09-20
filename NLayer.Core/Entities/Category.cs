﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties
        public ICollection<Product> Products { get; set; }
    }
}
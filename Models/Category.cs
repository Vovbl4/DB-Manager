﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyrofest_Manager_App.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set;}
    }
}

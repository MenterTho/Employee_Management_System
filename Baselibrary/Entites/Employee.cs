﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Baselibrary.Entites
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public List<Employee> Employees { get; set; }
    }
}

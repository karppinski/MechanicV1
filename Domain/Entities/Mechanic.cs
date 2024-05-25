﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Mechanic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Appointment> Apponments { get; set; }
    }
}
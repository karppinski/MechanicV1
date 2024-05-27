﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public Guid MechanicId { get; set; }
        public Mechanic Mechanic { get; set; }
        public string CustomerName { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}

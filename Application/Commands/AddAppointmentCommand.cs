using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class AddAppointmentCommand : IRequest<bool>
    {
        public Guid MechanicId { get; }
        public string CustomerName { get; }
        public DateTime AppointmentDate { get; }

        public AddAppointmentCommand(Guid mechanicId, string customerName, DateTime appointmentDate)
        {
            MechanicId = mechanicId;
            CustomerName = customerName;
            AppointmentDate = appointmentDate;
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CancelAppointmentCommand : IRequest<bool>
    {
        public Guid AppointmentId { get; set; }

        public CancelAppointmentCommand(Guid appointmentId)
        {
            AppointmentId = appointmentId;
        }
    }
}

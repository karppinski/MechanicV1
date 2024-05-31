using Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetAppointmentByIdQuery : IRequest<AppointmentQueryDTO>
    {
        public Guid AppointmentId { get; set; }


    }
}

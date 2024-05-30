using Application.DTO;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetAppointmentsQueryHandler : IRequestHandler<GetAppointmentsQuery, List<AppointmentQueryDTO>>
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;



        public GetAppointmentsQueryHandler(IAppointmentRepository appointmentRepository, IMapper mapper)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }



        public async Task<List<AppointmentQueryDTO>> Handle(GetAppointmentsQuery request, CancellationToken cancellationToken)
        {
            var appointments = await _appointmentRepository.GetAllAsync();

            List<AppointmentQueryDTO> appointmentQueryDTOs = _mapper.Map<List<AppointmentQueryDTO>>(appointments);

            return appointmentQueryDTOs;

        }
    }
}

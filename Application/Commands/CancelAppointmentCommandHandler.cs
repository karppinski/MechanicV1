using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CancelAppointmentCommandHandler : IRequestHandler<CancelAppointmentCommand, bool>
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CancelAppointmentCommandHandler(IAppointmentRepository appointmentRepository, IUnitOfWork unitOfWork)
        {
            _appointmentRepository = appointmentRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(CancelAppointmentCommand request, CancellationToken cancellationToken)
        {
            await _appointmentRepository.RemoveAsync(request.AppointmentId);
            await _unitOfWork.CommitAsync();

            return true;
            
        }
    }
}

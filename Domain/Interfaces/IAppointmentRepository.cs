using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        Task AddAsync(Appointment appointment);
        Task RemoveAsync(Guid id);
        Task<Appointment> GetByIdAsync(Guid id);
        Task<IEnumerable<Appointment>> GetAllAsync();
    }
}

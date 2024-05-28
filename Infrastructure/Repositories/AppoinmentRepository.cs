using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AppoinmentRepository : IAppointmentRepository
    {

        private readonly AppDbContext _context;
        public AppoinmentRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Appointment appointment)
        {
            await _context.AddAsync(appointment);
        }

        public async Task<IEnumerable<Appointment>> GetAllAsync()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Appointment> GetByIdAsync(Guid id)
        {
            return await _context.Appointments.FindAsync(id);
        }

        public async Task RemoveAsync(Guid id)
        {
            var appointmentToLelete = await _context.Appointments.FindAsync(id);
            _context.Remove(appointmentToLelete);
            await Task.CompletedTask;
        }
    }
}

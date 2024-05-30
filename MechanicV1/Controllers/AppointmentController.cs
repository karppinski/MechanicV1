using Application.Commands;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AppointmentsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> AddAppointment(AddAppointmentCommand command)
    {
        var result = await _mediator.Send(command);
        if (result)
        {
            return Ok();
        }
        return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> CancelAppointment(CancelAppointmentCommand command)
    {
        var result = await _mediator.Send(command);
        if (result)
        {
            return NoContent();
        }
        return BadRequest();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAppointmentById(GetAppointmentByIdQuery query)
    {
        var appointment = await _mediator.Send(query);

        if(appointment != null)
        {
            return Ok(appointment);
        }

        return NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAppointments()
    {
        var query = new GetAppointmentsQuery();
        var appointments = await _mediator.Send(query);

        if (appointments != null)
        {
            return Ok(appointments);
        }

        return BadRequest();
    }
}
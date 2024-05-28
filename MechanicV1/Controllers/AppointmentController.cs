using Application.Commands;
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

    [HttpDelete]
    public async Task<IActionResult> CancelAppointment(CancelAppointmentCommand command)
    {
        var result = await _mediator.Send(command);
        if(result)
        {
            return NoContent();
        }
        return BadRequest();
    }
}
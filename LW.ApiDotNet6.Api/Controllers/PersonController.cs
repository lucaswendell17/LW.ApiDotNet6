using LW.ApiDotNet6.Application.DTOs;
using LW.ApiDotNet6.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace LW.ApiDotNet6.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] PersonDTO personDTO)
    {
        var result = await _personService.CreateAsync(personDTO);
        if (result.IsSuccess)
            return Ok(result);

        return BadRequest(result);
    }
}

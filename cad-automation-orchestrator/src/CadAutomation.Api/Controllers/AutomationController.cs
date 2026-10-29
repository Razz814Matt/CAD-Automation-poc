using Microsoft.AspNetCore.Mvc;
using CadAutomation.Core.Interfaces;
using CadAutomation.Core.Models;

namespace CadAutomation.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AutomationController : ControllerBase
{
  private readonly ICadOrchestrator _orchestrator;

  public AutomationController(ICadOrchestrator orchestrator)
  {
    _orchestrator = orchestrator;
  
  }
  [HttpPost ("generate")]
  [ProducesResponseType(typeof(AutomationResponseDto), StatusCode.Status2000K)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Generate([FromBody] AutomationRequestDto request, CancellationToken ct)
  {
    if (!ModelState.IsValid)
    return BadRequest(ModelState);

    var result = await _orchestrator,ProccessJobAsync(request, ct);
    return Ok(result);
    
  }
}

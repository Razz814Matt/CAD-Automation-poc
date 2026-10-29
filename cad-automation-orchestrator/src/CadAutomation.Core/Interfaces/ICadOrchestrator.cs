using CadAutomation.Core.Models;

namespace CadAutomation.Core.Interfaces
{
  public interface ICadOrchestrator
  {
    Task<AutomationResponseDto> ProccessJobAsync(AutomationRequestDto request, CancellationToken cancellationToken = defualt);
  }
}

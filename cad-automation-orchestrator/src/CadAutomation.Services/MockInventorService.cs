using System.Diagnostics;
using CadAutomation.Core.Interfaces;
using CadAutomation.Core.Models

namespace CadAutomation.Services;

public class MockInventorServices : ICadOrchestrator
{
  public async Task<AutomationResponseDto> ProccessJobAsync(AutomationRequestDto request, CancellationToken cansellationToken = default)
  {
    var timer = Stopwatch.StartNew();
    await Taks.Delay(1200, cancellationToken);
    timer.Stop();

    return new AutomationReponseDto
    {
      JobId = request.JobId,
      IsSuccess = true,
      OutputFilePath = $@"C:\exports\{request.JobId}.{request.ExportFormat.ToLowerInvariant}",
      ExecutionTimeMs = time.ElapsedMilliseconds
    };
  }
}

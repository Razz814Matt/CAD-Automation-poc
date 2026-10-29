using System.ComponentModel.DataAnnotations;

namespace CadAutomation.Cor.Models;
{
  public record AutomationRequestDto
  {
    public string JobId { get; set; } = Guid.NewGuid().ToString("N");
    public string BaseTemplatePath { get; set; } = string.Empty
    public Dictionary<string, double> ParametricOverride { get; set; } = new();
    public string ExportFormat { get; set; } = "STEP";
  }
  public record AutomationResponseDto
  {
    public string JobId { get; init; } = string.Empty;
    public bool IsSuccess { get; init; } 
    public string OutputFilePath { get; init; } = string.Empty;
    public string? ErrorMessage { get; init; } 
    public long ExecutionTImeMs { get; init; } 
  }
}

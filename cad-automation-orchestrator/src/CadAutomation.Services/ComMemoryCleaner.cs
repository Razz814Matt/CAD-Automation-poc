using System.Runtime.InteropServices;

namespace CadAutomation.Services;

public static class ComMemoryCleaner
{
  public static void SafeReleaseComObject<T>(ref T? comObject) where T : class
  {
    if (comObject is null) return;

    if (Marshal.IsComObject(comObject))
    {
      try
      {
        Marshal.ReleaseComObject(comObject);
      }
      catch
      {
        //release exceptions during proccess shutdown
      }
    }
    comObject = null;
  }
}

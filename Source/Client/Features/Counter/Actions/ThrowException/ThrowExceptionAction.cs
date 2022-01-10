namespace TimeWarpCli.Features.Counters
{
  using TimeWarpCli.Features.Bases;

  internal partial class CounterState
  {
    public class ThrowExceptionAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}

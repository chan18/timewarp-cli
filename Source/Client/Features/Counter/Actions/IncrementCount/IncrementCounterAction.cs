namespace TimeWarpCli.Features.Counters
{
  using TimeWarpCli.Features.Bases;

  internal partial class CounterState
  {
    public class IncrementCounterAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}

namespace TimeWarpCli.Features.Counters.Components
{
  using System.Threading.Tasks;
  using TimeWarpCli.Components;
  using TimeWarpCli.Features.Bases;
  using static TimeWarpCli.Features.Counters.CounterState;

  public partial class Counter : BaseComponent, IAttributeComponent
  {
    protected async Task ButtonClick() => await Send(new IncrementCounterAction { Amount = 5 }).ConfigureAwait(false);
  }
}

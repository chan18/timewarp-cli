namespace TimeWarpCli.Features.EventStreams
{
  using TimeWarpCli.Features.Bases;

  internal partial class EventStreamState
  {
    public class AddEventAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}

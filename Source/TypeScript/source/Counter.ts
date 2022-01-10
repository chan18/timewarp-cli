export class Counter {
  private BlazorState: BlazorState;

  constructor(aBlazorState: BlazorState) {
    this.BlazorState = aBlazorState;
  }

  DispatchIncrementCountAction() {
    console.log("%cdispatchIncrementCountAction", "color: green");

    const IncrementCountActionName =
      "TimeWarpCli.Features.Counters.CounterState+IncrementCounterAction, TimeWarpCli.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";

    this.BlazorState.DispatchRequest(IncrementCountActionName, { amount: 7 });
  }
}

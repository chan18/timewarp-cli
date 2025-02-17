﻿namespace TimeWarpCli.Features.Hello
{
  using ProtoBuf.Grpc;
  using System.Threading.Tasks;
  using TimeWarpCli.Features.Hellos;

  public class HelloService : IHelloService
  {
    public Task<HelloResponse> SayHelloAsync(HelloRequest aHelloRequest, CallContext aCallContext = default) =>
      Task.FromResult(new HelloResponse { Message = $"Hello {aHelloRequest.Name}" });
  }
}

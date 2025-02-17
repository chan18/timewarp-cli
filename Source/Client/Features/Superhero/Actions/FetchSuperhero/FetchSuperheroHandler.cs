﻿namespace TimeWarpCli.Features.Superheros
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TimeWarpCli.Features.Bases;

  internal partial class SuperheroState
  {
    public class FetchSuperheroHandler : BaseHandler<FetchSuperheroAction>
    {
      private readonly ISuperheroService SuperheroService;
      public FetchSuperheroHandler(IStore aStore, ISuperheroService aSuperheroService) : base(aStore)
      {
        SuperheroService = aSuperheroService;
      }

      public override async Task<Unit> Handle
      (
        FetchSuperheroAction aFetchSuperheroAction,
        CancellationToken aCancellationToken
      )
      {
        SuperheroState._Superheros.Clear();
        var getSuperheroRequest = new SuperheroRequest { NumberOfHero = 5};
        SuperheroResponse getSuperheroResponse =
          await SuperheroService.GetSuperheroAsync(getSuperheroRequest);

        foreach (SuperheroDto superhero in getSuperheroResponse.Superheros)
        {
          SuperheroState._Superheros.Add(superhero);
        }
        return Unit.Value;
      }
    }
  }
}

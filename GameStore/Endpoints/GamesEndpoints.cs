using GameStore.Api.Data;
using GameStore.Api.DTOs;
using GameStore.Api.Entities;
using GameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{
  const string GetGameEndpoint = "GetName";

  // Extension method to map endpoints
  public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
  {
    var group = app.MapGroup("/games")
                  .WithParameterValidation();

    group.MapGet("/", (GameStoreContext dbContext) =>
    {
      return dbContext.Games
                      .Include(g => g.Genre)
                      .Select(g => g.ToGameSummaryDTO())
                      .AsNoTracking();
    });

    group.MapGet("/{id}", (int id, GameStoreContext dbContext) =>
    {
      Game? game = dbContext.Games.Find(id);
      return game is null ? Results.NotFound() : Results.Ok(game.ToGameDetailsDTO());
    })
    .WithName(GetGameEndpoint);

    group.MapPost("/", (CreateGameDTO gameData, GameStoreContext dbContext) =>
    {
      Game game = gameData.ToEntity();
      dbContext.Games.Add(game);
      dbContext.SaveChanges();

      return Results.CreatedAtRoute(
        GetGameEndpoint,
        new { game.Id },
        game.ToGameDetailsDTO()
      );
    });

    group.MapPut("/{id}", (int id, UpdateGameDTO gameData, GameStoreContext dbContext) =>
    {
      var existingGame = dbContext.Games.Find(id);

      if (existingGame is null) return Results.NotFound();

      dbContext.Entry(existingGame)
              .CurrentValues
              .SetValues(gameData.ToEntity(id));

      dbContext.SaveChanges();

      return Results.NoContent();
    });

    group.MapDelete("/{id}", (int id, GameStoreContext dbContext) =>
    {
      dbContext.Games
              .Where(g => g.Id == id)
              .ExecuteDelete();

      return Results.NoContent();
    });

    return group;
  }
}

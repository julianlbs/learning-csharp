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

    group.MapGet("/", async (GameStoreContext dbContext) =>
    {
      return await dbContext.Games
                      .Include(g => g.Genre)
                      .Select(g => g.ToGameSummaryDTO())
                      .AsNoTracking()
                      .ToListAsync();
    });

    group.MapGet("/{id}", async (int id, GameStoreContext dbContext) =>
    {
      Game? game = await dbContext.Games.FindAsync(id);
      return game is null ? Results.NotFound() : Results.Ok(game.ToGameDetailsDTO());
    })
    .WithName(GetGameEndpoint);

    group.MapPost("/", async (CreateGameDTO gameData, GameStoreContext dbContext) =>
    {
      Game game = gameData.ToEntity();
      dbContext.Games.Add(game);
      await dbContext.SaveChangesAsync();

      return Results.CreatedAtRoute(
        GetGameEndpoint,
        new { game.Id },
        game.ToGameDetailsDTO()
      );
    });

    group.MapPut("/{id}", async (int id, UpdateGameDTO gameData, GameStoreContext dbContext) =>
    {
      var existingGame = await dbContext.Games.FindAsync(id);

      if (existingGame is null) return Results.NotFound();

      dbContext.Entry(existingGame)
              .CurrentValues
              .SetValues(gameData.ToEntity(id));

      await dbContext.SaveChangesAsync();

      return Results.NoContent();
    });

    group.MapDelete("/{id}", async (int id, GameStoreContext dbContext) =>
    {
      await dbContext.Games
              .Where(g => g.Id == id)
              .ExecuteDeleteAsync();

      return Results.NoContent();
    });

    return group;
  }
}

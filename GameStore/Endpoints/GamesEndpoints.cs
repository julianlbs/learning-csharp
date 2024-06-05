﻿using GameStore.Api.DTOs;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{
  const string GetGameEndpoint = "GetName";

  private static readonly List<GameDTO> games = [
    new (
      1,
      "Street Fighter II",
      "Fighting",
      19.99M,
      new DateOnly(1992, 7, 15)
    ),
    new (
      2,
      "Final Fantasy XIV",
      "Roleplaying",
      59.99M,
      new DateOnly(2010, 9, 30)
    ),
    new (
      3,
      "FIFA 23",
      "Sports",
      69.99M,
      new DateOnly(1992, 7, 15)
    ),
  ];

  // Extension method to map endpoints
  public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
  {
    var group = app.MapGroup("/games");

    group.MapGet("/", () => games);

    group.MapGet("/{id}", (int id) =>
    {
      GameDTO? game = games.FirstOrDefault(g => g.Id == id);
      return game is null ? Results.NotFound() : Results.Ok(game);
    })
    .WithName(GetGameEndpoint);

    group.MapPost("/", (CreateGameDTO gameData) =>
    {
      GameDTO game = new(
        games.Count + 1,
        gameData.Name,
        gameData.Genre,
        gameData.Price,
        gameData.ReleaseDate
      );
      games.Add(game);
      return Results.CreatedAtRoute(GetGameEndpoint, new { game.Id }, game);
    });

    group.MapPut("/{id}", (int id, UpdateGameDTO gameData) =>
    {
      var index = games.FindIndex(g => g.Id == id);

      if (index == -1) return Results.NotFound();

      games[index] = new GameDTO(
        id,
        gameData.Name,
        gameData.Genre,
        gameData.Price,
        gameData.ReleaseDate
      );

      return Results.NoContent();
    });

    group.MapDelete("/{id}", (int id) =>
    {
      games.RemoveAll(g => g.Id == id);
      return Results.NoContent();
    });

    return group;
  }
}

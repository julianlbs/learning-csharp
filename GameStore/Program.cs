using GameStore.Api.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetGameEndpoint = "GetName";

List<GameDTO> games = [
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

app.MapGet("/games", () => games);

app.MapGet("/games/{id}", (int id) =>
{
  GameDTO? game = games.FirstOrDefault(g => g.Id == id);
  return game is null ? Results.NotFound() : Results.Ok(game);
})
.WithName(GetGameEndpoint);

app.MapPost("/games", (CreateGameDTO gameData) =>
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

app.MapPut("/games/{id}", (int id, UpdateGameDTO gameData) =>
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

app.MapDelete("games/{id}", (int id) =>
{
  games.RemoveAll(g => g.Id == id);
  return Results.NoContent();
});

app.Run();

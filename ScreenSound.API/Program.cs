using ScreenSound.API.Modelos;
using System.Text.Json;
using ScreenSound.API.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1].ExibirDetalhes();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2010");

        //var musicasPreferidasGustavo = new MusicasPreferidas("Gustavo");

        //musicasPreferidasGustavo.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasGustavo.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasGustavo.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasGustavo.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasGustavo.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasGustavo.ExibirMusicasFavoritas();

        //var musicasPreferidasKermelin = new MusicasPreferidas("Kermelin");
        //musicasPreferidasKermelin.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasKermelin.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasKermelin.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasKermelin.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasKermelin.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasKermelin.AdicionarMusicasFavoritas(musicas[71]);

        //musicasPreferidasKermelin.ExibirMusicasFavoritas();

        //musicasPreferidasGustavo.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
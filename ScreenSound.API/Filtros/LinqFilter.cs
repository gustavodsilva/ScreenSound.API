using ScreenSound.API.Modelos;

namespace ScreenSound.API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical (List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        
        Console.WriteLine($"Exibindo as músicas do artista >>> {artista}");
        
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    } 
    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Lancamento!.CompareTo(ano) >= 0).ToList();
        
        Console.WriteLine($"Exibindo as músicas do ano >>> {ano}");
        
        foreach (var musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}

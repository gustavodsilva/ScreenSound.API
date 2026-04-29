using System.Text.Json.Serialization;

namespace ScreenSound.API.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? Lancamento { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade
    {
        get
        {
            return this.tonalidades[Key];
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração em segundos: {Duracao/1000}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Ano de lançamento: {Lancamento}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}

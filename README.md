# ScreenSound.API

Aplicação console desenvolvida em C# com foco em consumo de API externa, deserialização de JSON e manipulação de dados com LINQ.

O projeto consome uma API pública de músicas e permite explorar e filtrar dados de artistas, faixas e atributos musicais como popularidade, energia e dançabilidade — manipulados em memória com consultas LINQ.

---

## Tecnologias

| Tecnologia | Descrição |
|---|---|
| C# | Linguagem principal |
| .NET | Plataforma de desenvolvimento |
| HttpClient | Consumo de API externa |
| System.Text.Json | Deserialização de JSON |
| LINQ | Manipulação e consulta de dados |

---

## API utilizada

**Endpoint:** `https://guilhermeonrails.github.io/api-csharp-songs/songs.json`

Retorna uma coleção de músicas com os seguintes atributos:

```json
{
  "artist": "Taylor Swift",
  "song": "22",
  "duration_ms": 232120,
  "explicit": "False",
  "year": "2012",
  "popularity": "68",
  "danceability": "0.661",
  "energy": "0.729",
  "genre": "pop"
}
```

---

## Funcionalidades

- Consumo de API externa via `HttpClient`
- Deserialização de JSON em objetos C# com `System.Text.Json`
- Filtragem de músicas por artista e gênero com `Where()`
- Cálculo de médias de atributos musicais com `Average()`
- Ordenação por popularidade e energia com `OrderByDescending()`
- Projeção de propriedades específicas com `Select()`

---

## Estrutura do projeto

```
ScreenSound.API/
├── Models/
│   └── Music.cs
├── Services/
│   └── MusicService.cs
└── Program.cs
```

---

## Como executar

**Pré-requisito:** .NET SDK instalado — [download aqui](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/gustavodsilva/ScreenSound.API
cd ScreenSound.API
dotnet run
```

---

## Aprendizados aplicados

- Integração de projetos C# com APIs externas via `HttpClient`
- Transformação de JSON em objetos C# com desserialização
- Manipulação de coleções em memória com LINQ: `Where`, `Average`, `OrderByDescending`, `Select`

---

## Autor

**Gustavo Silva Tiano**
[LinkedIn](https://www.linkedin.com/in/gttiano/) | [GitHub](https://github.com/gustavodsilva)

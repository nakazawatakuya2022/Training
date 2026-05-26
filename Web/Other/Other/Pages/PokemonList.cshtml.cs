using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json.Serialization;

namespace Other.Pages
{
    public class PokemonListModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public PokemonListModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<PokemonViewModel> Pokemons { get; set; } = new();

        public async Task OnGetAsync()
        {
            for (int id = 1; id <= 10; id++)
            {
                var pokemon = await _httpClient.GetFromJsonAsync<PokemonResponse>(
                    $"https://pokeapi.co/api/v2/pokemon/{id}"
                );

                var species = await _httpClient.GetFromJsonAsync<PokemonSpeciesResponse>(
                    $"https://pokeapi.co/api/v2/pokemon-species/{id}"
                );

                var japaneseName = species?.Names
                    .FirstOrDefault(n => n.Language.Name == "ja")?
                    .Name ?? pokemon?.Name ?? "";

                Pokemons.Add(new PokemonViewModel
                {
                    Id = id,
                    JapaneseName = japaneseName,
                    ImageUrl = pokemon?.Sprites.FrontDefault ?? "",

                    Hp = GetStat(pokemon, "hp"),
                    Attack = GetStat(pokemon, "attack"),
                    Defense = GetStat(pokemon, "defense"),
                    SpecialAttack = GetStat(pokemon, "special-attack"),
                    SpecialDefense = GetStat(pokemon, "special-defense"),
                    Speed = GetStat(pokemon, "speed")
                });
            }
        }

        private int GetStat(PokemonResponse? pokemon, string statName)
        {
            return pokemon?.Stats
                .FirstOrDefault(s => s.Stat.Name == statName)?
                .BaseStat ?? 0;
        }
    }

    public class PokemonViewModel
    {
        public int Id { get; set; }
        public string JapaneseName { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
    }

    public class PokemonResponse
    {
        public string Name { get; set; } = "";
        public List<PokemonStat> Stats { get; set; } = new();
        public PokemonSprites Sprites { get; set; } = new();
    }

    public class PokemonStat
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }

        public StatInfo Stat { get; set; } = new();
    }

    public class StatInfo
    {
        public string Name { get; set; } = "";
    }

    public class PokemonSpeciesResponse
    {
        public List<PokemonName> Names { get; set; } = new();
    }

    public class PokemonName
    {
        public string Name { get; set; } = "";
        public LanguageInfo Language { get; set; } = new();
    }

    public class LanguageInfo
    {
        public string Name { get; set; } = "";
    }

    public class PokemonSprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; } = "";
    }
}

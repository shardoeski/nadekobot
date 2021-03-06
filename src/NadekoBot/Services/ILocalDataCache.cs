using NadekoBot.Common.Pokemon;
using NadekoBot.Modules.Games.Common.Trivia;
using System.Collections.Generic;

namespace NadekoBot.Services
{
    public interface ILocalDataCache
    {
        IReadOnlyDictionary<string, SearchPokemon> Pokemons { get; }
        IReadOnlyDictionary<string, SearchPokemonAbility> PokemonAbilities { get; }
        IReadOnlyDictionary<int, string> PokemonMap { get; }
        TriviaQuestion[] TriviaQuestions { get; }
    }
}

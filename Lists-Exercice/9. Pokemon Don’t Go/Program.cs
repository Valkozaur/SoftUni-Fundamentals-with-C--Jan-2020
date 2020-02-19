using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int currentPokemon = 0;
            int catchedPokemonsSum = 0;

            while (pokemons.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    currentPokemon = LastPokemonCopiedToTheFirst(pokemons);
                }
                else if (index >= pokemons.Count)
                {
                    currentPokemon = FirstPokemonCopiedTOTheLast(pokemons);
                }
                else
                {
                    currentPokemon = pokemonIsInRange(pokemons, index);
                }

                catchedPokemonsSum += currentPokemon;
                DistanceReavaluation(pokemons, currentPokemon);
            }

            Console.WriteLine(catchedPokemonsSum);
        }

        private static void DistanceReavaluation(List<int> pokemons, int currentPokemon)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (currentPokemon >= pokemons[i])
                {
                    pokemons[i] += currentPokemon;
                }
                else if (currentPokemon < pokemons[i])
                {
                    pokemons[i] -= currentPokemon;
                }
            }
        }

        private static int pokemonIsInRange(List<int> pokemons, int index)
        {
            int pokemon = pokemons[index];
            pokemons.RemoveAt(index);
            return pokemon;
        }

        private static int FirstPokemonCopiedTOTheLast(List<int> pokemons)
        {
            int pokemon = pokemons[pokemons.Count - 1];
            pokemons[pokemons.Count - 1] = pokemons[0];
            return pokemon;
        }

        private static int LastPokemonCopiedToTheFirst(List<int> pokemons)
        {
            int pokemon = pokemons[0];
            pokemons[0] = pokemons[pokemons.Count - 1];
            return pokemon;
        }
    }
}

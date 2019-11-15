using System;

namespace MVMTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var algorithm = new EvolutiveAlgorithm("MVM INGENIERIA DE SOFTWARE");
            var result = algorithm.Resolve(10);

            for (int i = 0; i < result.Count; i++)
            {
                var bestMatch = result[i].GetBestMatch();
                Console.WriteLine($"Generación: {i + 1} - Mutación: {bestMatch.Current} - Puntaje: {bestMatch.Score}");
            }
        }
    }
}
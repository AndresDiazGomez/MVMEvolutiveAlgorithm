using System;

namespace MVMTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var algorithm = new EvolutiveAlgorithm("MVM INGENIERIA DE SOFTWARE");
            var result = algorithm.Resolve(50);

            for (int i = 0; i < result.Count; i++)
            {
                var bestMatch = result[i].GetBestMatch();
                Console.WriteLine($"Generation: {i + 1} - Mutation: {bestMatch.Current} - Score: {bestMatch.CurrentScore} - Rate: {bestMatch.SucessRate * 100}%");
            }
        }
    }
}
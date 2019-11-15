using System;
using System.Globalization;

namespace MVMTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var algorithm = new EvolutiveAlgorithm("MVM INGENIERIA DE SOFTWARE VS INGENEO DESARROLLO Y COMPANIA");

            algorithm.OnNewGenerationCreated += (sender, e) =>
                Console.WriteLine($"Generation: {e.Iteration} - Mutation: {e.Mutation.Current} - Score: {e.Mutation.CurrentScore} - Rate: {e.Mutation.SucessRate.ToString("P", CultureInfo.InvariantCulture)}");

            var result = algorithm.Resolve(100);
        }
    }
}
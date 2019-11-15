using System;

namespace MVMTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var algorithm = new EvolutiveAlgorithm("MVM INGENIERIA DE SOFTWARE VS INGENEO DESARROLLO Y COMPANIA");
            algorithm.OnNewGenerationCreated += (i, generation) =>
                Console.WriteLine($"Generation: {i} - Mutation: {generation.Current} - Score: {generation.CurrentScore} - Rate: {generation.SucessRate * 100}%");
            var result = algorithm.Resolve(25);
        }
    }
}
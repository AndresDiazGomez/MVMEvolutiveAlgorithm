namespace MVMTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EvolutiveAlgorithm
    {
        private const string _validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        private Random random = new Random();

        public EvolutiveAlgorithm(string targetText)
            : this(targetText, 0.03m)
        {
        }

        public EvolutiveAlgorithm(string targetText, decimal changeRate)
        {
            TargetText = targetText ?? throw new ArgumentNullException(nameof(targetText));
            MaxScore = TargetText.Length;
            ChangeRate = changeRate;
        }

        public decimal ChangeRate { get; } = 0.03m;
        public int MaxScore { get; }
        public string TargetText { get; }

        public List<Generation> Resolve(short generationSize)
        {
            if (generationSize <= 0) 
                throw new ArgumentException("The generation size cannot be zero or negative.", nameof(generationSize));
            List<Generation> generations = new List<Generation>();
            var reference = GetRandomText(MaxScore);
            var score = 0;
            while (score < MaxScore)
            {
                var generation = GetNewGeneration(generationSize, reference);
                var bestMutation = generation.GetBestMatch();
                score = bestMutation.Score;
                reference = bestMutation.Current;
                generations.Add(generation);
            }
            return generations;
        }

        private Generation GetNewGeneration(short generationSize, string baseText)
        {
            var generation = new Generation();
            for (int i = 0; i < generationSize; i++)
            {
                generation.Add(GetNewMutation(baseText), TargetText);
            }
            return generation;
        }

        private string GetNewMutation(string mutate)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < mutate.Length; i++)
            {
                var @char = mutate[i];
                int randomNumber = random.Next(100);
                decimal chance = randomNumber / 100m;
                if (chance < ChangeRate)
                {
                    @char = GetRandomChar();
                }
                builder.Append(@char);
            }
            return builder.ToString();
        }

        private char GetRandomChar()
        {
            return _validChars[random.Next(_validChars.Length)];
        }

        private string GetRandomText(int lenght)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < lenght; i++)
            {
                builder.Append(GetRandomChar());
            }
            return builder.ToString();
        }
    }
}
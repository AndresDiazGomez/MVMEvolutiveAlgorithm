namespace MVMTest
{
    using System;

    public class Mutation
    {
        public Mutation(string current, string target)
        {
            Current = current ?? throw new ArgumentNullException(nameof(current));
            Target = target ?? throw new ArgumentNullException(nameof(target));
            if (Current.Length != Target.Length) throw new InvalidOperationException($@"The lenght of {nameof(current)} and {nameof(target)} don't match.");
            CalculateScore();
        }

        public string Current { get; }
        public string Target { get; }
        public int Score { get; private set; }

        private void CalculateScore()
        {
            for (int i = 0; i < Current.Length; i++)
            {
                if (Current[i].Equals(Target[i]))
                {
                    Score++;
                }
            }
        }
    }
}
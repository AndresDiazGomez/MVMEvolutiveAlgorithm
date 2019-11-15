namespace MVMTest
{
    using System.Collections.Generic;
    using System.Linq;

    public class Generation
    {
        private List<Mutation> _mutations = new List<Mutation>();

        public Generation()
        {
        }

        public int Count => _mutations.Count;

        public IReadOnlyCollection<Mutation> Mutations => _mutations;

        public void Add(string current, string target)
        {
            var mutation = new Mutation(current, target);
            _mutations.Add(mutation);
        }

        public Mutation GetBestMatch()
        {
            var maxScore = _mutations.Max(mutation => mutation.Score);
            return _mutations.First(mutation => mutation.Score == maxScore);
        }
    }
}
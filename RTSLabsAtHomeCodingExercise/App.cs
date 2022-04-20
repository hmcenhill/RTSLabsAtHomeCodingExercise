namespace RTSLabsAtHomeCodingExercise
{
    public class App
    {
        public IDictionary<string, int> AboveBelow(IList<int> collection, int comparor)
        {
            var aboveName = "above";
            var belowName = "below";
            var inv = new Dictionary<string, int>
            {
                [aboveName] = 0,
                [belowName] = 0
            };

            foreach (var val in collection)
            {
                if (val > comparor)
                {
                    inv[aboveName]++;
                }
                else if (val < comparor)
                {
                    inv[belowName]++;
                }
            }
            return inv;
        }

        public string StringRotation(string s, int rotationAmount)
        {
            if (s.Length <= 1 || rotationAmount <= 0) return s;

            rotationAmount %= s.Length;

            return s.Substring(s.Length - rotationAmount) + s.Substring(0, s.Length - rotationAmount);
        }
    }
}

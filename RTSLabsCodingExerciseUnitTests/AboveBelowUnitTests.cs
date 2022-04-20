using RTSLabsAtHomeCodingExercise;
using System.Collections.Generic;
using Xunit;

namespace RTSLabsCodingExercise.UnitTests
{
    public class AboveBelowUnitTests
    {
        [Theory]
        [MemberData(nameof(PassData))]
        public void TestPass(IList<int> collection, int comparor, IDictionary<string, int> expected)
            => Assert.Equal(expected, new App().AboveBelow(collection, comparor));

        [Theory]
        [MemberData(nameof(FailData))]
        public void TestFail(IList<int> collection, int comparor, IDictionary<string, int> expected)
            => Assert.NotEqual(expected, new App().AboveBelow(collection, comparor));

        public static TheoryData<IList<int>, int, IDictionary<string, int>> PassData => new TheoryData<IList<int>, int, IDictionary<string, int>>
        {
            // Provided example test case
            {
                new List<int>{1, 5, 2, 1, 10 },
                6,
                new Dictionary<string, int>
                {
                    ["above"] = 1,
                    ["below"] = 4
                }
            },
            // Values Neither above or below but counted below
            {
                new List<int>{5, 5, 5, 5, 5 },
                5,
                new Dictionary<string, int>
                {
                    ["above"] = 0,
                    ["below"] = 0
                }
            },
        };

        public static TheoryData<IList<int>, int, IDictionary<string, int>> FailData => new TheoryData<IList<int>, int, IDictionary<string, int>>
        {
            // Just wrong
            {
                new List<int>{1, 5, 2, 1, 10 },
                3,
                new Dictionary<string, int>
                {
                    ["above"] = 1,
                    ["below"] = 4
                }
            },
            // Not enough values
            {
                new List<int>{1, 5, 2, 1, 10 },
                6,
                new Dictionary<string, int>
                {
                    ["above"] = 1,
                    ["below"] = 3
                }
            },
            // Values Neither above or below but counted below
            {
                new List<int>{5, 5, 5, 5, 5 },
                5,
                new Dictionary<string, int>
                {
                    ["above"] = 0,
                    ["below"] = 5
                }
            },
            // Values Neither above or below but counted above
            {
                new List<int>{5, 5, 5, 5, 5 },
                5,
                new Dictionary<string, int>
                {
                    ["above"] = 5,
                    ["below"] = 0
                }
            },

        };
    }
}

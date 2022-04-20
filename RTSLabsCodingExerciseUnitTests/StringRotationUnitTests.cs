using RTSLabsAtHomeCodingExercise;
using Xunit;

namespace RTSLabsCodingExercise.UnitTests
{
    public class StringRotationUnitTests
    {
        [Theory]
        [MemberData(nameof(PassData))]
        public void TestPass(string s, int rotationAround, string expected)
            => Assert.Equal(expected, new App().StringRotation(s, rotationAround));

        public static TheoryData<string, int, string> PassData => new TheoryData<string, int, string>
        {
            // Provided test case
            {
                "MyString", 2, "ngMyStri"
            },
            // rotation integer larger than provided string
            {
                "MyString", 10, "ngMyStri"
            },
            // rotation integer much larger than string
            {
                "MyString", 800002, "ngMyStri"
            },
            // rotation integer provided not valid (non-positive): should return original string
            {
                "MyString", 0, "MyString"
            },
            // rotation integer provided not valid (non-positive): should return original string
            {
                "MyString", -100, "MyString"
            },
            // Empty string should return directly
            {
                "", 1, ""
            },
            // Single Character string should return directly
            {
                "A", 100, "A"
            },
        };
    }
}
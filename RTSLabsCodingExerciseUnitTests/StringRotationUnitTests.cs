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
            // Variation
            {
                "MyString", 5, "tringMyS"
            },
            // Exactly the provided string length
            {
                "MyString", 8, "MyString"
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
            // Very Long String
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Odio pellentesque diam volutpat commodo sed egestas. Quis commodo odio aenean sed adipiscing diam. Non arcu risus quis varius quam quisque. Nibh sit amet commodo nulla facilisi. Nisl suscipit adipiscing bibendum est. In ornare quam viverra orci sagittis eu volutpat odio. Turpis cursus in hac habitasse platea dictumst quisque. Sed blandit libero volutpat sed. Tincidunt augue interdum velit euismod in pellentesque massa. Pellentesque diam volutpat commodo sed egestas egestas. Vitae ultricies leo integer malesuada nunc. Eget gravida cum sociis natoque penatibus et magnis. Eget arcu dictum varius duis at. Massa enim nec dui nunc mattis enim ut. Praesent elementum facilisis leo vel fringilla. Volutpat commodo sed egestas egestas fringilla phasellus. Neque vitae tempus quam pellentesque nec. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Malesuada fames ac turpis egestas. Sed risus pretium quam vulputate dignissim suspendisse in. Quis risus sed vulputate odio ut enim blandit volutpat. Vivamus arcu felis bibendum ut tristique et egestas. Nulla aliquet porttitor lacus luctus. Vulputate ut pharetra sit amet aliquam id diam maecenas. Egestas pretium aenean pharetra magna ac placerat vestibulum lectus. Gravida rutrum quisque non tellus orci ac. Quisque non tellus orci ac. Praesent tristique magna sit amet purus gravida quis blandit. Euismod lacinia at quis risus. Erat nam at lectus urna. Rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt. Sit amet luctus venenatis lectus magna. Molestie a iaculis at erat pellentesque adipiscing commodo. Mauris vitae ultricies leo integer malesuada. Enim facilisis gravida neque convallis a cras semper auctor neque. Ultrices mi tempus imperdiet nulla. Sed augue lacus viverra vitae congue eu. Volutpat maecenas volutpat blandit aliquam. At volutpat diam ut venenatis tellus in metus. Turpis nunc eget lorem dolor. Urna duis convallis convallis tellus id interdum velit laoreet. Etiam dignissim diam quis enim lobortis. Non odio euismod lacinia at. Enim lobortis scelerisque fermentum dui faucibus in ornare. Cursus in hac habitasse platea dictumst. Amet est placerat in egestas erat imperdiet sed euismod nisi. Quam quisque id diam vel quam elementum. Scelerisque viverra mauris in aliquam sem. Sollicitudin ac orci phasellus egestas tellus rutrum tellus pellentesque. Malesuada fames ac turpis egestas maecenas pharetra convallis. Nisl nunc mi ipsum faucibus vitae aliquet nec ullamcorper sit. Lectus magna fringilla urna porttitor rhoncus dolor purus non enim. Imperdiet nulla malesuada pellentesque elit eget gravida. Ornare quam viverra orci sagittis eu volutpat odio. Fermentum dui faucibus in ornare quam viverra orci sagittis. Augue neque gravida in fermentum et sollicitudin ac. Mattis pellentesque id nibh tortor id aliquet lectus proin. Mi quis hendrerit dolor magna eget est. At consectetur lorem donec massa sapien faucibus. Ultricies mi eget mauris pharetra. Cras fermentum odio eu feugiat pretium nibh. Sem fringilla ut morbi tincidunt augue interdum velit euismod in. Pellentesque habitant morbi tristique senectus. Nullam eget felis eget nunc lobortis mattis aliquam faucibus purus. Feugiat nibh sed pulvinar proin gravida hendrerit lectus a. Ornare aenean euismod elementum nisi quis eleifend quam. Egestas pretium aenean pharetra magna ac placerat. Tincidunt id aliquet risus feugiat in. Suspendisse faucibus interdum posuere lorem ipsum dolor. Ipsum suspendisse ultrices gravida dictum fusce ut placerat. Risus viverra adipiscing at in tellus. Dolor morbi non arcu risus quis varius quam quisque. Nec nam aliquam sem et tortor consequat id porta. A condimentum vitae sapien pellentesque habitant. Ullamcorper sit amet risus nullam eget felis eget nunc. Diam sollicitudin tempor id eu nisl nunc mi ipsum. Eu facilisis sed odio morbi quis commodo odio aenean. Feugiat vivamus at augue eget arcu. Eget egestas purus viverra accumsan in. Tempus imperdiet nulla malesuada pellentesque elit eget. Lobortis feugiat vivamus at augue eget arcu dictum varius. Lorem donec massa sapien faucibus et molestie ac feugiat sed. Suspendisse ultrices gravida dictum fusce ut.",
                10,
                " fusce ut.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Odio pellentesque diam volutpat commodo sed egestas. Quis commodo odio aenean sed adipiscing diam. Non arcu risus quis varius quam quisque. Nibh sit amet commodo nulla facilisi. Nisl suscipit adipiscing bibendum est. In ornare quam viverra orci sagittis eu volutpat odio. Turpis cursus in hac habitasse platea dictumst quisque. Sed blandit libero volutpat sed. Tincidunt augue interdum velit euismod in pellentesque massa. Pellentesque diam volutpat commodo sed egestas egestas. Vitae ultricies leo integer malesuada nunc. Eget gravida cum sociis natoque penatibus et magnis. Eget arcu dictum varius duis at. Massa enim nec dui nunc mattis enim ut. Praesent elementum facilisis leo vel fringilla. Volutpat commodo sed egestas egestas fringilla phasellus. Neque vitae tempus quam pellentesque nec. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Malesuada fames ac turpis egestas. Sed risus pretium quam vulputate dignissim suspendisse in. Quis risus sed vulputate odio ut enim blandit volutpat. Vivamus arcu felis bibendum ut tristique et egestas. Nulla aliquet porttitor lacus luctus. Vulputate ut pharetra sit amet aliquam id diam maecenas. Egestas pretium aenean pharetra magna ac placerat vestibulum lectus. Gravida rutrum quisque non tellus orci ac. Quisque non tellus orci ac. Praesent tristique magna sit amet purus gravida quis blandit. Euismod lacinia at quis risus. Erat nam at lectus urna. Rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt. Sit amet luctus venenatis lectus magna. Molestie a iaculis at erat pellentesque adipiscing commodo. Mauris vitae ultricies leo integer malesuada. Enim facilisis gravida neque convallis a cras semper auctor neque. Ultrices mi tempus imperdiet nulla. Sed augue lacus viverra vitae congue eu. Volutpat maecenas volutpat blandit aliquam. At volutpat diam ut venenatis tellus in metus. Turpis nunc eget lorem dolor. Urna duis convallis convallis tellus id interdum velit laoreet. Etiam dignissim diam quis enim lobortis. Non odio euismod lacinia at. Enim lobortis scelerisque fermentum dui faucibus in ornare. Cursus in hac habitasse platea dictumst. Amet est placerat in egestas erat imperdiet sed euismod nisi. Quam quisque id diam vel quam elementum. Scelerisque viverra mauris in aliquam sem. Sollicitudin ac orci phasellus egestas tellus rutrum tellus pellentesque. Malesuada fames ac turpis egestas maecenas pharetra convallis. Nisl nunc mi ipsum faucibus vitae aliquet nec ullamcorper sit. Lectus magna fringilla urna porttitor rhoncus dolor purus non enim. Imperdiet nulla malesuada pellentesque elit eget gravida. Ornare quam viverra orci sagittis eu volutpat odio. Fermentum dui faucibus in ornare quam viverra orci sagittis. Augue neque gravida in fermentum et sollicitudin ac. Mattis pellentesque id nibh tortor id aliquet lectus proin. Mi quis hendrerit dolor magna eget est. At consectetur lorem donec massa sapien faucibus. Ultricies mi eget mauris pharetra. Cras fermentum odio eu feugiat pretium nibh. Sem fringilla ut morbi tincidunt augue interdum velit euismod in. Pellentesque habitant morbi tristique senectus. Nullam eget felis eget nunc lobortis mattis aliquam faucibus purus. Feugiat nibh sed pulvinar proin gravida hendrerit lectus a. Ornare aenean euismod elementum nisi quis eleifend quam. Egestas pretium aenean pharetra magna ac placerat. Tincidunt id aliquet risus feugiat in. Suspendisse faucibus interdum posuere lorem ipsum dolor. Ipsum suspendisse ultrices gravida dictum fusce ut placerat. Risus viverra adipiscing at in tellus. Dolor morbi non arcu risus quis varius quam quisque. Nec nam aliquam sem et tortor consequat id porta. A condimentum vitae sapien pellentesque habitant. Ullamcorper sit amet risus nullam eget felis eget nunc. Diam sollicitudin tempor id eu nisl nunc mi ipsum. Eu facilisis sed odio morbi quis commodo odio aenean. Feugiat vivamus at augue eget arcu. Eget egestas purus viverra accumsan in. Tempus imperdiet nulla malesuada pellentesque elit eget. Lobortis feugiat vivamus at augue eget arcu dictum varius. Lorem donec massa sapien faucibus et molestie ac feugiat sed. Suspendisse ultrices gravida dictum"
            },
        };
    }
}

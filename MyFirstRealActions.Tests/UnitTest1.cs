using FluentAssertions;

namespace MyFirstRealActions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "Hello World!";   
            string result = "Hello";
            result.Should().BeEquivalentTo(expected);
        }
    }
}
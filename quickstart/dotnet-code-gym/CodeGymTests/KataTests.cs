namespace CodeGymTests;

using CodeGym;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void TestSolution()
    {
        var kata = new Kata();

        var solution = kata.Solve();

        Assert.Equal(0, solution);
    }
}

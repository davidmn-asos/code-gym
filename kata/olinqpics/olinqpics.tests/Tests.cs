namespace olinqpics.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Average_Age_Should_Be_41_Point_0625()
    {
        Assert.AreEqual(41.0625,People.AverageAge());
    }
}
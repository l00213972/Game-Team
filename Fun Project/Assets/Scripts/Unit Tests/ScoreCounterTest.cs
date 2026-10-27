using NUnit.Framework;

public class ScoreCounterTests
{
    [SetUp]
    public void SetUp()
    {
        ScoreCounter.appleCounter = 0;
    }

    [Test]
    public void AddApples_IncreasesScoreByOne()
    {
        ScoreCounter.AddApples();

        Assert.AreEqual(1, ScoreCounter.appleCounter);
    }

    [Test]
    public void AddApples_ThreeTimes_IncreasesScoreToThree()
    {
        ScoreCounter.AddApples();
        ScoreCounter.AddApples();
        ScoreCounter.AddApples();

        Assert.AreEqual(3, ScoreCounter.appleCounter);
    }
}
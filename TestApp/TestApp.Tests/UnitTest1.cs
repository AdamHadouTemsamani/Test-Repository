namespace TestApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Simple_Test_That_Returns_Answer()
    {
        Program app = new Program();
        var answer = app.PrintOut("input");

        Assert.Equal("input", answer);
    }
}
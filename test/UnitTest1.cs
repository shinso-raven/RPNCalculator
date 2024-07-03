namespace test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("20 5 /", "4")]
    [TestCase("100 5 /", "20")]
    public void Calculate_simple_operation(string input, string output)
    {

        Calculator rpn = new Calculator();

        string result = rpn.Calculate(input);

        Assert.That(result, Is.EqualTo(output));
    }
}
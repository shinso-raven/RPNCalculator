
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


public class Calculator
{
    public string Calculate(string input)
    {

        string[] values = input.Split(" ");

        double input1 = double.Parse(values[0]);
        double input2 = double.Parse(values[1]);
        return (input1 / input2).ToString();
    }
}
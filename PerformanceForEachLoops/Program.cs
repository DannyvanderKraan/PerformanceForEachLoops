using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<ForBenchmark>();
    }
}

public class ForBenchmark
{
    //Initialize field with collection of numbers and populate it with 10000 numbers
    private List<int> numbers = new List<int>();
    public ForBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            numbers.Add(i);
        }
    }

    [Benchmark(Baseline = true)]
    public void ForEach()
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
    }

    [Benchmark]
    public void For()
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
    }
}




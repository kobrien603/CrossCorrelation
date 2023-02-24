using CrossCorrelation;
using static FSharpAux.Colors.ColorComponent;

Console.WriteLine("Hello, World!");
var sampleA = new List<double>();
var sampleB = new List<double>();
var weight = new List<double>();

for (int i = 0; i < 300; i++)
{
    Console.WriteLine($"row: {i + 1}");

    sampleA = Enumerable.Range(1, 300).Select(p => (double)(p * (i + 1) / 10000M)).ToList();
    sampleB = Enumerable.Range(1, 300).Select(p => (double)(p * (i + 5) / 10000M)).ToList();
    weight = Enumerable.Range(1, 300).Select(p => (double)(p * (i + 1) / 10000M)).ToList();

    // call F# helper to run correlation
    CrossCorrelationHelper.RunCrossCorrelation(sampleA.ToArray(), sampleB.ToArray(), weight.ToArray());
    Console.WriteLine("");
}


    
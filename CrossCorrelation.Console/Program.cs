using CrossCorrelation;
using static FSharp.Stats.Interpolation.CubicSpline;
using static FSharpAux.Colors.ColorComponent;

Console.WriteLine("Hello, World!");
//List<double> sampleA = sampleA = Enumerable.Range(1, 300).Select(p => (double)(p * (5 * 5.54M))).ToList();
//List<double> sampleB = Enumerable.Range(1, 300).Select(p => (double)(p * (2 + 4.3M))).ToList();
List<double> sampleA = sampleA = Enumerable.Range(1, 300).Select(p => (double)p).ToList();
List<double> sampleB = Enumerable.Range(1, 300).Select(p => (double)p).ToList();
var weight = new List<double>();

CrossCorrelationHelper.RunCrossCorrelation(sampleA.ToArray(), sampleB.ToArray(), 300);

//for (int i = 0; i < 300; i++)
//{
//    Console.WriteLine($"row: {i + 1}");

//    sampleA = Enumerable.Range(1, 300).Select(p => (double)(p * (i + 1) / 10000M)).ToList();
//    sampleB = Enumerable.Range(1, 300).Select(p => (double)(p * (i + 5) / 10000M)).ToList();
//    weight = Enumerable.Range(1, 300).Select(p => (double)(p * (i + 1) / 10000M)).ToList();

//    // call F# helper to run correlation
//    CrossCorrelationHelper.RunCrossCorrelation(sampleA.ToArray(), sampleB.ToArray(), weight.ToArray());
//    Console.WriteLine("");
//}



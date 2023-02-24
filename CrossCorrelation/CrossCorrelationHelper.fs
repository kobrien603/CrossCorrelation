namespace CrossCorrelation

open FSharp.Stats
open FSharp.Stats.Correlation

module CrossCorrelationHelper =

    // function to run correlation
    let RunCrossCorrelation (a : array<float>, b: array<float>, weight : array<float>) = 

        let pearson = Seq.pearson a b
        let pearsonW = Seq.pearsonWeighted  a b weight
        let spearman = Seq.spearman a b
        let kendall = Seq.kendall a b
        let bicor = Seq.bicor a b

        printfn($"Pearson: {pearson}");
        printfn($"Pearson W: {pearsonW}");
        printfn($"Spearman: {spearman}");
        printfn($"Kendall: {kendall}");
        printfn($"Bicor: {bicor}");


namespace CrossCorrelation

open FSharp.Stats
open FSharp.Stats.Correlation

module CrossCorrelationHelper =

    // function to run correlation
    let RunCrossCorrelation (data1 : float[]) (data2 : float[]) (range : int) =
        let crossCorrelation = Array.zeroCreate<float> (range * 2 + 1)
        for i in -range .. range do
            let offsetData2 = Array.zeroCreate<float> data2.Length
            for j in 0 .. data2.Length - 1 do
                let k = j + i
                if k >= 0 && k < data2.Length then
                    offsetData2.[j] <- data2.[k]
            crossCorrelation.[i + range] <- pearson data1 offsetData2;
            printfn "Lag: %d Cross-correlation: %A" i crossCorrelation.[i + range];
        crossCorrelation

        //let lagRange = [-300..300];
        //for lag in lagRange do
        //    let shiftedX, shiftedY = 
        //        if lag < 0 then 
        //            Array.append<float> a (Array.map (fun _ -> 0) [|1..-lag|]), Array.append<float> b (Array.map (fun _ -> 0) [|1..-lag|])
        //        elif lag > 0 then 
        //            Array.append<float> (Array.map (fun _ -> 0) [|1..lag|]) a, Array.append<float> (Array.map (fun _ -> 0) [|1..lag|]) b
        //        else 
        //            a, b
        //    let corr = Seq.pearson shiftedX shiftedY
        //    printfn "Lag: %d, Cross-correlation: %A" lag corr
        //let pearson = Seq.pearson a b
        //let pearsonW = Seq.pearsonWeighted  a b weight
        //let spearman = Seq.spearman a b
        //let kendall = Seq.kendall a b
        //let bicor = Seq.bicor a b

        //printfn($"Pearson: {pearson}");
        //printfn($"Pearson W: {pearsonW}");
        //printfn($"Spearman: {spearman}");
        //printfn($"Kendall: {kendall}");
        //printfn($"Bicor: {bicor}");


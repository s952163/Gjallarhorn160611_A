module Model

open OxyPlot

let rnd = System.Random()   
let makeSeries n =
    seq {for _ in 1..n -> rnd.NextDouble() - 0.5} |> Seq.scan (+) 0. |> Seq.mapi (fun x y -> DataPoint(float x,y)) |> Seq.toList



module Raindrops

let private factorsToDrops = [(3, "Pling");
                              (5, "Plang");
                              (7, "Plong")]

let private isFactor number target =
    number % target = 0

let convert (number: int): string = 
    let sounds = factorsToDrops
                |> Seq.filter (fun (k, v) -> number % k = 0) 
                |> Seq.map snd
                |> String.concat ""
    if sounds.Length <> 0 then sounds
    else number.ToString()

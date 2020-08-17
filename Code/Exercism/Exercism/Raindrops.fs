module Raindrops

let private factorsToDrops = Map[3, "Pling";
                                 5, "Plang";
                                 7, "Plong"]

let private isFactor number target =
    number % target = 0

let convert (number: int): string = 
    let sounds = factorsToDrops
                |> Map.filter (fun key value -> number % key = 0) 
                |> Map.toSeq
                |> Seq.map snd
                |> String.concat ""
    if sounds.Length <> 0 then sounds
    else number.ToString()

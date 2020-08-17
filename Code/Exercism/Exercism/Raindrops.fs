module Raindrops

let private factorsToDrops = Map[3, "Pling";
                                 5, "Plang";
                                 7, "Plong"]

let private isFactor number target =
    number % target = 0

let convert (number: int): string = 
    let mutable sounds = ""
    for KeyValue(factor, sound) in factorsToDrops do
        if isFactor number factor then sounds <- sounds + sound
    if sounds = "" then
        sounds <- number.ToString()
    sounds

module Clock

open System

let create hours minutes = 
    let targetHours = ((minutes / 60) + hours) % 24
    new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                 targetHours, minutes % 60, 0)


let add minutes clock = failwith "You need to implement this function."

let subtract minutes clock = failwith "You need to implement this function."

let display (clock: DateTime) = 
    sprintf "%s" (clock.ToString("HH:mm"))

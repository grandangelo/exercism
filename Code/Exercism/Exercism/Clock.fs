module Clock

open System

let private setDate (dateTime: DateTime) = 
    new DateTime(1970, 1, 1, dateTime.Hour, dateTime.Minute, 0)

let create (hours: int) (minutes: int) = 
    let startTime = new DateTime(1970, 1, 1, 0, 0, 0)
    startTime.AddHours(float(hours)).AddMinutes(float(minutes)) |> setDate

let add (minutes: int) (clock: DateTime) = 
    clock.AddMinutes(float(minutes))

let subtract (minutes: int) (clock: DateTime) = 
    add (minutes * -1) clock

let display (clock: DateTime) = 
    sprintf "%s" (clock.ToString("HH:mm"))

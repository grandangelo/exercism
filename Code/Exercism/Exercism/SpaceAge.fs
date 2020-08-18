module SpaceAge

[<Measure>]
type EarthYear

type Planet =
    | Mercury
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let private GetOrbitalPeriod (planet: Planet) =
    match planet with
    | Mercury -> 0.2408467<EarthYear>
    | Venus -> 0.61519726<EarthYear>
    | Earth -> 1.0<EarthYear>
    | Mars -> 1.8808158<EarthYear>
    | Jupiter -> 11.862615<EarthYear>
    | Saturn -> 29.447498<EarthYear>
    | Uranus -> 84.016846<EarthYear>
    | Neptune -> 164.79132<EarthYear>

let age (planet: Planet) (seconds: int64): float = failwith "You need to implement this function."
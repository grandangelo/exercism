module Bob

open System.Text.RegularExpressions

let response (input: string): string = 
    let trimmedInput = input.Trim()
    if Regex.IsMatch(input, "^([ \r\n\t])+$") || input = "" then "Fine. Be that way!"
    else if Regex.IsMatch(trimmedInput, "^([^A-Z])+\?$") then "Sure."
    else if Regex.IsMatch(trimmedInput, "^([^a-z])+\?$") then "Calm down, I know what I'm doing!"
    else if Regex.IsMatch(trimmedInput, "^([A-Z0-9,!%\^\*@#\$\(\s])+$") && Regex.IsMatch(trimmedInput, "([A-Z])+") then "Whoa, chill out!"
    else if trimmedInput.EndsWith('?') then "Sure."
    else "Whatever."


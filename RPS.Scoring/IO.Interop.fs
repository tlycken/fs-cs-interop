namespace RPS.Scoring
open RPS.IO
open System

module IO =

    let prompt (query : string) (options : string list) =
        Console.Prompt(query, (options |> List.toArray))

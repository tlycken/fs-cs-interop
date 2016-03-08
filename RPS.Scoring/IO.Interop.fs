namespace RPS.Scoring
open RPS.IO

module IO =

    let prompt (query : string) (options : (string list) option) =
        match options with
        | Some o -> IO.Prompt(query, (o |> List.toArray))
        | None -> IO.Prompt(query)
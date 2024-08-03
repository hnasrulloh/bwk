module Bwk.Text

open System
open System.Text.RegularExpressions

let find (key: string) (text: seq<string>) =
    seq {
        for segment in text do
            let matchPositions =
                Regex.Matches(segment, key) |> Seq.map (fun m -> m.Index) |> Seq.toList

            if not (List.isEmpty matchPositions) then
                yield (segment, matchPositions)
    }

module Bwk.Tests.Text

open System
open Expecto
open Bwk.Text

let sampleLines = seq {
    "This is a sample text"
    "Another junk 1234"
}

[<Tests>]
let find =
    testList "Tests for `find` commands" [
        test "Find a key in text sequence" {
            let actual = find "sample text" sampleLines |> Seq.toList
            let expected = [ ("This is a sample text", [ 10 ]) ]
            Expect.equal actual expected ""
        }
    ]

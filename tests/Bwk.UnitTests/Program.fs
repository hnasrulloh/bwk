open Expecto



[<Tests>]
let tests = test "A demo test" {
    let subject = "Hello"
    Expect.equal subject "Hello" "Strings should equal"
}


[<EntryPoint>]
let main args = runTestsInAssemblyWithCLIArgs [] args

namespace MyKatas
// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

module Program = 
    let fizzBuzzer value =
        match value with
        | v when v % 15 = 0 -> "FizzBuzz"
        | v when v % 3 = 0 -> "Fizz"
        | v when v % 5 = 0 -> "Buzz"
        | _ -> value.ToString ()

    let shouldBecome expected value = 
        let result = value |> fizzBuzzer
        printfn "%d becomes %s is %b received '%s'" value expected (expected = result) result

    [<EntryPoint>]
    let main argv = 
       (* 1 |> shouldBecome "1"
        2 |> shouldBecome "2"
        3 |> shouldBecome "Fizz"
        6 |> shouldBecome "Fizz"
        5 |> shouldBecome "Buzz"
        10 |> shouldBecome "Buzz"
        15 |> shouldBecome "FizzBuzz"
        30 |> shouldBecome "FizzBuzz" //*)

        [1..100] 
            |> List.map (fun v -> sprintf "%d : '%s'" v (v |> fizzBuzzer)) 
            |> List.iter (fun s -> printfn "%s" s)
        


        
        

        System.Console.ReadKey true |> ignore
        0 // return an integer exit code

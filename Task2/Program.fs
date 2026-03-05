open System

let rec n () =
    let input = Console.ReadLine()

    // Безопасный ввод
    match Int32.TryParse(input) with
    | true, value when value > 0 -> value
    | _ ->
        printfn "Ошибка: введите натуральное число"
        n()

let rec inpDigit () = 
    let input = Console.ReadLine()

    // Безопасный ввод
    match Int32.TryParse(input) with
    | true, value when value >= 0 && value <= 9 -> value
    | _ ->
        printfn "Ошибка: введите цифру от 0 до 9"
        inpDigit()

let inpList  = [
    printf "Введите кол-во цифр: "
    let num = n()

    printfn "Введите цифры:"
    
    for i: int in [1..num] do
        yield inpDigit()
]

[<EntryPoint>]
let main args =
    printfn "Результат: %i" (List.fold (fun acc x -> acc * 10 + x) 0 inpList)
    0
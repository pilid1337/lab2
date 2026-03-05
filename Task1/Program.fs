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
    | true, value when value >= 1 && value <= 9 -> value
    | _ ->
        printfn "Ошибка: введите цифру от 1 до 9"
        inpDigit()

let inpList  = [
    printf "Введите кол-во цифр: "
    let num = n()

    printfn "Введите цифры:"
    
    for i: int in [1..num] do
        yield inpDigit()
]

let toRoman (digit: int): string = 
    match digit with
    | 1 -> "I"
    | 2 -> "II"
    | 3 -> "III"
    | 4 -> "IV"
    | 5 -> "V"
    | 6 -> "VI"
    | 7 -> "VII"
    | 8 -> "VIII"
    | 9 -> "IX"
    | _ -> 
        printfn "Ошибка: перевод не цифры"
        "Error"

let printAns (ans: string list) =
    for i in ans do 
        printf "%A " i
    printfn ""

[<EntryPoint>]
let main args =
    let output = inpList |> List.map toRoman

    printf "Результат: "
    printAns output

    0
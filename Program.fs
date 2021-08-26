// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let description (card: int) : string =
    let cardNo: int = card % 13
    if cardNo = 1 then "Ás"
    elif cardNo = 11 then "Valete"
    elif cardNo = 12 then "Dama"
    elif cardNo = 0 then "Rei"
    else string cardNo

let suit (no:int) : string = 
    let suitNo:int = no / 13
    if suitNo = 0 then "Copas"
    elif suitNo = 1 then "Espada"
    elif suitNo = 2 then "Ouro"
    else "Paus" 

let card c =
    let cardNo = int c
    let output =
        sprintf "A carta %s é %s de %s" c (description cardNo) (suit cardNo)
    printfn "%s" output 

[<EntryPoint>]
let main argv =
    card "11" 
    card "25" 
    card "27" 
    card "52"
    printf "Insira uma carta: "
    card <| Console.ReadLine()
    0 // return an integer exit codee
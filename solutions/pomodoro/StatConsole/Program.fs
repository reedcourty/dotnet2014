// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open Pomodoro.Stat.SQLDataConnection

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    SQLDataConnection.printer
    ignore (System.Console.ReadLine())
    0 // return an integer exit code

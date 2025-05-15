module Solution
open System

let isSquare x: bool =
  let root = Math.Sqrt(x)
  root = floor root
  
Console.WriteLine(isSquare(25))

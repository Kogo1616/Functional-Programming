module FP.Codewars.Sqrt
open System

let isSquare (x: int) : bool =
    let root = Math.Sqrt(float x)
    root = floor root

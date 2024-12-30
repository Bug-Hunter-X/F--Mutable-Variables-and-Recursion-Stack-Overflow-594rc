let rec loop x y =
    if x < 10 then
        loop (x + 1) (y + 1)
    else
        printfn "%d %d" x y

loop 0 0
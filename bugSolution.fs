let mutable x = 10
let mutable y = 20

let add (x:byref<int>) (y:byref<int>) =  x <- x + y

printf "%d\n" (add &x &y |> ignore; x)

x <- 30
y <- 40

printf "%d\n" (add &x &y |> ignore; x)
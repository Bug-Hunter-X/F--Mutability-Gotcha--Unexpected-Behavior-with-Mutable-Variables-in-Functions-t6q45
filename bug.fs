let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d\n" z

x <- 30
y <- 40

printf "%d\n" (add x y)
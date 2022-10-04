open System

//Задание 1
printf "\nЗадание 1"
let func1(a:int, b:int, c:int) = a + b + c;
let func2(a: int)(b: int)(c: int) = a + b + c;

let a = func1(1, 2, 2)
let b = func2(1)(2)(3)
printf "\nОтвет: %A" a
printf "\nОтвет: %A" b

//Задание 2
printf "\n\nЗадание 2"
let rec recursFunc(a:int, b:int):int = 
    if b<=a then a
    else b + recursFunc(a, b-1)
let ex2 = recursFunc(2, 10)
printf "\nСумма от 2 до 10 = %A" ex2

//Задание 3
printf "\n\nЗадание 3"
let rec tailRec(a:int, b:int, acc:int):int = 
    if b <= a then acc+a 
    else tailRec(a, b-1, b+acc)
let rec tailRec2(a, b) = tailRec(a, b, 0)
let ex3 = tailRec2(3, 7)
printf "\nСумма от 3 до 7 = %A" ex3

//Задание 4
printf "\n\nЗадание 4\n"
let rec State1(x:int) =
    printfn "%i - (+1) %i" x (x+1)
    let x_next = x+1
    if x_next>5 then State2(x_next)
    else 
        State1(x_next)

and State2(x:int) =
    printfn "%i - (^2) %i" x (x*x)
    let x_next = x+1
    if x_next>10 then State3(x_next)
    else 
        State2(x_next)
and State3(x:int) =
    printfn  "%i - (^3) %i" x (x*x*x)
    let x_next = x+1
    if x_next<=15 then State3(x_next)
State1(1)

//Задание 5
printf "\n\nЗадание 5"
let lambda1 = fun (a:int, b:int, c:int) -> a+b+c
let ex4_1 = lambda1(1,2,3)

let del1(a:int, b:int, func1: int*int->int) = func1(a, b)
let ex4_2 = del1(1, 3, fun(a, b) -> a+b);

printf "\nЛямбда = %A" ex4_1
printf "\nПринимает лямбду = %A" ex4_2

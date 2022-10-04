//Задание 1
let ex1_1(a, b, c) = (a, b, c)

let ex1_2(a, b, c) = (a+a, b+0.0, c+"")

//Задание 2
let sum_generic(a, b, c, f) = f(a, b, c)
let ex2_1(a, b, c) = sum_generic(a, b, c, fun(a, b, c)->a+b+c)
let ex2_2(a, b, c) = sum_generic(a, b, c, fun(a, b, c)->0.0+a+b+c)
let ex2_3(a, b, c) = sum_generic(a, b, c, fun(a, b, c)->""+a+b+c)

printf "Задание 2"
printf "\n2_1: %i" (ex2_1(1,2,3));
printf "\n2_2: %f" (ex2_2(1.1,2.2,3.3));
printf "\n2_3: %s" (ex2_3("1","2","3"));

//Задание 3
let list3 = [for x in [1..10] do if x % 2 = 0 then yield (x, x*x, x*x*x)]
printf "\n\nЗадание 3\n"
for x in list3 do
    printfn "%A" x

//Задание 4
let list4 = [1..10]
let rec ex4_1(l:int list):int list =
    if l.IsEmpty then []
    else (l.Head*l.Head)::ex4_1(l.Tail)

let rec ex4_2 = function
    | [] -> []
    | x::xs -> x*x::ex4_2(xs)

let res4_1 = ex4_1(list4)
let res4_2 = ex4_2(list4)

printf "\nЗадание 4\n"
printf "ex4_1: "
for x in res4_1 do
    printf "%A, " x

printf "\nex4_2: "
for x in res4_2 do
    printf "%A, " x

//Задание 5
printf "\n\nЗадание 5\n"

let testList = [1..10]
printfn "testList = %A" testList

let mapList = List.map(fun x->x*x*x) testList // Map
printfn "..map.. %A" mapList

let sortList = List.rev (List.sort mapList) // Sort
printfn "..sort.. %A" sortList

let filterList = List.filter(fun x->x % 2 = 0) sortList // Filter
printfn "..filter.. %A" filterList

let foldValue = List.fold(fun acc x -> acc + x) 0 filterList // Fold
printfn "..fold.. %A" foldValue

let zipList = List.zip testList mapList // Zip
printfn "..zip.. %A" zipList

// Задание 6
printf "\nЗадание 6\n"

let newList = testList |> List.map(fun x->x*x*x) |> List.rev |> List.filter(fun x->x % 2 = 0)
printfn "..map..sort..filter.. %A" newList

// Задание 7
printf "\nЗадание 7\n"

let ListFunc = List.map(fun x->x*x*x) >> List.rev >> List.filter(fun x->x % 2 = 0)
let newList1 = ListFunc testList
printfn "..map..sort..filter.. %A" newList1

//функтор
let rec fmapList f list =
    match list with
        | [] -> []
        | x::xs -> f x :: fmapList f xs

//проверка 1
//Пусть id – функция, которая возвращает неизменным значение аргумента.
//Тогда подъем этой функции в контекст не влияет на вычисление:
let list1 = [1..10]
let lst1 = fmapList (fun x->x+1) list1

let id x = x

let lst3 = fmapList id list1

//проверка 2
//Для двух функций f и g композиция их подъемов эквивалентна
//подъему композиции.
let func_f x = x + 1
let func_g x = x * 2
let lst2_1 = fmapList func_f list1
let lst2_2 = fmapList func_g lst2_1
let lst2_3 = fmapList (func_f >> func_g) list1

//апликаторная функция
let rec applyList (lf: ('a->'b) list) (list: 'a list) =
    [ for f in lf do
        for x in list do
            yield f x ]

let rec applyList2 (list: 'a list) (lf: ('a->'b) list) =
    [ for x in list do
        for f in lf do
            yield f x]

let al1 = applyList [(fun x-> x+1);(fun x->x*10)] list1

//Закон 1
//Функция id переданная в списке [id] применяется также как и функцияid вне списка
let at11 = id 1
let at12 = applyList [id] list1
//Закон 2
//Если y=f(x), то подъем функции f и значения х и применение к ним
//функции apply приведет к такому же результату, что и подъем y
let app_f = fun x -> x+1
let app_x = 1
let app_y = [app_f app_x]

let app_y2 = applyList [app_f] [app_x]
//Закон 3
//Аргументы apply можно менять местами.
let at31 = applyList [(fun x->x*10);(fun x-> x*20)] list1
let at32 = applyList2 list1 [(fun x->x*10);(fun x-> x*20)]



let q = 1


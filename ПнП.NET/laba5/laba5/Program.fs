//Для использования классов Math и Console
open System
// Алгебраический тип или "Discriminated Unions"
// Алгебраический тип - тип сумма из типов произведений
// | - означает "или" и задает тип-сумму
// * - означает "и" и задает произведение (кортеж, который соединяет все элементы)
// В абстрактных алгебрах наиболее близкой алгеброй является полукольцо

// Тип решения квадратного уравнения
type SquareRootResult =
    | NoRoots
    | FourRoots of double * double * double * double

///Функция вычисления корней уравнения
let CalculateRoots(a:double, b:double, c:double):SquareRootResult =
    let sq = (b*b-4.0*a*c);
    let sq1 = ((-b-Math.Sqrt(sq))/(2.0*a));
    let sq2 = ((-b+Math.Sqrt(sq))/(2.0*a));


    if (sq < 0.0 || sq1 < 0.0 || sq2 < 0.0)
        then NoRoots
    else
        let x1 = (-1.0)*Math.Sqrt(sq1);
        let x2 = (-1.0)*Math.Sqrt(sq2);
        let x3 = Math.Sqrt(sq1);
        let x4 = Math.Sqrt(sq2);
        FourRoots (x1, x2, x3, x4)


///Вывод корней (тип unit - аналог void)
let PrintRoots(a:double, b:double, c:double):unit =
    printf "Коэффициенты: a=%A, b=%A, c=%A. " a b c
    let root = CalculateRoots(a,b,c)
    //Оператор сопоставления с образцом
    let textResult = 
        match root with
        | NoRoots -> "Отрицательный корень"
        | FourRoots(x1, x2, x3, x4) -> "Корни: (" + x1.ToString() + ", " + x2.ToString() + ", " + x3.ToString() + ", " + x4.ToString() + ")"
    printfn "%s" textResult

[<EntryPoint>]
let main argv =
    //Тестовые данные
    //2 корня
    let a1 = 1.0;
    let b1 = -10.0;
    let c1 = 9.0;
    //1 корень
    let a2 = 4.0;
    let b2 = -5.0;
    let c2 = 1.0;
    //нет корней
    let a3 = 12.0;
    let b3 = 1.0;
    let c3 = 4.0;

    PrintRoots(a1,b1,c1)
    PrintRoots(a2,b2,c2)
    PrintRoots(a3,b3,c3)
    
    //|> ignore - перенаправление потока с игнорирование результата вычисления  
    Console.ReadLine() |> ignore 
    
    0 // возвращение целочисленного кода выхода

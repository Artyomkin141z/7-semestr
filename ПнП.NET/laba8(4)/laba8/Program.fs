//Часть 1
[<AbstractClass>]
type GiometrycFigure() = 
    abstract member setArea: unit -> float

type Interface1 = interface
    abstract member Print: unit -> unit
    end

type Rectangle(a: float, b: float) =
    inherit GiometrycFigure()
    let mutable A = a
    let mutable B = b
    override this.setArea() = A * B
    override this.ToString() = 
        let str = "\nПрямоугольник \na: " + A.ToString() + "\nb: " + B.ToString() + "\nПлощадь прямоугольника: " +  (this.setArea()).ToString()
        str 
    interface Interface1 with
        member this.Print() =
            printf "%s" (this.ToString())
            
    

type Square(a: float) = 
    inherit GiometrycFigure()
    let mutable A = a
    override this.setArea() = A * A
    override this.ToString() = 
        let str = "\n\nКвадрат\na: " + A.ToString() + "\nПлощадь квадрата: "  + (this.setArea()).ToString()
        str
    interface Interface1 with
        member this.Print() =
            printf "%s" (this.ToString())
            


type Circle(a: float) = 
    inherit GiometrycFigure()
    let mutable A = a
    override this.setArea() = A * A * 3.14
    override this.ToString() = "\n\nКруг\nr: " + A.ToString() + "\nПлощадь круга: " + (this.setArea()).ToString()
    interface Interface1 with
        member this.Print() =
            printf "%s" (this.ToString())
            


let rectangle = Rectangle(1.2, 10)
let i1 = rectangle :> Interface1
i1.Print()

let square = Square(5)
let i2 = square :> Interface1
i2.Print()

let circle = Circle(13)
let i3 = circle :> Interface1
i3.Print()

//Часть 2
printfn"\n\nЧасть 2"
type GFigure =
    | Rectangle1 of a: float * b : float
    | Square1 of a: float
    | Circle1 of r: float

let gArea (gf: GFigure) =
    match gf with
    |GFigure.Rectangle1 (a, b) -> printfn"\nСтороны прямоугольника: %s %s\nПлощадь прямоугольника: %s" (a.ToString()) (b.ToString()) ((a*b).ToString())
    |GFigure.Square1 a -> printfn"\nСторона квадрата: %s \nПлощадь квадрата: %s" (a.ToString()) ((a*a).ToString())
    |GFigure.Circle1 r -> printfn"\nРадиус круга: %s \nПлощадь круга: %s" (r.ToString()) ((r*r*3.14).ToString())


gArea (GFigure.Rectangle1(4, 5))
gArea (GFigure.Square1 6)
gArea (GFigure.Circle1 4)



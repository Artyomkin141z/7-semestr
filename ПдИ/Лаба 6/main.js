const mas = [1,2,3,7,4,11,3,2,4,1];

function ex1(mas){
    mas.forEach(element => {
        if(element === 4) console.error("Элемент ", element);
        else console.log("Элемент ", element);
    });
}

function ex2(){
    let isOut = true;
    while(isOut){
        let str = prompt();
        if(str == "Дата"){
            console.log(new Date());
            isOut = false;
        }
    }
}

function ex3(N){
    let mas = [];
    mas[N-1] = N;
    mas.fill(N, 0, N);
    setTimeout(() => {
        mas.forEach((element, i) => {
            console.log(i+1 + ": " + element);
        })
    }, 3000)
}
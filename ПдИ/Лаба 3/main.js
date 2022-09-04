const calculator = {
    x: 0, 
    y: 0,
    read(x, y){
        this.x = x;
        this.y = y;
        return this;
    },
    sum(){
        console.log('x + y = ', this.x+this.y);
        return this;
    },
    mul(){
        console.log('x * y = ', this.x*this.y);
        return this;
    }
}

function Accumulator(startingValue){
    this.value = startingValue;
    this.read = () => {
        this.value += +prompt('Введите число');
        console.log('value: ', this.value);
    }
}

function random(min, max){
    return Math.random() * (max - min) + min;
}

function extractCurencyValue(str){
    return +str.slice(1);
}

function sumInput(){
    let num = 0;
    let mas = [];
    while(true){
        num = prompt();
        if(isNaN(num) || num === null) break;
        else mas.push(+num);
    }
    return mas.reduce((x, y) => x + y);
}

const salaries = {
    a: 12,
    b: 100,
    c: 1000,
}

function sumSalaries(salaries){
    let sum = 0;
    for(let i of Object.values(salaries)){
        sum += i;
    }
    return sum;
}

function topSalary(salaries){
    let max = null;
    let name = '';
    for([name, zp] of Object.entries(salaries)){
        if(zp > max) max = zp;
    }
    return (max === null) ? null : name;
}

function sum(a){
    return (b) => {
        return a + b;
    }
}
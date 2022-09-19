    function checkAge1(age){
    return age >= 18 ? true : 'Родители разрешили?';
}

function checkAge2(age){
    return age >= 18 || 'Родители разрешили?';
}

function min(a, b){
    return a < b ? a : b;
}

function pow(x, n){
    return x**n;
}

function les4(a){
    if(a % 2 == 1) alert(a);
    while(a % 2 === 0){
        if(a % 2 == 1) alert(a);
        else a = prompt('Введите число');
    }    
}

function les5(str){
    if(+str){
        alert(+str * 2);
    }
    console.log(str * 2);
    while(isNaN(+str)){
        str =  prompt('Введите строку');
        if(+str){
            alert(+str * 2);
            break;
        }
    } 
}

function les6(mass){
    let answer = [];
    for(let i = 0; i< mass.length; i++){
        if(mass[i] % 2 === 0){
            answer.push(mass[i]);
        }
    }
    console.log(answer);
}
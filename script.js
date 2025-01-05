getSum(5, 3) // result: 8
getSum(-11, 3) // result: -8
getSum(0.2, 0.7) // result: 0.9

function getSum (a,b){
    return a+b;
}

console.log(getSum(5, 3));
console.log(getSum(-11, 3));
console.log(getSum(0.2, 0.7));

isSquare(9) // result: true (√9=3)
isSquare(8) // result: false

function isSquare (x){
    if (Number.isInteger(Math.sqrt(x))){
        return true;
    }else {
        return false;
    }
}

console.log(isSquare(9));
console.log(isSquare(8));

greeting('Bill', 'Jacobson', 33); // result: Hello, my name is Bill Jacobson and I am 33 years old.
greeting('Jim', 'Power', 11); // result: Hello, my name is Jim Power and I am 11 years old.

function greeting (firstNAme, lastName, age){
    return `Hello, my name is ${firstNAme} ${lastName} and I am ${age} years old.`
}

console.log(greeting('Bill', 'Jacobson', 33));
console.log(greeting('Jim', 'Power', 11));
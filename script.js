function sumSequence(n) {

     if (n === 0) {
          return '0.00';
     }
     let sum = 0;


     for (let i = 1; i <= n; i++) {
          sum += 1 / (2 ** i);
     }
     return sum.toFixed(2);

}

// function mergeArrays(...arr) {
 
// if(arr.length === 0){
//      return []
// }
    
// return arr.reduce((acc,curr)=>acc.concat(curr),[]);

//    }
// console.log(mergeArrays([1, 2, 3], [5, 6], [9]));
// console.log(mergeArrays());


function isPalindrome(str) {

     let newStr = str.split('').reverse().join('');

   return str === newStr;
   }

   isPalindrome("abba"); // true
isPalindrome("abbaa"); // true
isPalindrome("abbx"); // false
isPalindrome("aade"); // false
isPalindrome("ab"); // false
isPalindrome("abcba"); // true


function countLetters(str) {
    
    if(!str||str.length === 0){
     return {}
    };
    
     let charCount = {};

     for(let char of str){
          if(char !==' '){
     if(charCount[char]){
          charCount[char]++;
     }else{
          charCount[char]=1;
     }
    }
   }
    return charCount;
   }

// console.log(countLetters("abababa")); //{a: 4, b: 3}

// console.log(countLetters("asdf sdf df f")); //{a: 1, s: 2, d: 3, f: 4}

// console.log(countLetters("")); //{}


function divideArrays(arr, size) {
     if(arr.length < size){
          return arr;
     }else if (size<=0){ 
          return [];
     }

    let newArr = [];
    for (let i =0; i<arr.length; i+=size){
          newArr.push(arr.slice(i,i+size));
    }
return newArr;
}

console.log(divideArrays([1, 2, 3, 4, 5], 2)); //[[1,2],[3,4],[5]]
console.log(divideArrays([1, 2, 3, 4, 5], 8)); //[[1,2,3,4,5]]
console.log(divideArrays([1, 2, 3, 4, 5], -1)); //[]

   

function encrypt(str, n) {
     if(n<=0){
          return str
     }

     let alfavit = [];
     let stroka = 'A B C D E F G H I J K L M N O P Q R S T U V W X Y Z'
     alfavit = stroka.split(' ');
     let strArray = str.split('');
     let array = [];

          for(let char of strArray ){

               let index = alfavit.indexOf(char);
               if (index !== -1){
                    let newIndex = (index - n + alfavit.length)%alfavit.length;
                    array.push(alfavit[newIndex])
               }

          }
          return array.join('');
   }

console.log(encrypt("FUNCTION", 3));; // 'CRKZQFLK'
console.log(encrypt("JAVASCRIPT", 2));; // 'HYTYQAPGNR'
console.log(encrypt("HELLO", 0));; // 'HELLO'
console.log(encrypt("HELLO", -4));; // 'HELLO'

   
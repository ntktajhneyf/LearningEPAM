const marks = [50,20,70,60,45,30];


function findMinMax (array){

     let min = array[0];
     let max = array[0];

     for(let i=0; i<array.length; i++){
          console.log(i);
          if(marks[i]<min){
               min = marks[i];
          }else{
               max = marks[i]
          }
     
     }
     return {min: min, max: max};
}

console.log(findMinMax(marks));

console.log(min);
console.log(max);

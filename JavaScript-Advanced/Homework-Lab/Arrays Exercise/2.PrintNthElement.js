function solve(array,nth){
    nth = Number(nth);
    let result = [];
for (let index = 0; index < array.length; index++) {
   if (index % nth == 0) {
       result.push(array[index]);
   }
}
    return result;
}
solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2
)
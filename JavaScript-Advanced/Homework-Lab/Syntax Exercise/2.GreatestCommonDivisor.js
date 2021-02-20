function solve(first,second){
    let min = Math.min(first,second);
    let max = Math.max(first,second);
    let greatestDivisor = 2;
    for (let i = min; i > 0; i--){
        if (max % i == 0 && min % i == 0) {
           console.log(i);
           break;
        }
       
    }
   
}
solve(15,5)
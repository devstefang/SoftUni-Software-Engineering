function solve(input){
   let biggestNums = [];
    let currMax = input[0];
   for (let i = 0; i < input.length; i++) {
    
    if (input[i] >= currMax) {
        biggestNums.push(input[i]);
        currMax = input[i];
    }
   }
    return biggestNums;
}
solve([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    )
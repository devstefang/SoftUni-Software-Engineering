function solve(matrix){
    let maxNum = Number.MIN_SAFE_INTEGER;
    matrix.forEach(row => {
       let currMax = Math.max(...row);
       if (currMax > maxNum) {
           maxNum = currMax;
       }
    });
    console.log(maxNum);
}
solve([[20, 50, 10],
    [8, 33, 145]]
   )
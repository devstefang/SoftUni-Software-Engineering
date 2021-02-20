function solve(matrix){

    let rowMatrix = [];
    for (let i = 0; i < matrix.length; i++) {
        let row = matrix[i];
        let sum = row.reduce((acc,curr) => (acc + curr),0);
        rowMatrix.push(sum);
    }
    let sum = 0;
    let num = rowMatrix[0];
    let count = 0;
    for (let i = 0; i < rowMatrix.length; i++) {
        if (rowMatrix[i] == num) {
            count++;
        }
    }
    if (count == rowMatrix.length) {
        return true;
    }
    return false;
    
}
solve([[1, 0, 1],
    [0, 0, 2],
    [0, 0, 1]]
   
   )
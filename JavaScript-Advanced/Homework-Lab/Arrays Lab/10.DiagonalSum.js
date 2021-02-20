function solve(matrix){
    let primarySum = 0;
    let secondarySum = 0;
    let elementIndex = 0;
    matrix.forEach(row => {
        primarySum += row[elementIndex]
        secondarySum += row[matrix.length - 1 - elementIndex]
        elementIndex++;
    });
    console.log(primarySum + ' ' + secondarySum);
}

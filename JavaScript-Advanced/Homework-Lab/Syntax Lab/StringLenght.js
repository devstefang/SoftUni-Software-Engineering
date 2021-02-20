function solve(arr1, arr2, arr3){
    let sumLength;
    let averageLength;

    let firstArgument = arr1.length;
    let secondArgument = arr2.length;
    let thirdArgument = arr3.length;
    sumLength = firstArgument + secondArgument + thirdArgument;
    averageLength = Math.floor(sumLength / 3);
    console.log(sumLength);
    console.log(averageLength);
}
solve('chocolate', 'ice cream', 'cake');

function solve(input){
    let sortedArray = [];
    input.sort((a,b) =>{
    return a - b
    })
    while (input.length) {
       sortedArray.push(input.shift());
       sortedArray.push(input.pop());
    }
    return sortedArray;
}
solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56])
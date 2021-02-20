function solve(array){
    let finalArray = [];
    for (let i = 0; i < array.length; i++) {
        if (i % 2 != 0) {
            finalArray.push(array[i]);
        }
    }
   finalArray = finalArray.reverse().map(x=>x * 2);
    console.log(finalArray.join(' '));
    

}
solve([10, 15, 20, 25])
function subsum(array,startIndex,endIndex){
   
    if(endIndex > array.lenght - 1){
        endIndex = array.lenght - 1
    }
    if(startIndex < 0){
        startIndex = 0;
    }
    if(!Array.isArray(array)){
        return NaN;
    }
    let arrayToSum = array.slice(startIndex,endIndex+1);
    const reducer = (sum, val) => Number(sum + val);
    const initialValue = 0;
    return arrayToSum.reduce(reducer, initialValue);
}
subsum([10, 'twenty', 30, 40], 0, 2)
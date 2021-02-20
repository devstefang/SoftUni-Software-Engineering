function sumOfNums(n,m){
    let result = 0;
    let num1 = +n;
    let num2 = +m;
    for (let index = num1; index <= num2; index++) {
        if (index < 0) {
            index = Math.abs(index);
            continue;
        }
         result += index;
        
    }
    return result;
}
sumOfNums(-8,20)
function sameNums(number){
    number =number.toString();
     let count = 0;
    let length = number.length;
    let isEqual = false;
    let lastDigit = number % 10;
    let sum = 0;
        for (let i = 0; i < length; i++) {
            let currNum = number[i];
            currNum = Number(currNum);
            if (currNum == lastDigit) {
                count++;
            }
            if (count == number.length) {
                isEqual = true;
            }
            sum += currNum;
        }
    console.log(isEqual);
    console.log(sum);
}
sameNums(2222222)
function squareFrame(input){
    let n = Number(input);
    let fullrow = '* '.repeat(n);
    for (let index = 0; index < n; index++) {
        console.log(fullrow,'\n');
    }
}
squareFrame(4);
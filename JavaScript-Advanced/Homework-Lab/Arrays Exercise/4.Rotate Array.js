function solve(input,times){

    times = Number(times);
    for (let i = 0; i < times; i++) {
       let temp = input.pop();
       input.unshift(temp);
        
    }
    console.log(input.join(' '));
}
solve(['1', 
'2', 
'3', 
'4'], 
2
)
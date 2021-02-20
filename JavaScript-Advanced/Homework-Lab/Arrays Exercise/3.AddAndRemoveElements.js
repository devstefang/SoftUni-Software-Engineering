function solve(commands){
    let output = [];
    let count = 1;
    commands.forEach(element => {
        if (element == 'add') {
             output.push(count);
            }else{
                output.pop();
            }
            count++;
    });
    output.length == 0 ? console.log("Empty") : console.log(output.join('\n'));
}
solve(['add', 
'add', 
'add', 
'add']
)
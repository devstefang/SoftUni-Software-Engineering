function solve(input,criteria){

    let sortFunction = {
        asc: function(arr){
            arr.sort((a,b) => a - b);
        },
        desc: function(arr){
            arr.sort((a,b) => b-a);
        }
    }
    let func = sortFunction[criteria];
    func(input);
    return input;
}
solve([14, 7, 17, 6, 8], 'asc')
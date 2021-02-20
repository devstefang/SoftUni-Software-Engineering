function solve(population){
    const towns = {};
    for (let townAsString of population) {
        
        let tokens = townAsString.split(' <-> ');
        let city = tokens[0];
        let populationCount = Number(tokens[1]);
        if (towns[city] == undefined) {
            
            towns[city] = populationCount;
        }else{
            towns[city] += populationCount;
        }
    }
    for (let name in towns) {
        console.log(`${name} : ${towns[name]}`);
    }
}
solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
)
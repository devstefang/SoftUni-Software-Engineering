function evenPosition(numbers){
    let array = [];
    
for (let index = 0; index < numbers.length; index++) {
    if (index % 2 == 0) {
        
        array.push(numbers[index]);
    }
}
    console.log(array.join(' '));
}
evenPosition(['20', '30', '40', '50', '60']);
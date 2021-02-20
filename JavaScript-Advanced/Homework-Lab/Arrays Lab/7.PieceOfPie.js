function solve(array,startPie,endPie){
    let pieArray = [];
    let index = 0;
    let canIterate = false;
    array.forEach(pie => {
        if (canIterate === true) {
            pieArray[index++] = pie;
            canIterate = false;
        }
        if (pie === startPie) {
            pieArray[index++] = pie;
            canIterate = true;   
        }
        if (pie === endPie) {
            pieArray[index++] = pie;
        }

    });
   console.log(pieArray.toString());

}
solve(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
)
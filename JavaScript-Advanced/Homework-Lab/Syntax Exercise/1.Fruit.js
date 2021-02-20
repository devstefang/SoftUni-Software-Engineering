function buyFruit(fruit,weight,price){
    let weightReduced = weight / 1000;
    let totalPrice = weightReduced * price;
    console.log(`I need $${totalPrice.toFixed(2)} to buy ${weightReduced.toFixed(2)} kilograms ${fruit}.`)
}
buyFruit('orange', 2500, 1.80)
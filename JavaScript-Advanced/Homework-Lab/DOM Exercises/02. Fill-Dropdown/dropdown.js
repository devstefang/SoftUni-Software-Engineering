function addItem() {
    let textElement= document.getElementById('newItemText');
    let valueElement= document.getElementById('newItemValue');
    let option = `<option value="${valueElement.value}">${textElement.value}</option>`
    let select = document.getElementById('menu');
    select.innerHTML += option;
    textElement.value = '';
   valueElement.value = '';
}
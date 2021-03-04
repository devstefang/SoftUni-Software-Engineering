function addItem() {

    let ulElement = document.getElementById('items');
    let inputText = document.getElementById('newItemText');
    let liElement = document.createElement('li');
    liElement.innerHTML = inputText.value;
    ulElement.appendChild(liElement);
    liElement.value = ' ';
}

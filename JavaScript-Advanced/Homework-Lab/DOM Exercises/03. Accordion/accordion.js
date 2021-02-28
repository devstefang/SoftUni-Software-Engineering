function toggle() {
    let btn = document.getElementsByClassName('button')[0];
    let divText = document.getElementById('extra');
    if (btn.innerHTML == "More") {
        divText.style.display = 'block';
        btn.innerHTML = "Less";
    }else{
        divText.style.display = 'none';
        btn.innerHTML = "More";
    }
}
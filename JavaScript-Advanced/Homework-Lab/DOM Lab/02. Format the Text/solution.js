function solve() {
  let paragraphValue = document.getElementById('input').innerText;
  let outputElement = document.getElementById('output');
  let finalValue = paragraphValue
    .split('.')
    .reduce((acc,sentence,index)=>{
      if (index % 3 === 0) {
        acc.push([sentence]);
      }else{
        acc[acc.length-1].push(sentence);
      }
      return acc;
    },[])
    .forEach(paragraph =>{
      let paragraphElement = document.createElement('p');
      paragraphElement.textContent = paragraph;
      outputElement.appendChild(paragraphElement);
    });
  
  
}
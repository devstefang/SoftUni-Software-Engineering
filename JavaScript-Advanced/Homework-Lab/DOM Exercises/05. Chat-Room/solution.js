function solve() {
   let message = document.getElementById('chat_input');
   let btn = document.getElementById('send');
   let chatMessages = document.getElementById('chat_messages');
   btn.addEventListener('click',()=>{
      let currentMessage = message.value;
      let myMessages = document.createElement('div');
      myMessages.classList.add('message'); 
      myMessages.classList.add('my-message'); 
      myMessages.textContent = currentMessage;
      chatMessages.appendChild(myMessages);
      message.value = '';
   })
}



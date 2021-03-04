function deleteByEmail() {
   let emailInput = document.querySelector('input[name = "email"]');
   let inputValue = emailInput.value;
   let tdElements = document.querySelectorAll('#customers td:nth-of-type(2)');
   let divElement = document.getElementById('result');

   for (const emails of tdElements) {
       if (inputValue === emails.textContent) {
           divElement.textContent = 'Deleted.';
            emails.parentElement.remove();
            return;
       }
   }
   
     divElement.textContent = 'Not found';
   
}
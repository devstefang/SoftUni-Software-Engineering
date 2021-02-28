function createArticle() {
	
	let titleInput = document.getElementById('createTitle');
	let contentInput = document.getElementById('createContent');
	let articleElement = document.createElement('article');
	if (titleInput.value != '' && contentInput.value != '') {
	
		let h3Element = document.createElement('h3');
		let pElement = document.createElement('p');
		h3Element.innerHTML = titleInput.value;
		pElement.innerHTML = contentInput.value;
		articleElement.appendChild(h3Element);
		articleElement.appendChild(pElement);
		let articleSectionElement = document.getElementById('articles');
		articleSectionElement.appendChild(articleElement);
		titleInput.value = '';
		contentInput.value = '';
	}
}
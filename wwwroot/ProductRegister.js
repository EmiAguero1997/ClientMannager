submitButton.addEventListener('click', function () {
  const name = document.getElementById('name').value;
  const price = document.getElementById('price').value;

  const productData = {
    name: name,
    price: price
  };

  fetch('/api/Products', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(productData)
  })
  .then(response => {
    if (response.ok) {
      // Redirigir a Products.html después de que se registra el producto
      window.location.href = '/Products.html';
    } else {
      throw new Error('Error al enviar los datos del producto');
    }
  })
  .catch(error => {
    console.error('Error:', error);
  });
});

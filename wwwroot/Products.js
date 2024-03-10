document.addEventListener('DOMContentLoaded', function() {
    // Realizar una solicitud para obtener la lista de productos
    fetch('/api/products')
      .then(response => {
        if (!response.ok) {
          throw new Error('No se pudo obtener la lista de productos');
        }
        return response.json();
      })
      .then(products => {
        const productList = document.getElementById('product-list');
        products.forEach(product => {
          const productItem = document.createElement('div');
          productItem.classList.add('product-item');
          productItem.innerHTML = `
            <h2>${product.name}</h2>
            <p>Precio: ${product.price}</p>
          `;
          productList.appendChild(productItem);
        });
      })
      .catch(error => {
        console.error('Error:', error.message);
        // Manejar el error de alguna manera, como mostrar un mensaje de error al usuario.
      });
});

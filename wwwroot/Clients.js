document.addEventListener('DOMContentLoaded', function() {
    // Realizar una solicitud para obtener la lista de clientes
    fetch('/api/clients')
      .then(response => {
        if (!response.ok) {
          throw new Error('No se pudo obtener la lista de clientes');
        }
        return response.json();
      })
      .then(clients => {
        const clientList = document.getElementById('client-list');
        clients.forEach(client => {
          const clientItem = document.createElement('div');
          clientItem.classList.add('client-item');
          clientItem.innerHTML = `
            <h2>${client.companyName}</h2>
            <p>Nombre: ${client.firstName} ${client.lastName}</p>
            <p>Telefono Celular: ${client.cellPhone}</p>
            <p>Correo Electronico: ${client.email}</p>
          `;
          clientList.appendChild(clientItem);
        });
      })
      .catch(error => {
        console.error('Error:', error.message);
        // Manejar el error de alguna manera, como mostrar un mensaje de error al usuario.
      });
});

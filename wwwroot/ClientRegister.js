submitButton.addEventListener('click', function () {
  const companyName = document.getElementById('companyName').value;
  const cellPhone = document.getElementById('cellPhone').value;
  const firstName = document.getElementById('firstName').value;
  const lastName = document.getElementById('lastName').value;
  const email = document.getElementById('email').value;

  const clientData = {
    companyName: companyName,
    cellPhone: cellPhone,
    firstName: firstName,
    lastName: lastName,
    email: email
  };
  console.log(clientData)

  fetch('/api/Clients', {  // Utiliza la ruta '/api/Clients' en lugar de '/guardar-cliente'
    method: 'POST',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(clientData)
  })
  .then(response => {
    if (response.ok) {
      // Redirigir a clients.html después de que se registra el cliente
      window.location.href = '/clients.html';
      return response.json();
    } else {
      throw new Error('Error al enviar los datos del cliente');
    }
  })
  .then(data => {
    console.log('Cliente registrado exitosamente:', data);
    // Puedes hacer algo aquí después de que se registra el cliente
  })
  .catch(error => {
    console.error('Error:', error);
  });
});

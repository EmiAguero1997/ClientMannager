using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientMannager.Repositories;
using ClientMannager.Models;

namespace ClientMannager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        //CONSTRUCTOR
        #region
        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        private readonly IClientRepository _clientRepository;
        #endregion

        [HttpGet]
        public IActionResult GetAllClients()
        {
            try
            {
                var clients = _clientRepository.GetAllClients();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            try
            {
                var client = _clientRepository.FindById(id);
                if (client == null)
                {
                    return NotFound();
                }
                return Ok(client);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] ClientCreateDTO clientDTO)
        {
            try
            {
                var client = new Client(clientDTO);
                _clientRepository.Save(client);
                return Ok(client);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
    }
}

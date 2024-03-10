using ClientMannager.DTOs;
using ClientMannager.Models;
using ClientMannager.Repositories;
using ClientMannager.Repositories.HomeBankingMindHub.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClientMannager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        //CONSTRUCTOR
        #region
        public OrdersController(IOrderRepository orderRepository, IClientRepository clientRepository)
        {
            _orderRepository = orderRepository;
            _clientRepository = clientRepository;
        }
        private readonly IOrderRepository _orderRepository;
        private readonly IClientRepository _clientRepository;
        #endregion

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _orderRepository.GetAllOrders();
                return Ok(orders);
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
                var order = _orderRepository.FindById(id);
                if (order == null)
                {
                    return NotFound();
                }
                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderDTO orderDTO)
        {
            try
            {
                var order = new Order(orderDTO);
                _orderRepository.Save(order);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
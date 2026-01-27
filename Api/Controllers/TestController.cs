using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IOperationService _operationService1;
        private readonly IOperationService _operationService2;

        public TestController(IOperationService operationService1, IOperationService operationService2)
        {
            _operationService1 = operationService1;
            _operationService2 = operationService2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Service1 = _operationService1.OperationId,
                Service2 = _operationService2.OperationId
            });
        }
    }
}

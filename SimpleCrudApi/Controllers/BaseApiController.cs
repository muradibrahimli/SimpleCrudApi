using Microsoft.AspNetCore.Mvc;

namespace SimpleCrudApi.Controllers
{
    [Route("/api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {

    }
}
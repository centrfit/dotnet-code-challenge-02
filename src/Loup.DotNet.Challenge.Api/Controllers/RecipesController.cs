using Microsoft.AspNetCore.Mvc;

namespace Loup.DotNet.Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {

        private readonly ILogger<RecipesController> _logger;

        public RecipesController(ILogger<RecipesController> logger)
        {
            _logger = logger;
        }
    }
}
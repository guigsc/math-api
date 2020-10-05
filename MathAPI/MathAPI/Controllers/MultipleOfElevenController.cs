using MathAPI.Model;
using MathAPI.MultipleOf.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MathAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultipleOfElevenController : ControllerBase
    {
        private readonly IMultipleOfEleven multipleOfEleven;

        public MultipleOfElevenController(IMultipleOfEleven multipleOfEleven)
        {
            this.multipleOfEleven = multipleOfEleven;
        }

        [HttpPost]
        public IActionResult Post([FromBody] MultipleOfRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var result = multipleOfEleven.IsMultiple(request.Numbers);

            return Ok(new MultipleOfResponse
            {
                Result = result
            });
        }
    }
}


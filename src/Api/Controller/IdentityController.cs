using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    [Route("identity")]
    [Authorize]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var userClaims = User.Claims.Select(c => new { c.Type, c.Value }).ToList();
            return new JsonResult(userClaims);
        }
    }
}

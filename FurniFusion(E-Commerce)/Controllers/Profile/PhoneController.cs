using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FurniFusion_E_Commerce_.Controllers.Profile
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PhoneController : ControllerBase
    {



    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ID.Server.Controllers;

[Authorize]
public class BaseController : ControllerBase
{
    
}
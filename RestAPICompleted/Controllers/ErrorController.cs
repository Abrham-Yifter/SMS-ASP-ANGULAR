using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPICompleted.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICompleted.Controllers
{
    [Route("errors/{code}")]
    public class ErrorController : BaseApiController
    {
        //public IActionResult Error(int code)
        //{
        //    return new ObjectResult(new ApiResponse(code));
        //}
    }
}

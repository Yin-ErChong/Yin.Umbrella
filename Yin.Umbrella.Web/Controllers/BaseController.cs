using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Yin.Umbrella.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class BaseController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientFactory"></param>
        public BaseController()
        {

        }
    }
}

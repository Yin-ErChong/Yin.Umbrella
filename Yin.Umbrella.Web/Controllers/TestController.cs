using Microsoft.AspNetCore.Mvc;
using SpiderCore.ServiceInterFace;
using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yin.Umbrella.DTO;

namespace Yin.Umbrella.Web.Controllers
{
    /// <summary>
    /// 测试控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private IFirstTestService _firstTestService;
        public TestController(IFirstTestService firstTestService)
        {
            _firstTestService = firstTestService;
        }
        [Route(nameof(GetUser))]
        [HttpGet]
        public async Task<ReturnT<User>> GetUser(Guid guid)
        {
            return await _firstTestService.GetUser(guid);
        }
        [Route(nameof(AddUser))]
        [HttpGet]
        public async Task<ReturnT<User>> AddUser()
        {
            return await _firstTestService.AddUser();
        }
    }
}

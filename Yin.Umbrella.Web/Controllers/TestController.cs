using Microsoft.AspNetCore.Mvc;
using SpiderCore.ServiceInterFace;
using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yin.Umbrella.DTO;
using Microsoft.AspNetCore.Http;
using System.Collections;
using Newtonsoft.Json;
using System.IO;

namespace Yin.Umbrella.Web.Controllers
{
    /// <summary>
    /// 测试控制器
    /// </summary>
    public class TestController : BaseController
    {
        private IFirstTestService _firstTestService;
        //上下文
        private IHttpContextAccessor _accessor;
        public TestController(IFirstTestService firstTestService, IHttpContextAccessor accessor)
        {
            _firstTestService = firstTestService;
            _accessor = accessor;
        }
        [Route(nameof(GetUser))]
        [HttpPost]
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

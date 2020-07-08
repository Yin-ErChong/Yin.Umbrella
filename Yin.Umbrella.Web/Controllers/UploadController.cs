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
    public class UploadController : BaseController
    {
        private IFirstTestService _firstTestService;
        //上下文
        private IHttpContextAccessor _accessor;
        public UploadController(IFirstTestService firstTestService, IHttpContextAccessor accessor)
        {
            _firstTestService = firstTestService;
            _accessor = accessor;
        }
        [Route(nameof(Upload))]
        [HttpPost]
        public string Upload(IFormCollection Files)
        {
            try
            {
                //var form = Request.Form;//直接从表单里面获取文件名不需要参数
                var form = Files;//定义接收类型的参数
                IFormFileCollection cols = Request.Form.Files;
                if (cols == null || cols.Count == 0)
                {
                    return JsonConvert.SerializeObject(new { status = -1, message = "没有上传文件" });
                }
                string filePhysicalPath = "";//存储文件的文件夹
                if (!Directory.Exists(filePhysicalPath)) //判断上传文件夹是否存在，若不存在，则创建
                {
                    Directory.CreateDirectory(filePhysicalPath); //创建文件夹
                }
                foreach (IFormFile file in cols)
                {
                    //定义图片数组后缀格式
                    string[] LimitPictureType = { ".JPG", ".JPEG", ".GIF", ".PNG", ".BMP" };
                    //获取图片后缀是否存在数组中
                    string currentPictureExtension = Path.GetExtension(file.FileName).ToUpper();
                    if (LimitPictureType.Contains(currentPictureExtension))
                    {
                        //为了查看图片就不在重新生成文件名称了
                        var new_path = Path.Combine(filePhysicalPath, file.FileName);
                        using (var stream = new FileStream(new_path, FileMode.Create))
                        {
                            //图片路径保存到数据库里面去
                            bool flage = true;
                            if (flage == true)
                            {
                                //再把文件保存的文件夹中
                                file.CopyTo(stream);
                            }
                        }
                    }
                    else
                    {
                        return JsonConvert.SerializeObject(new { status = -2, message = "请上传指定格式的图片"});
                    }
                }

                return JsonConvert.SerializeObject(new { status = 0, message = "上传成功" });
            }
            catch (Exception ex)
            {

                return JsonConvert.SerializeObject(new { status = -3, message = "上传失败", data = ex.Message });
            }

        }

    }
}

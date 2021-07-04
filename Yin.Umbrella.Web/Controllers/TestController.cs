using Microsoft.AspNetCore.Mvc;
using SpiderCore.ServiceInterFace;
using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yin.Umbrella.DTO;
using Microsoft.AspNetCore.Http;
using Yin.Umbrella.DTO.ApiDTO;
using System.IO;
using System.Data;
using Yin.Umbrella.Util.TableAndExcel;
using Yin.Umbrella.Util.NPDataTableToExcel;
using NPOI.SS.UserModel;
using Yin.Umbrella.DataBase.Entity;

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

        #region User
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
        [Route(nameof(AddUser2))]
        [HttpPost]
        public async Task<ReturnT<User>> AddUser2(User user)
        {
            return await _firstTestService.AddUser2(user);
        }
        [Route(nameof(AddUser3))]
        [HttpPost]
        public async Task<ReturnT<User>> AddUser3(AddUser3DTO user)
        {
            return await _firstTestService.AddUser3(user);
        }
        [Route(nameof(RemoveUser))]
        [HttpGet]
        public async Task<ReturnT<User>> RemoveUser()
        {
            return await _firstTestService.RemoveUser();
        }
        [Route(nameof(UpdateUser))]
        [HttpPost]
        public async Task<ReturnT <User >> UpdateUser(AddUser3DTO user)
        {
            return await _firstTestService.UpdateUser(user);
        }
        #endregion

        #region 图书信息
        [Route(nameof(GetBook))]
        [HttpGet]
        public async Task<ReturnT<Book>> GetBook(Guid guid)
        {
            return await _firstTestService.GetBook(guid);
        }
        [Route(nameof(AddBook))]
        [HttpPost]
        public async Task<ReturnT<Book>> AddBook(Book book)
        {
            return await _firstTestService.AddBook(book);
        }
        [Route(nameof(UpdateBook))]
        [HttpPost]
        public async Task<ReturnT<Book>> UpdateBook(Book book)
        {
            return await _firstTestService.UpdateBook(book);
        }
        [Route(nameof(RemoveBook))]
        [HttpGet]
        public async Task<ReturnT<Book>> RemoveBook()
        {
            return await _firstTestService.RemoveBook();
        }
        #endregion

        #region 用户信息
        [Route(nameof(GetAdmin))]
        [HttpGet]
        public async Task<ReturnT<Admin>> GetAdmin(Guid guid)
        {
            return await _firstTestService.GetAdmin(guid);
        }
        [Route(nameof(AddAdmin))]
        [HttpPost]
        public async Task<ReturnT<Admin>> AddAdmin(Admin admin)
        {
            return await _firstTestService.AddAdmin(admin);
        }
        [Route(nameof(UpdateAdmin))]
        [HttpPost]
        public async Task<ReturnT<Admin>> UpdateAdmin(Admin admin)
        {
            return await _firstTestService.UpdateAdmin(admin);
        }
        [Route(nameof(RemoveAdmin))]
        [HttpGet]
        public async Task<ReturnT<Admin>> RemoveAdmin()
        {
            return await _firstTestService.RemoveAdmin();
        }
        #endregion

        #region 图书类型
        [Route(nameof(GetBookType))]
        [HttpGet]
        public async Task<ReturnT<BookType>> GetBookType(Guid guid)
        {
            return await _firstTestService.GetBookType(guid);
        }
        [Route(nameof(AddBookType))]
        [HttpPost]
        public async Task<ReturnT<BookType>> AddBookType(BookType bookType)
        {
            return await _firstTestService.AddBookType(bookType);
        }
        [Route(nameof(UpdateBookType))]
        [HttpPost]
        public async Task<ReturnT<BookType>> UpdateBookType(BookType bookType)
        {
            return await _firstTestService.UpdateBookType(bookType);
        }
        [Route(nameof(RemoveBookType))]
        [HttpGet]
        public async Task<ReturnT<BookType>> RemoveBookType()
        {
            return await _firstTestService.RemoveBookType();
        }
        #endregion

        #region 历史记录

        [Route(nameof(GetHistory))]
        [HttpGet]
        public async Task<ReturnT<History>> GetHistory(Guid guid)
        {
            return await _firstTestService.GetHistory(guid);
        }
        [Route(nameof(AddHistory))]
        [HttpPost]
        public async Task<ReturnT<History>> AddHistory(History history)
        {
            return await _firstTestService.AddHistory(history);
        }
        #endregion

        #region 借书
        [Route(nameof(BorrowBook))]
        [HttpPost]
        public async Task<ReturnT<History>> BorrowBook(History history)
        {
            return await _firstTestService.BorrowBook(history);
        }
        #endregion

        #region 还书
        [Route(nameof(ReturnBook))]
        [HttpPost]
        public async Task<ReturnT<History>> ReturnBook(History history)
        {
            return await _firstTestService.ReturnBook(history);
        }
        #endregion

        //[Route(nameof(ReadExcelData))]
        //[HttpPost]
        //public void ReadExcelData()
        //{
        //    DataTable dataTable = null;
        //    string filePath = @"C:\Users\Administrator\Desktop\1.xlsx";
        //    dataTable = ExcelToTable.ExcelToDataTable(filePath, true);
        //}


        [Route(nameof(ExcelGetTable))]
        [HttpPost]
        public async Task<ReturnT<NewExcel>> ExcelGetTable(NewExcel newExcel)
        {
            return await _firstTestService.ExcelGetTable(newExcel);
        }

        [Route(nameof(TableGetExcel))]
        [HttpPost]
        public async Task<ReturnBase> TableGetExcel(Book book)
        {
            return await _firstTestService.TableGetExcel(book);
        }



    }
}

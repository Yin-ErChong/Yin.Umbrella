using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yin.Umbrella.DTO;
using Yin.Umbrella.DTO.ApiDTO;

namespace SpiderCore.ServiceInterFace
{
    public interface IFirstTestService
    {
        #region User
        Task<ReturnT<User>> GetUser(Guid id);
         Task<ReturnT<User>> AddUser();
        Task<ReturnT<User>> AddUser2(User user);
        Task<ReturnT<User>> AddUser3(AddUser3DTO user);
        Task<ReturnT<User>> RemoveUser();
        Task<ReturnT<User>> UpdateUser(AddUser3DTO user);
        #endregion 

        #region 图书信息
        Task<ReturnT<Book>> GetBook(Guid id);
        Task<ReturnT<Book>> AddBook(Book book);
        Task<ReturnT<Book>> UpdateBook(Book book);
        Task<ReturnT<Book>> RemoveBook();
        #endregion

        #region 用户信息
        Task<ReturnT<Admin>> GetAdmin(Guid id);
        Task<ReturnT<Admin>> AddAdmin(Admin admin);
        Task<ReturnT<Admin>> UpdateAdmin(Admin admin);
        Task<ReturnT<Admin>> RemoveAdmin();
        #endregion

        #region 图书类型
        Task<ReturnT<BookType>> GetBookType(Guid guid);
        Task<ReturnT<BookType>> AddBookType(BookType bookType);
        Task<ReturnT<BookType>> UpdateBookType(BookType bookType);
        Task<ReturnT<BookType>> RemoveBookType();
        #endregion

        #region 历史记录
        Task<ReturnT<History>> GetHistory(Guid guid);
        Task<ReturnT<History>> AddHistory(History history);
        #endregion

        Task<ReturnT<History>> BorrowBook(History history);
        Task<ReturnT<History>> ReturnBook(History history);

    }
}

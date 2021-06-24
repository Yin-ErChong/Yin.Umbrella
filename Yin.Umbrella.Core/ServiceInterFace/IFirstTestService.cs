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
         Task<ReturnT<User>> GetUser(Guid id);
         Task<ReturnT<User>> AddUser();
        Task<ReturnT<User>> AddUser2(User user);
        Task<ReturnT<User>> AddUser3(AddUser3DTO user);
        Task<ReturnT<User>> RemoveUser();
        Task<ReturnT<User>> UpdateUser(AddUser3DTO user);




        Task<ReturnT<Book>> GetBook(Guid id);
        Task<ReturnT<Book>> AddBook(Book book);
        Task<ReturnT<Book>> UpdateBook(Book book);
        Task<ReturnT<Book>> RemoveBook();




        Task<ReturnT<Admin>> GetAdmin(Guid id);
        Task<ReturnT<Admin>> AddAdmin(Admin admin);
        Task<ReturnT<Admin>> UpdateAdmin(Admin admin);
        Task<ReturnT<Admin>> RemoveAdmin();




        Task<ReturnT<BookType>> GetBookType(Guid guid);
        Task<ReturnT<BookType>> AddBookType(BookType bookType);
        Task<ReturnT<BookType>> UpdateBookType(BookType bookType);
        Task<ReturnT<BookType>> RemoveBookType();




        Task<ReturnT<History>> GetHistory(Guid guid);
        Task<ReturnT<History>> AddHistory(History cookie);
    }
}

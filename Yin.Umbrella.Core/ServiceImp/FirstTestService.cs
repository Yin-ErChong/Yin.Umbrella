using Microsoft.EntityFrameworkCore;
using Snai.Mysql.DataAccess.Base;
using SpiderCore.ServiceInterFace;
using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yin.Umbrella.DTO;
using Yin.Umbrella.DTO.ApiDTO;

namespace SpiderCore.ServiceImp
{
    public class FirstTestService : IFirstTestService
    {
        private DataAccess _dataAccess;
        public FirstTestService(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<ReturnT<User>> GetUser(Guid id)
        {
            try
            {
                var userDB = await _dataAccess.User.Where(n => n.Id == id).FirstOrDefaultAsync();//await _dataAccess.User.Where(n => n.Id == id).FirstOrDefaultAsync();
                _dataAccess.User.Update(userDB);
                await _dataAccess.SaveChangesAsync();
                //_dataAccess.Database.Log=
                return ReturnT<User>.Instance.Success(userDB);
            }
            catch (Exception ee)
            {
                return ReturnT<User>.Instance.Error();
            }
        }
        public async Task<ReturnT<User>> AddUser()
        {
            try
            {
                User user = new User();
                user.SetDefault();
                _dataAccess.User.Add(user);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<User>.Instance.Success(user);
            }
            catch (Exception ee)
            {
                return ReturnT<User>.Instance.Error();
            }
        }
        public async Task<ReturnT<User>> AddUser2(User user)
        {
            try
            {
                //user.SetDefault();

                user.Name = "1";//修改
                _dataAccess.User.Add(user);//添加
                await _dataAccess.SaveChangesAsync();//保存
                return ReturnT<User>.Instance.Success(user);//返回
            }
            catch (Exception ee)
            {
                return ReturnT<User>.Instance.Error();
            }
        }
        public async Task<ReturnT<User>> AddUser3(AddUser3DTO user)
        {
            try
            {
                User user1 = new User();
                user1.Name = user.Name;
                user1.PassWord = user.PassWord;
                user1.Gender = user.Gender;
                user1.Email = user.Email;
                user1.Province = user.Province;
                user1.City = user.City;
                user1.Birthday = user.Birthday;
                user1.Type = user.Type;
                user1.ClassId = user.ClassId;
                _dataAccess.User.Add(user1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<User>.Instance.Success(user1);
            }
            catch (Exception ee)
            {
                return ReturnT<User>.Instance.Error();
            }
        }
        public async Task<ReturnT<User>> RemoveUser()
        {
            try
            {
                User user1 = _dataAccess.User.Where(n => n.Id == Guid.Parse("08d930af-639a-4c14-895b-3506dbed5a22")).FirstOrDefault();//select * from User where Id="3fa85f64-5717-4562-b3fc-2c963f66afa6"
                _dataAccess.User.Remove(user1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<User>.Instance.Success(user1);
            }
            catch (Exception ee)
            {
                return ReturnT<User>.Instance.Error();
            }
        }
        public async Task<ReturnT<User>> UpdateUser(AddUser3DTO user)
        {
            try
            {
                User user1 = _dataAccess.User.Where(n => n.Id == Guid.Parse("08d9360e-26bc-45c9-8e98-c3b627dd6822")).FirstOrDefault();
                user1.Name = user.Name;
                user1.PassWord = user.PassWord;
                user1.Gender = user.Gender;
                user1.Email = user.Email;
                user1.Province = user.Province;
                user1.City = user.City;
                user1.Birthday = user.Birthday;
                user1.Type = user.Type;
                user1.ClassId = user.ClassId;
                _dataAccess.User.Update(user1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<User>.Instance.Success(user1);
            }
            catch (Exception ee)
            {
                return ReturnT<User>.Instance.Error();
            }
        }





        public async Task<ReturnT<Book>> GetBook(Guid id)
        {
            try
            {
                var bookDB = await _dataAccess.Book.Where(n => n.Id == id).FirstOrDefaultAsync();
                _dataAccess.Book.Update(bookDB);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Book>.Instance.Success(bookDB);
            }
            catch (Exception ee)
            {
                return ReturnT<Book>.Instance.Error();
            }
        }
        public async Task<ReturnT<Book>> AddBook(Book book)
        {
            try
            {
                Book book1 = new Book();
                book1.Id = book.Id;
                book1.Name = book.Name;
                book1.Card = book.Card;
                book1.Autho = book.Autho;
                book1.Num = book.Num;
                book1.Press = book.Press;
                book1.Type = book.Type;
                _dataAccess.Book.Add(book1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Book>.Instance.Success(book1);
            }
            catch (Exception ee)
            {
                return ReturnT<Book>.Instance.Error();
            }
        }
        public async Task<ReturnT<Book>> UpdateBook(Book book)
        {
            try
            {
                Book book1 = _dataAccess.Book.Where(n => n.Id == Guid.Parse("3fa85f64-5717-4562-b3fc-2c111f11afa1")).FirstOrDefault();
                book1.Name = book.Name;
                book1.Card = book.Card;
                book1.Autho = book.Autho;
                book1.Num = book.Num;
                book1.Press = book.Press;
                book1.Type = book.Type;
                _dataAccess.Book.Update(book1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Book>.Instance.Success(book1);
            }
            catch (Exception ee)
            {
                return ReturnT<Book>.Instance.Error();
            }
        }
        public async Task<ReturnT<Book>> RemoveBook()
        {
            try
            {
                Book book1 = _dataAccess.Book.Where(n => n.Id == Guid.Parse("3fa85f64-5717-4562-b3fc-2c111f11afa1")).FirstOrDefault();
                _dataAccess.Book.Remove(book1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Book>.Instance.Success(book1);
            }
            catch (Exception ee)
            {
                return ReturnT<Book>.Instance.Error();
            }
        }






        public async Task<ReturnT<Admin>> GetAdmin(Guid id)
        {
            try
            {
                var adminDB = await _dataAccess.Admin.Where(n => n.Id == id).FirstOrDefaultAsync();
                _dataAccess.Admin.Update(adminDB);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Admin>.Instance.Success(adminDB);
            }
            catch (Exception ee)
            {
                return ReturnT<Admin>.Instance.Error();
            }
        }
        public async Task<ReturnT<Admin>> AddAdmin(Admin admin)
        {
            try
            {
                Admin admin1 = new Admin();
                admin1.Id = admin.Id;
                admin1.UserName = admin.UserName;
                admin1.Name = admin.Name;
                admin1.Password = admin.Password;
                admin1.Email = admin.Email;
                admin1.Phone = admin.Phone;
                admin1.Status = admin.Status;
                admin1.LendNum = admin.LendNum;
                admin1.MaxNum = admin.MaxNum;
                _dataAccess.Admin.Add(admin1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Admin>.Instance.Success(admin1);
            }
            catch (Exception ee)
            {
                return ReturnT<Admin>.Instance.Error();
            }
        }
        public async Task<ReturnT<Admin>> UpdateAdmin(Admin admin)
        {
            try
            {
                Admin admin1 = _dataAccess.Admin.Where(n => n.Id == Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f88afa6")).FirstOrDefault();
                admin1.UserName = admin.UserName;
                admin1.Name = admin.Name;
                admin1.Password = admin.Password;
                admin1.Email = admin.Email;
                admin1.Phone = admin.Phone;
                admin1.Status = admin.Status;
                admin1.LendNum = admin.LendNum;
                admin1.MaxNum = admin.MaxNum;
                _dataAccess.Admin.Update(admin1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Admin>.Instance.Success(admin1);
            }
            catch (Exception ee)
            {
                return ReturnT<Admin>.Instance.Error();
            }
        }
        public async Task<ReturnT<Admin>> RemoveAdmin()
        {
            try
            {
                Admin admin1 = _dataAccess.Admin.Where(n => n.Id == Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f88afa6")).FirstOrDefault();
                _dataAccess.Admin.Remove(admin1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<Admin>.Instance.Success(admin1);
            }
            catch (Exception ee)
            {
                return ReturnT<Admin>.Instance.Error();
            }
        }





        public async Task<ReturnT<BookType>> GetBookType(Guid guid)
        {
            try
            {
                var bookTypeDB = await _dataAccess.BookType.Where(n => n.Id == guid).FirstOrDefaultAsync();
                _dataAccess.BookType.Update(bookTypeDB);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<BookType>.Instance.Success(bookTypeDB);
            }
            catch (Exception ee)
            {
                return ReturnT<BookType>.Instance.Error();
            }
        }
        public async Task<ReturnT<BookType>> AddBookType(BookType bookType)
        {
            try
            {
                BookType bookType1 = new BookType();
                bookType1.Id = bookType.Id;
                bookType1.Name = bookType.Name;
                _dataAccess.BookType.Add(bookType1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<BookType>.Instance.Success(bookType1);
            }
            catch (Exception ee)
            {
                return ReturnT<BookType>.Instance.Error();
            }
        }
        public async Task<ReturnT<BookType>> UpdateBookType(BookType bookType)
        {
            try
            {
                BookType bookType1 = _dataAccess.BookType.Where(n => n.Id == Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f99afa6")).FirstOrDefault();
                bookType1.Name = bookType.Name;
                _dataAccess.BookType.Update(bookType1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<BookType>.Instance.Success(bookType1);
            }
            catch (Exception ee)
            {
                return ReturnT<BookType>.Instance.Error();
            }
        }
        public async Task<ReturnT<BookType>> RemoveBookType()
        {
            try
            {
                BookType bookType1 = _dataAccess.BookType.Where(n => n.Id == Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f99afa6")).FirstOrDefault();
                _dataAccess.BookType.Remove(bookType1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<BookType>.Instance.Success(bookType1);
            }
            catch (Exception ee)
            {
                return ReturnT<BookType>.Instance.Error();
            }
        }





        public async Task<ReturnT<History>> GetHistory(Guid guid)
        {
            try
            {
                var cookieDB = await _dataAccess.History.Where(n => n.Id == guid).FirstOrDefaultAsync();
                _dataAccess.History.Update(cookieDB);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<History>.Instance.Success(cookieDB);
            }
            catch (Exception ee)
            {
                return ReturnT<History>.Instance.Error();
            }
        }
        public async Task<ReturnT<History>> AddHistory(History cookie)
        {
            try
            {
                History cookie1 = new History();
                cookie1.Id = cookie.Id;
                cookie1.AId = cookie.AId;
                cookie1.BId = cookie.BId;
                cookie1.Card = cookie.Card;
                cookie1.BookName = cookie.BookName;
                cookie1.AdminName = cookie.AdminName; 
                cookie1.UserName = cookie.UserName;
                cookie1.BeginTime = cookie.BeginTime;
                cookie1.Endtime = cookie.Endtime;
                cookie1.Status = cookie.Status;
                _dataAccess.History.Add(cookie1);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<History>.Instance.Success(cookie1);
            }
            catch (Exception ee)
            {
                return ReturnT<History>.Instance.Error();
            }
        }
    }
}

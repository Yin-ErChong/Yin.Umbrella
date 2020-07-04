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
                User user = new User();
                user.SetDefault();
                _dataAccess.User.Add(user);
                await _dataAccess.SaveChangesAsync();
                return ReturnT<User>.Instance.Success(user);
                //var userDB = await _dataAccess.User.Where(n => n.Id == id).FirstOrDefaultAsync();//await _dataAccess.User.Where(n => n.Id == id).FirstOrDefaultAsync();
                //_dataAccess.User.Update(userDB);
                //await _dataAccess.SaveChangesAsync();
                //return ReturnT<User>.Instance.Success(userDB);
            }
            catch (Exception ee)
            {
                return ReturnT<User>.Instance.Error();
            }
        }
    }
}

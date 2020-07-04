using Microsoft.EntityFrameworkCore;
using Snai.Mysql.DataAccess.Base;
using SpiderCore.ServiceInterFace;
using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderCore.ServiceImp
{
    public class FirstTestService : IFirstTestService
    {
        private DataAccess _dataAccess;
        public FirstTestService(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<User> GetUser(Guid id)
        {
            try
            {
                var li = await _dataAccess.User.ToListAsync();
                var userDB = await _dataAccess.User.Where(n=>n.Id==id).FirstOrDefaultAsync();//await _dataAccess.User.Where(n => n.Id == id).FirstOrDefaultAsync();
                 _dataAccess.User.Update(userDB);
                await _dataAccess.SaveChangesAsync();
                return userDB;
            }
            catch (Exception ee)
            {

                return new User();
            }
        }
    }
}

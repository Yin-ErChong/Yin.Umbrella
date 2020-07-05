using SpiderDataBase.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yin.Umbrella.DTO;

namespace SpiderCore.ServiceInterFace
{
    public interface IFirstTestService
    {
         Task<ReturnT<User>> GetUser(Guid id);
        Task<ReturnT<User>> AddUser();

    }
}

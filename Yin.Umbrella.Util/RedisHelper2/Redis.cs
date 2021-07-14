using Newtonsoft.Json;
using ServiceStack.Redis;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yin.Umbrella.Util.RedisHelper2
{
    public class Redis
    {
        //private static readonly PooledRedisClientManager pool = null; 
        //private static readonly string[] redisHosts = null; 
        //public static int RedisMaxReadPool = 3; 
        //public static int RedisMaxWritePool = 1;

        //static Redis()
        //{
        //    var redisHostStr = "127.0.0.1:6379";

        //    if (!string.IsNullOrEmpty(redisHostStr))
        //    {
        //        redisHosts = redisHostStr.Split(','); 

        //        if (redisHosts.Length > 0)
        //        {
        //            pool = new PooledRedisClientManager(redisHosts, redisHosts, new RedisClientManagerConfig()
        //            {
        //                MaxWritePoolSize = RedisMaxWritePool,
        //                MaxReadPoolSize = RedisMaxReadPool,
        //                AutoStart = true
        //            });
        //        }
        //    }
        //}






        /// <summary>
        /// 连接字符串，一般写在配置文件里面
        /// </summary>
        private static readonly string ConnectionString = "127.0.0.1:6379,password=123456,connectTimeout=1000,connectRetry=1,syncTimeout=10000";
        /// <summary>
        /// 上锁，单例模式
        /// </summary>
        private static object locker = new object();
        /// <summary>
        /// 连接对象
        /// </summary>
        private volatile IConnectionMultiplexer _connection;
        /// <summary>
        /// 数据库
        /// </summary>
        private IDatabase _db;
        #region 创建Redis实例
        public Redis()
        {
            _connection = ConnectionMultiplexer.Connect(ConnectionString);
            _db = GetDatabase();
        }


        private static Redis redisHelper;

        public static Redis GetRedisHelper()
        {

            if (redisHelper == null)
            {
                lock (locker)
                {
                    if (redisHelper == null)
                    {
                        redisHelper = new Redis();
                    }
                }
            }
            return redisHelper;
        }
        #endregion


        /// <summary>
        /// 获取连接
        /// </summary>
        /// <returns></returns>
        protected IConnectionMultiplexer GetConnection()
        {
            if (_connection != null && _connection.IsConnected)
            {
                return _connection;
            }
            lock (locker)
            {
                if (_connection != null && _connection.IsConnected)
                {
                    return _connection;
                }

                if (_connection != null)
                {
                    _connection.Dispose();
                }
                _connection = ConnectionMultiplexer.Connect(ConnectionString);
            }

            return _connection;
        }
        /// <summary>
        /// 获取数据库
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public IDatabase GetDatabase(int? db = null)
        {
            return GetConnection().GetDatabase(db ?? -1);
        }
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="data">值</param>
        /// <param name="cacheTime">过期时间</param>
        public virtual void Set(string key, object data, int? cacheTime = null)
        {
            if (data == null)
            {
                return;
            }
            var entryBytes = Serialize(data);
            if (cacheTime != null)
            {
                var expiresIn = TimeSpan.FromMinutes(Convert.ToDouble(cacheTime));
                _db.StringSet(key, entryBytes, expiresIn);
            }
            else
            {
                _db.StringSet(key, entryBytes);
            }

        }

        /// <summary>
        /// 根据键获取值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual T Get<T>(string key)
        {
            var rValue = _db.StringGet(key);
            if (!rValue.HasValue)
            {
                return default(T);
            }

            var result = Deserialize<T>(rValue);

            return result;
        }

        /// <summary>
        /// 判断键是否已存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool IsExit(string key)
        {
            return _db.KeyExists(key);
        }

        /// <summary>
        /// 判断是否已经设置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual bool IsSet(string key)
        {
            return _db.KeyExists(key);
        }
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="data"></param>
        /// <returns>byte[]</returns>
        private byte[] Serialize(object data)
        {
            var json = JsonConvert.SerializeObject(data);
            return Encoding.UTF8.GetBytes(json);
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedObject"></param>
        /// <returns></returns>
        protected virtual T Deserialize<T>(byte[] serializedObject)
        {
            if (serializedObject == null)
            {
                return default(T);
            }
            var json = Encoding.UTF8.GetString(serializedObject);
            return JsonConvert.DeserializeObject<T>(json);
        }




    }
}

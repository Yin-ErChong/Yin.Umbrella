using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yin.Umbrella.Util
{
    /// <summary>
    /// 定时更新缓存管理器（只会在取缓存时更新）
    /// </summary>
    public class CacheManager
    {
        public static Dictionary<string, DataBaseModel> CacheObjectData = new Dictionary<string, DataBaseModel>();
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="timeSpan">多久更新一次</param>
        /// <param name="cacheName">缓存名称</param>
        /// <param name="function">更新缓存的方法</param>
        /// <param name="args">更新缓存的方法参数</param>
        public static bool Set<T>(TimeSpan timeSpan, string cacheName, Func<Args, T> function, Args args)
        {
            if (CacheObjectData.ContainsKey(cacheName))
            {
                return Updata(timeSpan, cacheName, function,args);
            }
            else
            {
                DataObjectModel<T> dataStringModel = new DataObjectModel<T>();
                dataStringModel.DataObject = function.Invoke(args);
                dataStringModel.LastRequestTime = DateTime.Now;
                dataStringModel.TimeSpan = timeSpan;
                dataStringModel.Function = function;
                dataStringModel.args = args;
                CacheObjectData.Add(cacheName, dataStringModel);
                return true;
            }
        }
        /// <summary>
        /// 更新缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="timeSpan"></param>
        /// <param name="cacheName"></param>
        /// <param name="function"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private static bool Updata<T>(TimeSpan timeSpan, string cacheName, Func<Args, T> function, Args args)
        {
            DataObjectModel<T> dataStringModel = new DataObjectModel<T>();
            dataStringModel.DataObject = function.Invoke(args);
            dataStringModel.LastRequestTime = DateTime.Now;
            dataStringModel.TimeSpan = timeSpan;
            dataStringModel.Function = function;
            dataStringModel.args = args;
            CacheObjectData[cacheName] = dataStringModel;
            return true;
        }
        /// <summary>
        /// 获取缓存的值
        /// </summary>
        /// <param name="cacheName"></param>
        /// <returns></returns>
        public static T Get<T>(string cacheName)
        {
            if (CacheObjectData.ContainsKey(cacheName))
            {
                DataObjectModel<T> model =(DataObjectModel<T>) CacheObjectData[cacheName];
                if (DateTime.Now > model.LastRequestTime.Add(model.TimeSpan))
                {
                    lock (model.DataObject)
                    {
                        if (DateTime.Now > model.LastRequestTime.Add(model.TimeSpan))
                        {
                            model.DataObject = model.Function.Invoke(model.args);
                        }
                        else
                        {
                            return model.DataObject;
                        }

                    }
                    return model.DataObject;
                }
                else
                {
                    return model.DataObject;
                }
            }
            else
            {
                throw new Exception("缓存管理器中不包含该缓存");
            }
        }

    }
    public class DataBaseModel
    {
        /// <summary>
        /// 上次请求时间
        /// </summary>
        public DateTime LastRequestTime;
        /// <summary>
        /// 间隔多久缓存失效
        /// </summary>
        public TimeSpan TimeSpan;
        /// <summary>
        /// 入参
        /// </summary>
        public Args args;
    }
    public class DataObjectModel<T>: DataBaseModel
    {
        public T DataObject;
        /// <summary>
        /// 缓存失效后执行的方法
        /// </summary>
        public Func<Args, T> Function;
    }
    public class Args
    {
        public int TenantId;
    }
}

using System;

namespace Yin.Umbrella.DTO
{
    public class ReturnBase
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
    }
    public class ReturnT<T> : ReturnBase
    {
        /// <summary>
        /// 数据载体
        /// </summary>
        public T Data { get; set; }

    }
    public static class ReturnExtension
    {
        public static ReturnBase Success(this ReturnBase returnBase)
        {
            returnBase.Code = (int)ErrorEnum.成功;
            returnBase.IsSuccess = true;
            returnBase.Message = ErrorEnum.成功.ToString();
            return returnBase;
        }
        public static ReturnBase Error(this ReturnBase returnBase, ErrorEnum errorEnum)
        {
            returnBase.Code = (int)errorEnum;
            returnBase.IsSuccess = false;
            returnBase.Message = errorEnum.ToString();
            return returnBase;
        }
        public static ReturnBase Success<T>(this ReturnT<T> returnT,T data)
        {
            returnT.Success();
            returnT.Data = data;
            return returnT;
        }

    }

}

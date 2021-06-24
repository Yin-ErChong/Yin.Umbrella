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

        public static ReturnBase Instance { get { return new ReturnBase();} }

    }
    public class ReturnT<T> : ReturnBase
    {
        /// <summary>
        /// 数据载体
        /// </summary>
        public T Data { get; set; }

        public static new ReturnT<T> Instance { get { return new ReturnT<T>(); }}

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
        public static ReturnT<T> Error<T>(this ReturnT<T> returnT, ErrorEnum errorEnum, string msg)
        {
            returnT.Code = (int)ErrorEnum.未知错误;
            returnT.IsSuccess = false;
            returnT.Message = msg;
            return returnT;
        }
        public static ReturnBase Error(this ReturnBase returnBase)
        {
            returnBase.Code = (int)ErrorEnum.未知错误;
            returnBase.IsSuccess = false;
            returnBase.Message = ErrorEnum.未知错误.ToString();
            return returnBase;
        }
        public static ReturnT<T> Error<T>(this ReturnT<T> returnT)
        {
            returnT.Code = (int)ErrorEnum.未知错误;
            returnT.IsSuccess = false;
            returnT.Message = ErrorEnum.未知错误.ToString();
            return returnT;
        }
        public static ReturnT<T> Success<T>(this ReturnT<T> returnT,T data)
        {
            returnT.Success();
            returnT.Data = data;
            return returnT;
        }

    }

}

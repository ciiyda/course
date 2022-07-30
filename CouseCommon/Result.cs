using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouseCommon
{
    public class Result<T> : IResult
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }

        public T Data { get; set; }

        public int Totalcount { get; set; }

        public Result(bool isSuccses, string message): this(isSuccses, message,default(T))
        {

        }

        public Result(bool isSuccses, string message, T data) : this(isSuccses, message, data, 0)
        {

        }

        public Result(bool isSuccses, string message, T data, int totalcount) 
        {
            IsSucces = isSuccses;
            Message = message;
            Data = data;
            Totalcount = totalcount;
        }
    }
}

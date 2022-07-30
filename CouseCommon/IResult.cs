using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouseCommon
{
   public interface IResult
    {
        bool IsSucces { get; set; }

        string Message { get; set; }
    }
}

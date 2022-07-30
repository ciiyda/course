using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime runtime, string message)
        {
            await runtime.InvokeVoidAsync("DisplayToastr", "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime runtime, string message)
        {
            await runtime.InvokeVoidAsync("DisplayToastr", "error", message);
        }
    }
}

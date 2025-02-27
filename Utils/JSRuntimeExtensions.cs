﻿using Microsoft.JSInterop;

namespace Session4.Utils
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string message)
        {
            return JSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static ValueTask ToastrError(this IJSRuntime JSRuntime, string message)
        {
            return JSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}

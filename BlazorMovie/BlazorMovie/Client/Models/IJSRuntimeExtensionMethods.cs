using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Client.Models
{
    public static class IJSRuntimeExtensionMethods
    {
        //Se utiliza InvokeAsync para retornar algo
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask Log(this IJSRuntime js)
        {
            await js.InvokeVoidAsync("console.log", "prueba de console log");
        }
    }
}

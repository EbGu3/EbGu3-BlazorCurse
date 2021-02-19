using BlazorMovie.Client.Servicio;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Client.Pages
{
    public class CounterBase : ComponentBase
    {
        [Inject]
        protected ServiceSingleton singleton { get; set; }

        [Inject]
        protected ServiceTransient transient { get; set; }

        [Inject]
        protected IJSRuntime JS { get; set; }

        protected int currentCount = 0;

        static int currentCountStatic = 0;
        protected async Task IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        [JSInvokable]
        public static Task<int> GetCourrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}

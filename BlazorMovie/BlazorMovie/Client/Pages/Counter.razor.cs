using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMovie.Client.Shared.MainLayout;

namespace BlazorMovie.Client.Pages
{
    public class CounterBase : ComponentBase
    {

        [Inject]
        protected IJSRuntime JS { get; set; }
        
        //Guardar la referencia de Counter.js
        IJSObjectReference modulo;

        protected int currentCount = 0;

        static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
           //hasta este momento se descargara el archivo Counter.js
            modulo = await JS.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await modulo.InvokeVoidAsync("ViewAlert", "Hola mundo");
            currentCount++;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        
        protected async Task IncrementCountJavaScript()
        {
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia", 
                DotNetObjectReference.Create(this)
                );
        }

        [JSInvokable]
        public static Task<int> GetCourrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}

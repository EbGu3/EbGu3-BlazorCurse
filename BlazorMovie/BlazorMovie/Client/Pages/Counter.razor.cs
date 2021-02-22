using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMovie.Client.Shared.MainLayout;
using MathNet.Numerics.Statistics;

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
            var array = new double[] { 1, 2, 3, 4, 5 };
            var max = array.Max();
            var min = array.Min();
            
           //hasta este momento se descargara el archivo Counter.js
            modulo = await JS.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await modulo.InvokeVoidAsync("ViewAlert", $"El max es {max} y  el min es {min}");  
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

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovie.Client.Servicio;

namespace BlazorMovie.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        ServiceSingleton singleton { get; set; }

        [Inject]
        ServiceTransient transient { get; set; }

        private int currentCount = 0;
        private void IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}

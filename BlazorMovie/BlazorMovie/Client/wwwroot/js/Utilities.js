﻿function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorMovie.Client", "GetCourrentCount")
        .then(resultado => {
            console.log("conteo desde javascript " + resultado);
        });
}

function pruebaPuntoNetInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}
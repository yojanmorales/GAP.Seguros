# GAP.Seguros
Carga inicial con modelo entity


URL Sitio Azure: https://gapsergurosweb.azurewebsites.net


Implementación:

* CodeFirst
* WebApi 2
* MVC con AngularjS
* Unit Test con Mock

Puntos a tener en cuenta:

- Se realiza implementación login pero solo funciona en la api, se decició cambiar a un filteraction pero no quedan funcionales, se envia en el header de la petición al servicio el parametro de usuario (valor estático) el cual no realiza validación contra BD. 




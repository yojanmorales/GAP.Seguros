"use strict";
(function () {

    angular.module("SegurosApp").factory("baseSvc", ["$http", "$q", function ($http, $q) {
        var urlapi = "http://localhost:51932/";
        var getRequest = function (query) {
            var deferred = $.Deferred();



            // Simple GET request example:
            $http({
                method: 'GET',
                url: urlapi + query,
                headers: {
                    "Accept": "application/json; odata=verbose",
                    "User": "UsuarioLogueado"
                }


            }).then(function successCallback(response) {
                deferred.resolve(response);
            }, function errorCallback(response) {
                deferred.reject(response);
            });
            return deferred;
        };



        var postLogin = function (data, url) {
            var deferred = $.Deferred();


            $http({
                method: 'POST',
                url: urlapi + url,

                data: $.param({ Email: data.Email, Password: data.Password }),

                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded'
                }


            }).then(function successCallback(response) {
                deferred.resolve(response);
            }, function errorCallback(response) {
                deferred.reject(response);
            });
            return deferred;
        };


        var postPoliza = function (data, url) {
            var deferred = $.Deferred();


            $http({
                method: 'POST',
                url: urlapi + url,

                data: $.param({
                    Nombre: data.Nombre,
                    Descripcion: data.Descripcion,
                    TipoCubrimientoId: data.TipoCubrimientoId,
                    Cobertura: data.Cobertura,
                    Vigencia: data.Vigencia,
                    Periodo: data.Periodo,
                    Precio: data.Precio,
                    Riesgo: data.Riesgo,
                    ClienteId: data.ClienteId,
                    Estado: 1,
                    Id: 0


                }),

                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded'
                }


            }).then(function successCallback(response) {
                deferred.resolve(response);
            }, function errorCallback(response) {
                deferred.resolve(response);
            });
            return deferred;
        };

        var postPolizaCancelar = function (data, url) {
            var deferred = $.Deferred();


            $http({
                method: 'POST',
                url: urlapi + url,

                data: $.param({
                    Nombre: data.nombre,
                    Descripcion: data.descripcion,
                    TipoCubrimientoId: data.tipoCubrimientoId,
                    Cobertura: data.cobertura,
                    Vigencia: data.vigencia,
                    Periodo: data.periodo,
                    Precio: data.precio,
                    Riesgo: data.riesgo,
                    ClienteId: data.clienteId,
                    Estado: 2,
                    Id: data.id


                }),

                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded'
                }


            }).then(function successCallback(response) {
                deferred.resolve(response);
            }, function errorCallback(response) {
                deferred.reject(response);
            });
            return deferred;
        };


        var updateRequest = function (data, url) {
            var deferred = $.Deferred();
            $http({
                url: url,
                method: "PATCH",
                headers: {
                    "accept": "application/json;odata=verbose",
                    "X-RequestDigest": document.getElementById("__REQUESTDIGEST").value,
                    "content-Type": "application/json;odata=verbose",
                    "X-Http-Method": "PATCH",
                    "If-Match": "*"
                },
                data: JSON.stringify(data)
            }).then(function successCallback(response) {
                deferred.resolve(response);
            }, function errorCallback(response) {
                deferred.reject(response);
            });
            return deferred;
        };
        var deleteRequest = function (url) {
            var deferred = $.Deferred();
            $http({
                url: baseUrl + url,
                method: "DELETE",
                headers: {
                    "accept": "application/json;odata=verbose",
                    "X-RequestDigest": document.getElementById("__REQUESTDIGEST").value,
                    "IF-MATCH": "*"
                }
            })
                .then(function successCallback(response) {
                    deferred.resolve(response);
                }, function errorCallback(response) {
                    deferred.reject(response);
                });
        };
        return {
            getRequest: getRequest,
            postLogin: postLogin,
            postPoliza: postPoliza,
            updateRequest: updateRequest,
            deleteRequest: deleteRequest,
            postPolizaCancelar: postPolizaCancelar

        };
    }]);
})();
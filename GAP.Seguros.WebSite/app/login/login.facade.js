"use strict";
(function () {

    angular.module("SegurosApp").factory("loginServices", ["baseSvc", function (baseService) {




        var Login = function (usuario) {
            var query = "/Autenticacion/Login";
            return baseService.postLogin(usuario, query);
        };



        return {
            Login: Login
        };
    }]);
})();
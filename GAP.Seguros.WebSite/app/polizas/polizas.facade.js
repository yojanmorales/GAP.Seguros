"use strict";
(function () {

    angular.module("SegurosApp").factory("polizasServices", ["baseSvc", function (baseService) {



        var obtenerTipoCubrimientos = function () {
            var query = "/api/TipoCubrimientos";
            return baseService.getRequest(query);
        };
        var obtenerClientes = function () {
            var query = "/api/Clientes";
            return baseService.getRequest(query);
        };
        var ObtenerPolizasPorCliente = function (clienteId) {
            var query = "/api/Polizas?clienteId=" + clienteId;
            return baseService.getRequest(query);
        };



        var guardarPoliza = function (data) {
            var query = "/api/Polizas/GuardarPoliza";
            return baseService.postPoliza(data, query);

        }



        return {
            obtenerClientes: obtenerClientes,
            obtenerTipoCubrimientos: obtenerTipoCubrimientos,
            obtenerTipoCubrimientos: obtenerTipoCubrimientos,
            guardarPoliza: guardarPoliza,
            ObtenerPolizasPorCliente: ObtenerPolizasPorCliente
        };
    }]);
})();
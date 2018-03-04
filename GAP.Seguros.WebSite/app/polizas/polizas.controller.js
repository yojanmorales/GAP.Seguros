"use strict";
(function () {


    angular.module("SegurosApp").controller("polizasController", ["$scope", "polizasServices", "$http", "$q",
        function ($scope, polizasServices, $http, $q) {

            $scope.poliza = {
                Riesgo: ''
            };
            $scope.ClienteSeleccionado = "";


            polizasServices.obtenerClientes().done(function (response) {
                $scope.clientesCollection = response.data;

            });
            polizasServices.obtenerTipoCubrimientos().done(function (response) {
                $scope.tipoCubrimientosCollection = response.data;

            });
            $scope.GuardarPoliza = function () {

                var fechapoliza = new Date($scope.poliza.Vigencia);
                var dd = fechapoliza.getDate();
                var mm = fechapoliza.getMonth() + 1; //January is 0!

                var yyyy = fechapoliza.getFullYear();
                if (dd < 10) {
                    dd = '0' + dd;
                }
                if (mm < 10) {
                    mm = '0' + mm;
                }

                $scope.poliza.Vigencia = dd + '/' + mm + '/' + yyyy;
                polizasServices.guardarPoliza($scope.poliza).done(function (response) {
                    $scope.poliza = {
                        Riesgo: ''
                    };

                });
            };

            $scope.ObtenerPolizasPorCliente = function () {
                polizasServices.ObtenerPolizasPorCliente($scope.ClienteSeleccionado).done(function (response) {
                    $scope.PolizasCliente = response.data;

                });
            }


        }
    ]);
})();




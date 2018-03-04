"use strict";
(function () {


    angular.module("SegurosApp").controller("polizasController", ["$scope", "polizasServices", "$http", "$q", "$rootScope", "$location",
        function ($scope, polizasServices, $http, $q, $rootScope, $location) {






            $scope.poliza = {
                Riesgo: ''
            };
            $scope.ClienteSeleccionado = "";
            $scope.success = false;
            $scope.cargando = false;
            $scope.mensajeError = "";
            $scope.ContieneError = false;
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
                    if (response.status == 200) {
                        $scope.poliza = {
                            Riesgo: ''
                        };
                        $scope.success = true;
                        $scope.ContieneError = false;
                    } else {
                        $scope.mensajeError = response.data.message;
                        $scope.ContieneError = true;
                        $scope.success = false;
                    }


                });


            };

            $scope.ObtenerPolizasPorCliente = function () {
                $scope.success = false;
                $scope.cargando = true;
                polizasServices.ObtenerPolizasPorCliente($scope.ClienteSeleccionado).done(function (response) {
                    $scope.PolizasCliente = response.data;
                    $scope.cargando = false;

                });
            }

            $scope.CancelarPoliza = function (poliza) {
                $scope.cargando = true;
                polizasServices.CancelarPoliza(poliza).done(function (response) {
                    $scope.ObtenerPolizasPorCliente();
                });
            }


        }
    ]);
})();




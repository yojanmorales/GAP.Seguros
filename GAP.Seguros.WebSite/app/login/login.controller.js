"use strict";
(function () {


    angular.module("SegurosApp").controller("loginController", ["$scope", "loginServices", "$http", "$q", "$rootScope", "$location",
        function ($scope, loginServices, $http, $q, $rootScope, $location) {

            $scope.usuario = {};
            $scope.Ingresar = function () {
                $rootScope.usuario = $scope.usuario;
                //window.location.href = "http://localhost:51069/Polizas";

                loginServices.Login($scope.usuario).done(function (response) {
                    var r = response;
                    $rootScope.usuario = $scope.usuario;
                    window.location.href = "http://localhost:51069/Polizas";

                });
            };

        }
    ]);
})();




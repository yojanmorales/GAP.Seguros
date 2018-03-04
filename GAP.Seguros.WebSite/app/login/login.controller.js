"use strict";
(function () {


    angular.module("SegurosApp").controller("loginController", ["$scope", "loginServices", "$http", "$q",
        function ($scope, loginServices, $http, $q) {

            $scope.usuario = {};
            $scope.Ingresar = function () {

                loginServices.Login($scope.usuario).done(function (response) {
                    var r = response;

                });
            };

        }
    ]);
})();




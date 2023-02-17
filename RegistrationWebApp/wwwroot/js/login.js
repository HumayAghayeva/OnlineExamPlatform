var mainApp = angular.module("mainApp", []);

mainApp.controller('LoginController', ['$scope', '$http', function ($scope, $http) {
    $scope.Login = function () {
        $http({
            method: "GET",
            Accept:"application/json, text/plain",
            url: "http://localhost:8068/api/User/1"
        }).then(function (response) {
            alert("test")
        }),
            function (error) {
                alert("error")
            }
    }
   }]);
var mainApp = angular.module("mainApp", []);

mainApp.controller('LoginController', ['$scope', '$http', function ($scope, $http) {
    $scope.Login = function () {
        var get = $http({
            method: "GET",
            headers: { "Content-Type": "application/json" },
            dataType: 'json',
            data: { email: $scope.Email, password: $scope.Password },
            url: "https://localhost:7063/swagger/v1/swagger.json"
        }).then(function onSuccess(response) {
            if (response.data = "Ok") {
                $window.location.reload();
            }
        }) .catch(function onError(response) {
                alert(response)
            });
        }
    }]);
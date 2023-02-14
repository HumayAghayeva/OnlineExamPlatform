var mainApp = angular.module("mainApp", []);

mainApp.controller('LoginController', [function () {
        this.Login = function () {
            $http({
                method: "GET",
                url: "https://api.chucknorris.io/jokes/random"
            }).then(function mySuccess(response) {
                $scope = response.data;
                alert($scope.value)
            }, function myError(response) {
                alert(message);("erreur : ", response.data.errors);
            });
        }
    }]);
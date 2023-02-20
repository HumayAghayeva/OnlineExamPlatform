var mainApp = angular.module("mainApp", []);

mainApp.controller('LoginController', ['$scope', '$http', function ($scope, $http) {
    $scope.Login = function () {
        $http({
            method: "GET",
            Accept:"application/json, text/plain",
            url: "http://localhost:8068/api/User/" + $scope.Email + "/" + $scope.Password +""
        }).then(function (response) {
            $scope.Fullname = response.data.fullname
            alert($scope.Fullname)
        }),
            function (error) {
                alert("error")
            }
    }
   }]);
var mainApp = angular.module("mainApp", []);
mainApp.controller('LoginController', ['$scope', '$http', function ($scope, $http) {
    $scope.Login = function () {
        $http({
            method: "GET",
            Accept: "application/json, text/plain",
            url: "http://localhost:8078/api/User/" + $scope.Email + "/" + $scope.Password + ""
        }).then(function (response) {
            $scope.Fullname = response.data.fullname
            alert($scope.Fullname)
        }),
            function (error) {
                alert("error")
            }
    }


    $scope.SignUp = function () {
        var data = {
            'fullname': $scope.FullName,
            'email': $scope.Email,
            'password': $scope.Password
        }
        $http({
            method: "POST",
            data: JSON.stringify(data),
            Accept: "application/json, text/plain",
            url: "http://localhost:8078/api/User/"
        }).then(function (response) {
            if (response.data)
                $scope.msg = "Post Data Submitted Successfully!";
        },
            function (response) {
                $scope.msg = "Service not Exists";
                $scope.statusval = response.status;
                $scope.statustext = response.statusText;
                $scope.headers = response.headers();
            });
    }
    $scope.users = [];
        $http({
            method: "GET",
            Accept: "application/json, text/plain",
            url: "http://localhost:8078/api/User/"
        }).then(function (response) {
            $scope.users = response.data;
        },
            function (response) {
                $scope.msg = "Service not Exists";
            });
    $scope.UpdateData = function (user) {
        data = {
            'id': user.id,
            'fullname': user.fullname,
            'email': user.email,
            'password': user.password
        }
        $http({
            method: 'PUT',
            url: "http://localhost:8078/api/User/",
            data: JSON.stringify(data),
            Accept: "application/json, text/plain",
        }).then(function (response) {
            alert(response.data.email)
        }, function (response) {
            console.log(response);
        });
    };
}]);

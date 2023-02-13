

var mainApp = angular.module("mainApp", []);

mainApp.controller('LoginController', [function () {
        this.Login = function () {
            alert("Iam from angular controller");
        }
    }]);
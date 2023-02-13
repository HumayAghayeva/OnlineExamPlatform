
$(function () {
    var mainApp = angular.module("mainApp", []);

    mainApp.controller('exampleController', [function () {
        this.myFunction = function () {
            alert("Iam from angular controller");
        }
    }]);
})();
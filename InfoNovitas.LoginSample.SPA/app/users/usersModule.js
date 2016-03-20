angular.module("users", [])
  .controller("UsersCtrl", ["$scope", "$http", function ($scope, $http) {
      $scope.users = {};
      $http.get(serviceBase + "api/user").success(function (response) {
          $scope.users = response;
      });
  }]);
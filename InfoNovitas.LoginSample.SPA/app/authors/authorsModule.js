angular.module("authors", [])
  .controller("AuthorsCtrl", ["$scope", "$http", function ($scope, $http) {
      $scope.authors = {};
      $http.get(serviceBase + "api/author").success(function (response) {
          $scope.authors = response;
      });
  }]);
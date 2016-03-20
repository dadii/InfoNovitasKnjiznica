angular.module("books", [])
  .controller("BooksCtrl", ["$scope", "$http", function ($scope, $http) {
      $scope.books = {};
      $http.get(serviceBase + "api/book").success(function (response) {
          $scope.books = response;
      });
  }]);
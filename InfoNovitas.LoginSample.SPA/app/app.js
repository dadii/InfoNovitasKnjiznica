var loginApp = angular.module('LoginApp', ['common', 'LocalStorageModule', 'oc.lazyLoad','ui.router']);

loginApp.run([
    'authService', '$http', '$window', '$q', '$rootScope', function (authService, $http, $window, $q, $rootScope) {
        if (authService.getToken() == null) {
            $window.location.href = '/account/login';
        }

        $rootScope.$on('event:auth-loginRequired', function () {
            console.log("AUTH REQUIRED CONFIG");
            authService.refreshToken();
        });

        $rootScope.$on('event:auth-loginCancelled', function () {
            console.log("AUTH CANCELLED CONFIG");
            $window.location.href = '/account/login';
        });
    }
]);

var loginRequired = function ($location, $window, authService) {
    return true;
    if (authService.getToken() == null) {
        $window.location.href = '/account/login';
    }
}

loginApp.config([
    '$httpProvider', '$stateProvider', '$urlRouterProvider', '$locationProvider','$ocLazyLoadProvider',
    function ($httpProvider, $stateProvider, $urlRouterProvider, $locationProvider,$ocLazyLoadProvider) {


        if (!$httpProvider.defaults.headers.get) {
            $httpProvider.defaults.headers.get = {};
        }
        $httpProvider.defaults.headers.get['Cache-Control'] = 'no-cache';
        $httpProvider.defaults.headers.get['Pragma'] = 'no-cache';

        $ocLazyLoadProvider.config({
            debug: true
        });

        $urlRouterProvider.otherwise('/');

        $stateProvider
            .state('dashboard', {
                url: "/dashboard",
                controller: "DashboardCtrl",
                templateUrl: "app/dashboard/partials/dashboard.html",
                cache: false,
                resolve: {
                    loginRequired: loginRequired,
                    dashboard: function($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "dashboard",
                            files: [
                                "app/dashboard/controllers/dashboardCtrl.js",
                                "app/dashboard/dashboardModule.js"
                            ]
                        });
                    }

                }
            }).state('publishers', {
                url: "/publishers",
                controller: "PublishersCtrl",
                templateUrl: "app/publishers/partials/publishers.html",
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "publishers",
                            files: [
                                "app/publishers/publishersModule.js"
                            ]
                        });
                    }

                }
            }).state('books', {
                url: "/books",
                controller: "BooksCtrl",
                templateUrl: "app/books/partials/books.html",
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "books",
                            files: [                                
                                "app/books/booksModule.js"
                            ]
                        });
                    }

                }
            }).state('authors', {
                url: "/authors",
                controller: "AuthorsCtrl",
                templateUrl: "app/authors/partials/authors.html",
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "authors",
                            files: [                                
                                "app/authors/authorsModule.js"
                            ]
                        });
                    }

                }
            }).state('users', {
                url: "/users",
                controller: "UsersCtrl",
                templateUrl: "app/users/partials/users.html",
                cache: false,
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "users",
                            files: [                                
                                "app/users/usersModule.js"
                            ]
                        });
                    }

                }
            }).state('newAuthor', {
                url: "/newAuthor",
                controller: "NewAuthorCtrl",
                templateUrl: "app/authors/partials/newAuthor.html",
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "newAuthor",
                            files: [                                
                                "app/authors/newAuthorModule.js"
                            ]
                        });
                    }
                }
            }).state('newPublisher', {
                url: "/newPublisher",
                controller: "NewPublisherCtrl",
                templateUrl: "app/publishers/partials/newPublisher.html",
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "newPublisher",
                            files: [
                                "app/publishers/newPublisherModule.js"
                            ]
                        });
                    }
                }
            }).state('newBook', {
                url: "/newBook",
                controller: "NewBookCtrl",
                templateUrl: "app/books/partials/newBook.html",
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "newBook",
                            files: [
                                "app/books/newBookModule.js"
                            ]
                        });
                    }
                }
            }).state('newUser', {
                url: "/newUser",
                controller: "NewUserCtrl",
                templateUrl: "app/users/partials/newUser.html",
                resolve: {
                    loginRequired: loginRequired,
                    publishers: function ($ocLazyLoad) {
                        return $ocLazyLoad.load({
                            name: "newUser",
                            files: [
                                "app/users/newUserModule.js"
                            ]
                        });
                    }
                }
            })
        $locationProvider.html5Mode(true);
    }
]);

loginApp.controller('LayoutCtrl', [
    '$scope', 'authService', '$window', '$rootScope', 'userInfoService', function ($scope, authService, $window, $rootScope, userInfoService) {

        userInfoService.getInfo().then(function(result) {
            $scope.loggedUser = result.data;
        }, function(result) {
            //error; cannot fetch info for logged user
        });

    

        $scope.logOut = function () {
            authService.logOut();
            $window.location.href = '/account/login';
        };

        $rootScope.$on('event:auth-loginRequired', function () {
            console.log("AUTH REQUIRED");
            authService.logOut();
            $window.location.href = '/account/login';
        });

        $rootScope.$on('event:auth-loginCancelled', function () {
            console.log("LOGIN CANCELLED");
            $scope.logOut();
        });
    }
]);
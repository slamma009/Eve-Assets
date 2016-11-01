
angular.module('bang.app', ['ngRoute'
    , 'bang.miningCalculators'
    , 'bang.dataAccess'
])
.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "main.htm"
    })
    .when("/Mining", {
        templateUrl: "App/Mining/Mining.html"
    })
})
.controller('AppCtrl', function ($scope) {
    $scope.PageTitle = "Eve Assets";
});
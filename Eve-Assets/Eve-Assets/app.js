
angular.module('bang.app', ['ngRoute'
    , 'bang.miningCalculators'
    , 'bang.dataAccess'
    , 'bang.characterSheet'
])
.factory('characters', function() {
    var characters = [];
    var selected = {};
    var charactersService = {};

    charactersService.add = function (character) {
        characters.push(character);
    };
    charactersService.select = function (character) {
        selected = character;
    };
    charactersService.list = function () {
        return characters;
    };

    charactersService.selected = function () {
        return selected;
    }

    return charactersService;
})
.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "App/CharacterSheet/CharacterSheet.html"
    })
    .when("/Mining", {
        templateUrl: "App/Mining/Mining.html"
    })
})
.controller('AppCtrl', function ($scope) {
    $scope.PageTitle = "Eve Assets";
});
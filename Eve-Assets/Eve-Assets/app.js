
angular.module('bang.app', ['ngRoute'
    , 'bang.miningCalculators'
    , 'bang.dataAccess'
    , 'bang.characterSheet'
])
.factory('characterService', function ($rootScope) {
    /* Factory for all characters */
    //list of all characters
    var characters = [];
    //selected character
    var selected = {};
    //service
    var charactersService = {};

    //add a character to the list
    charactersService.add = function (character) {
        characters.push(character);
        $rootScope.$broadcast('CharacterListChanged');
    };
    //sets the selected character
    charactersService.select = function (character) {
        selected = character;
    };

    //returns a list of all characters
    charactersService.list = function () {
        return characters;
    };
    //returns the selected character
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
.controller('AppCtrl', function ($scope, characterService) {
    $scope.PageTitle = "Eve Assets";

    $scope.$on('CharacterListChanged', function () {
        $scope.allCharacters = characterService.list();
    });
    
});
angular.module('bang.characterSheet', [])

.controller('CharacterSheetController', ['$scope', 'characters', 'characterDataAccess',
    function ($scope, characters, characterDataAccess) {
        $scope.allCharacters = characters.list();
        if ($scope.allCharacters.length == 0) {
            $scope.characterPromise = characterDataAccess.getCharacters("4481816", "5zocklPRE98luK9Ddgndc2swjDk0C0v0TaZc7ih8t4uQAwV9axxmsjP2hFk5FvKK");
            $scope.characterPromise.then(function (data) {
                if (data.data !== undefined) {
                    characters.select(data.data[0]);
                    for (var i = 0; i < data.data.length; ++i) {
                        characters.add(data.data[i])
                    }
                }
                $scope.allCharacters = characters.list();
                console.log($scope.allCharacters);
            });
        }
    }]
);
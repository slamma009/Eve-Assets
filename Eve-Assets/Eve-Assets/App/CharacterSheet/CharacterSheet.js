angular.module('bang.characterSheet', [])

.controller('CharacterSheetController', ['$scope', 'characters', 'characterDataAccess',
    function ($scope, characters, characterDataAccess) {
        //get a list of current characters
        $scope.allCharacters = characters.list();

        //if the list is empty, lets grab a list of them (temporarily hardcoded)
        if ($scope.allCharacters.length == 0) {
            $scope.characterPromise = characterDataAccess.getCharacters("4481816", "5zocklPRE98luK9Ddgndc2swjDk0C0v0TaZc7ih8t4uQAwV9axxmsjP2hFk5FvKK");
            $scope.characterPromise.then(function (data) {
                if (data.data !== undefined) {
                    //select the first character (temporarily harcoded)
                    characters.select(data.data[0]);

                    for (var i = 0; i < data.data.length; ++i) {
                        characters.add(data.data[i])
                    }
                }
                //get a list with the new characters
                $scope.allCharacters = characters.list();
            });
        }
    }]
);
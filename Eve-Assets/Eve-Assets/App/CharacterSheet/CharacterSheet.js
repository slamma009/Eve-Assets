angular.module('bang.characterSheet', [])

.controller('CharacterSheetController', ['$scope', 'characterService', 'characterDataAccess',
    function ($scope, characterService, characterDataAccess) {
        //get a list of current characters
        $scope.allCharacters = characterService.list();


        $scope.addCharacter = function (key, verification) {
            $scope.characterPromise = characterDataAccess.getCharacters(key, verification);
            $scope.characterPromise.then(function (data) {
                $scope.key = undefined;
                if (data.data !== undefined) {
                    //select the first character (temporarily harcoded)
                    characterService.select(data.data[0]);

                    for (var i = 0; i < data.data.length; ++i) {
                        characterService.add(data.data[i])
                    }
                }
                //get a list with the new characters
                $scope.allCharacters = characterService.list();
            });
        };

        //if the list is empty, lets grab a list of them (temporarily hardcoded)
        if ($scope.allCharacters.length == 0) {
            $scope.addCharacter("5zocklPRE98luK9Ddgndc2swjDk0C0v0TaZc7ih8t4uQAwV9axxmsjP2hFk5FvKK", "4481816");
            $scope.addCharacter("LJk9KHxGZo6JYXvohZwrzcr6nLMCBPW1MykmUus15IuOKFoyT72ZnHlEVwhgHQsi", "1514612");
        }
    }]
);
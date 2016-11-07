angular.module('bang.assetCalculator', [])
.controller('AssetsController', ['$scope', 'characterService', 'assetDataAccess',
    function ($scope, characterService, assetDataAccess) {
        $scope.allCharacters = characterService.list();
        $scope.selected = [];
        for (var i = 0; i < $scope.allCharacters.length; ++i) {
            $scope.selected.push[true];
        }

        $scope.calculate = function () {
            characters = [];
            for (var i = 0; i < $scope.allCharacters.length; ++i) {
                if ($scope.selected[i]) {
                    characters.push($scope.allCharacters[i]);
                }
            }

            var promise = assetDataAccess.calculateLiquidIsk(characters);
            promise.then(function (data) {
                $scope.value = data.data;
            });
            console.log(characters);
        };
    }]
);
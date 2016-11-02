angular.module('bang.miningCalculators', [])

.controller('MiningController', ['$scope', 'characterService', 'oreDataAccess',
    function ($scope, characterService, oreDataAccess) {
        $scope.allOresPromise = oreDataAccess.getAllOres();
        $scope.allOresPromise.then(function (data) {
            $scope.allOres = data.data;
        });
    }]
);
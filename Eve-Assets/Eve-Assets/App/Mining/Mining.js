angular.module('bang.miningCalculators', [])

.controller('MiningController', ['$scope', 'characters', 'oreDataAccess',
    function ($scope, characters, oreDataAccess) {
        $scope.allOresPromise = oreDataAccess.getAllOres();
        $scope.allOresPromise.then(function (data) {
            $scope.allOres = data.data;
        });
    }]
);
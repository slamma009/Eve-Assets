angular.module('bang.miningCalculators', [])

.controller('MiningController', ['$scope', 'oreDataAccess',
    function ($scope, oreDataAccess) {
        $scope.allOresPromise = oreDataAccess.getAllOres();
        $scope.allOresPromise.then(function (data) {
            $scope.allOres = data.data;
            console.log(data.data);
        });
        $scope.test = "this is a test.";
    }]
);
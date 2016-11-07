angular.module('bang.assetDataAccess', [])
    .service('assetDataAccess', ["$http",
    function ($http) {
        var baseApi = "api/asset/";
        this.calculateLiquidIsk = function (characters) {
            return $http({
                url: baseApi + "calculateLiquidIsk",
                method: "GET",
                params: { data: JSON.stringify(characters) }
            });
        }
    }
]);
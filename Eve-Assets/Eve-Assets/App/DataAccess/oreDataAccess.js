angular.module('bang.oreDataAccess', [])
    .service('oreDataAccess', [ "$http",
    function ($http) {
        var baseApi = "api/ore/";
        this.getAllOres = function () {
            return $http.get(baseApi + "getAllOres");
        }
    }
]);
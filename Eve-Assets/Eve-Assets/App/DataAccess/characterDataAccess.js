angular.module('bang.characterDataAccess', [])
    .service('characterDataAccess', ["$http",
    function ($http) {
        var baseApi = "api/character/";
        this.getCharacters = function (key, code) {
            return $http({
                url: baseApi + "getCharacters",
                method: "GET",
                params: {key: key, code: code}
            });
        }
    }
]);
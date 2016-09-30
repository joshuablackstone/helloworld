(function () {
    'use strict';

    var serviceId = 'HelloWorldService';
    var app = angular.module('helloworld');
    app.constant('HelloWorldServiceUrl', 'http://localhost:63403/api/helloworld');
    app.factory(serviceId, ['$http', 'HelloWorldServiceUrl',
        function ($http, serviceUrl) {
            return {
                get: function () {
                    return $http.get(serviceUrl);
                }
            };
        }]);
})();
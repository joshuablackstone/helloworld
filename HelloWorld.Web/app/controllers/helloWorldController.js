(function () {
    'use strict';

    var app = angular.module('helloworld');

    app.controller('HelloWorldCtlr', ['HelloWorldService', function(HelloWorldService){
        var vm = this;
        vm.value = "-- Loading --";
        HelloWorldService.get().then(function (data) {
            vm.value = data.data;
        });
    }]);
})();
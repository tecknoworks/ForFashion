'use strict';
angular.
    module('ForFashionApp').
    config(['$locationProvider', '$routeProvider',
    function config($locationProvider, $routeProvider) {
        $locationProvider.hashPrefix('!');
        $routeProvider.
            when('/home', {
            template: '<home></home>'
        }).
            when('/register', {
            template: '<register></register>'
        }).
            when('/fashionhouse', {
            template: '<fashionhouse></fashionhouse>'
        }).
            when('/live', {
            template: '<live></live>'
        }).
            when('/news', {
            template: '<news></news>'
        }).
            when('/register', {
            template: '<register></register>'
        }).
            when('/videos', {
            template: '<videos></videos>'
        }).
            when('/vlog', {
            template: '<vlog></vlog>'
        }).
            otherwise('/home');
    }
]);
//# sourceMappingURL=app.config.js.map
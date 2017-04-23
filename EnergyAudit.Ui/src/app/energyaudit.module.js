var angular = require('angular');

var dependencies = [
    require('angular-ui-router'),
    require('./home/home.module')(angular)
];

angular.module('energyaudit', dependencies);
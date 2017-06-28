var angular = require('angular');

var dependencies = [
    require('angular-ui-router'),
    require('./home/home.module')(angular)
];

angular.module('energyaudit', dependencies);

HTMLJSCSS
(function() {
  'use strict';

  angular.module('navBarDemoBasicUsage', ['ngMaterial'])
      .controller('AppCtrl', AppCtrl);

  function AppCtrl($scope) {
    $scope.currentNavItem = 'page1';
  }
})();
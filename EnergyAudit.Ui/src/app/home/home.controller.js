module.exports = function($scope, $state) {
'use strict';

  angular.module('energyaudit.home', ['ngMaterial'])
      .controller('AppCtrl', AppCtrl);

  function AppCtrl($scope) {
    $scope.currentNavItem = 'page1';
  }
}
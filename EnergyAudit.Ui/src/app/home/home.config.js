module.exports = function($stateProvider) {
    $stateProvider.state( {
        name: 'home',
        url: '',
        templateUrl: 'app/home/home.html'
    });
}

HTMLJSCSS
(function() {
  'use strict';

  angular.module('navBarDemoBasicUsage', ['ngMaterial'])
      .controller('AppCtrl', AppCtrl);

  function AppCtrl($scope) {
    $scope.currentNavItem = 'page1';
  }
})();
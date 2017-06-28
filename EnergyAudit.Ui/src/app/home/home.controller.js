<<<<<<< HEAD
module.exports = function($scope, $state) {
'use strict';

  angular.module('energyaudit.home', ['ngMaterial'])
      .controller('AppCtrl', AppCtrl);

  function AppCtrl($scope) {
    $scope.currentNavItem = 'page1';
  }
=======
module.exports = function($scope, $state, $http) {
    $http.get('http://localhost:55792/api/energyaudit/user')
        .then(function(response) {
           $scope.user = response.data;
        })
>>>>>>> 72bd7fec334cebad57f450074a5dcdce51c61293
}
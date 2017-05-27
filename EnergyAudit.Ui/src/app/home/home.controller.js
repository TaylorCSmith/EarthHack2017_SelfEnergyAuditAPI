module.exports = function($scope, $state, $http) {
    $http.get('http://localhost:55792/api/energyaudit/user')
        .then(function(response) {
           $scope.user = response.data;
        })
}
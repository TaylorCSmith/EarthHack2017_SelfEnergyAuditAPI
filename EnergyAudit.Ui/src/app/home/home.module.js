module.exports = function(angular) {
    const module = 'energyaudit.home';

    var dependencies = [
    ];

    angular.module(module, dependencies)
        .controller('home.controller', ['$scope', '$state', '$http', require('./home.controller')])
        .config(['$stateProvider', require('./home.config')])

    return module;
}

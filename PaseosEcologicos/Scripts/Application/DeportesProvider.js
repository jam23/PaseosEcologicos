PE.service('DeportesProvider', ['$resource', function ($resource) {
    return $resource('api/deportes');
}]);
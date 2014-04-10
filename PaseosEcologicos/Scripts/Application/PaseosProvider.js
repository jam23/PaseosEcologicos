PE.service('PaseosProvider', ['$resource', function ($resource) {
    return $resource('api/paseos');
}]);
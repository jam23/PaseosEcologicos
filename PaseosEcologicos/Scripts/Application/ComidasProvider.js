PE.service('ComidasProvider', ['$resource', function ($resource) {
    return $resource('api/comidas');
}]);
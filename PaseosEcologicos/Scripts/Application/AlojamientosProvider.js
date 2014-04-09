PE.service('AlojamientosProvider', ['$resource', function ($resource) {
    return $resource('api/alojamientos');
}]);
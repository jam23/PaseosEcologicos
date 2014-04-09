PE.service('ReservacionProvider', ['$resource', function ($resource) {
    return $resource('api/reservacion');
}]);
PE.service('ReservacionProvider', ['$resource', function ($resource) {
    var provider = $resource('api/reservacion/:codigo', {codigo:'@codigo'});
    return provider;
}]);
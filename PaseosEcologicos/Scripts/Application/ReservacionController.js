PE.controller('ReservacionController', ['$scope', 'AlojamientosProvider', 'ComidasProvider', 'DeportesProvider',
    'ReservacionProvider', '$window',
    function ($scope, AlojamientosProvider, ComidasProvider, DeportesProvider, ReservacionProvider, $window) {
        $scope.reservacion = {};

        $scope.alojamientos = AlojamientosProvider.query();
        $scope.comidas = ComidasProvider.query();
        $scope.deportes = DeportesProvider.query();

        $scope.finish = function () {
            $window.jQuery('#wizard').hide();
            ReservacionProvider.save($scope.reservacion);
            $scope.reservacion = {};
        };

        //console.log($scope.alojamientos);
        //console.log($scope.comidas);
        //console.log($scope.deportes);
    }]);
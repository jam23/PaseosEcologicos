PE.controller('ReservacionController', ['$scope', 'AlojamientosProvider', 'ComidasProvider', 'DeportesProvider', 'ReservacionProvider',
    function ($scope, AlojamientosProvider, ComidasProvider, DeportesProvider, ReservacionProvider) {
        $scope.reservacion = {};

        $scope.alojamientos = AlojamientosProvider.query();
        $scope.comidas = ComidasProvider.query();
        $scope.deportes = DeportesProvider.query();

        $scope.finish = function () {
            alert("Completado");
        };

        //console.log($scope.alojamientos);
        //console.log($scope.comidas);
        //console.log($scope.deportes);
    }]);
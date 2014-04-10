PE.controller('ReservacionController', ['$scope', 'AlojamientosProvider', 'ComidasProvider', 'DeportesProvider',
    'ReservacionProvider', 'PaseosProvider', '$window',
    function ($scope, AlojamientosProvider, ComidasProvider, DeportesProvider, ReservacionProvider,
        PaseosProvider, $window) {
        $scope.reservacion = {};

        $scope.alojamientos = AlojamientosProvider.query();
        $scope.comidas = ComidasProvider.query();
        $scope.deportes = DeportesProvider.query();
        $scope.paseos = PaseosProvider.query();
        $scope.registro = function () {
            $window.OpenWizard();
        };

        var encontrarServicio = function (servicios, id) {
            var servicio = _.find(servicios, function (servicio) {
                if (id === servicio.id) {
                    return servicio;
                }
            });

            if (servicio) {
                return servicio.titulo;
            }

            return "";
        };
        $scope.alojamientoSeleccionado = function (id) {
            return encontrarServicio($scope.alojamientos, id);
        };

        $scope.comidaSeleccionada = function (id) {
            return encontrarServicio($scope.comidas, id);
        };
        $scope.deporteSeleccionado = function (id) {
            return encontrarServicio($scope.deportes, id);
        };
        $scope.paseoSeleccionado = function (id) {
            return encontrarServicio($scope.paseos, id);
        };
    }]);